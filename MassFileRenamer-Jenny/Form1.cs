using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MassFileRenamer_Jenny
{
	public partial class Form_massFileRenamer : Form
	{
		private FolderBrowserDialog targetFolder = new FolderBrowserDialog();

		private List<string> fileList;
		private List<string> extensionList;

		private string oldText = "";

		private bool folderLoaded = false;

		public Form_massFileRenamer()
		{
			InitializeComponent();
			txtOuputInfo.Text += "Waiting to run...\r\n";
		}

		private void btnSelectFolder_Click(object sender, EventArgs e)
		{
			LoadFolder();
		}

		//
		private void LoadFolder(bool newFolder = true)
		{
			if (newFolder)
				targetFolder.ShowDialog();
			if (targetFolder.SelectedPath.Equals(""))
				return;

			folderLoaded = true;
			chkEnableFilter.Enabled = true;
			btnRunRename.Enabled = !txtOutputName.Text.Equals("");


			txtSelectedDirectory.Text = targetFolder.SelectedPath;

			fileList = Directory.GetFiles(targetFolder.SelectedPath)
												.Select(path => Path.GetFileName(path))
												.ToList();

			PopulateExtensionList();
			PopulateFileList();
		}

		// Context menu code to open file from file list
		private void viewFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(targetFolder.SelectedPath + "\\" + lstFileNames.SelectedItem.ToString());
		}

		private void lstFileNames_MouseDown(object sender, MouseEventArgs e)
		{
			lstFileNames.SelectedIndex = lstFileNames.IndexFromPoint(e.X, e.Y);

			if (e.Button == System.Windows.Forms.MouseButtons.Right)
			{
				contextMenuStrip1.Show(lstFileNames, e.X, e.Y);
			}
		}

		private void lstExtensions_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			//var targetExt = lstExtensions.Items[e.Index].ToString();

			//if (e.NewValue.Equals(CheckState.Unchecked))
			//	extensionList.Remove(targetExt);
			//if (e.NewValue.Equals(CheckState.Checked))
			//	extensionList.Add(targetExt);

			// Reparse the file list since a lstExtensions item checked state changed
			PopulateFileList();
		}

		private void PopulateFileList()
		{
			var tempList = new List<string>(fileList);
			var isToBeKept = new bool[tempList.Count];

			lstFileNames.Items.Clear();

			foreach (var fileName in fileList)
			{
				if (lstExtensions.CheckedItems.Contains(Path.GetExtension(fileName)) &&
				    fileName.Contains(txtFilterInput.Text))
						lstFileNames.Items.Add(fileName);
			}
		}

		/// <summary>
		/// Populates the extensions listbox with every unique file extension in
		/// the selected folder
		/// </summary>
		private void PopulateExtensionList()
		{
			// Clear the extensions list
			lstExtensions.Items.Clear();
			
			// Get a list of unique extensions in the folder
			extensionList = fileList
				.Select(Path.GetExtension)
				.Distinct()
				.ToList();

			// Add the items in the list to the listbox
			lstExtensions.Items.AddRange(extensionList.ToArray());

			// Unsubscribe the ItemCheck method temporarily so that we don't waste
			// time calling the method for each loop element
			lstExtensions.ItemCheck -= lstExtensions_ItemCheck;

			// Set all checkboxes in list as checked
			for (var i = 0; i < lstExtensions.Items.Count; i++)
				lstExtensions.SetItemChecked(i, true);

			// Resubscribe the ItemCheck method
			lstExtensions.ItemCheck += lstExtensions_ItemCheck;
		}

		private void chkEnableFilter_CheckedChanged(object sender, EventArgs e)
		{
			txtFilterInput.Enabled = chkEnableFilter.Checked;
		}

		private void txtFilterInput_TextChanged(object sender, EventArgs e)
		{
			PopulateFileList();
		}

		private void txtOutputName_TextChanged(object sender, EventArgs e)
		{
			if (txtOutputName.Text.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
			{
				txtOutputName.Text = oldText;
				txtOutputName.Select(txtOutputName.TextLength, 0);
				return;
			}
			if (!txtOutputName.Text.Equals("") && folderLoaded)
				btnRunRename.Enabled = true;
			else
				btnRunRename.Enabled = false;
			txtOutputExample.Text = CreateFileName(0);
			oldText = txtOutputName.Text;
		}

		private void numLeadingZeros_ValueChanged(object sender, EventArgs e)
		{
			txtOutputExample.Text = CreateFileName(0);
		}

		private string CreateFileName(int number)
		{
			var temp = "";
			temp += txtOutputName.Text;
			if (numLeadingZeros.Value == 0)
				temp += number.ToString();
			else
				temp += number.ToString("D" + numLeadingZeros.Value);
			return temp;
		}

		private void ResetForm()
		{
			fileList = new List<string>();
			extensionList = new List<string>();
			folderLoaded = false;
			lstFileNames.Items.Clear();
			lstExtensions.Items.Clear();
			txtOutputName.Clear();
			txtFilterInput.Clear();
			numLeadingZeros.Value = 0;
			chkEnableFilter.Checked = false;
			chkEnableFilter.Enabled = false;
			txtOutputExample.Clear();
			txtSelectedDirectory.Clear();
			txtOuputInfo.Clear();
			txtOuputInfo.Text += @"Waiting to run...\r\n";
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			ResetForm();
		}

		private void btnRunRename_Click(object sender, EventArgs e)
		{
			List<string> filesToRename = new List<string>();

			txtOuputInfo.Text += "Operation Started\r\n";

			filesToRename = lstFileNames.CheckedItems.OfType<string>().ToList();

			for (var i = 0; i < filesToRename.Count; i++)
			{
				string extension = Path.GetExtension(filesToRename[i]),
					   path = targetFolder.SelectedPath + "\\",
					   fullOldFilePath = path + filesToRename[i],
					   newFileName = CreateFileName(i);


				if (File.Exists(path + newFileName + extension))
				{
					txtOuputInfo.Text += "File \"" + 
										 newFileName + extension + 
										 "\" already exists. Renaming old file to \"" + 
										 newFileName + extension + "-OLD\".\r\n";
					File.Move(path + newFileName + extension, path + newFileName + "-OLD" + extension);
				}
				txtOuputInfo.Text += "Renamed: \"" +
									 filesToRename[i] +
									 "\"  TO  \"" +
									 newFileName + extension +
									 "\"\r\n";
				File.Move(fullOldFilePath, path + newFileName + extension);
			}
			txtOuputInfo.Text += "Operation Completed.\r\n";
			LoadFolder(false);
		}
	}
}
