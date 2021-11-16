using System.Drawing;

namespace Met_1311
{
    interface IFigureActions
    {
        void Move(MovingType movingType, double value);
        void SetColor(Color color);
        void ChangeVisible();
    }
}
