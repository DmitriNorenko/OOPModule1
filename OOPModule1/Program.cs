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
            User user = new User("Dmitry", "Dmitry@gmail.com");
            user.Show();
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
                    Console.WriteLine("В автобусе : {0} пассажиров.", Load);
                else
                    Console.WriteLine("Автобус пуст.");
            }
        }
        class circle
        {
            public int radius;
            public void CircumferenceLengths()
            {

            }
        }
        class triangle
        {
            public int a, b, c;

            public void Perimeter()
            {

            }
            public void Square()
            {

            }
        }
        class Cube
        {
            public int a, b, c;

            public void Perimeter()
            {

            }
            public void Square()
            {

            }
        }
        class TrafficLight
        {
            private string color;
            private void ChangeColor(string Color)
            {
                color = Color;
            }
            public void GetColor()
            {
                Console.WriteLine(color);
            }
        }
        class User
        {
            private string login;
            private string email;
            public User(string log,string eml)
            {
                Login = log;
                Email = eml;
            }
            public string Email
            {
                get { return email; }
                set
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        if (value[i] == '@')
                        {
                            email = value;
                        }
                    }
                }
            }
            public string Login
            {
                get { return login; }
                set
                {
                    if (value.Length > 3)
                    {
                        login = value;
                    }
                    else
                    {
                        Console.WriteLine(" Вы ввели короткий логин.Не меньше 3 символов.");
                    }
                }
            }
            public void Show()
            {
                Console.WriteLine("\n Ваш логин: {0} \n Ваша почта: {1}",login,email);
            }
        }
    }
}
