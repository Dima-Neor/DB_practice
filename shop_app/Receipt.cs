using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;

namespace shop_app
{
    class Receipt : Document
    {
        private OleDbConnection connect = new OleDbConnection();
        private OleDbCommand com = new OleDbCommand();
        
        public Receipt() :base() { }
        public Receipt(int id_document, string nameUser, DateTime date, int id_product, int count) : base(id_document, nameUser, date, id_product, count) { }
        
        public void setConnect(string connect)
        {
            this.connect.ConnectionString = connect;
            this.connect.Open();
            com.Connection = this.connect;
        }
        public override void insertTable()
        {
            try
            {
                com.CommandText = "Добавить_поступление";
                com.CommandType = System.Data.CommandType.StoredProcedure;
                com.Parameters.Clear();
                com.Parameters.AddWithValue("@nameUser", nameUser);
                com.Parameters.AddWithValue("@date", date);
                com.Parameters.AddWithValue("@id_product", id_product);
                com.Parameters.AddWithValue("@count", count);
                com.ExecuteNonQuery();
            }
            catch (System.Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка доступа к базе данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public override void updateTable()
        {
            try
            {
                //проверить
                com.CommandText = "Обновить_поступление";
                com.CommandType = System.Data.CommandType.StoredProcedure;
                com.Parameters.Clear();
                com.Parameters.AddWithValue("@id_document", id_document);
                com.Parameters.AddWithValue("@nameUser", nameUser);
                com.Parameters.AddWithValue("@date", date);
                com.Parameters.AddWithValue("@id_product", id_product);
                com.Parameters.AddWithValue("@count", count);
                com.ExecuteNonQuery();
            }
            catch (System.Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка доступа к базе данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
