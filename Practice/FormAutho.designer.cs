
namespace Practice
{
    partial class FormAutho
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAutho = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(63, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "password";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(273, 123);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(337, 39);
            this.txtPassword.TabIndex = 6;
            //this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(63, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "login";
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtLogin.Location = new System.Drawing.Point(273, 58);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(337, 39);
            this.txtLogin.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(273, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(338, 60);
            this.label5.TabIndex = 8;
            this.label5.Text = "от 3-х до 6-ти символов ENG или RUS (больших или маленьких) и цифр";
            // 
            // btnAutho
            // 
            this.btnAutho.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnAutho.Location = new System.Drawing.Point(70, 298);
            this.btnAutho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAutho.Name = "btnAutho";
            this.btnAutho.Size = new System.Drawing.Size(263, 113);
            this.btnAutho.TabIndex = 9;
            this.btnAutho.Text = "АВТОРИЗОВАТЬСЯ";
            this.btnAutho.UseVisualStyleBackColor = true;
            this.btnAutho.Click += new System.EventHandler(this.btnAutho_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCancel.Location = new System.Drawing.Point(360, 298);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(253, 113);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "ОТМЕНА";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormAutho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 481);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAutho);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLogin);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormAutho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAutho;
        private System.Windows.Forms.Button btnCancel;
    }
}