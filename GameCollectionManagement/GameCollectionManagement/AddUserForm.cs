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
    public partial class AddUserForm : Form
    {
        private UserList _userList = null;

        public AddUserForm(UserList userList)
        {
            InitializeComponent();
            _userList = userList;
        }

        public AddUserForm()
        {
            InitializeComponent();

        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            AddUser addUser = null;
            if (_userList is not null) 
                addUser= new AddUser(_userList);
            else
                addUser = new AddUser(fromLoginPage:true);

            panelContainer.Controls.Add(addUser);
        }
    }
}
