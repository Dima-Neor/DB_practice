using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace shop_app
{
    public partial class addMaker : Form
    {
        public addMaker()
        {
            InitializeComponent();
        }
        private void ok_bt_Click(object sender, EventArgs e)
        {
            Maker maker = new Maker(0, name_tb.Text, country_tb.Text);
            maker.setConnect("Provider=SQLOLEDB;Data Source=.\\sqlexpress;Initial Catalog=shop;Integrated Security=SSPI");
            maker.insertTable();
            MessageBox.Show("Запись добавлена", "Успех");
            this.Close();
        }
    }
}
