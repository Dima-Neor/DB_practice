using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;

namespace shop_app
{
    class Maker
    {
        private int id;
        private string name;
        private string country;

        OleDbConnection connect = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();

        public Maker(int id = 0, string name = "", string country = "")
        {
            this.id = id;
            this.name = name;
            this.country = country;
        }

        public int getID () { return id; }
        public string getName () { return name; }
        public string getCountry () { return country; }

        public void setConnect(string connect)
        {
            this.connect.ConnectionString = connect;
            this.connect.Open();
            com.Connection = this.connect;
        }
        public void insertTable()
        {
            com.CommandText = "INSERT INTO Изготовитель (Название, Страна) VALUES (?, ?)";
            com.Parameters.Clear();
            com.Parameters.AddWithValue("@n", name);
            com.Parameters.AddWithValue("@с", country);
            com.ExecuteScalar();
        }
    }
}
