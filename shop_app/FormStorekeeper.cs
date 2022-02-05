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
    public partial class FormStorekeeper : Form
    {
        private string userName;
        private Receipt receipt = new Receipt();
        private bool chose = true;

        OleDbConnection connect;
        public FormStorekeeper(string name)
        {
            InitializeComponent();
            userName = name;
        }
        

        private void производительToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addMaker a = new addMaker();
            a.ShowDialog();
        }
        private void товарToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addProduct a = new addProduct();
            a.ShowDialog();
        }

        private void showStor()
        {
            chose = false;

            OleDbCommand com = new OleDbCommand();
            com.CommandText = "SELECT Товар.Название, Товар.Категория, Изготовитель.Название AS Изготовитель, Изготовитель.Страна , Товар.Цена_закупки, Товар.Цена_продажи, Склад.Количество FROM Склад, Товар, Изготовитель WHERE Склад.Id_товар = Товар.Id_товар AND Товар.Id_изготовитель =  Изготовитель.Id_изготовитель";
            com.Connection = connect;
            com.ExecuteNonQuery();
            OleDbDataAdapter DA = new OleDbDataAdapter(com);
            DataTable DT = new DataTable();
            DA.Fill(DT);

            dataGridView1.ClearSelection();
            dataGridView1.DataSource = DT;
        }
        private void showReceipt()
        {
            OleDbCommand com = new OleDbCommand();
            com.CommandText = "SELECT Товар.Название, Товар.Категория, Документ.Дата, Документ.Количество, Поступление_товара.Сумма, Поступление_товара.Кладовщик, Товар.Id_товар, Документ.Id_документ FROM Товар, Документ, Поступление_товара WHERE Документ.Id_товар = Товар.Id_товар AND Поступление_товара.Id_документ = Документ.Id_документ";
            com.Connection = connect;
            com.ExecuteNonQuery();
            OleDbDataAdapter DA = new OleDbDataAdapter(com);
            DataTable DT = new DataTable();
            DA.Fill(DT);

            dataGridView1.ClearSelection();
            dataGridView1.DataSource = DT;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;

            chose = true;
        }
        void showCB()
        {
            OleDbCommand com = new OleDbCommand();
            com.CommandText = "SELECT ID_товар, Название  FROM Товар";
            com.Connection = connect;
            OleDbDataReader reader = com.ExecuteReader();
            product_cb.Items.Clear();
            productId_cb.Items.Clear();
            while (reader.Read())
            {
                product_cb.Items.Add(reader.GetValue(1));
                productId_cb.Items.Add(reader.GetValue(0));
            }
            reader.Close();
        }
        private void FormStorekeeper_Load(object sender, EventArgs e)
        {
            connect = new OleDbConnection("Provider=SQLOLEDB;Data Source=.\\sqlexpress;Initial Catalog=shop;Integrated Security=SSPI");
            connect.Open();
            showCB();
            showReceipt();
            receipt.setConnect("Provider=SQLOLEDB;Data Source=.\\sqlexpress;Initial Catalog=shop;Integrated Security=SSPI");
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            
            if (dataGridView1.CurrentRow != null && chose)
            {
                
                receipt.set(Convert.ToInt32(dataGridView1[7, i].Value), userName, Convert.ToDateTime(dataGridView1[2, i].Value), Convert.ToInt32(dataGridView1[6, i].Value), Convert.ToInt32(dataGridView1[3, i].Value));
                count_tb.Text = receipt.getCount().ToString();
                date_dtp.Value = receipt.GetDate();
                string id = receipt.getIdProduct().ToString();
                int j = 0;
                for (bool b = true; j <= productId_cb.Items.Count && b; j++)
                {
                    if (productId_cb.Items[j].ToString() == id)
                    {
                        b = false;
                    }
                }
                product_cb.SelectedIndex = j - 1;
            }
        }

        private void поступлениеТовараToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showReceipt();
            
            product_cb.Visible = true;
            product_lb.Visible = true;

            count_tb.Visible = true;
            count_lb.Visible = true;

            date_dtp.Visible = true;
            date_lb.Visible = true;
        }

        private void складToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showStor();
            product_cb.Visible = false;
            product_lb.Visible = false;

            count_tb.Visible = false;
            count_lb.Visible = false;

            date_dtp.Visible = false;
            date_lb.Visible = false;
        }

        private void add_bt_Click(object sender, EventArgs e)
        {
            productId_cb.SelectedIndex = product_cb.SelectedIndex;
            int idp = Convert.ToInt32(productId_cb.Text);

            receipt.set(0, userName, date_dtp.Value, idp, Convert.ToInt32(count_tb.Text));
            receipt.insertTable();

            showReceipt();
        }

        private void update_bt_Click(object sender, EventArgs e)
        {
            productId_cb.SelectedIndex = product_cb.SelectedIndex;
            int idp = Convert.ToInt32(productId_cb.Text);
            int i = dataGridView1.CurrentRow.Index;

            receipt.set(Convert.ToInt32(dataGridView1[7, i].Value), userName, date_dtp.Value, idp, Convert.ToInt32(count_tb.Text));
            receipt.updateTable();

            showReceipt();
        }
    }
}
