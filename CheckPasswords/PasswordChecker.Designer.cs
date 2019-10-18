namespace CheckPasswords
{
    partial class PasswordChecker
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
            this.btnHashwithMD5 = new System.Windows.Forms.Button();
            this.txtPasswordtoHash = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHashMD5SaltPepper = new System.Windows.Forms.Button();
            this.btnHashMD5Salt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHashedPassword = new System.Windows.Forms.TextBox();
            this.txtSalt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPepper = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCheckPassword = new System.Windows.Forms.TextBox();
            this.lblCheck = new System.Windows.Forms.Label();
            this.btnCheckwithSalt = new System.Windows.Forms.Button();
            this.btnCheckwithSaltPepper = new System.Windows.Forms.Button();
            this.btnCheckwithMD5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHashwithMD5
            // 
            this.btnHashwithMD5.Location = new System.Drawing.Point(168, 95);
            this.btnHashwithMD5.Name = "btnHashwithMD5";
            this.btnHashwithMD5.Size = new System.Drawing.Size(170, 23);
            this.btnHashwithMD5.TabIndex = 0;
            this.btnHashwithMD5.Text = "Hash with MD5";
            this.btnHashwithMD5.UseVisualStyleBackColor = true;
            this.btnHashwithMD5.Click += new System.EventHandler(this.BtnHashwithMD5_Click);
            // 
            // txtPasswordtoHash
            // 
            this.txtPasswordtoHash.Location = new System.Drawing.Point(168, 50);
            this.txtPasswordtoHash.Name = "txtPasswordtoHash";
            this.txtPasswordtoHash.Size = new System.Drawing.Size(514, 20);
            this.txtPasswordtoHash.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password or Text to Hash";
            // 
            // btnHashMD5SaltPepper
            // 
            this.btnHashMD5SaltPepper.Location = new System.Drawing.Point(512, 95);
            this.btnHashMD5SaltPepper.Name = "btnHashMD5SaltPepper";
            this.btnHashMD5SaltPepper.Size = new System.Drawing.Size(170, 23);
            this.btnHashMD5SaltPepper.TabIndex = 3;
            this.btnHashMD5SaltPepper.Text = "Hash with MD5 Salt and Pepper";
            this.btnHashMD5SaltPepper.UseVisualStyleBackColor = true;
            this.btnHashMD5SaltPepper.Click += new System.EventHandler(this.BtnHashMD5SaltPepper_Click);
            // 
            // btnHashMD5Salt
            // 
            this.btnHashMD5Salt.Location = new System.Drawing.Point(340, 95);
            this.btnHashMD5Salt.Name = "btnHashMD5Salt";
            this.btnHashMD5Salt.Size = new System.Drawing.Size(170, 23);
            this.btnHashMD5Salt.TabIndex = 4;
            this.btnHashMD5Salt.Text = "Hash with MD5 and Salt";
            this.btnHashMD5Salt.UseVisualStyleBackColor = true;
            this.btnHashMD5Salt.Click += new System.EventHandler(this.BtnHashMD5Salt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hashed Password";
            // 
            // txtHashedPassword
            // 
            this.txtHashedPassword.Enabled = false;
            this.txtHashedPassword.Location = new System.Drawing.Point(168, 157);
            this.txtHashedPassword.Name = "txtHashedPassword";
            this.txtHashedPassword.Size = new System.Drawing.Size(514, 20);
            this.txtHashedPassword.TabIndex = 6;
            // 
            // txtSalt
            // 
            this.txtSalt.Enabled = false;
            this.txtSalt.Location = new System.Drawing.Point(168, 183);
            this.txtSalt.Name = "txtSalt";
            this.txtSalt.Size = new System.Drawing.Size(514, 20);
            this.txtSalt.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Salt Random( to be stored in DB)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Pepper( not stored in DB-may be username)";
            // 
            // txtPepper
            // 
            this.txtPepper.Enabled = false;
            this.txtPepper.Location = new System.Drawing.Point(224, 207);
            this.txtPepper.Name = "txtPepper";
            this.txtPepper.Size = new System.Drawing.Size(458, 20);
            this.txtPepper.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Password to Compare";
            // 
            // txtCheckPassword
            // 
            this.txtCheckPassword.Location = new System.Drawing.Point(168, 266);
            this.txtCheckPassword.Name = "txtCheckPassword";
            this.txtCheckPassword.Size = new System.Drawing.Size(514, 20);
            this.txtCheckPassword.TabIndex = 12;
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.lblCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheck.Location = new System.Drawing.Point(165, 343);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(92, 31);
            this.lblCheck.TabIndex = 13;
            this.lblCheck.Text = "Check";
            this.lblCheck.Visible = false;
            // 
            // btnCheckwithSalt
            // 
            this.btnCheckwithSalt.Location = new System.Drawing.Point(340, 296);
            this.btnCheckwithSalt.Name = "btnCheckwithSalt";
            this.btnCheckwithSalt.Size = new System.Drawing.Size(170, 23);
            this.btnCheckwithSalt.TabIndex = 16;
            this.btnCheckwithSalt.Text = "Check with MD5 and Salt";
            this.btnCheckwithSalt.UseVisualStyleBackColor = true;
            this.btnCheckwithSalt.Click += new System.EventHandler(this.BtnCheckwithSalt_Click);
            // 
            // btnCheckwithSaltPepper
            // 
            this.btnCheckwithSaltPepper.Location = new System.Drawing.Point(512, 296);
            this.btnCheckwithSaltPepper.Name = "btnCheckwithSaltPepper";
            this.btnCheckwithSaltPepper.Size = new System.Drawing.Size(170, 23);
            this.btnCheckwithSaltPepper.TabIndex = 15;
            this.btnCheckwithSaltPepper.Text = "Check with MD5 Salt and Pepper";
            this.btnCheckwithSaltPepper.UseVisualStyleBackColor = true;
            this.btnCheckwithSaltPepper.Click += new System.EventHandler(this.BtnCheckwithSaltPepper_Click);
            // 
            // btnCheckwithMD5
            // 
            this.btnCheckwithMD5.Location = new System.Drawing.Point(168, 296);
            this.btnCheckwithMD5.Name = "btnCheckwithMD5";
            this.btnCheckwithMD5.Size = new System.Drawing.Size(170, 23);
            this.btnCheckwithMD5.TabIndex = 14;
            this.btnCheckwithMD5.Text = "Check with MD5";
            this.btnCheckwithMD5.UseVisualStyleBackColor = true;
            this.btnCheckwithMD5.Click += new System.EventHandler(this.BtnCheckwithMD5_Click);
            // 
            // PasswordChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 433);
            this.Controls.Add(this.btnCheckwithSalt);
            this.Controls.Add(this.btnCheckwithSaltPepper);
            this.Controls.Add(this.btnCheckwithMD5);
            this.Controls.Add(this.lblCheck);
            this.Controls.Add(this.txtCheckPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPepper);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSalt);
            this.Controls.Add(this.txtHashedPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHashMD5Salt);
            this.Controls.Add(this.btnHashMD5SaltPepper);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPasswordtoHash);
            this.Controls.Add(this.btnHashwithMD5);
            this.Name = "PasswordChecker";
            this.Text = "PasswordChecker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHashwithMD5;
        private System.Windows.Forms.TextBox txtPasswordtoHash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHashMD5SaltPepper;
        private System.Windows.Forms.Button btnHashMD5Salt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHashedPassword;
        private System.Windows.Forms.TextBox txtSalt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPepper;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCheckPassword;
        private System.Windows.Forms.Label lblCheck;
        private System.Windows.Forms.Button btnCheckwithSalt;
        private System.Windows.Forms.Button btnCheckwithSaltPepper;
        private System.Windows.Forms.Button btnCheckwithMD5;
    }
}

