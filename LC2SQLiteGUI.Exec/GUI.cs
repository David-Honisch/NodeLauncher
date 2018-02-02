using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Diagnostics;

using Finisar.SQLite;
using System.Configuration;
using System.IO;

namespace LC2SQLiteGUI
{
    public partial class GUI : Form
    {
        private string DB_NAME = null;
        private SQLiteDataAdapter dataAdapter = null;
        private DataSet dataSet = null;
        private static SQLiteCommand sql_cmd;
        
        private static SQLiteConnection sql_con;

        private DataGridViewPrinter userDataGridViewPrinter = null;

        private static int iVersion = 3;
        private static String sNew = "False";
        private static String sCompress = "True";

        



        //<summary>
        //Constructor
        //</summary>
        public GUI()
        {
            InitializeComponent();
            typecombo.Items.Add("TEXT");
            typecombo.Items.Add("NUMERIC");
            typecombo.Items.Add("INTEGER");
            typecombo.SelectedIndex = 0;
        }

        #region set SetConnection()
        public void SetConnection()
        {
            SetConnection("Data Source=" + DB_NAME + ";Version=" + iVersion + ";New=" + sNew + ";Compress=" + sCompress + ";");

        }
        #endregion

        #region SetConnection(String pStrValue)
        public static void SetConnection(String pStrValue)
        {
            sql_con = new SQLiteConnection("" + pStrValue);

        }
        #endregion

        #region reload_tables
        //<summary>
        //Reload the tables in the Combo Box
        //</summary>
        private void reload_tables()
        {
            try
            {
                tablecombobox.Items.Clear();

                DataSet ds = new DataSet();

                if (DB_NAME == null)
                {
                    MessageBox.Show("Open an existing database or Create a new database");
                    return;
                }
                //SetConnection();
                //sql_con.Open();

                string connString = String.Format("Data Source={0};New=" + sNew + ";Version=" + iVersion + ";Compress=" + sCompress + ";", DB_NAME);

                SQLiteConnection sql_con = new SQLiteConnection(connString);

                sql_con.Open();

                string CommandText = "Select name from sqlite_master";

                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(CommandText, sql_con);
                dataAdapter.Fill(ds);

                DataRowCollection dataRowCol = ds.Tables[0].Rows;

                foreach (DataRow dr in dataRowCol)
                {
                    tablecombobox.Items.Add(dr["name"]);
                    cbExec.Items.Add(dr["name"]);
                }

                if (tablecombobox.Items.Count > 0)
                {
                    tablecombobox.SelectedIndex = 0;
                    cbExec.SelectedIndex = 0;
                    btnDelete.Enabled = true;
                }
                else
                {
                    tablecombobox.Text = " ";
                    btnDelete.Enabled = false;
                }

                sql_con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message
                    + ex.StackTrace);
            }

            return;
        }
        #endregion

        #region Events

        #region comboBoxExec_SelectedIndexChanged
        private void comboBoxExec_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (DB_NAME == null)
                {
                    MessageBox.Show("Open an existing database or Create a new database");
                    return;
                }

                this.dataSet = new DataSet();
                string connString = String.Format("Data Source={0};New=" + sNew + ";Version=" + iVersion + ";Compress=" + sCompress + ";", DB_NAME);

                SQLiteConnection sqlconn = new SQLiteConnection(connString);
                sqlconn.Open();

                string CommandText = String.Format("Select url from {0};", tablecombobox.Text);

                this.dataAdapter = new SQLiteDataAdapter(CommandText, sqlconn);
                SQLiteCommandBuilder builder = new SQLiteCommandBuilder(this.dataAdapter);

                this.dataAdapter.Fill(this.dataSet, tablecombobox.Text);

