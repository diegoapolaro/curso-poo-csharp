using abstract_methods_exercise.Entities.Enums;

namespace abstract_methods_exercise.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape() { }
        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
