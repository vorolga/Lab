using System;

namespace lab2
{
    interface IPrint
    {
        void Print(); 
    }

    abstract class GeomFigure
    {
        public abstract double Area();

    }

    class Rectangle : GeomFigure, IPrint
    {
        public double height { get; set; }
        public double width { get; set; }

        public Rectangle(double width, double height) 
        {
            this.height = height;
            this.width = width;
        }

        public override double Area()
        {
            return height * width;
        }

        public override string ToString()
        {
            return ("Прямоугольник:\n  ширина: " + width + "\n  высота: " + height + "\n  площадь: " + Area());
        }

        public void Print()
        {
            Console.WriteLine(ToString()); 
        }

    }

    class Square : Rectangle
    {
        public double sideLength { get; set; }
        public Square(double sideLength) : base(sideLength, sideLength) 
        {
            this.sideLength = sideLength;
        }

        public override double Area()
        {
            return sideLength * sideLength;
        }

        public override string ToString()
        {
            return ("Квадрат:\n  длина стороны: " + sideLength + "\n  площадь: " + Area());
        }

    }

    class Circle : GeomFigure, IPrint
    {
        public double radius { get; set; }

        public Circle(double radius) 
        {
            this.radius = radius; 
        }
        
        public override double Area()
        {
            return radius * radius * 3.14;
        }

        public override string ToString()
        {
            return ("Круг:\n  радиус: " + radius + "\n  площадь: " + Area());
        }

        public void Print()
        {
            Console.WriteLine(ToString());
        }
    }

    public static class Program {
        public static void Main()
        {
            Rectangle r = new Rectangle(2, 3);
            Square s = new Square(5);
            Circle c = new Circle(7);
            r.Print();
            s.Print();
            c.Print();
        }
    }
}