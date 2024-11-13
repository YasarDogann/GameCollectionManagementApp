namespace GameCollectionManagement
{
    partial class GameList
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
            panel1 = new Panel();
            label1 = new Label();
            btnSearch = new Button();
            cbGenre = new ComboBox();
            cbPlatform = new ComboBox();
            txtSearch = new TextBox();
            btnAdd = new Button();
            btnGameDelete = new Button();
            btnGameList = new Button();
            btnEditGame = new Button();
            panel2 = new Panel();
            dgvGames = new DataGridView();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGames).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(cbGenre);
            panel1.Controls.Add(cbPlatform);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnGameDelete);
            panel1.Controls.Add(btnGameList);
            panel1.Controls.Add(btnEditGame);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1131, 245);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(429, 77);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 8;
            label1.Text = "Platform : ";
            label1.Click += label1_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(244, 28);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Ara";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // cbGenre
            // 
            cbGenre.FormattingEnabled = true;
            cbGenre.Location = new Point(807, 74);
            cbGenre.Name = "cbGenre";
            cbGenre.Size = new Size(151, 28);
            cbGenre.TabIndex = 6;
            // 
            // cbPlatform
            // 
            cbPlatform.FormattingEnabled = true;
            cbPlatform.Items.AddRange(new object[] { "PC", "Xbox", "Play Station", "Nintendo" });
            cbPlatform.Location = new Point(521, 74);
            cbPlatform.Name = "cbPlatform";
            cbPlatform.Size = new Size(151, 28);
            cbPlatform.TabIndex = 5;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(378, 30);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(580, 27);
            txtSearch.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(438, 200);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnGameDelete
            // 
            btnGameDelete.BackColor = Color.FromArgb(192, 0, 0);
            btnGameDelete.ForeColor = SystemColors.ButtonHighlight;
            btnGameDelete.Location = new Point(667, 200);
            btnGameDelete.Name = "btnGameDelete";
            btnGameDelete.Size = new Size(94, 29);
            btnGameDelete.TabIndex = 2;
            btnGameDelete.Text = "Sil";
            btnGameDelete.UseVisualStyleBackColor = false;
            btnGameDelete.Click += btnGameDelete_Click;
            // 
            // btnGameList
            // 
            btnGameList.Location = new Point(538, 200);
            btnGameList.Name = "btnGameList";
            btnGameList.Size = new Size(123, 28);
            btnGameList.TabIndex = 1;
            btnGameList.Text = "Oyunları Lİstele";
            btnGameList.UseVisualStyleBackColor = true;
            btnGameList.Click += btnGameList_Click;
            // 
            // btnEditGame
            // 
            btnEditGame.Location = new Point(767, 200);
            btnEditGame.Name = "btnEditGame";
            btnEditGame.Size = new Size(191, 29);
            btnEditGame.TabIndex = 0;
            btnEditGame.Text = "Oyun Güncelle";
            btnEditGame.UseVisualStyleBackColor = true;
            btnEditGame.Click += btnEditGame_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvGames);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 245);
            panel2.Name = "panel2";
            panel2.Size = new Size(1131, 437);
            panel2.TabIndex = 2;
            // 
            // dgvGames
            // 
            dgvGames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGames.Dock = DockStyle.Fill;
            dgvGames.Location = new Point(0, 0);
            dgvGames.Name = "dgvGames";
            dgvGames.RowHeadersWidth = 51;
            dgvGames.Size = new Size(1131, 437);
            dgvGames.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(720, 77);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 9;
            label2.Text = "Tür : ";
            // 
            // GameList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "GameList";
            Size = new Size(1131, 682);
            Load += GameList_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGames).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button btnEditGame;
        private Panel panel2;
        private DataGridView dgvGames;
        private Button btnGameList;
        private Button btnGameDelete;
        private Button btnAdd;
        private Button btnSearch;
        private ComboBox cbGenre;
        private ComboBox cbPlatform;
        private TextBox txtSearch;
        private Label label1;
        private Label label2;
    }
}
