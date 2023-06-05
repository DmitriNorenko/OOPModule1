using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPModule1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pen pen = new Pen();
            pen.Show();
        }
        class Pen
        {
            public string color;
            public int cost;
            public Pen()
            {
                color = "черный";
                cost = 100;
            }
            public Pen(string penColor, int penCost)
            {
                color = penColor;
                cost = penCost;
            }
            public void Show() 
            {
                Console.WriteLine("Цвет : {0}, Значение : {1}",color,cost);
            }
        }
    }
}
