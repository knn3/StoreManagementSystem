
namespace WindowsFormsApp1
{
    partial class AddCategoryWindow
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
            this.txtNameOfCategory = new System.Windows.Forms.TextBox();
            this.lblNameOfCategory = new System.Windows.Forms.Label();
            this.btnSaveCategory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNameOfCategory
            // 
            this.txtNameOfCategory.Location = new System.Drawing.Point(133, 41);
            this.txtNameOfCategory.Name = "txtNameOfCategory";
            this.txtNameOfCategory.Size = new System.Drawing.Size(232, 20);
            this.txtNameOfCategory.TabIndex = 0;
            this.txtNameOfCategory.TextChanged += new System.EventHandler(this.txtNameOfCategory_TextChanged);
            // 
            // lblNameOfCategory
            // 
            this.lblNameOfCategory.AutoSize = true;
            this.lblNameOfCategory.Location = new System.Drawing.Point(30, 44);
            this.lblNameOfCategory.Name = "lblNameOfCategory";
            this.lblNameOfCategory.Size = new System.Drawing.Size(97, 13);
            this.lblNameOfCategory.TabIndex = 1;
            this.lblNameOfCategory.Text = "Name of category: ";
            // 
            // btnSaveCategory
            // 
            this.btnSaveCategory.Location = new System.Drawing.Point(398, 44);
            this.btnSaveCategory.Name = "btnSaveCategory";
            this.btnSaveCategory.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCategory.TabIndex = 2;
            this.btnSaveCategory.Text = "Save";
            this.btnSaveCategory.UseVisualStyleBackColor = true;
            this.btnSaveCategory.Click += new System.EventHandler(this.btnSaveCategory_Click);
            // 
            // AddCategoryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaveCategory);
            this.Controls.Add(this.lblNameOfCategory);
            this.Controls.Add(this.txtNameOfCategory);
            this.Name = "AddCategoryWindow";
            this.Text = "AddCategoryWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNameOfCategory;
        private System.Windows.Forms.Label lblNameOfCategory;
        private System.Windows.Forms.Button btnSaveCategory;
    }
}