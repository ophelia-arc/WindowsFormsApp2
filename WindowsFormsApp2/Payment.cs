using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Payment
    {
        public string Title { get; set; }
        public double Amount { get; set; }
        public Payment()
        {
        }
        public Payment(string title, double amount)
        {
            Title = title;
            Amount = amount;
        }
    }
}
