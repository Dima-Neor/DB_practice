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
    public partial class FormAdmin : Form
    {
        OleDbConnection connect;
        OleDbCommand com;
        DataTable DT;
        OleDbDataAdapter DA;

        User user = new User();
        public FormAdmin()
        {
            InitializeComponent();
        }
        private void showCB()
        {
            OleDbCommand comCB;
            comCB = new OleDbCommand();
            comCB.CommandText = "SELECT * FROM Должность";
            comCB.Connection = connect;
            OleDbDataReader reader = comCB.ExecuteReader();
            role_cb.Items.Clear();
            while (reader.Read())
            {
                role_cb.Items.Add(reader.GetValue(1));
                roleId_cb.Items.Add(reader.GetValue(0));
            }
            reader.Close();
        }
        private void show ()
        {
            com = new OleDbCommand();
            //com.CommandText = "SELECT * FROM Сотрудник";
            com.CommandText = "SELECT Сотрудник.ФИО, Сотрудник.Логин, Сотрудник.Пароль, Должность.Наименование, Должность.ID_должность FROM Сотрудник, Должность " +
                    "WHERE Сотрудник.ID_должность = Должность.ID_должность";
            com.Connection = connect;
            com.ExecuteNonQuery();
            DA = new OleDbDataAdapter(com);
            DT = new DataTable();
            DA.Fill(DT);
            dataGridView1.DataSource = DT;

        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;

            if(dataGridView1.CurrentRow != null)
            {
                user.set(dataGridView1[0, i].Value.ToString(), dataGridView1[1, i].Value.ToString(), dataGridView1[2, i].Value.ToString(), Convert.ToInt32(dataGridView1[4, i].Value), dataGridView1[2, i].Value.ToString());
                name_tb.Text = user.getName();
                login_tb.Text = user.getLogin();
                pass_tb.Text = user.getPass();

                string id = user.getIdRole().ToString();
                int j = 0;
                for (bool b = true; j <= roleId_cb.Items.Count && b; j++)
                {
                    if (roleId_cb.Items[j].ToString() == id)
                    {
                        b = false;
                    }
                }
                role_cb.SelectedIndex = j - 1;

            }
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            connect = new OleDbConnection("Provider=SQLOLEDB;Data Source=.\\sqlexpress;Initial Catalog=shop;Integrated Security=SSPI");
            connect.Open();
            user.setConnect("Provider=SQLOLEDB;Data Source=.\\sqlexpress;Initial Catalog=shop;Integrated Security=SSPI");

            showCB();
            show();
            
        }

        private void update_bt_Click(object sender, EventArgs e)
        {
            roleId_cb.SelectedIndex = role_cb.SelectedIndex;
            user.set(name_tb.Text, login_tb.Text, pass_tb.Text, Convert.ToInt32(roleId_cb.Text), role_cb.Text);
            user.updateTable();
            show();
        }

        private void add_bt_Click(object sender, EventArgs e)
        {
            roleId_cb.SelectedIndex = role_cb.SelectedIndex;
            user.set(name_tb.Text, login_tb.Text, pass_tb.Text, Convert.ToInt32(roleId_cb.Text), role_cb.Text);
            user.insertTable();
            show();
        }

        private void del_bt_Click(object sender, EventArgs e)
        {
            roleId_cb.SelectedIndex = role_cb.SelectedIndex;
            user.set(login: login_tb.Text);
            user.delTable();
            show();
        }
    }
}
