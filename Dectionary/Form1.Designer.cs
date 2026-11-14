namespace Dectionary
{
    partial class Form1
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            txtSearch = new TextBox();
            lblSearch = new Label();
            lblLanguage = new Label();
            label3 = new Label();
            label4 = new Label();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            dgvSaved = new DataGridView();
            lblEbglish = new Label();
            lblMongolian = new Label();
            lblRussian = new Label();
            txtEnglish = new TextBox();
            txtMongolian = new TextBox();
            txtRussian = new TextBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnSave = new Button();
            cmbLanguage = new ComboBox();
            dgvWords = new DataGridView();
            colNumber = new DataGridViewTextBoxColumn();
            colEnglish = new DataGridViewTextBoxColumn();
            colMongolian = new DataGridViewTextBoxColumn();
            colRussian = new DataGridViewTextBoxColumn();
            lblSavedTitle = new Label();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)dgvSaved).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvWords).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(69, 14);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Хайх ...";
            txtSearch.Size = new Size(599, 30);
            txtSearch.TabIndex = 0;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.ForeColor = Color.Gray;
            lblSearch.Location = new Point(12, 17);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(51, 23);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Хайх:";
            // 
            // lblLanguage
            // 
            lblLanguage.AutoSize = true;
            lblLanguage.ForeColor = Color.Gray;
            lblLanguage.Location = new Point(690, 17);
            lblLanguage.Name = "lblLanguage";
            lblLanguage.Size = new Size(41, 23);
            lblLanguage.TabIndex = 2;
            lblLanguage.Text = "Хэл:";
            lblLanguage.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(46, 77);
            label3.Name = "label3";
            label3.Size = new Size(117, 23);
            label3.TabIndex = 3;
            label3.Text = "toli.db · words";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(579, 77);
            label4.Name = "label4";
            label4.Size = new Size(186, 23);
            label4.TabIndex = 4;
            label4.Text = "saved.db · saved_words";
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // dgvSaved
            // 
            dgvSaved.AllowUserToAddRows = false;
            dgvSaved.AllowUserToDeleteRows = false;
            dgvSaved.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSaved.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSaved.BackgroundColor = Color.White;
            dgvSaved.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.DarkGray;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSaved.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSaved.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSaved.EnableHeadersVisualStyles = false;
            dgvSaved.Location = new Point(579, 129);
            dgvSaved.Name = "dgvSaved";
            dgvSaved.ReadOnly = true;
            dgvSaved.RowHeadersVisible = false;
            dgvSaved.RowHeadersWidth = 51;
            dgvSaved.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSaved.Size = new Size(309, 48);
            dgvSaved.TabIndex = 6;
            // 
            // lblEbglish
            // 
            lblEbglish.AutoSize = true;
            lblEbglish.ForeColor = Color.Gray;
            lblEbglish.Location = new Point(31, 489);
            lblEbglish.Name = "lblEbglish";
            lblEbglish.Size = new Size(57, 23);
            lblEbglish.TabIndex = 7;
            lblEbglish.Text = "Англи";
            // 
            // lblMongolian
            // 
            lblMongolian.AutoSize = true;
            lblMongolian.ForeColor = Color.Gray;
            lblMongolian.Location = new Point(313, 489);
            lblMongolian.Name = "lblMongolian";
            lblMongolian.Size = new Size(71, 23);
            lblMongolian.TabIndex = 8;
            lblMongolian.Text = "Монгол";
            // 
            // lblRussian
            // 
            lblRussian.AutoSize = true;
            lblRussian.ForeColor = Color.Gray;
            lblRussian.Location = new Point(617, 489);
            lblRussian.Name = "lblRussian";
            lblRussian.Size = new Size(51, 23);
            lblRussian.TabIndex = 9;
            lblRussian.Text = "Орос";
            // 
            // txtEnglish
            // 
            txtEnglish.Location = new Point(94, 486);
            txtEnglish.Name = "txtEnglish";
            txtEnglish.Size = new Size(191, 30);
            txtEnglish.TabIndex = 10;
            // 
            // txtMongolian
            // 
            txtMongolian.Location = new Point(390, 486);
            txtMongolian.Name = "txtMongolian";
            txtMongolian.Size = new Size(191, 30);
            txtMongolian.TabIndex = 11;
            // 
            // txtRussian
            // 
            txtRussian.Location = new Point(674, 486);
            txtRussian.Name = "txtRussian";
            txtRussian.Size = new Size(191, 30);
            txtRussian.TabIndex = 12;
            // 
            // btnAdd
            // 
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderColor = Color.Silver;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(46, 553);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(144, 39);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Нэмэх";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderColor = Color.Silver;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Location = new Point(196, 553);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(144, 39);
            btnEdit.TabIndex = 14;
            btnEdit.Text = "Засах";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderColor = Color.Silver;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(346, 553);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(144, 39);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Устгах";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderColor = Color.Silver;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Location = new Point(496, 553);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(144, 39);
            btnClear.TabIndex = 16;
            btnClear.Text = "Цэвэрлэх";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderColor = Color.Silver;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.LightGreen;
            btnSave.Location = new Point(646, 553);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(144, 39);
            btnSave.TabIndex = 17;
            btnSave.Text = "Санах";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // cmbLanguage
            // 
            cmbLanguage.BackColor = Color.White;
            cmbLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLanguage.FormattingEnabled = true;
            cmbLanguage.Items.AddRange(new object[] { "Бүгд", "Англи", "Монгол", "Орос" });
            cmbLanguage.Location = new Point(737, 13);
            cmbLanguage.Name = "cmbLanguage";
            cmbLanguage.Size = new Size(151, 31);
            cmbLanguage.TabIndex = 18;
            // 
            // dgvWords
            // 
            dgvWords.AllowUserToDeleteRows = false;
            dgvWords.AllowUserToResizeRows = false;
            dgvWords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvWords.BackgroundColor = Color.White;
            dgvWords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWords.Columns.AddRange(new DataGridViewColumn[] { colNumber, colEnglish, colMongolian, colRussian });
            dgvWords.Location = new Point(12, 103);
            dgvWords.MultiSelect = false;
            dgvWords.Name = "dgvWords";
            dgvWords.ReadOnly = true;
            dgvWords.RowHeadersVisible = false;
            dgvWords.RowHeadersWidth = 51;
            dgvWords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvWords.Size = new Size(480, 320);
            dgvWords.TabIndex = 19;
            // 
            // colNumber
            // 
            colNumber.HeaderText = "№";
            colNumber.MinimumWidth = 6;
            colNumber.Name = "colNumber";
            colNumber.ReadOnly = true;
            // 
            // colEnglish
            // 
            colEnglish.HeaderText = "Англи";
            colEnglish.MinimumWidth = 6;
            colEnglish.Name = "colEnglish";
            colEnglish.ReadOnly = true;
            // 
            // colMongolian
            // 
            colMongolian.HeaderText = "Монгол";
            colMongolian.MinimumWidth = 6;
            colMongolian.Name = "colMongolian";
            colMongolian.ReadOnly = true;
            // 
            // colRussian
            // 
            colRussian.HeaderText = "Орос";
            colRussian.MinimumWidth = 6;
            colRussian.Name = "colRussian";
            colRussian.ReadOnly = true;
            // 
            // lblSavedTitle
            // 
            lblSavedTitle.BackColor = Color.LightGreen;
            lblSavedTitle.Location = new Point(579, 103);
            lblSavedTitle.Name = "lblSavedTitle";
            lblSavedTitle.Size = new Size(309, 35);
            lblSavedTitle.TabIndex = 20;
            lblSavedTitle.Text = "Санасан үг";
            lblSavedTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip1.Location = new Point(0, 633);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(900, 26);
            statusStrip1.TabIndex = 21;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.ItemClicked += statusStrip1_ItemClicked;
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(168, 20);
            lblStatus.Text = "Нийт: 10 үг · Санасан: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 659);
            Controls.Add(statusStrip1);
            Controls.Add(lblSavedTitle);
            Controls.Add(dgvWords);
            Controls.Add(cmbLanguage);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtRussian);
            Controls.Add(txtMongolian);
            Controls.Add(txtEnglish);
            Controls.Add(lblRussian);
            Controls.Add(lblMongolian);
            Controls.Add(lblEbglish);
            Controls.Add(dgvSaved);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblLanguage);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Гурван хэлний толь бичиг";
            ((System.ComponentModel.ISupportInitialize)dgvSaved).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvWords).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Label lblSearch;
        private Label lblLanguage;
        private Label label3;
        private Label label4;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private DataGridView dgvSaved;
        private Label lblEbglish;
        private Label lblMongolian;
        private Label lblRussian;
        private TextBox txtEnglish;
        private TextBox txtMongolian;
        private TextBox txtRussian;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnClear;
        private Button btnSave;
        private ComboBox cmbLanguage;
        private DataGridView dgvWords;
        private DataGridViewTextBoxColumn colNumber;
        private DataGridViewTextBoxColumn colEnglish;
        private DataGridViewTextBoxColumn colMongolian;
        private DataGridViewTextBoxColumn colRussian;
        private Label lblSavedTitle;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
    }
}
