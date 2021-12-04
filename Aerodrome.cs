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

        /// Список объектов, которые храним
        private readonly List<T> _places;

        /// Максимальное количество мест на аэродроме
        private readonly int _maxCount;

        /// Ширина окна отрисовки
        private readonly int pictureWidth;

        /// Высота окна отрисовки
        private readonly int pictureHeight;

        /// Размер места (ширина)
        private readonly int _placeSizeWidth = 230;

        /// Размер места (высота)
        private readonly int _placeSizeHeight = 100;

        private int width;
        private int height;

        /// Конструктор
        public Aerodrome(int picWidth, int picHeight)
        {
            width = picWidth / _placeSizeWidth;
            height = picHeight / _placeSizeHeight;
            _maxCount = width * height;
            pictureWidth = picWidth;
            pictureHeight = picHeight;
            _places = new List<T>();
        }

        /// Перегрузка оператора сложения
        /// Логика действия: на аэродром добавляется самолет
        public static int operator +(Aerodrome<T> a, T plane)
        {
            if (a._places.Count >= a._maxCount)
            {
                throw new AerodromeOverflowException();
            }
            a._places.Add(plane);
            return 1;
        }

        /// Перегрузка оператора вычитания
        /// Логика действия: с аэродрома отгоняется самолет
        public static T operator -(Aerodrome<T> a, int index)
        {
            if (index >= a._places.Count || index < 0)
            {
                throw new AerodromeNotFoundException(index);
            }
            if (a._places[index] != null)
            {
                T res_plane = a._places[index];
                a._places.RemoveAt(index);
                return res_plane;
            }
            else return null;
        }

        /// Метод отрисовки аэродрома
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Count; ++i)
            {
                _places[i]?.SetPosition((i % (pictureWidth / _placeSizeWidth)) * _placeSizeWidth + 5,
                    (i / (pictureWidth / _placeSizeWidth)) * _placeSizeHeight,
                    pictureWidth, pictureHeight);
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
                { //линия рамзетки места
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i *
                   _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth,
               (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }

        /// Функция получения элементы из списка
        public T GetNext(int index)
        {
            if (index < 0 || index >= _places.Count)
            {
                return null;
            }
            return _places[index];
        }
    }
}
