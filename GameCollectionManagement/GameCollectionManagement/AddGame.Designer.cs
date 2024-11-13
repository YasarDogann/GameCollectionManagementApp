namespace GameCollectionManagement
{
    partial class AddGame
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            txtGameName = new TextBox();
            txtGameGenre = new TextBox();
            cbGamePlatform = new ComboBox();
            dtpGameReleaseDate = new DateTimePicker();
            numericGamePlayTime = new NumericUpDown();
            txtGameCoverImage = new TextBox();
            btnOpenFileDialog = new Button();
            ofdCoverImage = new OpenFileDialog();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnGameSave = new Button();
            ((System.ComponentModel.ISupportInitialize)numericGamePlayTime).BeginInit();
            SuspendLayout();
            // 
            // txtGameName
            // 
            txtGameName.Location = new Point(186, 27);
            txtGameName.Name = "txtGameName";
            txtGameName.Size = new Size(417, 27);
            txtGameName.TabIndex = 0;
            // 
            // txtGameGenre
            // 
            txtGameGenre.Location = new Point(186, 74);
            txtGameGenre.Name = "txtGameGenre";
            txtGameGenre.Size = new Size(417, 27);
            txtGameGenre.TabIndex = 1;
            // 
            // cbGamePlatform
            // 
            cbGamePlatform.FormattingEnabled = true;
            cbGamePlatform.Items.AddRange(new object[] { "PC", "XBox", "Playstation", "Nintendo" });
            cbGamePlatform.Location = new Point(186, 121);
            cbGamePlatform.Name = "cbGamePlatform";
            cbGamePlatform.Size = new Size(417, 28);
            cbGamePlatform.TabIndex = 3;
            // 
            // dtpGameReleaseDate
            // 
            dtpGameReleaseDate.Location = new Point(186, 171);
            dtpGameReleaseDate.Name = "dtpGameReleaseDate";
            dtpGameReleaseDate.Size = new Size(417, 27);
            dtpGameReleaseDate.TabIndex = 4;
            // 
            // numericGamePlayTime
            // 
            numericGamePlayTime.Location = new Point(186, 220);
            numericGamePlayTime.Name = "numericGamePlayTime";
            numericGamePlayTime.Size = new Size(417, 27);
            numericGamePlayTime.TabIndex = 5;
            // 
            // txtGameCoverImage
            // 
            txtGameCoverImage.Location = new Point(186, 266);
            txtGameCoverImage.Name = "txtGameCoverImage";
            txtGameCoverImage.Size = new Size(359, 27);
            txtGameCoverImage.TabIndex = 6;
            txtGameCoverImage.Text = " ";
            // 
            // btnOpenFileDialog
            // 
            btnOpenFileDialog.Location = new Point(551, 264);
            btnOpenFileDialog.Name = "btnOpenFileDialog";
            btnOpenFileDialog.Size = new Size(52, 29);
            btnOpenFileDialog.TabIndex = 7;
            btnOpenFileDialog.Text = "...";
            btnOpenFileDialog.UseVisualStyleBackColor = true;
            btnOpenFileDialog.Click += btnOpenFileDialog_Click;
            // 
            // ofdCoverImage
            // 
            ofdCoverImage.FileName = "openFileDialog1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 27);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 8;
            label1.Text = "Oyun Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 74);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 9;
            label2.Text = "Oyun Türü";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 121);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 10;
            label3.Text = "Oyun Platformu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 171);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 11;
            label4.Text = "Çıkış Tarihi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 220);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 12;
            label5.Text = "Oynanış Süresi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 273);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 13;
            label6.Text = "Kapak Resmi";
            // 
            // btnGameSave
            // 
            btnGameSave.Location = new Point(509, 310);
            btnGameSave.Name = "btnGameSave";
            btnGameSave.Size = new Size(94, 29);
            btnGameSave.TabIndex = 14;
            btnGameSave.Text = "Oyun Ekle";
            btnGameSave.UseVisualStyleBackColor = true;
            btnGameSave.Click += btnGameSave_Click;
            // 
            // AddGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnGameSave);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnOpenFileDialog);
            Controls.Add(txtGameCoverImage);
            Controls.Add(numericGamePlayTime);
            Controls.Add(dtpGameReleaseDate);
            Controls.Add(cbGamePlatform);
            Controls.Add(txtGameGenre);
            Controls.Add(txtGameName);
            Name = "AddGame";
            Size = new Size(634, 366);
            ((System.ComponentModel.ISupportInitialize)numericGamePlayTime).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtGameName;
        private TextBox txtGameGenre;
        private ComboBox cbGamePlatform;
        private DateTimePicker dtpGameReleaseDate;
        private NumericUpDown numericGamePlayTime;
        private TextBox txtGameCoverImage;
        private Button btnOpenFileDialog;
        private OpenFileDialog ofdCoverImage;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnGameSave;
    }
}
