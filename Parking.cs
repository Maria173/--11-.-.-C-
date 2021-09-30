using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsPlanes
{
    public class Aerodrome<T> where T : class, ITransport
    {
        
        /// Массив объектов, которые храним
        private readonly T[] _places;

        /// Ширина окна отрисовки
        private readonly int pictureWidth;

        /// Высота окна отрисовки
        private readonly int pictureHeight;

        /// Размер места на аэродроме (ширина)
        private readonly int _placeSizeWidth = 230;

        /// Размер места на аэродроме (высота)
        private readonly int _placeSizeHeight = 100;

        private int width;
        private int height;

        /// Конструктор
        public Aerodrome(int picWidth, int picHeight)
        {
            width = picWidth / _placeSizeWidth;
            height = picHeight / _placeSizeHeight;
            _places = new T[width * height];
            pictureWidth = picWidth;
            pictureHeight = picHeight;
        }

        /// Перегрузка оператора сложения
        /// Логика действия: на аэродром добавляется самолет
        public static int operator +(Aerodrome<T> a, T plane)
        {
            int i = 0;
            int j = 0;

            while (i < a.height)
            {
                j = 0;
                while (j < a.width)
                {
                    if (a._places[i * a.width + j] == null)
                    {
                        plane.SetPosition(j * a._placeSizeWidth,i * a._placeSizeHeight, a.pictureWidth, a.pictureHeight);
                        a._places[i * a.width + j] = plane;
                        return (i * a.width + j);
                    }
                    j++;
                }
                i++;
            }
            return -1;
        }

        /// Перегрузка оператора вычитания
        /// Логика действия: с аэродрома отгоняется самолет
        public static T operator -(Aerodrome<T> a, int index)
        {
            if (index >= a._places.Length || index < 0) return null;
            if (a._places[index] != null)
            {
                T res_plane = a._places[index];
                a._places[index] = null;
                return res_plane;
            }
            else return null;
        }

        /// Метод отрисовки аэродрома
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Length; i++)
            {
                _places[i]?.DrawTransport(g);
            }
        }

        /// Метод отрисовки разметки мест на аэродроме
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {
                    ///линия рамзетки места
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i *
                   _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth,
               (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }
    }
}
