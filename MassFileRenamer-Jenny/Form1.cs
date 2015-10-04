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

		// Holds the last version of the text in the txtOutputName TextBox
		private string previousTxtOutputNameValue = "";

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

			chkEnableFilter.Enabled = 
				btnRunRename.Enabled = 
				folderLoaded = true;

			btnRunRename.Enabled = !txtOutputName.Text.Equals("");

			txtSelectedDirectory.Text = targetFolder.SelectedPath;

			fileList = Directory.GetFiles(targetFolder.SelectedPath)
												.Select(Path.GetFileName)
												.ToList();

			PopulateExtensionList();
			PopulateFileList();
		}

		// Context menu code to open file from file list
		private void viewFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(targetFolder.SelectedPath + "\\" + lstFileNames.SelectedItem);
		}

		/// <summary>
		///	Shows the context menu for the selected file
		/// </summary>
		private void lstFileNames_MouseDown(object sender, MouseEventArgs e)
		{
			// Set the selected value in the list to the value that was right clicked
			lstFileNames.SelectedIndex = lstFileNames.IndexFromPoint(e.X, e.Y);

			if (e.Button == MouseButtons.Right)
			{
				contextMenuStrip1.Show(lstFileNames, e.X, e.Y);
			}
		}

		private void lstExtensions_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			// Calls PopulateFileList after the item check action is complete
			// since PopulateFileList relies on the checked state of its collection
			BeginInvoke((MethodInvoker) PopulateFileList);
		}

		private void PopulateFileList()
		{
			lstFileNames.Items.Clear();

			// Add every element of fileList to lstFileNames that matches the filter settings
			foreach (var fileName in fileList)
			{
				if (lstExtensions.CheckedItems.Contains(Path.GetExtension(fileName)) &&
					fileName.ToLower().Contains(txtFilterInput.Text.ToLower()))
					lstFileNames.Items.Add(fileName, CheckState.Checked);
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

		// If the character key pressed is an invalid file name character, ignore it
		private void txtOutputName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Path.GetInvalidFileNameChars().Contains(e.KeyChar))
				e.Handled = true;
		}

		/// <summary>
		/// Sets the output file name preview text
		/// </summary>
		private void txtOutputName_TextChanged(object sender, EventArgs e)
		{
			txtOutputExample.Text = GenerateFileName(0);
			previousTxtOutputNameValue = txtOutputName.Text;
		}

		private void numLeadingZeros_ValueChanged(object sender, EventArgs e)
		{
			txtOutputExample.Text = GenerateFileName(0);
		}

		/// <summary>
		/// Generates a file name string based on the rename options set in the form controls
		/// </summary>
		/// <param name="number">The number to be used for file name</param>
		/// <returns>A file name string</returns>
		private string GenerateFileName(int number)
		{
			return txtOutputName.Text + number.ToString("D" + numLeadingZeros.Value);
		}

		/// <summary>
		/// Reset the form to its initial state
		/// </summary>
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
			txtOuputInfo.Text += "Waiting to run...\r\n";
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			ResetForm();
		}

		private void btnRunRename_Click(object sender, EventArgs e)
		{
			txtOuputInfo.Text += "Operation Started\r\n";

			var filesToRename = lstFileNames.CheckedItems.OfType<string>().ToList();
			var i = 1;

			foreach (var file in filesToRename)
			{
				string extension = Path.GetExtension(file),
					   path = targetFolder.SelectedPath + @"\",
					   fullOldFilePath = path + file,
					   newFileName = GenerateFileName(i++);


				if (File.Exists(path + newFileName + extension))
				{
					txtOuputInfo.Text += 
						"File \"" + newFileName + extension + "\" already exists." +
						" Renaming old file to \"" + newFileName + extension + "-OLD\".\r\n";
					File.Move(path + newFileName + extension, path + newFileName + "-OLD" + extension);
				}
				txtOuputInfo.Text += 
					"Renamed: \"" + file + "\"  TO  \"" 
					+ newFileName + extension + "\"\r\n";
				File.Move(fullOldFilePath, path + newFileName + extension);
			}
			txtOuputInfo.Text += "Operation Completed.\r\n";
			LoadFolder(false);
		}
	}
}
