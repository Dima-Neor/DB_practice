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
    public partial class addProduct : Form
    {
        public addProduct()
        {
            InitializeComponent();
        }
        OleDbConnection connect;
        Product product;
        private void showCB ()
        {
            OleDbCommand comCB;
            comCB = new OleDbCommand();
            comCB.CommandText = "SELECT * FROM Изготовитель";
            comCB.Connection = connect;
            OleDbDataReader reader = comCB.ExecuteReader();
            maker_cb.Items.Clear();
            while (reader.Read())
            {
                maker_cb.Items.Add(reader.GetValue(1));
                makerId_cb.Items.Add(reader.GetValue(0));
            }
            reader.Close();
        }
        private void addProduct_Load(object sender, EventArgs e)
        {
            connect = new OleDbConnection("Provider=SQLOLEDB;Data Source=.\\sqlexpress;Initial Catalog=shop;Integrated Security=SSPI");
            connect.Open();
            showCB();
        }

        private void ok_bt_Click(object sender, EventArgs e)
        {
            int id = maker_cb.SelectedIndex;
            makerId_cb.SelectedIndex = id;
            int idm = Convert.ToInt32(makerId_cb.Text);
            product = new Product(name_tb.Text, new Maker(idm), category_tb.Text, Convert.ToDouble(cost_tb.Text), Convert.ToDouble(cost2_tb.Text));
            product.setConnect(connect.ConnectionString);
            product.insertTable();
            this.Close();
        }
    }
}
