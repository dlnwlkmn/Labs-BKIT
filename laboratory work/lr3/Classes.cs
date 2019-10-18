using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr3
{
    interface IPrint
    {
        void Print();
    }
    abstract class GeomFigure
    {
        string type;
        public string Type
        {
            protected set
            {
                this.type = value;
            }
            get
            {
                return this.type;
            }
        }

        public abstract double Square();
        public override string ToString()
        {
            return this.type + " площадью " + this.Square();
        }
    }
    class Rectangle : GeomFigure, IPrint
    {
        double width;
        double height;
        public Rectangle(double w, double h) //Главные конструктор класса
        {
            this.width = w;
            this.height = h;
            this.Type = "Прямоугольник";
        }
        public override double Square()
        {
            return this.width * this.height;
        }
        public override string ToString()
        {
            return "Прямоугольник площадью " + this.Square();
        }
        public void Print()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(this.ToString());
            Console.ResetColor();
        }
    }
    class Squad : Rectangle
    {
        public Squad(double a)
            : base(a, a)
        {
            this.Type = "Квадрат";
        }
        public override string ToString()
        {
            return "Квадрат площадью " + this.Square();
        }
    }
    class Circle : GeomFigure, IPrint
    {
        double radius;
        public Circle(double r)
        {
            this.radius = r;
            this.Type = "Круг";
        }
        public override double Square()
        {
            return System.Math.PI * this.radius * this.radius;
        }
        public override string ToString()
        {
            return "Круг площадью " + this.Square();
        }
        public void Print()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(this.ToString());
            Console.ResetColor();
        }

    }
}
