namespace BMIApp
{
    partial class DataInputForm
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
            this.txtDataName = new System.Windows.Forms.TextBox();
            this.txtDataWeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDataHeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radbtnMale = new System.Windows.Forms.RadioButton();
            this.radbtnFemale = new System.Windows.Forms.RadioButton();
            this.btnContinue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txtDataName
            // 
            this.txtDataName.Location = new System.Drawing.Point(43, 48);
            this.txtDataName.Name = "txtDataName";
            this.txtDataName.Size = new System.Drawing.Size(100, 26);
            this.txtDataName.TabIndex = 1;
            // 
            // txtDataWeight
            // 
            this.txtDataWeight.Location = new System.Drawing.Point(43, 117);
            this.txtDataWeight.Name = "txtDataWeight";
            this.txtDataWeight.Size = new System.Drawing.Size(100, 26);
            this.txtDataWeight.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Weight (Kg)";
            // 
            // txtDataHeight
            // 
            this.txtDataHeight.Location = new System.Drawing.Point(43, 186);
            this.txtDataHeight.Name = "txtDataHeight";
            this.txtDataHeight.Size = new System.Drawing.Size(100, 26);
            this.txtDataHeight.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Height (cm)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gender";
            // 
            // radbtnMale
            // 
            this.radbtnMale.AutoSize = true;
            this.radbtnMale.Location = new System.Drawing.Point(43, 268);
            this.radbtnMale.Name = "radbtnMale";
            this.radbtnMale.Size = new System.Drawing.Size(68, 24);
            this.radbtnMale.TabIndex = 7;
            this.radbtnMale.TabStop = true;
            this.radbtnMale.Text = "Male";
            this.radbtnMale.UseVisualStyleBackColor = true;
            // 
            // radbtnFemale
            // 
            this.radbtnFemale.AutoSize = true;
            this.radbtnFemale.Location = new System.Drawing.Point(43, 298);
            this.radbtnFemale.Name = "radbtnFemale";
            this.radbtnFemale.Size = new System.Drawing.Size(87, 24);
            this.radbtnFemale.TabIndex = 8;
            this.radbtnFemale.TabStop = true;
            this.radbtnFemale.Text = "Female";
            this.radbtnFemale.UseVisualStyleBackColor = true;
            this.radbtnFemale.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(35, 342);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(95, 33);
            this.btnContinue.TabIndex = 9;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            // 
            // DataInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.radbtnFemale);
            this.Controls.Add(this.radbtnMale);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDataHeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDataWeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDataName);
            this.Controls.Add(this.label1);
            this.Name = "DataInputForm";
            this.Text = "Data Input";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDataName;
        private System.Windows.Forms.TextBox txtDataWeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDataHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radbtnMale;
        private System.Windows.Forms.RadioButton radbtnFemale;
        private System.Windows.Forms.Button btnContinue;
    }
}