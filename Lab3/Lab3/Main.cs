using System;
using System.Collections;
using System.Collections.Generic;

namespace lab3
{
    class MainClass
    {
        public static void Main()
        {
            Console.WriteLine("Фигуры:\n");
            Rectangle r = new Rectangle(5, 6);
            Square s = new Square(5);
            Circle c = new Circle(7);
            r.Print();
            s.Print();
            c.Print();

            Console.WriteLine("\nКоллекция ArrayList до сортировки:\n");
            ArrayList arrayListFigures = new ArrayList();
            arrayListFigures.Add(r);
            arrayListFigures.Add(s);
            arrayListFigures.Add(c);

            foreach (GeomFigure i in arrayListFigures)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nКоллекция ArrayList после сортировки:\n");
            arrayListFigures.Sort();

            foreach (GeomFigure i in arrayListFigures)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nКоллекция List<GeomFigure> до сортировки:\n");
            List<GeomFigure> listFigure = new List<GeomFigure>();
            listFigure.Add(r);
            listFigure.Add(s);
            listFigure.Add(c);

            foreach (GeomFigure i in listFigure)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nКоллекция List<GeomFigure> после сортировки:\n");
            listFigure.Sort();

            foreach (GeomFigure i in listFigure)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nМатрица\n");
            Matrix<GeomFigure> matrix = new Matrix<GeomFigure>(3, 3, 3, new FigureMatrixCheckEmpty());
            matrix[0, 0, 0] = r;
            matrix[1, 1, 1] = s;
            matrix[2, 2, 2] = c;
            Console.WriteLine(matrix.ToString());

            Console.WriteLine("\nПример работы класса  SimpleStack:\n");
            Console.WriteLine("Фигуры добавлены в SimpleStack с помощью метода Push() и выведены с помощью метода Pop()\n");
            SimpleStack<GeomFigure> simpleStackFigures = new SimpleStack<GeomFigure>();
            simpleStackFigures.Push(r);
            simpleStackFigures.Push(s);
            simpleStackFigures.Push(c);
            
            while (simpleStackFigures.Count != 0)
            {
                Console.WriteLine(simpleStackFigures.Pop());
                
            }
        }
    }
}