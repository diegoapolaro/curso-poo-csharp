using System;
using abstract_methods_exercise.Entities.Enums;

namespace abstract_methods_exercise.Entities
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle()
        {
        }

        public Circle(double radius, Color color) : base(color) 
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
