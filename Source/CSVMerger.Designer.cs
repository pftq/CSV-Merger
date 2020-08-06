namespace CSVMerger
{
    partial class CSVMerger
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
            this.folder = new System.Windows.Forms.Button();
            this.folderSaved = new System.Windows.Forms.TextBox();
            this.fileSaved = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.merge = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.headerRow = new System.Windows.Forms.NumericUpDown();
            this.firstRow = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lastRow = new System.Windows.Forms.NumericUpDown();
            this.addCol = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addColPos = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.newColY = new System.Windows.Forms.NumericUpDown();
            this.newColX = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.newColRegex = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.optionsLink = new System.Windows.Forms.LinkLabel();
            this.moreOptions = new System.Windows.Forms.GroupBox();
            this.addColEnabled = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.delimiter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.newColFormat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.headerRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addColPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newColY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newColX)).BeginInit();
            this.moreOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // folder
            // 
            this.folder.Location = new System.Drawing.Point(12, 12);
            this.folder.Name = "folder";
            this.folder.Size = new System.Drawing.Size(85, 23);
            this.folder.TabIndex = 0;
            this.folder.Text = "Select Folder:";
            this.folder.UseVisualStyleBackColor = true;
            this.folder.Click += new System.EventHandler(this.folder_Click);
            // 
            // folderSaved
            // 
            this.folderSaved.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.folderSaved.Location = new System.Drawing.Point(103, 14);
            this.folderSaved.Name = "folderSaved";
            this.folderSaved.Size = new System.Drawing.Size(269, 20);
            this.folderSaved.TabIndex = 1;
            // 
            // fileSaved
            // 
            this.fileSaved.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fileSaved.Location = new System.Drawing.Point(103, 40);
            this.fileSaved.Name = "fileSaved";
            this.fileSaved.Size = new System.Drawing.Size(269, 20);
            this.fileSaved.TabIndex = 3;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(12, 38);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(85, 23);
            this.save.TabIndex = 2;
            this.save.Text = "Save File To:";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // merge
            // 
            this.merge.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.merge.Location = new System.Drawing.Point(150, 115);
            this.merge.Name = "merge";
            this.merge.Size = new System.Drawing.Size(85, 23);
            this.merge.TabIndex = 4;
            this.merge.Text = "Merge CSVs";
            this.merge.UseVisualStyleBackColor = true;
            this.merge.Click += new System.EventHandler(this.merge_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data Rows:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Header Row:";
            // 
            // headerRow
            // 
            this.headerRow.Location = new System.Drawing.Point(166, 76);
            this.headerRow.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.headerRow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.headerRow.Name = "headerRow";
            this.headerRow.Size = new System.Drawing.Size(37, 20);
            this.headerRow.TabIndex = 7;
            this.headerRow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.headerRow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.headerRow.ValueChanged += new System.EventHandler(this.headerRow_ValueChanged);
            // 
            // firstRow
            // 
            this.firstRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.firstRow.Location = new System.Drawing.Point(275, 76);
            this.firstRow.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.firstRow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.firstRow.Name = "firstRow";
            this.firstRow.Size = new System.Drawing.Size(37, 20);
            this.firstRow.TabIndex = 8;
            this.firstRow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.firstRow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.firstRow.ValueChanged += new System.EventHandler(this.firstRow_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "to";
            // 
            // lastRow
            // 
            this.lastRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lastRow.Location = new System.Drawing.Point(335, 76);
            this.lastRow.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.lastRow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lastRow.Name = "lastRow";
            this.lastRow.Size = new System.Drawing.Size(37, 20);
            this.lastRow.TabIndex = 10;
            this.lastRow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.lastRow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lastRow.ValueChanged += new System.EventHandler(this.lastRow_ValueChanged);
            // 
            // addCol
            // 
            this.addCol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.addCol.Location = new System.Drawing.Point(128, 20);
            this.addCol.Name = "addCol";
            this.addCol.Size = new System.Drawing.Size(74, 20);
            this.addCol.TabIndex = 12;
            this.addCol.Text = "Date";
            this.addCol.TextChanged += new System.EventHandler(this.addCol_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "New Column Position:";
            // 
            // addColPos
            // 
            this.addColPos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addColPos.Location = new System.Drawing.Point(336, 21);
            this.addColPos.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.addColPos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.addColPos.Name = "addColPos";
            this.addColPos.Size = new System.Drawing.Size(37, 20);
            this.addColPos.TabIndex = 14;
            this.addColPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.addColPos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.addColPos.ValueChanged += new System.EventHandler(this.addColPos_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Fill New Column with Data from Cell:";
            // 
            // newColY
            // 
            this.newColY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newColY.Location = new System.Drawing.Point(336, 52);
            this.newColY.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.newColY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.newColY.Name = "newColY";
            this.newColY.Size = new System.Drawing.Size(37, 20);
            this.newColY.TabIndex = 17;
            this.newColY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.newColY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.newColY.ValueChanged += new System.EventHandler(this.newColY_ValueChanged);
            // 
            // newColX
            // 
            this.newColX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newColX.Location = new System.Drawing.Point(251, 52);
            this.newColX.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.newColX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.newColX.Name = "newColX";
            this.newColX.Size = new System.Drawing.Size(37, 20);
            this.newColX.TabIndex = 16;
            this.newColX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.newColX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.newColX.ValueChanged += new System.EventHandler(this.newColX_ValueChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "(Row)";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(217, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "(Col)";
            // 
            // newColRegex
            // 
            this.newColRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.newColRegex.Location = new System.Drawing.Point(222, 79);
            this.newColRegex.Name = "newColRegex";
            this.newColRegex.Size = new System.Drawing.Size(151, 20);
            this.newColRegex.TabIndex = 21;
            this.newColRegex.Text = "([0-9]{2})/([0-9]{2})/([0-9]{4})";
            this.newColRegex.TextChanged += new System.EventHandler(this.newColRegex_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(192, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Filter Data for New Column with Regex:";
            // 
            // optionsLink
            // 
            this.optionsLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.optionsLink.AutoSize = true;
            this.optionsLink.Location = new System.Drawing.Point(304, 120);
            this.optionsLink.Name = "optionsLink";
            this.optionsLink.Size = new System.Drawing.Size(68, 13);
            this.optionsLink.TabIndex = 22;
            this.optionsLink.TabStop = true;
            this.optionsLink.Text = "Less Options";
            this.optionsLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.optionsLink_LinkClicked);
            // 
            // moreOptions
            // 
            this.moreOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.moreOptions.Controls.Add(this.label4);
            this.moreOptions.Controls.Add(this.newColFormat);
            this.moreOptions.Controls.Add(this.addColEnabled);
            this.moreOptions.Controls.Add(this.label9);
            this.moreOptions.Controls.Add(this.label8);
            this.moreOptions.Controls.Add(this.newColRegex);
            this.moreOptions.Controls.Add(this.newColY);
            this.moreOptions.Controls.Add(this.label7);
            this.moreOptions.Controls.Add(this.addColPos);
            this.moreOptions.Controls.Add(this.newColX);
            this.moreOptions.Controls.Add(this.label6);
            this.moreOptions.Controls.Add(this.label5);
            this.moreOptions.Controls.Add(this.addCol);
            this.moreOptions.Location = new System.Drawing.Point(0, 148);
            this.moreOptions.Name = "moreOptions";
            this.moreOptions.Size = new System.Drawing.Size(385, 136);
            this.moreOptions.TabIndex = 23;
            this.moreOptions.TabStop = false;
            this.moreOptions.Text = "Options";
            // 
            // addColEnabled
            // 
            this.addColEnabled.AutoSize = true;
            this.addColEnabled.Location = new System.Drawing.Point(9, 22);
            this.addColEnabled.Name = "addColEnabled";
            this.addColEnabled.Size = new System.Drawing.Size(111, 17);
            this.addColEnabled.TabIndex = 22;
            this.addColEnabled.Text = "Add New Column:";
            this.addColEnabled.UseVisualStyleBackColor = true;
            this.addColEnabled.CheckedChanged += new System.EventHandler(this.addColEnabled_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Delimiter:";
            // 
            // delimiter
            // 
            this.delimiter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.delimiter.Location = new System.Drawing.Point(62, 75);
            this.delimiter.Name = "delimiter";
            this.delimiter.Size = new System.Drawing.Size(22, 20);
            this.delimiter.TabIndex = 25;
            this.delimiter.Text = ",";
            this.delimiter.TextChanged += new System.EventHandler(this.delimiter_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Format Filtered Data with Regex ($1, $2,...):";
            // 
            // newColFormat
            // 
            this.newColFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.newColFormat.Location = new System.Drawing.Point(222, 105);
            this.newColFormat.Name = "newColFormat";
            this.newColFormat.Size = new System.Drawing.Size(151, 20);
            this.newColFormat.TabIndex = 24;
            this.newColFormat.Text = "$3-$2-$1";
            this.newColFormat.TextChanged += new System.EventHandler(this.newColFormat_TextChanged);
            // 
            // CSVMerger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 282);
            this.Controls.Add(this.delimiter);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.moreOptions);
            this.Controls.Add(this.optionsLink);
            this.Controls.Add(this.lastRow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstRow);
            this.Controls.Add(this.headerRow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.merge);
            this.Controls.Add(this.fileSaved);
            this.Controls.Add(this.save);
            this.Controls.Add(this.folderSaved);
            this.Controls.Add(this.folder);
            this.MinimumSize = new System.Drawing.Size(400, 320);
            this.Name = "CSVMerger";
            this.Text = "CSVMerger";
            ((System.ComponentModel.ISupportInitialize)(this.headerRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addColPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newColY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newColX)).EndInit();
            this.moreOptions.ResumeLayout(false);
            this.moreOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button folder;
        private System.Windows.Forms.TextBox folderSaved;
        private System.Windows.Forms.TextBox fileSaved;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button merge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown headerRow;
        private System.Windows.Forms.NumericUpDown firstRow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown lastRow;
        private System.Windows.Forms.TextBox addCol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown addColPos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown newColY;
        private System.Windows.Forms.NumericUpDown newColX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox newColRegex;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel optionsLink;
        private System.Windows.Forms.GroupBox moreOptions;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox delimiter;
        private System.Windows.Forms.CheckBox addColEnabled;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox newColFormat;
    }
}

