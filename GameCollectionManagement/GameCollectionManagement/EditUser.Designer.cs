namespace GameCollectionManagement
{
    partial class EditUser
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
            btnSave = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtRole = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtUserName = new TextBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(400, 271);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 17;
            btnSave.Text = "Güncelle";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 218);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 16;
            label4.Text = "Rol :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 165);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 15;
            label3.Text = "Şifre : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 110);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 14;
            label2.Text = "E-Posta :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 58);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 13;
            label1.Text = "Kullanıcı Adı :";
            // 
            // txtRole
            // 
            txtRole.Location = new Point(219, 211);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(275, 27);
            txtRole.TabIndex = 12;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(219, 158);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(275, 27);
            txtPassword.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(219, 103);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(275, 27);
            txtEmail.TabIndex = 10;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(219, 58);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(275, 27);
            txtUserName.TabIndex = 9;
            // 
            // EditUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 341);
            Controls.Add(btnSave);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtRole);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtUserName);
            Name = "EditUser";
            Text = "EditUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtRole;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtUserName;
    }
}