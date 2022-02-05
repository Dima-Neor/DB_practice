using System;
using System.Collections.Generic;
using System.Text;

namespace shop_app
{
    class Sale : Document
    {
        public Sale(int id_document, string nameUser, DateTime date, int id_product, int count) : base(id_document, nameUser, date, id_product, count) { }
        public override void insertTable()
        {

        }
        public override void updateTable()
        {

        }
    }
}
