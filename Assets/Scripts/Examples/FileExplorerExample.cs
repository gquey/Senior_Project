/*
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using WinApplication = System.Windows.Forms.Application;

//https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.folderbrowserdialog?view=windowsdesktop-6.0

public class FileExplorerExample : MonoBehaviour
{
	
	
	public class FolderBrowserDialogExampleForm : System.Windows.Forms.Form
    {
		private FolderBrowserDialog folderBrowserDialog1;
		// Constructor.
		public FolderBrowserDialogExampleForm()
		{
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			DialogResult result = folderBrowserDialog1.ShowDialog();
			if( result == DialogResult.OK )
			{
				StaticValues.slidePath = folderBrowserDialog1.SelectedPath;
			}
		}
    }
	
	public void tester()
	{
		WinApplication.Run(new FolderBrowserDialogExampleForm());
	}
	
    
}
*/