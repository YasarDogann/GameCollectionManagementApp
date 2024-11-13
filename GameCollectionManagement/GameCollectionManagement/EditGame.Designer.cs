namespace GameCollectionManagement
{
    partial class EditGame
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
            btnOpenFileDialog = new Button();
            txtGameCoverImage = new TextBox();
            numericGamePlayTime = new NumericUpDown();
            dtpGameReleaseDate = new DateTimePicker();
            cbGamePlatform = new ComboBox();
            txtGameGenre = new TextBox();
            txtGameName = new TextBox();
            ofdCoverImage = new OpenFileDialog();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnEdit = new Button();
            ofdCoverImage2 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)numericGamePlayTime).BeginInit();
            SuspendLayout();
            // 
            // btnOpenFileDialog
            // 
            btnOpenFileDialog.Location = new Point(568, 277);
            btnOpenFileDialog.Name = "btnOpenFileDialog";
            btnOpenFileDialog.Size = new Size(52, 29);
            btnOpenFileDialog.TabIndex = 21;
            btnOpenFileDialog.Text = "...";
            btnOpenFileDialog.UseVisualStyleBackColor = true;
            btnOpenFileDialog.Click += btnOpenFileDialog_Click;
            // 
            // txtGameCoverImage
            // 
            txtGameCoverImage.Location = new Point(203, 279);
            txtGameCoverImage.Name = "txtGameCoverImage";
            txtGameCoverImage.Size = new Size(359, 27);
            txtGameCoverImage.TabIndex = 20;
            txtGameCoverImage.Text = " ";
            // 
            // numericGamePlayTime
            // 
            numericGamePlayTime.Location = new Point(203, 233);
            numericGamePlayTime.Name = "numericGamePlayTime";
            numericGamePlayTime.Size = new Size(417, 27);
            numericGamePlayTime.TabIndex = 19;
            // 
            // dtpGameReleaseDate
            // 
            dtpGameReleaseDate.Location = new Point(203, 184);
            dtpGameReleaseDate.Name = "dtpGameReleaseDate";
            dtpGameReleaseDate.Size = new Size(417, 27);
            dtpGameReleaseDate.TabIndex = 18;
            // 
            // cbGamePlatform
            // 
            cbGamePlatform.FormattingEnabled = true;
            cbGamePlatform.Items.AddRange(new object[] { "PC", "XBox", "Playstation", "Nintendo" });
            cbGamePlatform.Location = new Point(203, 134);
            cbGamePlatform.Name = "cbGamePlatform";
            cbGamePlatform.Size = new Size(417, 28);
            cbGamePlatform.TabIndex = 17;
            // 
            // txtGameGenre
            // 
            txtGameGenre.Location = new Point(203, 87);
            txtGameGenre.Name = "txtGameGenre";
            txtGameGenre.Size = new Size(417, 27);
            txtGameGenre.TabIndex = 16;
            // 
            // txtGameName
            // 
            txtGameName.Location = new Point(203, 40);
            txtGameName.Name = "txtGameName";
            txtGameName.Size = new Size(417, 27);
            txtGameName.TabIndex = 15;
            // 
            // ofdCoverImage
            // 
            ofdCoverImage.FileName = "openFileDialog1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 286);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 27;
            label6.Text = "Kapak Resmi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 233);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 26;
            label5.Text = "Oynanış Süresi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 184);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 25;
            label4.Text = "Çıkış Tarihi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 134);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 24;
            label3.Text = "Oyun Platformu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 87);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 23;
            label2.Text = "Oyun Türü";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 40);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 22;
            label1.Text = "Oyun Adı";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(526, 330);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 28;
            btnEdit.Text = "Güncelle";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // ofdCoverImage2
            // 
            ofdCoverImage2.FileName = "openFileDialog1";
            // 
            // EditGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 400);
            Controls.Add(btnEdit);
            Controls.Add(btnOpenFileDialog);
            Controls.Add(txtGameCoverImage);
            Controls.Add(numericGamePlayTime);
            Controls.Add(dtpGameReleaseDate);
            Controls.Add(cbGamePlatform);
            Controls.Add(txtGameGenre);
            Controls.Add(txtGameName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditGame";
            Text = "Oyun Güncelle";
            ((System.ComponentModel.ISupportInitialize)numericGamePlayTime).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOpenFileDialog;
        private TextBox txtGameCoverImage;
        private NumericUpDown numericGamePlayTime;
        private DateTimePicker dtpGameReleaseDate;
        private ComboBox cbGamePlatform;
        private TextBox txtGameGenre;
        private TextBox txtGameName;
        private OpenFileDialog ofdCoverImage;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnEdit;
        private OpenFileDialog ofdCoverImage2;
    }
}