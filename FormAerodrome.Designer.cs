namespace WindowsFormsPlanes
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
			this.buttonSetSeaplane = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.buttonTakePlane = new System.Windows.Forms.Button();
			this.textBoxNewLevelName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.listBoxAerodrome = new System.Windows.Forms.ListBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAerodrome)).BeginInit();
			this.groupBox1.SuspendLayout();
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
			this.buttonSetPlane.Location = new System.Drawing.Point(630, 274);
			this.buttonSetPlane.Name = "buttonSetPlane";
			this.buttonSetPlane.Size = new System.Drawing.Size(165, 23);
			this.buttonSetPlane.TabIndex = 1;
			this.buttonSetPlane.Text = "Поставить самолет";
			this.buttonSetPlane.UseVisualStyleBackColor = true;
			this.buttonSetPlane.Click += new System.EventHandler(this.buttonSetPlane_Click);
			// 
			// buttonSetSeaplane
			// 
			this.buttonSetSeaplane.Location = new System.Drawing.Point(630, 303);
			this.buttonSetSeaplane.Name = "buttonSetSeaplane";
			this.buttonSetSeaplane.Size = new System.Drawing.Size(165, 23);
			this.buttonSetSeaplane.TabIndex = 2;
			this.buttonSetSeaplane.Text = "Поставить гидросамолет";
			this.buttonSetSeaplane.UseVisualStyleBackColor = true;
			this.buttonSetSeaplane.Click += new System.EventHandler(this.buttonSetSeaplane_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.maskedTextBox);
			this.groupBox1.Controls.Add(this.buttonTakePlane);
			this.groupBox1.Location = new System.Drawing.Point(631, 354);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(164, 97);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Отогнать самолет";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Место:";
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
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(678, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Аэродромы:";
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
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(630, 73);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(164, 23);
			this.button1.TabIndex = 7;
			this.button1.Text = "Добавить аэродром";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.buttonAddAerodrome_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(630, 229);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(164, 23);
			this.button2.TabIndex = 8;
			this.button2.Text = "Удалить аэродром";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.buttonDelAerodrome_Click);
			// 
			// FormAerodrome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 507);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.listBoxAerodrome);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxNewLevelName);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.buttonSetSeaplane);
			this.Controls.Add(this.buttonSetPlane);
			this.Controls.Add(this.pictureBoxAerodrome);
			this.Name = "FormAerodrome";
			this.Text = "Аэродром";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAerodrome)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAerodrome;
        private System.Windows.Forms.Button buttonSetPlane;
        private System.Windows.Forms.Button buttonSetSeaplane;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Button buttonTakePlane;
        private System.Windows.Forms.TextBox textBoxNewLevelName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxAerodrome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}