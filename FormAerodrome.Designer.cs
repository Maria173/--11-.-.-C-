﻿namespace WindowsFormsPlanes
{
    partial class FormAerodrome
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
			this.pictureBoxAerodrome = new System.Windows.Forms.PictureBox();
			this.buttonSetPlane = new System.Windows.Forms.Button();
			this.groupBoxRemovePlane = new System.Windows.Forms.GroupBox();
			this.labelPlace = new System.Windows.Forms.Label();
			this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.buttonTakePlane = new System.Windows.Forms.Button();
			this.textBoxNewLevelName = new System.Windows.Forms.TextBox();
			this.labelAerodromes = new System.Windows.Forms.Label();
			this.listBoxAerodrome = new System.Windows.Forms.ListBox();
			this.buttonAddAerodrome = new System.Windows.Forms.Button();
			this.buttonDelAerodrome = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAerodrome)).BeginInit();
			this.groupBoxRemovePlane.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBoxAerodrome
			// 
			this.pictureBoxAerodrome.Location = new System.Drawing.Point(0, 0);
			this.pictureBoxAerodrome.Name = "pictureBoxAerodrome";
			this.pictureBoxAerodrome.Size = new System.Drawing.Size(625, 508);
			this.pictureBoxAerodrome.TabIndex = 0;
			this.pictureBoxAerodrome.TabStop = false;
			// 
			// buttonSetPlane
			// 
			this.buttonSetPlane.Location = new System.Drawing.Point(631, 278);
			this.buttonSetPlane.Name = "buttonSetPlane";
			this.buttonSetPlane.Size = new System.Drawing.Size(165, 51);
			this.buttonSetPlane.TabIndex = 1;
			this.buttonSetPlane.Text = "Добавить самолет";
			this.buttonSetPlane.UseVisualStyleBackColor = true;
			this.buttonSetPlane.Click += new System.EventHandler(this.buttonSetPlane_Click);
			// 
			// groupBoxRemovePlane
			// 
			this.groupBoxRemovePlane.Controls.Add(this.labelPlace);
			this.groupBoxRemovePlane.Controls.Add(this.maskedTextBox);
			this.groupBoxRemovePlane.Controls.Add(this.buttonTakePlane);
			this.groupBoxRemovePlane.Location = new System.Drawing.Point(631, 354);
			this.groupBoxRemovePlane.Name = "groupBoxRemovePlane";
			this.groupBoxRemovePlane.Size = new System.Drawing.Size(164, 97);
			this.groupBoxRemovePlane.TabIndex = 3;
			this.groupBoxRemovePlane.TabStop = false;
			this.groupBoxRemovePlane.Text = "Отогнать самолет";
			// 
			// labelPlace
			// 
			this.labelPlace.AutoSize = true;
			this.labelPlace.Location = new System.Drawing.Point(22, 40);
			this.labelPlace.Name = "labelPlace";
			this.labelPlace.Size = new System.Drawing.Size(42, 13);
			this.labelPlace.TabIndex = 2;
			this.labelPlace.Text = "Место:";
			// 
			// maskedTextBox
			// 
			this.maskedTextBox.Location = new System.Drawing.Point(70, 37);
			this.maskedTextBox.Name = "maskedTextBox";
			this.maskedTextBox.Size = new System.Drawing.Size(73, 20);
			this.maskedTextBox.TabIndex = 1;
			// 
			// buttonTakePlane
			// 
			this.buttonTakePlane.Location = new System.Drawing.Point(25, 73);
			this.buttonTakePlane.Name = "buttonTakePlane";
			this.buttonTakePlane.Size = new System.Drawing.Size(118, 23);
			this.buttonTakePlane.TabIndex = 0;
			this.buttonTakePlane.Text = "Отогнать";
			this.buttonTakePlane.UseVisualStyleBackColor = true;
			this.buttonTakePlane.Click += new System.EventHandler(this.buttonTakePlane_Click);
			// 
			// textBoxNewLevelName
			// 
			this.textBoxNewLevelName.Location = new System.Drawing.Point(656, 30);
			this.textBoxNewLevelName.Name = "textBoxNewLevelName";
			this.textBoxNewLevelName.Size = new System.Drawing.Size(118, 20);
			this.textBoxNewLevelName.TabIndex = 4;
			// 
			// labelAerodromes
			// 
			this.labelAerodromes.AutoSize = true;
			this.labelAerodromes.Location = new System.Drawing.Point(678, 9);
			this.labelAerodromes.Name = "labelAerodromes";
			this.labelAerodromes.Size = new System.Drawing.Size(69, 13);
			this.labelAerodromes.TabIndex = 5;
			this.labelAerodromes.Text = "Аэродромы:";
			// 
			// listBoxAerodrome
			// 
			this.listBoxAerodrome.FormattingEnabled = true;
			this.listBoxAerodrome.Location = new System.Drawing.Point(656, 102);
			this.listBoxAerodrome.Name = "listBoxAerodrome";
			this.listBoxAerodrome.Size = new System.Drawing.Size(118, 121);
			this.listBoxAerodrome.TabIndex = 6;
			this.listBoxAerodrome.SelectedIndexChanged += new System.EventHandler(this.listBoxAerodrome_SelectedIndexChanged);
			// 
			// buttonAddAerodrome
			// 
			this.buttonAddAerodrome.Location = new System.Drawing.Point(630, 73);
			this.buttonAddAerodrome.Name = "buttonAddAerodrome";
			this.buttonAddAerodrome.Size = new System.Drawing.Size(164, 23);
			this.buttonAddAerodrome.TabIndex = 7;
			this.buttonAddAerodrome.Text = "Добавить аэродром";
			this.buttonAddAerodrome.UseVisualStyleBackColor = true;
			this.buttonAddAerodrome.Click += new System.EventHandler(this.buttonAddAerodrome_Click);
			// 
			// buttonDelAerodrome
			// 
			this.buttonDelAerodrome.Location = new System.Drawing.Point(630, 229);
			this.buttonDelAerodrome.Name = "buttonDelAerodrome";
			this.buttonDelAerodrome.Size = new System.Drawing.Size(164, 23);
			this.buttonDelAerodrome.TabIndex = 8;
			this.buttonDelAerodrome.Text = "Удалить аэродром";
			this.buttonDelAerodrome.UseVisualStyleBackColor = true;
			this.buttonDelAerodrome.Click += new System.EventHandler(this.buttonDelAerodrome_Click);
			// 
			// FormAerodrome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 507);
			this.Controls.Add(this.buttonDelAerodrome);
			this.Controls.Add(this.buttonAddAerodrome);
			this.Controls.Add(this.listBoxAerodrome);
			this.Controls.Add(this.labelAerodromes);
			this.Controls.Add(this.textBoxNewLevelName);
			this.Controls.Add(this.groupBoxRemovePlane);
			this.Controls.Add(this.buttonSetPlane);
			this.Controls.Add(this.pictureBoxAerodrome);
			this.Name = "FormAerodrome";
			this.Text = "Аэродром";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAerodrome)).EndInit();
			this.groupBoxRemovePlane.ResumeLayout(false);
			this.groupBoxRemovePlane.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAerodrome;
        private System.Windows.Forms.Button buttonSetPlane;
        private System.Windows.Forms.GroupBox groupBoxRemovePlane;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Button buttonTakePlane;
        private System.Windows.Forms.TextBox textBoxNewLevelName;
        private System.Windows.Forms.Label labelAerodromes;
        private System.Windows.Forms.ListBox listBoxAerodrome;
        private System.Windows.Forms.Button buttonAddAerodrome;
        private System.Windows.Forms.Button buttonDelAerodrome;
    }
}