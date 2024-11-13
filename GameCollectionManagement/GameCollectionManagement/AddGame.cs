using GameCollectionManagement.Models;
using GameCollectionManagement.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCollectionManagement
{
    public partial class AddGame : UserControl
    {
        private readonly IGameService _gameService;

        private GameList _games;
        public AddGame()
        {
            _gameService = new GameService();
            InitializeComponent();
        }

        public AddGame(GameList gameList)
        {
            _gameService = new GameService();
            InitializeComponent();
            _games = gameList; 
        }
        private void btnGameSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                Game game = new Game();

                game.Name = txtGameName.Text.Trim();
                game.Genre = txtGameGenre.Text.Trim();
                game.Platform = cbGamePlatform.SelectedItem?.ToString();
                game.ReleaseDate = dtpGameReleaseDate.Value;
                game.PlayTime = (int)numericGamePlayTime.Value;
                game.CoverImage = _selectedCoverImage;

                try
                {
                    _gameService.Add(game);
                    _selectedCoverImage = null;
                    MessageBox.Show($"{game.Name} adlı oyun eklendi ");
                    if(_games is not null)
                    {
                        _games.LoadGames();
                        _games.LoadGenres();
                        ((Form)Parent.Parent).Close();
                    }

                    ClearForm();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }          
        }

        private void ClearForm()
        {
            txtGameName.Clear();
            txtGameGenre.Clear();
            cbGamePlatform.SelectedItem = null;
            dtpGameReleaseDate.Value = DateTime.Now;
            numericGamePlayTime.Value = 0;
        }



        private bool ValidateInput()
        {
            if(string.IsNullOrWhiteSpace(txtGameName.Text))
            {
                MessageBox.Show("Oyun adı giriniz","Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;   
            }

            if (string.IsNullOrWhiteSpace(txtGameGenre.Text))
            {
                MessageBox.Show("Tür adı giriniz", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cbGamePlatform.SelectedItem is null)
            {
                MessageBox.Show("Platform Seçin", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private byte[] _selectedCoverImage = null;

        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            if (ofdCoverImage.ShowDialog() == DialogResult.OK)
            {
                string imagePath = ofdCoverImage.FileName;
                _selectedCoverImage = File.ReadAllBytes(imagePath);
            }
        }
    }
}
