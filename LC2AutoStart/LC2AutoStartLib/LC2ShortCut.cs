/*
 * Erstellt mit SharpDevelop.
 * Benutzer: David
 * Datum: 22.03.2015
 * Zeit: 19:10
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using IWshRuntimeLibrary;

//using IWshRuntimeLibary;

namespace LC2ShortcutCOM
{
	/// <summary>
	/// 
	/// </summary>
	public static class Shortcut
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="text"></param>
		/// <param name="sourceFile"></param>
		/// <param name="destPath"></param>
		public static void Create(string text, string sourceFile, string destPath)
		{
			try
			{
			if (destPath.Substring(destPath.Length - 1, 1) != "\\")
				destPath += "\\";

			string shortcutPath = destPath + text + ".lnk" ;
			WshShell shell = new WshShell();
			IWshShortcut link = (IWshShortcut)shell.CreateShortcut(shortcutPath);
			link.TargetPath = sourceFile;
			link.Save();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message
				                +"\n"
				                +ex.StackTrace);
			}
		}
	}
	
	/// <summary>
	/// Description of MyClass.
	/// </summary>
	public class LC2Shortcut
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="pText"></param>
		/// <param name="pSource"></param>
		/// <param name="pPath"></param>
		public static void Create(string pText, string pSource, string pPath)
		{
//			string text = "Test";
//			string source = @"D:\Musik\Test.mp3";
//			string path = @"C:\Users\Max Mustermann\Desktop\";

			WshShell shell = new WshShell();
			IWshShortcut link = (IWshShortcut)shell.CreateShortcut(pPath + pText + ".lnk");
			link.TargetPath = pSource;
			link.Save();
			//Alternativ:
			//Hinzufügen der link.cs
			//Shortcut.Create(pText, pSource, pPath);

		}
		
	}
}