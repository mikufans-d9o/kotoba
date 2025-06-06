namespace kotoba
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BtnImport = new Button();
            BtnCheck = new Button();
            OfdImport = new OpenFileDialog();
            DgvReview = new DataGridView();
            DgvReview_Words = new DataGridViewTextBoxColumn();
            DgvReview_Means = new DataGridViewTextBoxColumn();
            LblBooks = new Label();
            ((System.ComponentModel.ISupportInitialize)DgvReview).BeginInit();
            SuspendLayout();
            // 
            // BtnImport
            // 
            BtnImport.Location = new Point(11, 12);
            BtnImport.Margin = new Padding(2, 3, 2, 3);
            BtnImport.Name = "BtnImport";
            BtnImport.Size = new Size(93, 28);
            BtnImport.TabIndex = 1;
            BtnImport.Text = "导入词书";
            BtnImport.UseVisualStyleBackColor = true;
            BtnImport.Click += BtnImport_Click;
            // 
            // BtnCheck
            // 
            BtnCheck.Location = new Point(111, 12);
            BtnCheck.Margin = new Padding(2, 3, 2, 3);
            BtnCheck.Name = "BtnCheck";
            BtnCheck.Size = new Size(93, 28);
            BtnCheck.TabIndex = 2;
            BtnCheck.Text = "开始默写";
            BtnCheck.UseVisualStyleBackColor = true;
            BtnCheck.Click += BtnCheck_Click;
            // 
            // DgvReview
            // 
            DgvReview.AllowUserToAddRows = false;
            DgvReview.AllowUserToDeleteRows = false;
            DgvReview.AllowUserToResizeRows = false;
            DgvReview.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DgvReview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DgvReview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvReview.Columns.AddRange(new DataGridViewColumn[] { DgvReview_Words, DgvReview_Means });
            DgvReview.GridColor = SystemColors.ControlLight;
            DgvReview.Location = new Point(0, 45);
            DgvReview.Margin = new Padding(2, 3, 2, 3);
            DgvReview.Name = "DgvReview";
            DgvReview.ReadOnly = true;
            DgvReview.RowHeadersVisible = false;
            DgvReview.RowHeadersWidth = 51;
            DgvReview.Size = new Size(351, 404);
            DgvReview.TabIndex = 3;
            DgvReview.CellContentClick += dgvReview_CellContentClick;
            // 
            // DgvReview_Words
            // 
            DgvReview_Words.HeaderText = "单词";
            DgvReview_Words.MinimumWidth = 6;
            DgvReview_Words.Name = "DgvReview_Words";
            DgvReview_Words.ReadOnly = true;
            DgvReview_Words.Width = 125;
            // 
            // DgvReview_Means
            // 
            DgvReview_Means.HeaderText = "释义";
            DgvReview_Means.MinimumWidth = 6;
            DgvReview_Means.Name = "DgvReview_Means";
            DgvReview_Means.ReadOnly = true;
            DgvReview_Means.Width = 125;
            // 
            // LblBooks
            // 
            LblBooks.AutoSize = true;
            LblBooks.Location = new Point(213, 15);
            LblBooks.Margin = new Padding(2, 0, 2, 0);
            LblBooks.Name = "LblBooks";
            LblBooks.Size = new Size(99, 20);
            LblBooks.TabIndex = 4;
            LblBooks.Text = "当前词书：无";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 449);
            Controls.Add(LblBooks);
            Controls.Add(DgvReview);
            Controls.Add(BtnCheck);
            Controls.Add(BtnImport);
            Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            MaximizeBox = false;
            MaximumSize = new Size(369, 496);
            MinimizeBox = false;
            MinimumSize = new Size(369, 496);
            Name = "Form1";
            Text = "kotoba";
            ((System.ComponentModel.ISupportInitialize)DgvReview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BtnImport;
        private Button BtnCheck;
        private OpenFileDialog OfdImport;
        private DataGridView DgvReview;
        private DataGridViewTextBoxColumn DgvReview_Words;
        private DataGridViewTextBoxColumn DgvReview_Means;
        private Label LblBooks;
    }
}
