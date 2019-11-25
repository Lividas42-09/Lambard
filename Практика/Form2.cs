using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ConnectionButton_Click(object sender, EventArgs e)
        {
            string datasource = ServerNameBox.Text;
            string database = DbNameBox.Text;
            string username = UserNameBox.Text ?? "";
            string userpass = UserPasswordBox.Text ?? "";

            if (string.IsNullOrEmpty(datasource) || string.IsNullOrEmpty(database))
            {
                MessageBox.Show("Ошибка подключения! Некоторые поля были введены неверно.","Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }

        private void ServerNameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
