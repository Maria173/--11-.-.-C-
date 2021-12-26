using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsPlanes
{
    public class Seaplane : Plane, IEquatable<Seaplane>
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

        /// Конструктор для загрузки с файла
        public Seaplane(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length >= 6)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                BottomSpoiler = Convert.ToBoolean(strs[4]);
                ScrewSpoiler = Convert.ToBoolean(strs[5]);
            }
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

        public override string ToString()
        {
            return
            $"{base.ToString()}{separator}{DopColor.Name}{separator}{BottomSpoiler}{separator}{ScrewSpoiler}{separator}";
        }

        public bool Equals(Seaplane other)
        {
            if (base.Equals(other))
            {
                if (DopColor != other.DopColor)
                {
                    return false;
                }
                if (BottomSpoiler != other.BottomSpoiler)
                {
                    return false;
                }
                if (ScrewSpoiler != other.ScrewSpoiler)
                {
                    return false;
                }
                return true;
            }
            else return false;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Seaplane planeObj))
            {
                return false;
            }
            else
            {
                return Equals(planeObj);
            }
        }
    }
}

