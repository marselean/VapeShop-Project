namespace MiniCashier
{
    partial class Login
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
            this.user = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.SignIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user
            // 
            this.user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.user.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.user.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.user.HideSelection = false;
            this.user.Location = new System.Drawing.Point(372, 325);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(208, 16);
            this.user.TabIndex = 1;
            this.user.Text = "username";
            this.user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pass
            // 
            this.pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.pass.HideSelection = false;
            this.pass.Location = new System.Drawing.Point(372, 369);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(208, 16);
            this.pass.TabIndex = 2;
            this.pass.Text = "password";
            this.pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SignIn
            // 
            this.SignIn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.SignIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SignIn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.SignIn.Location = new System.Drawing.Point(417, 415);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(121, 35);
            this.SignIn.TabIndex = 3;
            this.SignIn.Text = "Sign In";
            this.SignIn.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::MiniCashier.Properties.Resources.output_onlinepngtools__2_;
            this.ClientSize = new System.Drawing.Size(952, 483);
            this.Controls.Add(this.SignIn);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.user);
            this.Name = "Login";
            this.Text = "Login Interface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Button SignIn;
    }
}

