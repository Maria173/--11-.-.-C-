using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsPlanes
{
    class Seaplane
    {
        // Левая координата отрисовки самолета
        private float _startPosX;
        // Правая кооридната отрисовки самолета
        private float _startPosY;
        // Ширина окна отрисовки
        private int _pictureWidth;
        // Высота окна отрисовки
        private int _pictureHeight;

        // Ширина отрисовки самолета
        private readonly int planeWidth = 220;
        // Высота отрисовки самолета
        private readonly int planeHeight = 90;
        // Максимальная скорость

        public int MaxSpeed { private set; get; }
        // Вес автомобиля
        public float Weight { private set; get; }

        // Основной цвет
        public Color MainColor { private set; get; }
        // Дополнительный цвет
        public Color DopColor { private set; get; }

        // Признак наличия нижнего спойлера
        public bool BottomSpoiler { private set; get; }
        // Признак наличия винтового спойлера
        public bool ScrewSpoiler { private set; get; }

        // Инициализация свойств
        public void Init(int maxSpeed, float weight, Color mainColor, Color dopColor,
       bool bottomSpoiler, bool screwSpoiler)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            BottomSpoiler = bottomSpoiler;
            ScrewSpoiler = screwSpoiler;
        }

        // Установка позиции самолета
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }

        // Изменение направления пермещения
        public void MoveTransport(Direction direction)
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
                // влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                // вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                // вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - planeHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        // Отрисовка самолета
        public void DrawTransport(Graphics g)
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

            if (BottomSpoiler)
            {
                g.DrawEllipse(pen, _startPosX, _startPosY + 80, 80, 10);
                g.DrawEllipse(pen, _startPosX + 130, _startPosY + 80, 40, 10);

                Brush spoiler = new SolidBrush(DopColor);
                g.FillEllipse(spoiler, _startPosX, _startPosY + 80, 80, 10);
                g.FillEllipse(spoiler, _startPosX + 130, _startPosY + 80, 40, 10);
            }

            if (ScrewSpoiler)
            {
                pen = new Pen(DopColor);
                g.DrawLine(pen, _startPosX + 215, _startPosY + 70, _startPosX + 185, _startPosY + 30);
                g.DrawLine(pen, _startPosX + 185, _startPosY + 70, _startPosX + 215, _startPosY + 30);

            }
        }
    }
}

