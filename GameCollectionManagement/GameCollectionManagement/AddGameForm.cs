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
    public partial class AddGameForm : Form
    {
        private GameList _gameList;
        public AddGameForm(GameList gameList)
        {
            InitializeComponent();
            _gameList = gameList;
        }

        private void AddGameForm_Load(object sender, EventArgs e)
        {
            AddGame addGame = new AddGame(_gameList);
            panelContainer.Controls.Add(addGame);
        }
    }
}
