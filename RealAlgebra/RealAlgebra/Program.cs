using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeAreaLib;

namespace RealAlgebra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice = "";
            Rectangle rect = new Rectangle();
            Circle circle = new Circle();
            Square sq = new Square();
            Triangle tri = new Triangle();
            do
            {
                Console.WriteLine("Choose the shape to find area");
                Console.WriteLine("1.Rectangle");
                Console.WriteLine("2.Square");
                Console.WriteLine("3.Circle");
                Console.WriteLine("4.Triangle");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter Length of the Rectangle");
                            double l = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Breadth of the Rectangle");
                            double b = double.Parse(Console.ReadLine());
                            Console.WriteLine("The Area of the Rectangle is: " + rect.Area(l, b));
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter the side of the square");
                            double a = double.Parse(Console.ReadLine());
                            Console.WriteLine("The Area of the square is: " + sq.Area(a));
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter the Radius of the circle");
                            double r = double.Parse(Console.ReadLine());
                            Console.WriteLine("The Area of the Circle is: " + circle.Area(r));
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Enter the height of the triangle");
                            double h = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the base of the triangle");
                            double b = double.Parse(Console.ReadLine());
                            Console.WriteLine("The Area of the Triangle is: " + tri.Area(h, b));
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Choice");
                            break;
                        }
                }
                Console.WriteLine("Do you want to continue press y/n");
                choice = Console.ReadLine();
            } while (choice == "y");

        }
    }
}
        
    

