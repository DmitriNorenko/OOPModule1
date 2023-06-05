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
            Rectangle rectangle = new Rectangle();
            Bus bus = new Bus(7);
            bus.printStatus();
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
                Console.WriteLine("Цвет : {0}, Значение : {1}", color, cost);
            }
        }
        class Rectangle
        {
            public int a;
            public int b;
            public Rectangle()
            {
                a = 6;
                b = 4;
            }
            public Rectangle(int a)
            {
                this.a = a;
                this.b = a;
            }
            public Rectangle(int a, int b)
            {
                this.a = a;
                this.b = b;
            }
            public void Square()
            {
                int S = a * b;
                Console.WriteLine("Площадь равна: " + S);
            }
        }
        class Bus
        {
            public int? Load;
            public Bus(int a)
            {
                Load = a;
            }
            public void printStatus()
            {
                if (Load != null)
                    Console.WriteLine("В автобусе : {0} пассажиров.",Load);
                else
                    Console.WriteLine("Автобус пуст.");
            }
        }
    }
}
