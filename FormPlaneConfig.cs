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
    public partial class FormPlaneConfig : Form
    {

        /// Переменная-выбранная машина
        Vehicle plane = null;

        /// Событие
        private Action<Vehicle> eventAddPlane;

        public FormPlaneConfig()
        {
            InitializeComponent();

            // привязать panelColor_MouseDown к панелям с цветами
            panelColorRed.MouseDown += panelColor_MouseDown;
            panelColorYellow.MouseDown += panelColor_MouseDown;
            panelColorBlack.MouseDown += panelColor_MouseDown;
            panelColorWhite.MouseDown += panelColor_MouseDown;
            panelColorGrey.MouseDown += panelColor_MouseDown;
            panelColorPink.MouseDown += panelColor_MouseDown;
            panelColorGreen.MouseDown += panelColor_MouseDown;
            panelColorBlue.MouseDown += panelColor_MouseDown;

            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        private void DrawPlane()
        {
            if (plane != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxPlane.Width, pictureBoxPlane.Height);
                Graphics gr = Graphics.FromImage(bmp);
                plane.SetPosition(5, 5, pictureBoxPlane.Width, pictureBoxPlane.Height);
                plane.DrawTransport(gr);
                pictureBoxPlane.Image = bmp;
            }
        }

        public void AddEvent(Action<Vehicle> ev)
        {
            if (eventAddPlane == null)
            {
                eventAddPlane = new Action<Vehicle>(ev);
            }
            else
            {
                eventAddPlane += ev;
            }
        }

        private void labelPlane_MouseDown(object sender, MouseEventArgs e)
        {
            labelPlane.DoDragDrop(labelPlane.Name, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelSeaplane_MouseDown(object sender, MouseEventArgs e)
        {
            labelSeaplane.DoDragDrop(labelSeaplane.Name, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panelPlane_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void panelPlane_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "labelPlane":
                    plane = new Plane((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.White);
                    break;
                case "labelSeaplane":
                    plane = new Seaplane((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.White, Color.Black,
                    checkBoxBottomSpoiler.Checked, checkBoxScrewSpoiler.Checked);
                    break;
            }
            DrawPlane();

        }

        /// Отправляем цвет с панели
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            // Прописать логику вызова dragDrop для панелей, используя sender
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        private void labelMainColor_DragEnter(object sender, DragEventArgs e)
        {
            // Прописать логику проверки приходящего значения на тип Color
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        /// Принимаем основной цвет
        private void labelMainColor_DragDrop(object sender, DragEventArgs e)
        {
            // Прописать логику смены базового цвета
            if (plane != null)
            {
                plane.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawPlane();
            }
        }

        /// Принимаем дополнительный цвет
        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            // Прописать логику смены дополнительного цвета, если объект является объектом дочернего класса
            if (plane != null)
            {
                if (plane is Seaplane)
                {
                    (plane as Seaplane).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawPlane();
                }
            }
        }

        /// Добавление машины
        private void buttonOk_Click(object sender, EventArgs e)
        {
            eventAddPlane?.Invoke(plane);
            Close();
        }
    }
}
