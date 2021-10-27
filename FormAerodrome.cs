using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPlanes
{
    public partial class FormAerodrome : Form
    {
        /// Объект от класса-коллекции аэродромов
        private readonly AerodromeCollection aerodromeCollection;
        public FormAerodrome()
        {
            InitializeComponent();
            aerodromeCollection = new AerodromeCollection(pictureBoxAerodrome.Width, pictureBoxAerodrome.Height);
        }

        /// Заполнение listBoxAerodrome
        private void ReloadLevels()
        {
            int index = listBoxAerodrome.SelectedIndex;
            listBoxAerodrome.Items.Clear();
            for (int i = 0; i < aerodromeCollection.Keys.Count; i++)
            {
                listBoxAerodrome.Items.Add(aerodromeCollection.Keys[i]);
            }
            if (listBoxAerodrome.Items.Count > 0 && (index == -1 || index >=
           listBoxAerodrome.Items.Count))
            {
                listBoxAerodrome.SelectedIndex = 0;
            }
            else if (listBoxAerodrome.Items.Count > 0 && index > -1 && index <
           listBoxAerodrome.Items.Count)
            {
                listBoxAerodrome.SelectedIndex = index;
            }
        }

        /// Метод отрисовки аэродрома
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxAerodrome.Width, pictureBoxAerodrome.Height);
            Graphics gr = Graphics.FromImage(bmp);
            if (listBoxAerodrome.SelectedIndex > -1)
            {
                aerodromeCollection[listBoxAerodrome.SelectedItem.ToString()].Draw(gr);
            }
            pictureBoxAerodrome.Image = bmp;
  
        }

        /// Обработка нажатия кнопки "Добавить парковку"
        private void buttonAddAerodrome_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNewLevelName.Text))
            {
                MessageBox.Show("Введите название парковки", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            aerodromeCollection.AddAerodrome(textBoxNewLevelName.Text);
            ReloadLevels();
        }

        /// Обработка нажатия кнопки "Удалить парковку"
        private void buttonDelAerodrome_Click(object sender, EventArgs e)
        {
            if (listBoxAerodrome.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить парковку{ listBoxAerodrome.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    aerodromeCollection.DelAerodrome(listBoxAerodrome.SelectedItem.ToString());
                    ReloadLevels();
                }
                Draw();
            }
        }

        /// Обработка нажатия кнопки "Поставить самолет"
        private void buttonSetPlane_Click(object sender, EventArgs e)
        {
            var formPlaneConfig = new FormPlaneConfig();
            formPlaneConfig.AddEvent(AddPlane);
            formPlaneConfig.Show();
        }

        private void AddPlane(Vehicle plane) {
            if (plane != null && listBoxAerodrome.SelectedIndex > -1)
            {
                if ((aerodromeCollection[listBoxAerodrome.SelectedItem.ToString()] + plane) > -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Парковка переполнена");
                }
            }
        }

        /// Обработка нажатия кнопки "Отогнать"
            private void buttonTakePlane_Click(object sender, EventArgs e)
        {
            if (listBoxAerodrome.SelectedIndex > -1 && maskedTextBox.Text != "")
            {
                var plane = aerodromeCollection[listBoxAerodrome.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBox.Text);
                if (plane != null)
                {
                    FormPlane form = new FormPlane();
                    form.SetPlane(plane);
                    form.ShowDialog();
                }
                Draw();
            }

        }

        /// Метод обработки выбора элемента на listBoxAerodrome
        private void listBoxAerodrome_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }

    }
}
