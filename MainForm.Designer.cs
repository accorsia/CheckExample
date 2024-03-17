namespace CheckExample
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtPath = new TextBox();
            btnBrowseFile = new Button();
            btnReadCSV = new Button();
            lblReadOutcome = new Label();
            lblDelimiter = new Label();
            txtDelimiter = new TextBox();
            lblSelectedCol = new Label();
            cboSelectedCol = new ComboBox();
            rbtnHeader = new RadioButton();
            lblHeader = new Label();
            gridReadRecords = new DataGridView();
            btnFindDuplicates = new Button();
            gridFindDuplicates = new DataGridView();
            label3 = new Label();
            txtNumReps = new TextBox();
            label1 = new Label();
            txtItemRepetitions = new TextBox();
            label2 = new Label();
            lblTimer = new Label();
            ((System.ComponentModel.ISupportInitialize)gridReadRecords).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridFindDuplicates).BeginInit();
            SuspendLayout();
            // 
            // txtPath
            // 
            txtPath.Location = new Point(6, 13);
            txtPath.Margin = new Padding(3, 2, 3, 2);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(284, 23);
            txtPath.TabIndex = 0;
            txtPath.Text = "C:\\Users\\aless\\Desktop\\repos\\CheckExample\\small.csv";
            // 
            // btnBrowseFile
            // 
            btnBrowseFile.Location = new Point(303, 13);
            btnBrowseFile.Margin = new Padding(3, 2, 3, 2);
            btnBrowseFile.Name = "btnBrowseFile";
            btnBrowseFile.Size = new Size(82, 25);
            btnBrowseFile.TabIndex = 1;
            btnBrowseFile.Text = "Sfoglia";
            btnBrowseFile.UseVisualStyleBackColor = true;
            btnBrowseFile.Click += btnBrowseFile_Click;
            // 
            // btnReadCSV
            // 
            btnReadCSV.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReadCSV.Location = new Point(456, 5);
            btnReadCSV.Margin = new Padding(3, 2, 3, 2);
            btnReadCSV.Name = "btnReadCSV";
            btnReadCSV.Size = new Size(156, 95);
            btnReadCSV.TabIndex = 2;
            btnReadCSV.Text = "READ CSV";
            btnReadCSV.UseVisualStyleBackColor = true;
            btnReadCSV.Click += btnReadCSV_Click;
            // 
            // lblReadOutcome
            // 
            lblReadOutcome.Location = new Point(476, 101);
            lblReadOutcome.Name = "lblReadOutcome";
            lblReadOutcome.Size = new Size(118, 15);
            lblReadOutcome.TabIndex = 4;
            lblReadOutcome.Text = "Waiting for CSV file...";
            lblReadOutcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDelimiter
            // 
            lblDelimiter.AutoSize = true;
            lblDelimiter.Location = new Point(226, 45);
            lblDelimiter.Name = "lblDelimiter";
            lblDelimiter.Size = new Size(55, 15);
            lblDelimiter.TabIndex = 5;
            lblDelimiter.Text = "Delimiter";
            // 
            // txtDelimiter
            // 
            txtDelimiter.Location = new Point(303, 40);
            txtDelimiter.Margin = new Padding(3, 2, 3, 2);
            txtDelimiter.Name = "txtDelimiter";
            txtDelimiter.Size = new Size(31, 23);
            txtDelimiter.TabIndex = 6;
            // 
            // lblSelectedCol
            // 
            lblSelectedCol.AutoSize = true;
            lblSelectedCol.Location = new Point(166, 67);
            lblSelectedCol.Name = "lblSelectedCol";
            lblSelectedCol.Size = new Size(111, 15);
            lblSelectedCol.TabIndex = 7;
            lblSelectedCol.Text = "# Colonna duplicati";
            // 
            // cboSelectedCol
            // 
            cboSelectedCol.FormattingEnabled = true;
            cboSelectedCol.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            cboSelectedCol.Location = new Point(303, 61);
            cboSelectedCol.Margin = new Padding(3, 2, 3, 2);
            cboSelectedCol.Name = "cboSelectedCol";
            cboSelectedCol.Size = new Size(133, 23);
            cboSelectedCol.TabIndex = 8;
            // 
            // rbtnHeader
            // 
            rbtnHeader.AutoSize = true;
            rbtnHeader.Checked = true;
            rbtnHeader.Location = new Point(303, 86);
            rbtnHeader.Margin = new Padding(3, 2, 3, 2);
            rbtnHeader.Name = "rbtnHeader";
            rbtnHeader.RightToLeft = RightToLeft.Yes;
            rbtnHeader.Size = new Size(14, 13);
            rbtnHeader.TabIndex = 9;
            rbtnHeader.TabStop = true;
            rbtnHeader.UseVisualStyleBackColor = true;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Location = new Point(196, 85);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(82, 15);
            lblHeader.TabIndex = 10;
            lblHeader.Text = "Header record";
            // 
            // gridReadRecords
            // 
            gridReadRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridReadRecords.Location = new Point(6, 120);
            gridReadRecords.Name = "gridReadRecords";
            gridReadRecords.Size = new Size(608, 170);
            gridReadRecords.TabIndex = 12;
            // 
            // btnFindDuplicates
            // 
            btnFindDuplicates.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFindDuplicates.Location = new Point(458, 326);
            btnFindDuplicates.Margin = new Padding(3, 2, 3, 2);
            btnFindDuplicates.Name = "btnFindDuplicates";
            btnFindDuplicates.Size = new Size(156, 95);
            btnFindDuplicates.TabIndex = 15;
            btnFindDuplicates.Text = "FIND DUPLICATES";
            btnFindDuplicates.UseVisualStyleBackColor = true;
            btnFindDuplicates.Click += btnFindDuplicates_Click;
            // 
            // gridFindDuplicates
            // 
            gridFindDuplicates.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridFindDuplicates.Location = new Point(6, 326);
            gridFindDuplicates.Name = "gridFindDuplicates";
            gridFindDuplicates.Size = new Size(444, 204);
            gridFindDuplicates.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(472, 487);
            label3.Name = "label3";
            label3.Size = new Size(124, 15);
            label3.TabIndex = 17;
            label3.Text = "Number of repetitions";
            // 
            // txtNumReps
            // 
            txtNumReps.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtNumReps.ForeColor = SystemColors.MenuText;
            txtNumReps.Location = new Point(472, 505);
            txtNumReps.Name = "txtNumReps";
            txtNumReps.Size = new Size(122, 25);
            txtNumReps.TabIndex = 18;
            txtNumReps.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-45, 293);
            label1.Name = "label1";
            label1.Size = new Size(732, 15);
            label1.TabIndex = 13;
            label1.Text = "_________________________________________________________________________________________________________________________________________________";
            // 
            // txtItemRepetitions
            // 
            txtItemRepetitions.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtItemRepetitions.ForeColor = SystemColors.MenuText;
            txtItemRepetitions.Location = new Point(472, 448);
            txtItemRepetitions.Name = "txtItemRepetitions";
            txtItemRepetitions.Size = new Size(122, 25);
            txtItemRepetitions.TabIndex = 20;
            txtItemRepetitions.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(472, 430);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 19;
            label2.Text = "Items with duplicates";
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Location = new Point(472, 541);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(0, 15);
            lblTimer.TabIndex = 21;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 565);
            Controls.Add(lblTimer);
            Controls.Add(txtItemRepetitions);
            Controls.Add(label2);
            Controls.Add(txtNumReps);
            Controls.Add(label3);
            Controls.Add(gridFindDuplicates);
            Controls.Add(btnFindDuplicates);
            Controls.Add(label1);
            Controls.Add(gridReadRecords);
            Controls.Add(lblHeader);
            Controls.Add(rbtnHeader);
            Controls.Add(cboSelectedCol);
            Controls.Add(lblSelectedCol);
            Controls.Add(txtDelimiter);
            Controls.Add(lblDelimiter);
            Controls.Add(lblReadOutcome);
            Controls.Add(btnReadCSV);
            Controls.Add(btnBrowseFile);
            Controls.Add(txtPath);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "AlessandroVerdad - CSV Duplicates Checker";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)gridReadRecords).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridFindDuplicates).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPath;
        private Button btnBrowseFile;
        private Button btnReadCSV;
        private Label lblReadOutcome;
        private Label lblDelimiter;
        private TextBox txtDelimiter;
        private Label lblSelectedCol;
        private ComboBox cboSelectedCol;
        private RadioButton rbtnHeader;
        private Label lblHeader;
        private DataGridView gridReadRecords;
        private Button btnFindDuplicates;
        private DataGridView gridFindDuplicates;
        private Label label3;
        private TextBox txtNumReps;
        private Label label1;
        private TextBox txtItemRepetitions;
        private Label label2;
        private Label lblTimer;
    }
}
