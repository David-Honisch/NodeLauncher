/*
 * Erstellt mit SharpDevelop.
 * Benutzer: David
 * Datum: 22.03.2015
 * Zeit: 19:09
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using LC2ShortcutCOM;

namespace LC2ShortCut
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		void MainFormLoad(object sender, EventArgs e)
		{
			this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			string[] args = Environment.GetCommandLineArgs();
			string text = "LetzteChance.Org";
			string source = @"C:\msvsmon120.bat";
			string path = @"C:\";
			try
			{
			tbOut.Dock = DockStyle.Fill;
			
			if (args.Length >=2)
			{
				tbOut.Text += "Parameter gefunden:"+Environment.NewLine;
				tbOut.Text += args[1]+Environment.NewLine;
				text = args[1];
				tbOut.Text += args[2]+Environment.NewLine;
				source = args[2];
				tbOut.Text += args[3]+Environment.NewLine;
				path = args[3];
				LC2ShortcutCOM.Shortcut.Create(text, source, path);
				Close();
			}
			else
			{
				tbOut.Text = "Usage:"+Environment.NewLine;
				tbOut.Text += "LC2ShortcutCOM <text> <source> <path>";
			}
			tbOut.Text += Environment.NewLine;
			}
			catch(FileNotFoundException ex)
			{
				MessageBox.Show(path+Environment.NewLine+ex.Message+Environment.NewLine+ex.StackTrace,"Exception");
				           
			}
				
			
			
		}
	}
}
