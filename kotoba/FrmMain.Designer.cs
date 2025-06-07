namespace kotoba
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            OfdImport = new OpenFileDialog();
            DgvReview = new DataGridView();
            DgvReview_Words = new DataGridViewTextBoxColumn();
            DgvReview_Means = new DataGridViewTextBoxColumn();
            Ms = new MenuStrip();
            Ms_Import = new ToolStripMenuItem();
            Ms_Check = new ToolStripMenuItem();
            Ms_About = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)DgvReview).BeginInit();
            Ms.SuspendLayout();
            SuspendLayout();
            // 
            // DgvReview
            // 
            DgvReview.AllowUserToAddRows = false;
            DgvReview.AllowUserToDeleteRows = false;
            DgvReview.AllowUserToResizeRows = false;
            DgvReview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DgvReview.BorderStyle = BorderStyle.None;
            DgvReview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvReview.Columns.AddRange(new DataGridViewColumn[] { DgvReview_Words, DgvReview_Means });
            DgvReview.Dock = DockStyle.Fill;
            DgvReview.GridColor = SystemColors.ControlLight;
            DgvReview.Location = new Point(0, 28);
            DgvReview.Margin = new Padding(2, 3, 2, 3);
            DgvReview.Name = "DgvReview";
            DgvReview.ReadOnly = true;
            DgvReview.RowHeadersVisible = false;
            DgvReview.RowHeadersWidth = 51;
            DgvReview.Size = new Size(351, 421);
            DgvReview.TabIndex = 6;
            // 
            // DgvReview_Words
            // 
            DgvReview_Words.HeaderText = "单词";
            DgvReview_Words.MinimumWidth = 6;
            DgvReview_Words.Name = "DgvReview_Words";
            DgvReview_Words.ReadOnly = true;
            DgvReview_Words.Width = 68;
            // 
            // DgvReview_Means
            // 
            DgvReview_Means.HeaderText = "释义";
            DgvReview_Means.MinimumWidth = 6;
            DgvReview_Means.Name = "DgvReview_Means";
            DgvReview_Means.ReadOnly = true;
            DgvReview_Means.Width = 68;
            // 
            // Ms
            // 
            Ms.ImageScalingSize = new Size(20, 20);
            Ms.Items.AddRange(new ToolStripItem[] { Ms_Import, Ms_Check, Ms_About });
            Ms.Location = new Point(0, 0);
            Ms.Name = "Ms";
            Ms.RenderMode = ToolStripRenderMode.Professional;
            Ms.Size = new Size(351, 28);
            Ms.TabIndex = 7;
            Ms.Text = "menuStrip1";
            // 
            // Ms_Import
            // 
            Ms_Import.Name = "Ms_Import";
            Ms_Import.Size = new Size(83, 24);
            Ms_Import.Text = "导入词书";
            Ms_Import.Click += Ms_Import_Click;
            // 
            // Ms_Check
            // 
            Ms_Check.Name = "Ms_Check";
            Ms_Check.Size = new Size(83, 24);
            Ms_Check.Text = "开始默写";
            Ms_Check.Click += Ms_Check_Click;
            // 
            // Ms_About
            // 
            Ms_About.Name = "Ms_About";
            Ms_About.Size = new Size(53, 24);
            Ms_About.Text = "关于";
            Ms_About.Click += Ms_About_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 449);
            Controls.Add(DgvReview);
            Controls.Add(Ms);
            Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = Ms;
            Margin = new Padding(2, 3, 2, 3);
            Name = "MainForm";
            Text = "kotoba";
            ((System.ComponentModel.ISupportInitialize)DgvReview).EndInit();
            Ms.ResumeLayout(false);
            Ms.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private OpenFileDialog OfdImport;
        private DataGridView DgvReview;
        private DataGridViewTextBoxColumn DgvReview_Words;
        private DataGridViewTextBoxColumn DgvReview_Means;
        private MenuStrip Ms;
        private ToolStripMenuItem Ms_Import;
        private ToolStripMenuItem Ms_Check;
        private ToolStripMenuItem Ms_About;
    }
}
