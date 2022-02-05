using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;

namespace shop_app
{
    class User
    {
        private string name;
        private string login;
        private string password;
        private int IdRole;
        private string nameRole;

        OleDbConnection connect = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();

        public User (string name = "",string login = "", string pass = "", int IdRole = 0, string nameRole = "")
        {
            this.name = name;
            this.login = login;
            this.password = pass;
            this.IdRole = IdRole;
            this.nameRole = nameRole;
        }
        public void set (string name = "", string login = "", string pass = "", int IdRole = 0, string nameRole = "")
        {
            this.name = name;
            this.login = login;
            this.password = pass;
            this.IdRole = IdRole;
            this.nameRole = nameRole;
        }
        public void setConnect(string connect)
        {
            this.connect.ConnectionString = connect;
            this.connect.Open();
            com.Connection = this.connect;
        }
        public void insertTable()
        {
            com.CommandText = "INSERT INTO Сотрудник (ФИО, Логин, Пароль, ID_должность) VALUES (?, ?, ?, ?)";
            com.Parameters.Clear();
            com.Parameters.AddWithValue("@n", name);
            com.Parameters.AddWithValue("@l", login);
            com.Parameters.AddWithValue("@p", password);
            com.Parameters.AddWithValue("@id", IdRole);
            com.ExecuteScalar();
        }
        public void updateTable()
        {
            com.CommandText = "UPDATE Сотрудник SET ФИО =?, Логин=?, Пароль=?, ID_должность=? WHERE Логин=?";
            com.Parameters.Clear();
            com.Parameters.AddWithValue("@n", name);
            com.Parameters.AddWithValue("@l", login);
            com.Parameters.AddWithValue("@p", password);
            com.Parameters.AddWithValue("@idr", IdRole);
            com.Parameters.AddWithValue("@id", login);
            com.ExecuteScalar();
        }
        public void delTable()
        {
            com.CommandText = "DELETE FROM Сотрудник WHERE Логин=?";
            com.Parameters.Clear();
            com.Parameters.AddWithValue("@l", login);
            com.ExecuteScalar();
            this.set();
        }
        public void fromTable (ref OleDbDataReader reader)
        {
            name = reader.GetValue(0).ToString();
            login = reader.GetValue(1).ToString();
            password = reader.GetValue(2).ToString();
            IdRole = Convert.ToInt32(reader.GetValue(3));
        }

        public string getName() { return name; }
        public string getLogin() { return login; }
        public string getPass() { return password; }
        public int getIdRole() { return IdRole; }
        public string getNameRole() { return nameRole; }
    }
}