                dgvExec.DataSource = this.dataSet;
                dgvExec.DataMember = tablecombobox.Text;
                dgvExec.AutoSize = true;
                dgvExec.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (SQLiteException sqlex)
            {
                MessageBox.Show(sqlex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region tablecombobox_SelectedIndexChanged
        //<summary>
        //Displays the contents of the table in the DataGridView
        //</summary>
        private void tablecombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (DB_NAME == null)
                {
                    MessageBox.Show("Open an existing database or Create a new database");
                    return;
                }

                this.dataSet = new DataSet();
                string connString = String.Format("Data Source={0};New=" + sNew + ";Version=" + iVersion + ";Compress=" + sCompress + ";", DB_NAME);

                SQLiteConnection sqlconn = new SQLiteConnection(connString);
                sqlconn.Open();

                string CommandText = String.Format("Select * from {0} limit 100;", tablecombobox.Text);

                this.dataAdapter = new SQLiteDataAdapter(CommandText, sqlconn);
                SQLiteCommandBuilder builder = new SQLiteCommandBuilder(this.dataAdapter);

                this.dataAdapter.Fill(this.dataSet, tablecombobox.Text);

                userDataGridView.DataSource = this.dataSet;
                userDataGridView.DataMember = tablecombobox.Text;
                userDataGridView.AutoSize = true;
                userDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (SQLiteException sqlex)
            {
                MessageBox.Show(sqlex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region tlstrpbtnconnect_Click
        //<summary>
        //Connect to the existing DB
        //</summary>
        private void tlstrpbtnconnect_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                opnfiledlg.CheckPathExists = true;
                opnfiledlg.CheckFileExists = true;
                opnfiledlg.Filter = "DB Files (*.db)|*.db|All Files(*.*)|*.*";
                opnfiledlg.Multiselect = false;
                opnfiledlg.Title = "Select SQLite Database File";

                if (opnfiledlg.ShowDialog() == DialogResult.OK)
                {
                    //Connects To SQLiteDatabase

                    lblconnected.Text = "YES";

                    DB_NAME = opnfiledlg.FileName;

                    reload_tables();
                    //DataGrid grid = new DataGrid();
                    //grid.DataSource = userDataGridView.DataSource;
                    //LoadData(grid, "select id, data, url from  url", false);
                }
            }
            catch (SQLiteException sqliteex)
            {
                MessageBox.Show(sqliteex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region tlStpbtnnew_Click
        //<summary>
        //Create and connect to the new DB
        //</summary>
        private void tlStpbtnnew_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                savefileDlg.Filter = "DB Files(*.db)|*.db|All Files (*.*)|*.*";
                savefileDlg.DefaultExt = ".db";
                savefileDlg.AddExtension = true;

                if (savefileDlg.ShowDialog() == DialogResult.OK)
                {
                    DB_NAME = savefileDlg.FileName;
                    
                    string connString = String.Format("Data Source={0};New=True;Version=3;Compress=" + sCompress + ";", DB_NAME);

                    SQLiteConnection sqlconn = new SQLiteConnection(connString);

                    sqlconn.Open();

                    lblconnected.Text = "YES";
                    
                    sqlconn.Close();
                }
            }
            catch (SQLiteException sqlex)
            {
                MessageBox.Show(sqlex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        #endregion

        #region btnDelete_Click
        //<summary>
        //Delete a table from the DB
        //</summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (DB_NAME == null)
                {
                    MessageBox.Show("Open an existing database or Create a new database");
                    return;
                }

                string connString = String.Format("Data Source={0};New=False;Version=3", DB_NAME);

                SQLiteConnection sqlconn = new SQLiteConnection(connString);

                sqlconn.Open();

                string CommandText = String.Format("drop table {0};", tablecombobox.Text);

                SQLiteCommand SQLiteCommand = new SQLiteCommand(CommandText, sqlconn);
                SQLiteCommand.ExecuteNonQuery();

                sqlconn.Close();

                reload_tables();

                MessageBox.Show("Deleted Table.", "SQLite GUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
         

            }
            catch (SQLiteException sqlex)
            {
                MessageBox.Show(sqlex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        
        #region btnAdd_Click
        //<summary>
        //Create a new table in the DB
        //</summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder query = new StringBuilder();

                if (txttablename.Enabled)
                {
                    if (txttablename.Text.Length <= 0)
                    {
                        MessageBox.Show("Table Name cannot be empty!!!");
                        return;
                    }

                    rchtxtCreate.Text = "";
                    string createStr = String.Format("Create table {0}( ", txttablename.Text);
                    query.Append(createStr);
                }
                else
                {
                    query.Append(",");
                }

                txttablename.Enabled = false;

                query.Append(txtcolumnname.Text);
                query.Append(" ");
                query.Append(typecombo.Text);

                if (chkprimary.Enabled)
                {
                    if (chkprimary.CheckState == CheckState.Checked)
                    {
                        query.Append(" primary key");
                        chkprimary.Enabled = false;
                    }
                }

                rchtxtCreate.Text += query.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        #endregion

        #region btnCreate_Click
        //<summary>
        //Create a new table in the DB
        //</summary>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (DB_NAME == null)
                {
                    MessageBox.Show("Open an existing database or Create a new database");
                    return;
                }

                rchtxtCreate.Text += ");";

                string connString = String.Format("Data Source={0};New=" + sNew + ";Version=" + iVersion + ";Compress=" + sCompress + ";", DB_NAME);

                SQLiteConnection sqlconn = new SQLiteConnection(connString);

                sqlconn.Open();

                string CommandText = String.Format("{0}",rchtxtCreate.Text);

                SQLiteCommand SQLiteCommand = new SQLiteCommand(CommandText, sqlconn);
                SQLiteCommand.ExecuteNonQuery();

                sqlconn.Close();

                txttablename.Enabled = true;

                reload_tables();

                MessageBox.Show("Table Created", "SQLite GUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
         
            }
            catch (SQLiteException sqlex)
            {
                MessageBox.Show(sqlex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region btnClear_Click
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtcolumnname.Text = "";
            txttablename.Text = "";
            typecombo.SelectedIndex = 0;
            rchtxtCreate.Clear();
            txttablename.Enabled = true;
            chkprimary.Enabled = true;
            chkprimary.CheckState = CheckState.Checked;
        }
        #endregion

        #region  btnExecute_Click
        //<summary>
        //Executes a custom Query
        //</summary>
        private void btnExecute_Click(object sender, EventArgs e)
        {
            try
            {

                if (DB_NAME == null)
                {
                    MessageBox.Show("Open an existing database or Create a new database");
                    return;
                }

                string connString = String.Format("Data Source={0};New=" + sNew + ";Version=" + iVersion + ";Compress=" + sCompress + ";", DB_NAME);

                SQLiteConnection sqlconn = new SQLiteConnection(connString);

                sqlconn.Open();

                string CommandText = String.Format("{0}", rchtxtQuery.Text);

                SQLiteCommand SQLiteCommand = new SQLiteCommand(CommandText, sqlconn);
                SQLiteCommand.ExecuteNonQuery();

                sqlconn.Close();

                MessageBox.Show("Query Executed","SQLite GUI",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (SQLiteException sqlex)
            {
                MessageBox.Show(sqlex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion        

        #region btnUpdate_Click
        //<summary>
        //Update the changes in the DataGridView to the DB through the Datset and Data Adapter
        //</summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (DB_NAME == null)
                {
                    MessageBox.Show("Open an existing database or Create a new database");
                    return;
                }

                if (this.dataSet.HasChanges())
                {
                    this.dataAdapter.Update(this.dataSet, tablecombobox.Text);
                    MessageBox.Show("Changes Updated", "SQLite GUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
                }
                else
                {
                    MessageBox.Show("No changes to update!!");
                }
            }
            catch (InvalidOperationException invalidex)
            {
                MessageBox.Show(invalidex.Message +"\nRefer Help -> topics -> Help 1" );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        #endregion

        #region closeDBToolStripMenuItem_Click
        //<summary>
        //Close the connected DB
        //</summary>
        private void closeDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DB_NAME = null;
            lblconnected.Text = "NO";
        }
        #endregion

        #region aboutToolStripMenuItem_Click
        //<summary>
        //About Box
        //</summary>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.ShowDialog();
        }
        #endregion

        #region tlstrpprint_Click
        //<summary>
        //Prints the data in the DataGridView
        //summary>
        private void tlstrpprint_Click(object sender, EventArgs e)
        {
            try
            {
                if (SetupThePrinting())
                {
                    PrintPreviewDialog MyPrintPreviewDialog = new PrintPreviewDialog();
                    MyPrintPreviewDialog.Document = userPrintDocument;
                    MyPrintPreviewDialog.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region SetupThePrinting
        private bool SetupThePrinting()
        {
            try
            {
                PrintDialog MyPrintDialog = new PrintDialog();
                MyPrintDialog.AllowCurrentPage = false;
                MyPrintDialog.AllowPrintToFile = false;
                MyPrintDialog.AllowSelection = false;
                MyPrintDialog.AllowSomePages = false;
                MyPrintDialog.PrintToFile = false;
                MyPrintDialog.ShowHelp = false;
                MyPrintDialog.ShowNetwork = false;

                if (MyPrintDialog.ShowDialog() != DialogResult.OK)
                    return false;

                userPrintDocument.DocumentName = "Table Report";
                userPrintDocument.PrinterSettings = MyPrintDialog.PrinterSettings;
                userPrintDocument.DefaultPageSettings = MyPrintDialog.PrinterSettings.DefaultPageSettings;
                userPrintDocument.DefaultPageSettings.Margins = new Margins(40, 40, 40, 40);
                userDataGridView.AutoSize = true;
                userDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                userDataGridViewPrinter = new DataGridViewPrinter(userDataGridView, userPrintDocument, false, true, "Table", new Font("Verdana", 18, FontStyle.Bold, GraphicsUnit.Point), Color.Black, true);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        #endregion

        #region btnRefresh_Click
        //<summary>
        //Displays the schema for the available tables in the DB
        //</summary>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();

                if (DB_NAME == null)
                {
                    MessageBox.Show("Open an existing database or Create a new database");
                    return;
                }

                string connString = String.Format("Data Source={0};New=False;Version=3", DB_NAME);

                SQLiteConnection sqlconn = new SQLiteConnection(connString);

                sqlconn.Open();

                string CommandText = "Select * from sqlite_master;";

                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(CommandText, sqlconn);
                dataAdapter.Fill(ds);

                DataRowCollection dataRowCol = ds.Tables[0].Rows;

                rchtxtSchema.Clear();

                foreach (DataRow dr in dataRowCol)
                {
                    rchtxtSchema.Text += "\n________________________________________________\n";

                    rchtxtSchema.Text += "\nType :";
                    rchtxtSchema.Text += dr["type"];

                    rchtxtSchema.Text += "\nTable Name :";
                    rchtxtSchema.Text += dr["name"];

                    rchtxtSchema.Text += "\nSQL :";
                    rchtxtSchema.Text += dr["sql"];

                    rchtxtSchema.Text += "\n________________________________________________\n";

                }

                sqlconn.Close();
            }
            catch (SQLiteException sqliteex)
            {
                MessageBox.Show(sqliteex.Message);
            }
        }
        #endregion

        #region exitToolStripMenuItem_Click
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region btnRefreshdb_Click
        private void btnRefreshdb_Click(object sender, EventArgs e)
        {
            if (DB_NAME == null)
            {
                MessageBox.Show("Open an existing database or Create a new database");
                return;
            }

            reload_tables();
        }
        #endregion

        #region toolStripHelp_Click
        //<summary>
        //Displays the help
        //</summary>
        private void toolStripHelp_Click(object sender, EventArgs e)
        {
            Process.Start(ConfigurationManager.AppSettings["help"]);
        }
        #endregion

        #region userPrintDocument_PrintPage
        private void userPrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            bool more = userDataGridViewPrinter.DrawDataGridView(e.Graphics);
            if (more == true)
                e.HasMorePages = true;
        }
        #endregion

        

        #region dgvExec_CellContentDoubleClick
        private void dgvExec_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Process.Start(dgvExec.CurrentCell.Value.ToString());
        }
        #endregion

        #endregion

        #region Load
        private void GUI_Load(object sender, EventArgs e)
        {
            DB_NAME = Environment.CurrentDirectory + "\\" + ConfigurationManager.AppSettings["database"];
            if (File.Exists(DB_NAME))
            {
                lblconnected.Text = "YES";
                reload_tables();
            }

        }
        #endregion

        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                if (DB_NAME == null)
                {
                    MessageBox.Show("Open an existing database or Create a new database");
                    return;
                }

                this.dataSet = new DataSet();
                string connString = String.Format("Data Source={0};New=" + sNew + ";Version=" + iVersion + ";Compress=" + sCompress + ";", DB_NAME);

                SQLiteConnection sqlconn = new SQLiteConnection(connString);
                sqlconn.Open();

                string CommandText = String.Format("Select url from {0} where url like '%%" + tbQuery.Text + "%%';", tablecombobox.Text);

                this.dataAdapter = new SQLiteDataAdapter(CommandText, sqlconn);
                SQLiteCommandBuilder builder = new SQLiteCommandBuilder(this.dataAdapter);

                this.dataAdapter.Fill(this.dataSet, tablecombobox.Text);

                dgvExec.DataSource = this.dataSet;
                dgvExec.DataMember = tablecombobox.Text;
                dgvExec.AutoSize = true;
                dgvExec.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (SQLiteException sqlex)
            {
                MessageBox.Show(sqlex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}