using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkelonTest3
{
    public class OrderInfo
    {
        public string Id { get; set; }
        public string OrganizationName { get; set; }
        public string CountProducts { get; set; }
        public decimal Price { get; set; }
        public string Date { get; set; }

        public string GetOrderInfoString()
        {
            return $"id заказа: {Id}" + Environment.NewLine +
                   $"Клиент: {OrganizationName}" + Environment.NewLine +
                   $"Количество товара: {CountProducts}" + Environment.NewLine +
                   $"Итоговая цена: {Price}" + Environment.NewLine +
                   $"Дата заказа: {Date}" + Environment.NewLine + Environment.NewLine;
        }
    }
}
