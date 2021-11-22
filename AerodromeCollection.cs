using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
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

        /// Разделитель для записи информации в файл
        private readonly char separator = ':';

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
                if (aerodromeStages.ContainsKey(ind))
                {
                    return aerodromeStages[ind];
                }
                return null;
            }
        }

        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename, false))
            {
                sw.WriteLine("AerodromeCollection", sw);
                foreach (var level in aerodromeStages)
                {
                    //Начинаем аэродром
                    sw.WriteLine($"Aerodrome{separator}{level.Key}", sw);
                    ITransport plane = null;
                    for (int i = 0; (plane = level.Value.GetNext(i)) != null; i++)
                    {
                        if (plane != null)
                        {
                            if (plane.GetType().Name == "Plane")
                            {
                                sw.Write($"Plane{separator}", sw);
                            }
                            if (plane.GetType().Name == "Seaplane")
                            {
                                sw.Write($"Seaplane{separator}", sw);
                            }
                            //Записываемые параметры
                            sw.WriteLine(plane + "", sw);
                        }
                    }
                }
            }
            return true;
        }

        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            using (StreamReader sr = new StreamReader(filename))
            {
                string line;
                if ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("AerodromeCollection"))
                    {
                        aerodromeStages.Clear();
                    }
                    else
                    {
                        return false;
                    }
                    Vehicle plane = null;
                    string key = string.Empty;
                    while ((line = sr.ReadLine()) != null)
                    {
                        //идем по считанным записям
                        if (line.Contains("Aerodrome"))
                        {
                            key = line.Split(separator)[1];
                            aerodromeStages.Add(key, new Aerodrome<Vehicle>(pictureWidth, pictureHeight));
                            continue;
                        }
                        if (string.IsNullOrEmpty(line))
                        {
                            continue;
                        }
                        
                        if (line.Split(separator)[0] == "Plane")
                        {
                            plane = new Plane(line.Split(separator)[1]);
                        }
                        else if (line.Split(separator)[0] == "Seaplane")
                        {
                            plane = new Seaplane(line.Split(separator)[1]);
                        }
                        var result = aerodromeStages[key] + plane;
                        if (result < -1)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
        }
    }
}
