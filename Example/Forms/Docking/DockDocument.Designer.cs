namespace Example
{
    partial class DockDocument
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDocument = new DarkUI.Controls.DarkTextBox();
            cmbOptions = new DarkUI.Controls.DarkDropdownList();
            SuspendLayout();
            // 
            // txtDocument
            // 
            txtDocument.BackColor = System.Drawing.Color.FromArgb(43, 43, 43);
            txtDocument.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtDocument.Dock = System.Windows.Forms.DockStyle.Fill;
            txtDocument.ForeColor = System.Drawing.Color.Gainsboro;
            txtDocument.Location = new System.Drawing.Point(0, 0);
            txtDocument.Multiline = true;
            txtDocument.Name = "txtDocument";
            txtDocument.Size = new System.Drawing.Size(175, 173);
            txtDocument.TabIndex = 1;
            txtDocument.Text = "This is some example text";
            // 
            // cmbOptions
            // 
            cmbOptions.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            cmbOptions.DropdownDirection = System.Windows.Forms.ToolStripDropDownDirection.AboveRight;
            cmbOptions.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cmbOptions.Location = new System.Drawing.Point(0, 158);
            cmbOptions.MaxHeight = 300;
            cmbOptions.Name = "cmbOptions";
            cmbOptions.ShowBorder = false;
            cmbOptions.Size = new System.Drawing.Size(65, 15);
            cmbOptions.TabIndex = 2;
            cmbOptions.Text = "darkComboBox1";
            // 
            // DockDocument
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(cmbOptions);
            Controls.Add(txtDocument);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Name = "DockDocument";
            Size = new System.Drawing.Size(175, 173);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DarkUI.Controls.DarkTextBox txtDocument;
        private DarkUI.Controls.DarkDropdownList cmbOptions;
    }
}
