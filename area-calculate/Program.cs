using System;


namespace area_calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape Shape = new Shape();

            Triangle myTriangle = new Triangle(10,10,10,10);
            Console.WriteLine(myTriangle.Lengths());
            Console.WriteLine(myTriangle.Area());

            Square mySquare = new Square(10);
            Console.WriteLine(mySquare.Lengths());
            Console.WriteLine(mySquare.Area());

            Rectangle myRectangle = new Rectangle(10,20);
            Console.WriteLine(myRectangle.Lengths());
            Console.WriteLine(myRectangle.Area());

            Polygon myPolygon = new Polygon(5,5);
            Console.WriteLine(myPolygon.Lengths()); 
            Console.WriteLine(myPolygon.Area()); 

            Circle myCircle = new Circle(5);
            Console.WriteLine(myCircle.Lengths()); 
            Console.WriteLine(myCircle.Area()); 
           
            Elips myElips = new Elips(5,5);
            Console.WriteLine(myElips.Lengths()); 
            Console.WriteLine(myElips.Area());

            Cube myCube = new Cube(5);
            Console.WriteLine(myCube.Volume());

            Cubeoid myCubeoid = new Cubeoid(5,3,4);
            Console.WriteLine(myCubeoid.Volume()); 

            Console.ReadLine();
            
        }
    }
    class Shape
    {
        public int Width;
        public int Height;
        public int Length;

        public virtual int Lengths()
        {
            return Width+Height;
        }
        public virtual int Area()
        {
            return Width*Height;
        }
        public virtual int Volume()
        {
            return Width*Height*Length;
        }

    }
    class Triangle:Shape
    {      
        public int Edge1;
        public int Edge2;
        public Triangle(int width,int height,int edge1,int edge2)
        {
            this.Width = width;
            this.Height = height;
            this.Edge1 = edge1;
            this.Edge2 = edge2;
        }
        public override int Lengths()
        {
            return Edge1+Edge2+Width;
        }
        public override int Area()
        {
            return base.Area()/2;
        }
    }
    class Square:Shape
    {
        public Square(int width)
        {
            this.Width=width; 
        }
        public override int Lengths()
        {
            return Width*4;
        }
        public override int Area()
        {
            return Width*Width;
        }
    }
    class Rectangle:Shape
    {
        public Rectangle(int width,int height)
        {
            this.Width=width;
            this.Height=height;
        }
        public override int Lengths()
        {
            return base.Lengths()*2;
        }
    }
    class Polygon:Shape
    {
        public int Edges;
        
        public Polygon(int width,int edges)
        {
            this.Width=width;
            this.Edges=edges;
        }

        public override int Lengths()
        {
            return Width*Edges;
        }
        public override int Area()
        {
            double doubleArea = (Math.Sqrt(3)/4*Math.Pow(Width,2))*Edges;
            int area = Convert.ToInt32(doubleArea);

            return area;
        }
    }
    class Circle:Shape
    {
        double pi = 3.14;
        public Circle(int width)
        {
            this.Width=width;
            
        }
        public override int Lengths()
        {
            double doubleLength = Convert.ToDouble(Width)*pi;
            int length = Convert.ToInt32(doubleLength);

            return Convert.ToInt32(length);
        }
        public override int Area()
        {
            double doubleArea = Math.Sqrt(Width/2)*pi;
            int area = Convert.ToInt32(doubleArea);
             
            return area;
        }
    }
    class Elips:Shape
    {
        double Pi = 3.14;
        public Elips(int width,int height)
        {
            this.Width=width;
            this.Height=height;
        }
        public override int Lengths()
        {
            double doubleLength = 2*Pi*Math.Sqrt((Math.Pow(Width,2)+Math.Sqrt(Height*2))/2);
            int length = Convert.ToInt32(doubleLength);

            return length;
        }
        public override int Area()
        {
            double doubleArea = Width*Height*Pi;
            int area = Convert.ToInt32(doubleArea);

            return area;
        }
        
    }
    class Cube:Shape
    {
        public Cube(int width)
        {
            this.Width=width;
        }
        public int volume(int width)
        {
            return Width*6;
        }
    }
    class Cubeoid:Shape
    {
        public Cubeoid(int width,int height,int length)
        {
            this.Width=width;
            this.Height=height;
            this.Length=length;
        }       
    }
}
