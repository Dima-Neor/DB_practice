using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace shop_app
{
    public partial class Login : Form
    {
        private User user1 = new User();
        OleDbConnection connect;
        OleDbCommand com;
        public Login()
        {
            InitializeComponent();
        }
        private void enter_bt_Click(object sender, EventArgs e)
        {
            connect = new OleDbConnection("Provider=SQLOLEDB;Data Source=.\\sqlexpress;Initial Catalog=shop;Integrated Security=SSPI");
            connect.Open();
            com = new OleDbCommand();
            com.CommandText = "SELECT * FROM Сотрудник WHERE Логин =?";
            com.Parameters.Clear();
            com.Parameters.AddWithValue("@login", login_tb.Text);
            com.Connection = connect;
            OleDbDataReader reader = com.ExecuteReader();
            reader.Read();
            user1.fromTable(ref reader);
            if (user1.getPass() == pass_tb.Text)
            {
                pass_tb.Text = "";

                switch (user1.getIdRole())
                {
                    case 1:
                        FormAdmin a = new FormAdmin();
                        a.ShowDialog();
                        //a.FormClosed += Form_Closed;
                        break;
                    case 2:
                        FormStorekeeper sk = new FormStorekeeper(user1.getName());
                        sk.ShowDialog();
                        break;
                    case 3:
                        FormSeller s = new FormSeller();
                        s.ShowDialog();
                        break;
                }

            }
        }
    }
}
