using Polygon.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon
{

    class Program
    {
        static void Main(string[] args)
        {
            int option;
            int sidelength = 5;
            do
            {
                Console.WriteLine("[ 1 ] Maak concreet vierkant");
                Console.WriteLine("[ 2 ] Maak concrete driehoek");
                Console.WriteLine("[ 3 ] Maak abstract vierkant");
                Console.WriteLine("[ 4 ] Maak abstracte driehoek");
                Console.WriteLine("[ 5 ] Maak vierkant");
                Console.WriteLine("[ 6 ] Maak driehoek");
                Console.WriteLine("[ 7 ] Maak polygon");
                Console.WriteLine("[ 0 ] Afsluiten");
                Console.WriteLine("-------------------------------------");
                Console.Write("Kies een optie: ");
                option = Int32.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        concreetSquare(sidelength);
                        break;
                    case 2:
                        concreetTriangle(sidelength);
                        break;
                    case 3:
                        abstractSquare(sidelength);
                        break;
                    case 4:
                        abstractTriangle(sidelength);
                        break;
                    case 5:
                        square(sidelength);
                        break;
                    case 6:
                        triangle(sidelength);
                        break;
                    case 7:
                        polygon(sidelength);
                        break;
                    default:
                        quit();
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
            while (option != 0);
        }

        private static void polygon( int sidelength)
        {
            ConcreteRegularPolygon polygon = new ConcreteRegularPolygon(4, sidelength);
            Console.WriteLine("De omtrek is: {0}", polygon.GetPerimeter());
            Console.WriteLine("De oppervlakte is {0}", polygon.GetArea());
        }
        private static void triangle(int sidelength)
        {
            Triangle triangle = new Triangle(sidelength);
            Console.WriteLine("De omtrek is: {0}", triangle.GetPerimeter());
            Console.WriteLine("De oppervlakte is {0}", triangle.GetArea());
        }

        private static void square(int sidelength)
        {
            Square square = new Square(sidelength);
            Console.WriteLine("De omtrek is: {0}", square.GetPerimeter());
            Console.WriteLine("De oppervlakte is {0}", square.GetArea());
        }

        private static void abstractTriangle(int sidelength)
        {
            ATriangle triangle = new ATriangle(sidelength);
            Console.WriteLine("De omtrek is: {0}", triangle.GetPerimeter());
            Console.WriteLine("De oppervlakte is {0}", triangle.GetArea());
        }

        private static void abstractSquare(int sidelength)
        {
            ASquare square = new ASquare(sidelength);
            Console.WriteLine("De omtrek is: {0}", square.GetPerimeter());
            Console.WriteLine("De oppervlakte is {0}", square.GetArea());
        }

        private static void quit()
        {
            Console.WriteLine();
            Console.WriteLine("Bye Bye, vc saiu do Programa. Clique qq tecla para sair...");
        }

        private static void concreetSquare(int length)
        {
            CSquare square = new CSquare(length);
            Console.WriteLine("De omtrek is: {0}" , square.GetPerimeter());
            Console.WriteLine("De oppervlakte is {0}" , square.GetArea());
        }

        private static void concreetTriangle(int length)
        {
            CTriangle square = new CTriangle(length);
            Console.WriteLine("De omtrek is: {0}", square.GetPerimeter());
            Console.WriteLine("De oppervlakte is {0}", square.GetArea());
        }


        private static void matricularAluno(int codigoAluno)
        {
            Console.WriteLine();
            Console.WriteLine("Digitou a opção de Matricular o Aluno");
        }
    }
}

