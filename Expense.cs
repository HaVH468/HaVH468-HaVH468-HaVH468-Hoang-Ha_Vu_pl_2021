using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesManeger
{
    public class Expense
    {
        public string Date { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }

        public string Infor
        {
            get
            {
                return $"{Date}|{Category}|{Price}";
            }
        }
    }
}
