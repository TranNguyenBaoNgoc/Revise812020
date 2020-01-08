namespace StudentManagement
{
    partial class IndexForm
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
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.grdStudent = new System.Windows.Forms.DataGridView();
            this.BtnCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnCreate,
            this.BtnDelete});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(696, 28);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "menuStrip1";
            // 
            // grdStudent
            // 
            this.grdStudent.AllowUserToAddRows = false;
            this.grdStudent.AllowUserToDeleteRows = false;
            this.grdStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdStudent.Location = new System.Drawing.Point(0, 28);
            this.grdStudent.Name = "grdStudent";
            this.grdStudent.ReadOnly = true;
            this.grdStudent.RowTemplate.Height = 24;
            this.grdStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdStudent.Size = new System.Drawing.Size(696, 291);
            this.grdStudent.TabIndex = 1;
            // 
            // BtnCreate
            // 
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(64, 24);
            this.BtnCreate.Text = "Create";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(65, 24);
            this.BtnDelete.Text = "Delete";
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 319);
            this.Controls.Add(this.grdStudent);
            this.Controls.Add(this.menuBar);
            this.Name = "IndexForm";
            this.Text = "List of students";
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem BtnCreate;
        private System.Windows.Forms.ToolStripMenuItem BtnDelete;
        private System.Windows.Forms.DataGridView grdStudent;
    }
}