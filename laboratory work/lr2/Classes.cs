using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2_1
{
    public interface IPrint
    {
        void Print();
    }
    public interface IMatrixCheckEmpty<T>
    {
        T getEmptyElement();
        bool checkEmptyElement(T element);
    }
    public abstract class GeomFigure : IComparable
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

        public int CompareTo(object obj)
        {
            GeomFigure p = (GeomFigure)obj;

            if (this.Square() < p.Square()) return -1;
            else if (this.Square() == p.Square()) return 0;
            else return 1;
        }

    }
    public class Rectangle : GeomFigure, IPrint, IComparable
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
    public class Squad : Rectangle, IComparable
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
    public class Circle : GeomFigure, IPrint, IComparable
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
