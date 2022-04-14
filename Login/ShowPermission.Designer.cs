
namespace Login
{
    partial class ShowPermission
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
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbGroup = new System.Windows.Forms.Label();
            this.lbInvidual = new System.Windows.Forms.Label();
            this.lbGrPermission = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbUsername.Location = new System.Drawing.Point(72, 58);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(104, 30);
            this.lbUsername.TabIndex = 0;
            this.lbUsername.Text = "username";
            // 
            // lbGroup
            // 
            this.lbGroup.AutoSize = true;
            this.lbGroup.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbGroup.Location = new System.Drawing.Point(72, 147);
            this.lbGroup.Name = "lbGroup";
            this.lbGroup.Size = new System.Drawing.Size(65, 25);
            this.lbGroup.TabIndex = 1;
            this.lbGroup.Text = "Group";
            // 
            // lbInvidual
            // 
            this.lbInvidual.AutoSize = true;
            this.lbInvidual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbInvidual.Location = new System.Drawing.Point(72, 317);
            this.lbInvidual.Name = "lbInvidual";
            this.lbInvidual.Size = new System.Drawing.Size(0, 21);
            this.lbInvidual.TabIndex = 1;
            // 
            // lbGrPermission
            // 
            this.lbGrPermission.AutoSize = true;
            this.lbGrPermission.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbGrPermission.Location = new System.Drawing.Point(72, 244);
            this.lbGrPermission.Name = "lbGrPermission";
            this.lbGrPermission.Size = new System.Drawing.Size(0, 21);
            this.lbGrPermission.TabIndex = 1;
            // 
            // ShowPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 450);
            this.Controls.Add(this.lbGroup);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lbGrPermission);
            this.Controls.Add(this.lbInvidual);
            this.Name = "ShowPermission";
            this.Text = "ShowPermission";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbGroup;
        private System.Windows.Forms.Label lbInvidual;
        private System.Windows.Forms.Label lbGrPermission;
    }
}