using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace ExpensesManeger
{
    public partial class Form1 : Form
    {
        List<Expense> expenses = new List<Expense>();
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = textBox1.Text;
            try
            {
                List<string> lines = System.IO.File.ReadAllLines(filePath).ToList();
                string[] entries = null;
                foreach (var line in lines)
                {
                    entries = line.Split('|');
                    Expense newExpenses = new Expense();
                    newExpenses.Date = entries[0];
                    var price = Convert.ToDouble(entries[1]);
                    newExpenses.Price = price;
                    newExpenses.Category = entries[2];
                    expenses.Add(newExpenses);
                }

                var totalCategory = expenses.GroupBy(x => x.Category).Count();
                var totalExpenses = expenses.Select(x => x.Price).Sum();
                var output = $" Number of Categories:{totalCategory}, total expense {totalExpenses}";
                listBox1.Items.Add(output);
            }
            catch (System.Exception excep)
            {

                MessageBox.Show(excep.Message);
                textBox1.Clear();               
            }
        }
    }
}
