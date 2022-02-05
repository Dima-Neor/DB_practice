using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;

namespace shop_app
{
    class Product
    {
        private string name;
        private Maker maker;
        private string category;

        private double priceBuy;
        private double priceSail;

        OleDbConnection connect = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();

        public Product()
        {
            //
        }
        public Product( string name , Maker maker, string category, double priceBuy, double priceSail)
        {
            this.name = name;
            this.maker = maker;
            this.category = category;
            this.priceBuy = priceBuy;
            this.priceSail = priceSail;
        }
        public void setConnect(string connect)
        {
            this.connect.ConnectionString = connect;
            this.connect.Open();
            com.Connection = this.connect;
        }
        public void insertTable()
        {
            com.CommandText = "INSERT INTO Товар (Название, Id_изготовитель, Категория, Цена_закупки, Цена_продажи) VALUES (?, ?, ?, ?, ?)";
            com.Parameters.Clear();
            com.Parameters.AddWithValue("@n", name);
            com.Parameters.AddWithValue("@id", maker.getID());
            com.Parameters.AddWithValue("@c", category);
            com.Parameters.AddWithValue("@b", priceBuy);
            com.Parameters.AddWithValue("@s", priceSail);
            com.ExecuteNonQuery();
        }
    }
}
