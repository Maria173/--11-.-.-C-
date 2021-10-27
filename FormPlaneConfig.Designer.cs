namespace WindowsFormsPlanes
{
    partial class FormPlaneConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.groupBoxParametrs = new System.Windows.Forms.GroupBox();
			this.checkBoxScrewSpoiler = new System.Windows.Forms.CheckBox();
			this.labelMaxSpeed = new System.Windows.Forms.Label();
			this.checkBoxBottomSpoiler = new System.Windows.Forms.CheckBox();
			this.labelWeight = new System.Windows.Forms.Label();
			this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownMaxSpeed = new System.Windows.Forms.NumericUpDown();
			this.pictureBoxPlane = new System.Windows.Forms.PictureBox();
			this.groupBoxTypes = new System.Windows.Forms.GroupBox();
			this.labelSeaplane = new System.Windows.Forms.Label();
			this.labelPlane = new System.Windows.Forms.Label();
			this.panelPlane = new System.Windows.Forms.Panel();
			this.panelColorRed = new System.Windows.Forms.Panel();
			this.panelColorYellow = new System.Windows.Forms.Panel();
			this.panelColorBlack = new System.Windows.Forms.Panel();
			this.panelColorWhite = new System.Windows.Forms.Panel();
			this.panelColorGrey = new System.Windows.Forms.Panel();
			this.panelColorPink = new System.Windows.Forms.Panel();
			this.panelColorGreen = new System.Windows.Forms.Panel();
			this.panelColorBlue = new System.Windows.Forms.Panel();
			this.groupBoxColors = new System.Windows.Forms.GroupBox();
			this.labelDopColor = new System.Windows.Forms.Label();
			this.labelMainColor = new System.Windows.Forms.Label();
			this.buttonOk = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.groupBoxParametrs.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlane)).BeginInit();
			this.groupBoxTypes.SuspendLayout();
			this.panelPlane.SuspendLayout();
			this.groupBoxColors.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxParametrs
			// 
			this.groupBoxParametrs.Controls.Add(this.checkBoxScrewSpoiler);
			this.groupBoxParametrs.Controls.Add(this.labelMaxSpeed);
			this.groupBoxParametrs.Controls.Add(this.checkBoxBottomSpoiler);
			this.groupBoxParametrs.Controls.Add(this.labelWeight);
			this.groupBoxParametrs.Controls.Add(this.numericUpDownWeight);
			this.groupBoxParametrs.Controls.Add(this.numericUpDownMaxSpeed);
			this.groupBoxParametrs.Location = new System.Drawing.Point(12, 157);
			this.groupBoxParametrs.Name = "groupBoxParametrs";
			this.groupBoxParametrs.Size = new System.Drawing.Size(274, 118);
			this.groupBoxParametrs.TabIndex = 0;
			this.groupBoxParametrs.TabStop = false;
			this.groupBoxParametrs.Text = "Параметры";
			// 
			// checkBoxScrewSpoiler
			// 
			this.checkBoxScrewSpoiler.AutoSize = true;
			this.checkBoxScrewSpoiler.Checked = true;
			this.checkBoxScrewSpoiler.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxScrewSpoiler.Location = new System.Drawing.Point(155, 78);
			this.checkBoxScrewSpoiler.Name = "checkBoxScrewSpoiler";
			this.checkBoxScrewSpoiler.Size = new System.Drawing.Size(50, 17);
			this.checkBoxScrewSpoiler.TabIndex = 6;
			this.checkBoxScrewSpoiler.Text = "Винт";
			this.checkBoxScrewSpoiler.UseVisualStyleBackColor = true;
			// 
			// labelMaxSpeed
			// 
			this.labelMaxSpeed.AutoSize = true;
			this.labelMaxSpeed.Location = new System.Drawing.Point(6, 24);
			this.labelMaxSpeed.Name = "labelMaxSpeed";
			this.labelMaxSpeed.Size = new System.Drawing.Size(87, 13);
			this.labelMaxSpeed.TabIndex = 1;
			this.labelMaxSpeed.Text = "Макс, скорость";
			// 
			// checkBoxBottomSpoiler
			// 
			this.checkBoxBottomSpoiler.AutoSize = true;
			this.checkBoxBottomSpoiler.Checked = true;
			this.checkBoxBottomSpoiler.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxBottomSpoiler.Location = new System.Drawing.Point(155, 55);
			this.checkBoxBottomSpoiler.Name = "checkBoxBottomSpoiler";
			this.checkBoxBottomSpoiler.Size = new System.Drawing.Size(76, 17);
			this.checkBoxBottomSpoiler.TabIndex = 5;
			this.checkBoxBottomSpoiler.Text = "Поплавки";
			this.checkBoxBottomSpoiler.UseVisualStyleBackColor = true;
			// 
			// labelWeight
			// 
			this.labelWeight.AutoSize = true;
			this.labelWeight.Location = new System.Drawing.Point(6, 79);
			this.labelWeight.Name = "labelWeight";
			this.labelWeight.Size = new System.Drawing.Size(78, 13);
			this.labelWeight.TabIndex = 2;
			this.labelWeight.Text = "Вес самолета";
			// 
			// numericUpDownWeight
			// 
			this.numericUpDownWeight.Location = new System.Drawing.Point(31, 98);
			this.numericUpDownWeight.Name = "numericUpDownWeight";
			this.numericUpDownWeight.Size = new System.Drawing.Size(75, 20);
			this.numericUpDownWeight.TabIndex = 4;
			this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// numericUpDownMaxSpeed
			// 
			this.numericUpDownMaxSpeed.Location = new System.Drawing.Point(31, 40);
			this.numericUpDownMaxSpeed.Name = "numericUpDownMaxSpeed";
			this.numericUpDownMaxSpeed.Size = new System.Drawing.Size(75, 20);
			this.numericUpDownMaxSpeed.TabIndex = 3;
			this.numericUpDownMaxSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// pictureBoxPlane
			// 
			this.pictureBoxPlane.Location = new System.Drawing.Point(20, 14);
			this.pictureBoxPlane.Name = "pictureBoxPlane";
			this.pictureBoxPlane.Size = new System.Drawing.Size(211, 100);
			this.pictureBoxPlane.TabIndex = 1;
			this.pictureBoxPlane.TabStop = false;
			// 
			// groupBoxTypes
			// 
			this.groupBoxTypes.Controls.Add(this.labelSeaplane);
			this.groupBoxTypes.Controls.Add(this.labelPlane);
			this.groupBoxTypes.Location = new System.Drawing.Point(12, 13);
			this.groupBoxTypes.Name = "groupBoxTypes";
			this.groupBoxTypes.Size = new System.Drawing.Size(129, 129);
			this.groupBoxTypes.TabIndex = 2;
			this.groupBoxTypes.TabStop = false;
			this.groupBoxTypes.Text = "Тип самолета";
			// 
			// labelSeaplane
			// 
			this.labelSeaplane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelSeaplane.Location = new System.Drawing.Point(6, 71);
			this.labelSeaplane.Name = "labelSeaplane";
			this.labelSeaplane.Size = new System.Drawing.Size(100, 23);
			this.labelSeaplane.TabIndex = 1;
			this.labelSeaplane.Text = "Гидросамолет";
			this.labelSeaplane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelSeaplane_MouseDown);
			// 
			// labelPlane
			// 
			this.labelPlane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelPlane.Location = new System.Drawing.Point(6, 25);
			this.labelPlane.Name = "labelPlane";
			this.labelPlane.Size = new System.Drawing.Size(100, 35);
			this.labelPlane.TabIndex = 0;
			this.labelPlane.Text = "Обычный самолет";
			this.labelPlane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelPlane_MouseDown);
			// 
			// panelPlane
			// 
			this.panelPlane.AllowDrop = true;
			this.panelPlane.Controls.Add(this.pictureBoxPlane);
			this.panelPlane.Location = new System.Drawing.Point(158, 13);
			this.panelPlane.Name = "panelPlane";
			this.panelPlane.Size = new System.Drawing.Size(252, 129);
			this.panelPlane.TabIndex = 3;
			this.panelPlane.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelPlane_DragDrop);
			this.panelPlane.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelPlane_DragEnter);
			// 
			// panelColorRed
			// 
			this.panelColorRed.BackColor = System.Drawing.Color.Red;
			this.panelColorRed.Location = new System.Drawing.Point(6, 75);
			this.panelColorRed.Name = "panelColorRed";
			this.panelColorRed.Size = new System.Drawing.Size(48, 40);
			this.panelColorRed.TabIndex = 4;
			this.panelColorRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panelColorYellow
			// 
			this.panelColorYellow.BackColor = System.Drawing.Color.Yellow;
			this.panelColorYellow.Location = new System.Drawing.Point(74, 75);
			this.panelColorYellow.Name = "panelColorYellow";
			this.panelColorYellow.Size = new System.Drawing.Size(45, 40);
			this.panelColorYellow.TabIndex = 5;
			this.panelColorYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panelColorBlack
			// 
			this.panelColorBlack.BackColor = System.Drawing.Color.Black;
			this.panelColorBlack.Location = new System.Drawing.Point(138, 75);
			this.panelColorBlack.Name = "panelColorBlack";
			this.panelColorBlack.Size = new System.Drawing.Size(46, 40);
			this.panelColorBlack.TabIndex = 6;
			this.panelColorBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panelColorWhite
			// 
			this.panelColorWhite.BackColor = System.Drawing.Color.White;
			this.panelColorWhite.Location = new System.Drawing.Point(202, 75);
			this.panelColorWhite.Name = "panelColorWhite";
			this.panelColorWhite.Size = new System.Drawing.Size(44, 40);
			this.panelColorWhite.TabIndex = 7;
			this.panelColorWhite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panelColorGrey
			// 
			this.panelColorGrey.BackColor = System.Drawing.Color.Gray;
			this.panelColorGrey.Location = new System.Drawing.Point(6, 125);
			this.panelColorGrey.Name = "panelColorGrey";
			this.panelColorGrey.Size = new System.Drawing.Size(48, 43);
			this.panelColorGrey.TabIndex = 8;
			this.panelColorGrey.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panelColorPink
			// 
			this.panelColorPink.BackColor = System.Drawing.Color.Pink;
			this.panelColorPink.Location = new System.Drawing.Point(74, 125);
			this.panelColorPink.Name = "panelColorPink";
			this.panelColorPink.Size = new System.Drawing.Size(45, 43);
			this.panelColorPink.TabIndex = 9;
			this.panelColorPink.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panelColorGreen
			// 
			this.panelColorGreen.BackColor = System.Drawing.Color.Green;
			this.panelColorGreen.Location = new System.Drawing.Point(138, 125);
			this.panelColorGreen.Name = "panelColorGreen";
			this.panelColorGreen.Size = new System.Drawing.Size(46, 43);
			this.panelColorGreen.TabIndex = 10;
			this.panelColorGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panelColorBlue
			// 
			this.panelColorBlue.BackColor = System.Drawing.Color.Blue;
			this.panelColorBlue.Location = new System.Drawing.Point(202, 125);
			this.panelColorBlue.Name = "panelColorBlue";
			this.panelColorBlue.Size = new System.Drawing.Size(44, 43);
			this.panelColorBlue.TabIndex = 11;
			this.panelColorBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// groupBoxColors
			// 
			this.groupBoxColors.Controls.Add(this.labelDopColor);
			this.groupBoxColors.Controls.Add(this.labelMainColor);
			this.groupBoxColors.Controls.Add(this.panelColorBlack);
			this.groupBoxColors.Controls.Add(this.panelColorBlue);
			this.groupBoxColors.Controls.Add(this.panelColorRed);
			this.groupBoxColors.Controls.Add(this.panelColorGreen);
			this.groupBoxColors.Controls.Add(this.panelColorYellow);
			this.groupBoxColors.Controls.Add(this.panelColorPink);
			this.groupBoxColors.Controls.Add(this.panelColorWhite);
			this.groupBoxColors.Controls.Add(this.panelColorGrey);
			this.groupBoxColors.Location = new System.Drawing.Point(431, 12);
			this.groupBoxColors.Name = "groupBoxColors";
			this.groupBoxColors.Size = new System.Drawing.Size(251, 174);
			this.groupBoxColors.TabIndex = 12;
			this.groupBoxColors.TabStop = false;
			this.groupBoxColors.Text = "Цвета";
			// 
			// labelDopColor
			// 
			this.labelDopColor.AllowDrop = true;
			this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelDopColor.Location = new System.Drawing.Point(135, 27);
			this.labelDopColor.Name = "labelDopColor";
			this.labelDopColor.Size = new System.Drawing.Size(100, 23);
			this.labelDopColor.TabIndex = 13;
			this.labelDopColor.Text = "Доп. цвет";
			this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
			this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
			// 
			// labelMainColor
			// 
			this.labelMainColor.AllowDrop = true;
			this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelMainColor.Location = new System.Drawing.Point(6, 27);
			this.labelMainColor.Name = "labelMainColor";
			this.labelMainColor.Size = new System.Drawing.Size(100, 23);
			this.labelMainColor.TabIndex = 12;
			this.labelMainColor.Text = "Осн. цвет";
			this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragDrop);
			this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
			// 
			// buttonOk
			// 
			this.buttonOk.Location = new System.Drawing.Point(591, 206);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(75, 23);
			this.buttonOk.TabIndex = 13;
			this.buttonOk.Text = "Добавить";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(591, 236);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 14;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// FormPlaneConfig
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(696, 286);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.groupBoxColors);
			this.Controls.Add(this.groupBoxTypes);
			this.Controls.Add(this.groupBoxParametrs);
			this.Controls.Add(this.panelPlane);
			this.Name = "FormPlaneConfig";
			this.Text = "FormPlaneConfig";
			this.groupBoxParametrs.ResumeLayout(false);
			this.groupBoxParametrs.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlane)).EndInit();
			this.groupBoxTypes.ResumeLayout(false);
			this.panelPlane.ResumeLayout(false);
			this.groupBoxColors.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxParametrs;
        private System.Windows.Forms.CheckBox checkBoxScrewSpoiler;
        private System.Windows.Forms.Label labelMaxSpeed;
        private System.Windows.Forms.CheckBox checkBoxBottomSpoiler;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxSpeed;
        private System.Windows.Forms.PictureBox pictureBoxPlane;
        private System.Windows.Forms.GroupBox groupBoxTypes;
        private System.Windows.Forms.Label labelSeaplane;
        private System.Windows.Forms.Label labelPlane;
        private System.Windows.Forms.Panel panelPlane;
        private System.Windows.Forms.Panel panelColorRed;
        private System.Windows.Forms.Panel panelColorYellow;
        private System.Windows.Forms.Panel panelColorBlack;
        private System.Windows.Forms.Panel panelColorWhite;
        private System.Windows.Forms.Panel panelColorGrey;
        private System.Windows.Forms.Panel panelColorPink;
        private System.Windows.Forms.Panel panelColorGreen;
        private System.Windows.Forms.Panel panelColorBlue;
        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelMainColor;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}