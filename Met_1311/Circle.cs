using System;

namespace Met_1311
{
    class Circle : Point, IFigureActions
    {
        public double Size;

        public Circle(double size)
        {
            Size = size;
        }

        public override double GetSquare()
        {
            return Math.PI * Size * Size;
        }
    }
}
