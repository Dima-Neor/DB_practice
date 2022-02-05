using System;
using System.Collections.Generic;
using System.Text;

namespace shop_app
{
    abstract class Document
    {
        protected int id_document;
        protected string nameUser;
        protected DateTime date;
        protected int id_product;
        protected int count;

        public Document() { }
        public Document(int id_document, string nameUser, DateTime date, int id_product, int count)
        {
            this.id_document = id_document;
            this.nameUser = nameUser;
            this.date = date;
            this.id_product = id_product;
            this.count = count;
        }
        public void set(int id_document, string nameUser, DateTime date, int id_product, int count)
        {
            this.id_document = id_document;
            this.nameUser = nameUser;
            this.date = date;
            this.id_product = id_product;
            this.count = count;
        }
        public int getCount() { return count; }
        public int getIdProduct() { return id_product; }
        public DateTime GetDate() { return date; }
        public abstract void insertTable();
        public abstract void updateTable();



    }
}
