using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsPlanes
{
    public class Plane : Vehicle
    {
        /// Ширина отрисовки самолета
        protected readonly int planeWidth = 200;

        /// Высота отрисовки самолета
        protected readonly int planeHeight = 80;

        /// Конструктор
        public Plane(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        /// Конструктор с изменением размеров самолета
        protected Plane(int maxSpeed, float weight, Color mainColor, int planeWidth, int
       planeHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.planeWidth = planeWidth;
            this.planeHeight = planeHeight;
        }
        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - planeWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - planeHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);

            g.DrawRectangle(pen, _startPosX + 5, _startPosY + 30, 150, 40);

            g.DrawEllipse(pen, _startPosX, _startPosY + 25, 40, 10);
            g.DrawEllipse(pen, _startPosX + 40, _startPosY + 45, 80, 10);

            g.DrawLine(pen, _startPosX + 40, _startPosY + 70, _startPosX + 30, _startPosY + 80);
            g.DrawLine(pen, _startPosX + 40, _startPosY + 70, _startPosX + 50, _startPosY + 80);
            g.DrawEllipse(pen, _startPosX + 25, _startPosY + 80, 10, 10);
            g.DrawEllipse(pen, _startPosX + 45, _startPosY + 80, 10, 10);

            g.DrawLine(pen, _startPosX + 150, _startPosY + 70, _startPosX + 150, _startPosY + 80);
            g.DrawEllipse(pen, _startPosX + 145, _startPosY + 80, 10, 10);

            g.DrawLine(pen, _startPosX + 155, _startPosY + 70, _startPosX + 200, _startPosY + 50);
            g.DrawLine(pen, _startPosX + 155, _startPosY + 30, _startPosX + 200, _startPosY + 50);
            g.DrawLine(pen, _startPosX + 155, _startPosY + 50, _startPosX + 200, _startPosY + 50);

            g.DrawLine(pen, _startPosX + 5, _startPosY, _startPosX + 5, _startPosY + 30);
            g.DrawLine(pen, _startPosX + 5, _startPosY, _startPosX + 50, _startPosY + 30);

            Brush br = new SolidBrush(MainColor);
            g.FillEllipse(br, _startPosX, _startPosY + 25, 40, 10);
            g.FillEllipse(br, _startPosX + 40, _startPosY + 45, 80, 10);
        }
    }
}
