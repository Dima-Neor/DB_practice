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
    public partial class FormSeller : Form
    {
        public FormSeller()
        {
            InitializeComponent();
        }
        OleDbConnection connect;

        private void showStor()
        {
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
        private void showSell()
        {

        }
        private void FormSeller_Load(object sender, EventArgs e)
        {
            connect = new OleDbConnection("Provider=SQLOLEDB;Data Source=.\\sqlexpress;Initial Catalog=shop;Integrated Security=SSPI");
            connect.Open();
            showStor();
        }
    }
}
