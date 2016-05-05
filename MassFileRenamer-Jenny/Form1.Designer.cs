namespace MassFileRenamer_Jenny
{
	partial class Form_massFileRenamer
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.btnSelectFolder = new System.Windows.Forms.Button();
			this.lstFileNames = new System.Windows.Forms.CheckedListBox();
			this.grpSelectedDirectory = new System.Windows.Forms.GroupBox();
			this.txtSelectedDirectory = new System.Windows.Forms.TextBox();
			this.grpFilter = new System.Windows.Forms.GroupBox();
			this.grpMatchFilter = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtFilterInput = new System.Windows.Forms.TextBox();
			this.chkEnableFilter = new System.Windows.Forms.CheckBox();
			this.grpExtensions = new System.Windows.Forms.GroupBox();
			this.lstExtensions = new System.Windows.Forms.CheckedListBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.viewFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.txtOuputInfo = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.numLeadingZeros = new System.Windows.Forms.NumericUpDown();
			this.lblSampleOutput = new System.Windows.Forms.Label();
			this.txtOutputExample = new System.Windows.Forms.TextBox();
			this.lblOutputNumbering = new System.Windows.Forms.Label();
			this.lblOutputName = new System.Windows.Forms.Label();
			this.txtOutputName = new System.Windows.Forms.TextBox();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnRunRename = new System.Windows.Forms.Button();
			this.grpSelectedDirectory.SuspendLayout();
			this.grpFilter.SuspendLayout();
			this.grpMatchFilter.SuspendLayout();
			this.grpExtensions.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numLeadingZeros)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSelectFolder
			// 
			this.btnSelectFolder.Location = new System.Drawing.Point(436, 20);
			this.btnSelectFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnSelectFolder.Name = "btnSelectFolder";
			this.btnSelectFolder.Size = new System.Drawing.Size(484, 35);
			this.btnSelectFolder.TabIndex = 0;
			this.btnSelectFolder.Text = "Select Folder";
			this.btnSelectFolder.UseVisualStyleBackColor = true;
			this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
			// 
			// lstFileNames
			// 
			this.lstFileNames.CheckOnClick = true;
			this.lstFileNames.FormattingEnabled = true;
			this.lstFileNames.HorizontalScrollbar = true;
			this.lstFileNames.Location = new System.Drawing.Point(436, 66);
			this.lstFileNames.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.lstFileNames.Name = "lstFileNames";
			this.lstFileNames.Size = new System.Drawing.Size(482, 193);
			this.lstFileNames.Sorted = true;
			this.lstFileNames.TabIndex = 1;
			this.lstFileNames.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstFileNames_MouseDown);
			// 
			// grpSelectedDirectory
			// 
			this.grpSelectedDirectory.Controls.Add(this.txtSelectedDirectory);
			this.grpSelectedDirectory.Location = new System.Drawing.Point(20, 289);
			this.grpSelectedDirectory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.grpSelectedDirectory.Name = "grpSelectedDirectory";
			this.grpSelectedDirectory.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.grpSelectedDirectory.Size = new System.Drawing.Size(1358, 72);
			this.grpSelectedDirectory.TabIndex = 2;
			this.grpSelectedDirectory.TabStop = false;
			this.grpSelectedDirectory.Text = "Selected Directory";
			// 
			// txtSelectedDirectory
			// 
			this.txtSelectedDirectory.Enabled = false;
			this.txtSelectedDirectory.Location = new System.Drawing.Point(10, 29);
			this.txtSelectedDirectory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtSelectedDirectory.Name = "txtSelectedDirectory";
			this.txtSelectedDirectory.Size = new System.Drawing.Size(1336, 26);
			this.txtSelectedDirectory.TabIndex = 0;
			this.txtSelectedDirectory.TabStop = false;
			// 
			// grpFilter
			// 
			this.grpFilter.Controls.Add(this.grpMatchFilter);
			this.grpFilter.Controls.Add(this.grpExtensions);
			this.grpFilter.Location = new System.Drawing.Point(930, 20);
			this.grpFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.grpFilter.Name = "grpFilter";
			this.grpFilter.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.grpFilter.Size = new System.Drawing.Size(447, 260);
			this.grpFilter.TabIndex = 3;
			this.grpFilter.TabStop = false;
			this.grpFilter.Text = "Filter Options";
			// 
			// grpMatchFilter
			// 
			this.grpMatchFilter.Controls.Add(this.label1);
			this.grpMatchFilter.Controls.Add(this.txtFilterInput);
			this.grpMatchFilter.Controls.Add(this.chkEnableFilter);
			this.grpMatchFilter.Location = new System.Drawing.Point(196, 31);
			this.grpMatchFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.grpMatchFilter.Name = "grpMatchFilter";
			this.grpMatchFilter.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.grpMatchFilter.Size = new System.Drawing.Size(240, 137);
			this.grpMatchFilter.TabIndex = 2;
			this.grpMatchFilter.TabStop = false;
			this.grpMatchFilter.Text = "Match Filter";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(63, 102);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "(No Wildcards)";
			// 
			// txtFilterInput
			// 
			this.txtFilterInput.Enabled = false;
			this.txtFilterInput.Location = new System.Drawing.Point(10, 66);
			this.txtFilterInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtFilterInput.Name = "txtFilterInput";
			this.txtFilterInput.Size = new System.Drawing.Size(218, 26);
			this.txtFilterInput.TabIndex = 1;
			this.txtFilterInput.TextChanged += new System.EventHandler(this.txtFilterInput_TextChanged);
			// 
			// chkEnableFilter
			// 
			this.chkEnableFilter.AutoSize = true;
			this.chkEnableFilter.Enabled = false;
			this.chkEnableFilter.Location = new System.Drawing.Point(10, 31);
			this.chkEnableFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.chkEnableFilter.Name = "chkEnableFilter";
			this.chkEnableFilter.Size = new System.Drawing.Size(172, 24);
			this.chkEnableFilter.TabIndex = 0;
			this.chkEnableFilter.Text = "Enable Match Filter";
			this.chkEnableFilter.UseVisualStyleBackColor = true;
			this.chkEnableFilter.CheckedChanged += new System.EventHandler(this.chkEnableFilter_CheckedChanged);
			// 
			// grpExtensions
			// 
			this.grpExtensions.Controls.Add(this.lstExtensions);
			this.grpExtensions.Location = new System.Drawing.Point(10, 31);
			this.grpExtensions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.grpExtensions.Name = "grpExtensions";
			this.grpExtensions.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.grpExtensions.Size = new System.Drawing.Size(176, 220);
			this.grpExtensions.TabIndex = 1;
			this.grpExtensions.TabStop = false;
			this.grpExtensions.Text = "Included Extensions";
			// 
			// lstExtensions
			// 
			this.lstExtensions.CheckOnClick = true;
			this.lstExtensions.FormattingEnabled = true;
			this.lstExtensions.Location = new System.Drawing.Point(9, 29);
			this.lstExtensions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.lstExtensions.Name = "lstExtensions";
			this.lstExtensions.Size = new System.Drawing.Size(156, 151);
			this.lstExtensions.Sorted = true;
			this.lstExtensions.TabIndex = 0;
			this.lstExtensions.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lstExtensions_ItemCheck);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewFileToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(153, 34);
			// 
			// viewFileToolStripMenuItem
			// 
			this.viewFileToolStripMenuItem.Name = "viewFileToolStripMenuItem";
			this.viewFileToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
			this.viewFileToolStripMenuItem.Text = "View File";
			this.viewFileToolStripMenuItem.Click += new System.EventHandler(this.viewFileToolStripMenuItem_Click);
			// 
			// txtOuputInfo
			// 
			this.txtOuputInfo.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtOuputInfo.Location = new System.Drawing.Point(20, 371);
			this.txtOuputInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtOuputInfo.MaxLength = 10000000;
			this.txtOuputInfo.Multiline = true;
			this.txtOuputInfo.Name = "txtOuputInfo";
			this.txtOuputInfo.ReadOnly = true;
			this.txtOuputInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtOuputInfo.Size = new System.Drawing.Size(1356, 336);
			this.txtOuputInfo.TabIndex = 6;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.numLeadingZeros);
			this.groupBox1.Controls.Add(this.lblSampleOutput);
			this.groupBox1.Controls.Add(this.txtOutputExample);
			this.groupBox1.Controls.Add(this.lblOutputNumbering);
			this.groupBox1.Controls.Add(this.lblOutputName);
			this.groupBox1.Controls.Add(this.txtOutputName);
			this.groupBox1.Controls.Add(this.btnReset);
			this.groupBox1.Controls.Add(this.btnRunRename);
			this.groupBox1.Location = new System.Drawing.Point(20, 20);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Size = new System.Drawing.Size(408, 260);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Rename";
			// 
			// numLeadingZeros
			// 
			this.numLeadingZeros.Location = new System.Drawing.Point(171, 77);
			this.numLeadingZeros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.numLeadingZeros.Name = "numLeadingZeros";
			this.numLeadingZeros.Size = new System.Drawing.Size(207, 26);
			this.numLeadingZeros.TabIndex = 10;
			this.numLeadingZeros.ValueChanged += new System.EventHandler(this.numLeadingZeros_ValueChanged);
			// 
			// lblSampleOutput
			// 
			this.lblSampleOutput.AutoSize = true;
			this.lblSampleOutput.Location = new System.Drawing.Point(9, 149);
			this.lblSampleOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblSampleOutput.Name = "lblSampleOutput";
			this.lblSampleOutput.Size = new System.Drawing.Size(185, 20);
			this.lblSampleOutput.TabIndex = 9;
			this.lblSampleOutput.Text = "Sample Output Filename";
			// 
			// txtOutputExample
			// 
			this.txtOutputExample.Enabled = false;
			this.txtOutputExample.Location = new System.Drawing.Point(10, 174);
			this.txtOutputExample.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtOutputExample.Name = "txtOutputExample";
			this.txtOutputExample.Size = new System.Drawing.Size(386, 26);
			this.txtOutputExample.TabIndex = 8;
			// 
			// lblOutputNumbering
			// 
			this.lblOutputNumbering.AutoSize = true;
			this.lblOutputNumbering.Location = new System.Drawing.Point(22, 80);
			this.lblOutputNumbering.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblOutputNumbering.Name = "lblOutputNumbering";
			this.lblOutputNumbering.Size = new System.Drawing.Size(133, 20);
			this.lblOutputNumbering.TabIndex = 7;
			this.lblOutputNumbering.Text = "Number Positions";
			// 
			// lblOutputName
			// 
			this.lblOutputName.AutoSize = true;
			this.lblOutputName.Location = new System.Drawing.Point(69, 42);
			this.lblOutputName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblOutputName.Name = "lblOutputName";
			this.lblOutputName.Size = new System.Drawing.Size(92, 20);
			this.lblOutputName.TabIndex = 3;
			this.lblOutputName.Text = "Base Name";
			// 
			// txtOutputName
			// 
			this.txtOutputName.Location = new System.Drawing.Point(171, 37);
			this.txtOutputName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtOutputName.Name = "txtOutputName";
			this.txtOutputName.Size = new System.Drawing.Size(205, 26);
			this.txtOutputName.TabIndex = 2;
			this.txtOutputName.TextChanged += new System.EventHandler(this.txtOutputName_TextChanged);
			this.txtOutputName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOutputName_KeyPress);
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(224, 215);
			this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(176, 35);
			this.btnReset.TabIndex = 1;
			this.btnReset.Text = "Reset Program";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// btnRunRename
			// 
			this.btnRunRename.Enabled = false;
			this.btnRunRename.Location = new System.Drawing.Point(10, 215);
			this.btnRunRename.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnRunRename.Name = "btnRunRename";
			this.btnRunRename.Size = new System.Drawing.Size(204, 35);
			this.btnRunRename.TabIndex = 0;
			this.btnRunRename.Text = "Rename Selected Files";
			this.btnRunRename.UseVisualStyleBackColor = true;
			this.btnRunRename.Click += new System.EventHandler(this.btnRunRename_Click);
			// 
			// Form_massFileRenamer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1396, 728);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtOuputInfo);
			this.Controls.Add(this.grpFilter);
			this.Controls.Add(this.grpSelectedDirectory);
			this.Controls.Add(this.lstFileNames);
			this.Controls.Add(this.btnSelectFolder);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form_massFileRenamer";
			this.Text = "Mass File Renamer";
			this.grpSelectedDirectory.ResumeLayout(false);
			this.grpSelectedDirectory.PerformLayout();
			this.grpFilter.ResumeLayout(false);
			this.grpMatchFilter.ResumeLayout(false);
			this.grpMatchFilter.PerformLayout();
			this.grpExtensions.ResumeLayout(false);
			this.contextMenuStrip1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numLeadingZeros)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSelectFolder;
		private System.Windows.Forms.CheckedListBox lstFileNames;
		private System.Windows.Forms.GroupBox grpSelectedDirectory;
		private System.Windows.Forms.TextBox txtSelectedDirectory;
		private System.Windows.Forms.GroupBox grpFilter;
		private System.Windows.Forms.GroupBox grpExtensions;
		private System.Windows.Forms.CheckedListBox lstExtensions;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem viewFileToolStripMenuItem;
		private System.Windows.Forms.GroupBox grpMatchFilter;
		private System.Windows.Forms.TextBox txtFilterInput;
		private System.Windows.Forms.CheckBox chkEnableFilter;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtOuputInfo;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblSampleOutput;
		private System.Windows.Forms.TextBox txtOutputExample;
		private System.Windows.Forms.Label lblOutputNumbering;
		private System.Windows.Forms.Label lblOutputName;
		private System.Windows.Forms.TextBox txtOutputName;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnRunRename;
		private System.Windows.Forms.NumericUpDown numLeadingZeros;
	}
}

