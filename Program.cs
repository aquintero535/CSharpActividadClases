using System;

namespace ActividadClases
{

    class Program
    {
        static void Main(string[] args)
        {
            Circulo circulo1 = new Circulo(25);
            System.Console.WriteLine($"El área del círculo es: {circulo1.calcularArea()}");
            Triangulo triangulo1 = new Triangulo();
            triangulo1.establecerAltura(40);
            triangulo1.establecerBase(35);
            System.Console.WriteLine($"El área del triángulo es: {triangulo1.calcularArea()}");
            Rectangulo rectangulo1 = new Rectangulo(25, 30);
            rectangulo1.establecerBase(45);
            System.Console.WriteLine($"El área del rectángulo es: {rectangulo1.calcularArea()}");
        }
    }

    class Circulo
    {
        public Circulo(int radio)
        {
            this.radio = radio;
        }

        public double calcularArea()
        {
            return 3.1416*(radio*radio);
        }
        private double radio; 
    }

    class Triangulo
    {

        public Triangulo() {}

        public Triangulo(double baseTriangulo, double altura)
        {
            this.baseTriangulo = baseTriangulo;
            this.altura = altura;
        }

        public double obtenerBase()
        {
            return baseTriangulo;
        }

        public void establecerBase(double baseTriangulo)
        {
            this.baseTriangulo = baseTriangulo;
        }

        public double obtenerAltura()
        {
            return altura;
        }

        public void establecerAltura(double altura)
        {
            this.altura = altura;
        }

        public double calcularArea()
        {
            return (baseTriangulo*altura)/2;
        }
        private double baseTriangulo;
        private double altura;
    }

    class Rectangulo
    {

        public Rectangulo() {}
        public Rectangulo(double baseRectangulo, double altura)
        {
            this.baseRectangulo = baseRectangulo;
            this.altura = altura;
        }

        public double obtenerBase()
        {
            return baseRectangulo;
        }

        public void establecerBase(double baseRectangulo)
        {
            this.baseRectangulo = baseRectangulo;
        }

        public double obtenerAltura()
        {
            return altura;
        }

        public void establecerAltura(double altura)
        {
            this.altura = altura;
        }

        public double calcularArea()
        {
            return baseRectangulo*altura;
        }
        private double baseRectangulo;
        private double altura;
    }
}
