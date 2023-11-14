namespace BMIApp
{
    partial class RegisterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameRegister = new System.Windows.Forms.TextBox();
            this.txtUsernameRegis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPasswordRegis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegisterRegis = new System.Windows.Forms.Button();
            this.btnCancelRegis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txtNameRegister
            // 
            this.txtNameRegister.Location = new System.Drawing.Point(37, 66);
            this.txtNameRegister.Name = "txtNameRegister";
            this.txtNameRegister.Size = new System.Drawing.Size(100, 26);
            this.txtNameRegister.TabIndex = 1;
            // 
            // txtUsernameRegis
            // 
            this.txtUsernameRegis.Location = new System.Drawing.Point(37, 129);
            this.txtUsernameRegis.Name = "txtUsernameRegis";
            this.txtUsernameRegis.Size = new System.Drawing.Size(100, 26);
            this.txtUsernameRegis.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // txtPasswordRegis
            // 
            this.txtPasswordRegis.Location = new System.Drawing.Point(37, 187);
            this.txtPasswordRegis.Name = "txtPasswordRegis";
            this.txtPasswordRegis.Size = new System.Drawing.Size(100, 26);
            this.txtPasswordRegis.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // btnRegisterRegis
            // 
            this.btnRegisterRegis.Location = new System.Drawing.Point(37, 238);
            this.btnRegisterRegis.Name = "btnRegisterRegis";
            this.btnRegisterRegis.Size = new System.Drawing.Size(90, 42);
            this.btnRegisterRegis.TabIndex = 6;
            this.btnRegisterRegis.Text = "Register";
            this.btnRegisterRegis.UseVisualStyleBackColor = true;
            this.btnRegisterRegis.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelRegis
            // 
            this.btnCancelRegis.Location = new System.Drawing.Point(146, 238);
            this.btnCancelRegis.Name = "btnCancelRegis";
            this.btnCancelRegis.Size = new System.Drawing.Size(90, 42);
            this.btnCancelRegis.TabIndex = 7;
            this.btnCancelRegis.Text = "Cancel";
            this.btnCancelRegis.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelRegis);
            this.Controls.Add(this.btnRegisterRegis);
            this.Controls.Add(this.txtPasswordRegis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsernameRegis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNameRegister);
            this.Controls.Add(this.label1);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameRegister;
        private System.Windows.Forms.TextBox txtUsernameRegis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPasswordRegis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegisterRegis;
        private System.Windows.Forms.Button btnCancelRegis;
    }
}