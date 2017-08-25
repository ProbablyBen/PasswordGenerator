namespace PasswordGenerator
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnGeneratePassword = new System.Windows.Forms.Button();
            this.grpPasswordOptions = new System.Windows.Forms.GroupBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.chkSpecial = new System.Windows.Forms.CheckBox();
            this.chkDigits = new System.Windows.Forms.CheckBox();
            this.chkLowerCase = new System.Windows.Forms.CheckBox();
            this.chkUpperCase = new System.Windows.Forms.CheckBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.grpPasswordOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.Location = new System.Drawing.Point(180, 152);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.Size = new System.Drawing.Size(110, 23);
            this.btnGeneratePassword.TabIndex = 5;
            this.btnGeneratePassword.Text = "Generate Password";
            this.btnGeneratePassword.UseVisualStyleBackColor = true;
            this.btnGeneratePassword.Click += new System.EventHandler(this.BtnGeneratePassword_Click);
            // 
            // grpPasswordOptions
            // 
            this.grpPasswordOptions.Controls.Add(this.lblLength);
            this.grpPasswordOptions.Controls.Add(this.txtLength);
            this.grpPasswordOptions.Controls.Add(this.chkSpecial);
            this.grpPasswordOptions.Controls.Add(this.chkDigits);
            this.grpPasswordOptions.Controls.Add(this.chkLowerCase);
            this.grpPasswordOptions.Controls.Add(this.chkUpperCase);
            this.grpPasswordOptions.Location = new System.Drawing.Point(12, 12);
            this.grpPasswordOptions.Name = "grpPasswordOptions";
            this.grpPasswordOptions.Size = new System.Drawing.Size(441, 134);
            this.grpPasswordOptions.TabIndex = 4;
            this.grpPasswordOptions.TabStop = false;
            this.grpPasswordOptions.Text = "Password Options";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(264, 24);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(137, 13);
            this.lblLength.TabIndex = 5;
            this.lblLength.Text = "Password Length [1 - 2048]";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(282, 40);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 20);
            this.txtLength.TabIndex = 4;
            // 
            // chkSpecial
            // 
            this.chkSpecial.AutoSize = true;
            this.chkSpecial.Location = new System.Drawing.Point(7, 89);
            this.chkSpecial.Name = "chkSpecial";
            this.chkSpecial.Size = new System.Drawing.Size(126, 17);
            this.chkSpecial.TabIndex = 3;
            this.chkSpecial.Text = "Special (!, $, %, &&, ...)";
            this.chkSpecial.UseVisualStyleBackColor = true;
            // 
            // chkDigits
            // 
            this.chkDigits.AutoSize = true;
            this.chkDigits.Location = new System.Drawing.Point(7, 66);
            this.chkDigits.Name = "chkDigits";
            this.chkDigits.Size = new System.Drawing.Size(106, 17);
            this.chkDigits.TabIndex = 2;
            this.chkDigits.Text = "Digits (0, 1, 2, ...)";
            this.chkDigits.UseVisualStyleBackColor = true;
            // 
            // chkLowerCase
            // 
            this.chkLowerCase.AutoSize = true;
            this.chkLowerCase.Location = new System.Drawing.Point(7, 43);
            this.chkLowerCase.Name = "chkLowerCase";
            this.chkLowerCase.Size = new System.Drawing.Size(135, 17);
            this.chkLowerCase.TabIndex = 1;
            this.chkLowerCase.Text = "Lower-case (a, b, c, ...)";
            this.chkLowerCase.UseVisualStyleBackColor = true;
            // 
            // chkUpperCase
            // 
            this.chkUpperCase.AutoSize = true;
            this.chkUpperCase.Location = new System.Drawing.Point(7, 20);
            this.chkUpperCase.Name = "chkUpperCase";
            this.chkUpperCase.Size = new System.Drawing.Size(138, 17);
            this.chkUpperCase.TabIndex = 0;
            this.chkUpperCase.Text = "Upper-case (A, B, C, ...)";
            this.chkUpperCase.UseVisualStyleBackColor = true;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(152, 181);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(166, 20);
            this.txtOutput.TabIndex = 6;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(180, 207);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(108, 23);
            this.btnCopy.TabIndex = 7;
            this.btnCopy.Text = "Copy to clipboard";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 232);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnGeneratePassword);
            this.Controls.Add(this.grpPasswordOptions);
            this.Controls.Add(this.txtOutput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(481, 271);
            this.MinimumSize = new System.Drawing.Size(481, 271);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generator";
            this.grpPasswordOptions.ResumeLayout(false);
            this.grpPasswordOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGeneratePassword;
        private System.Windows.Forms.GroupBox grpPasswordOptions;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.CheckBox chkSpecial;
        private System.Windows.Forms.CheckBox chkDigits;
        private System.Windows.Forms.CheckBox chkLowerCase;
        private System.Windows.Forms.CheckBox chkUpperCase;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnCopy;
    }
}

