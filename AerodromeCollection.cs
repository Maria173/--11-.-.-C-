using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlanes
{
    class AerodromeCollection
    {
        /// Словарь (хранилище) с аэродромами
        readonly Dictionary<string, Aerodrome<Vehicle>> aerodromeStages;

        /// Возвращение списка названий аэродромов
        public List<string> Keys => aerodromeStages.Keys.ToList();

        /// Ширина окна отрисовки
        private readonly int pictureWidth;

        /// Высота окна отрисовки
        private readonly int pictureHeight;

        /// Конструктор
        public AerodromeCollection(int pictureWidth, int pictureHeight)
        {
            aerodromeStages = new Dictionary<string, Aerodrome<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }

        /// Добавление аэродрома
        public void AddAerodrome(string name)
        {
            if (!aerodromeStages.ContainsKey(name))
            {
                aerodromeStages.Add(name, new Aerodrome<Vehicle>(pictureWidth, pictureHeight));
            }
        }

        /// Удаление аэродрома
        public void DelAerodrome(string name)
        {
            if (aerodromeStages.ContainsKey(name))
            {
                aerodromeStages.Remove(name);
            }
        }

        /// Доступ к аэродрому
        public Aerodrome<Vehicle> this[string ind]
        {
            get
            { 
                if(aerodromeStages.ContainsKey(ind))
                {
                    return aerodromeStages[ind];
                }
                return null;
            }
        }
    }
}
