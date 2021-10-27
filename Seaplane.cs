using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsPlanes
{
    public class Seaplane : Plane
    {
        // Дополнительный цвет
        public Color DopColor { private set; get; }

        // Признак наличия нижнего спойлера
        public bool BottomSpoiler { private set; get; }

        // Признак наличия винтового спойлера
        public bool ScrewSpoiler { private set; get; }

        // Инициализация свойств
        public Seaplane(int maxSpeed, float weight, Color mainColor,
            Color dopColor, bool bottomSpoiler, bool screwSpoiler) :
            base(maxSpeed, weight, mainColor, 220, 95)
        {
            DopColor = dopColor;
            BottomSpoiler = bottomSpoiler;
            ScrewSpoiler = screwSpoiler;
        }

        // Отрисовка самолета
        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush spoiler = new SolidBrush(DopColor);

            if (BottomSpoiler)
            {
                g.DrawEllipse(pen, _startPosX, _startPosY + 80, 80, 10);
                g.DrawEllipse(pen, _startPosX + 130, _startPosY + 80, 40, 10);

                g.FillEllipse(spoiler, _startPosX, _startPosY + 80, 80, 10);
                g.FillEllipse(spoiler, _startPosX + 130, _startPosY + 80, 40, 10);
            }

            if (ScrewSpoiler)
            {
                pen = new Pen(DopColor);
                g.DrawLine(pen, _startPosX + 215, _startPosY + 70, _startPosX + 185, _startPosY + 30);
                g.DrawLine(pen, _startPosX + 185, _startPosY + 70, _startPosX + 215, _startPosY + 30);

            }
            base.DrawTransport(g);
        }

        /// Смена дополнительного цвета
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
    }
}

