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
        /// Объект от класса-аэродрома
        private readonly Aerodrome<Plane> aerodrome;
        public FormAerodrome()
        {
            InitializeComponent();
            aerodrome = new Aerodrome<Plane>(pictureBoxAerodrome.Width, pictureBoxAerodrome.Height);
            Draw();
        }

        /// Метод отрисовки аэродрома
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxAerodrome.Width, pictureBoxAerodrome.Height);
            Graphics gr = Graphics.FromImage(bmp);
            aerodrome.Draw(gr);
            pictureBoxAerodrome.Image = bmp;
        }

        /// Обработка нажатия кнопки "Поставить самолет"
        private void buttonSetPlane_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var plane = new Plane(100, 1000, dialog.Color);
                if (aerodrome + plane > -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Аэродром переполнен");
                }
            }
        }

        /// Обработка нажатия кнопки "Поставить гидросамолет"
        private void buttonSetSeaplane_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var plane = new Seaplane(100, 1000, dialog.Color, dialogDop.Color,
                   true, true);
                    if (aerodrome + plane > -1)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Аэродром переполнен");
                    }
                }
            }
        }

        /// Обработка нажатия кнопки "Отогнать"
        private void buttonTakePlane_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "")
            {
                var plane = aerodrome - Convert.ToInt32(maskedTextBox.Text);
                if (plane != null)
                {
                    FormPlane form = new FormPlane();
                    form.SetPlane(plane);
                    form.ShowDialog();
                }
                Draw();
            }
        }
    }
}
