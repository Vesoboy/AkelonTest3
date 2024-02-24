using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkelonTest3.Models
{
    internal class ColumnIndices    //Обозначение колонок в Exel таблице
    {
        public static class Orders
        {
            public const int idOrder = 1;
            public const int idProduct = 2;
            public const int idClient = 3;
            public const int NumberOrder = 4;
            public const int CountProduct = 5;
            public const int Date = 6;
        }

        public static class Clients
        {
            public const int idClient = 1;
            public const int Name = 2;
            public const int Adres = 3;
            public const int ContactName = 4;
        }

        public static class Products
        {
            public const int idProduct = 1;
            public const int Name = 2;
            public const int Unit = 3;
            public const int Price = 4;
        }
    }
}
