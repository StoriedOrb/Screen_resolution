namespace Screen_resolution
{
    partial class WinSize
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinSize));
            this.Move = new System.Windows.Forms.GroupBox();
            this.Right_low_corner = new System.Windows.Forms.Button();
            this.Left_low_corner = new System.Windows.Forms.Button();
            this.Left_Top_corner = new System.Windows.Forms.Button();
            this.Centering = new System.Windows.Forms.Button();
            this.Right_Top_corner = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ResolutionAll = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Minus_resolution = new System.Windows.Forms.Button();
            this.Plus_resolution = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.GroupBox();
            this.Exit = new System.Windows.Forms.Button();
            this.Min_size_window = new System.Windows.Forms.Button();
            this.Max_size_window = new System.Windows.Forms.Button();
            this.Restart = new System.Windows.Forms.Button();
            this.Resolution = new System.Windows.Forms.Button();
            this.Move.SuspendLayout();
            this.ResolutionAll.SuspendLayout();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Move
            // 
            this.Move.BackColor = System.Drawing.Color.Orange;
            this.Move.Controls.Add(this.Right_low_corner);
            this.Move.Controls.Add(this.Left_low_corner);
            this.Move.Controls.Add(this.Left_Top_corner);
            this.Move.Controls.Add(this.Centering);
            this.Move.Controls.Add(this.Right_Top_corner);
            this.Move.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Move.Location = new System.Drawing.Point(32, 27);
            this.Move.Name = "Move";
            this.Move.Size = new System.Drawing.Size(300, 287);
            this.Move.TabIndex = 0;
            this.Move.TabStop = false;
            this.Move.Text = "Перемещение";
            // 
            // Right_low_corner
            // 
            this.Right_low_corner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Right_low_corner.BackgroundImage")));
            this.Right_low_corner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Right_low_corner.Location = new System.Drawing.Point(217, 200);
            this.Right_low_corner.Name = "Right_low_corner";
            this.Right_low_corner.Size = new System.Drawing.Size(58, 55);
            this.Right_low_corner.TabIndex = 9;
            this.Right_low_corner.UseVisualStyleBackColor = true;
            this.Right_low_corner.Click += new System.EventHandler(this.Right_low_corner_Click);
            // 
            // Left_low_corner
            // 
            this.Left_low_corner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Left_low_corner.BackgroundImage")));
            this.Left_low_corner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Left_low_corner.Location = new System.Drawing.Point(18, 200);
            this.Left_low_corner.Name = "Left_low_corner";
            this.Left_low_corner.Size = new System.Drawing.Size(58, 55);
            this.Left_low_corner.TabIndex = 8;
            this.Left_low_corner.UseVisualStyleBackColor = true;
            this.Left_low_corner.Click += new System.EventHandler(this.Left_low_corner_Click);
            // 
            // Left_Top_corner
            // 
            this.Left_Top_corner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Left_Top_corner.BackgroundImage")));
            this.Left_Top_corner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Left_Top_corner.Location = new System.Drawing.Point(18, 30);
            this.Left_Top_corner.Name = "Left_Top_corner";
            this.Left_Top_corner.Size = new System.Drawing.Size(58, 55);
            this.Left_Top_corner.TabIndex = 7;
            this.Left_Top_corner.UseVisualStyleBackColor = true;
            this.Left_Top_corner.Click += new System.EventHandler(this.Left_Top_corner_Click);
            // 
            // Centering
            // 
            this.Centering.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Centering.BackgroundImage")));
            this.Centering.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Centering.Location = new System.Drawing.Point(106, 103);
            this.Centering.Name = "Centering";
            this.Centering.Size = new System.Drawing.Size(82, 80);
            this.Centering.TabIndex = 1;
            this.Centering.UseVisualStyleBackColor = true;
            this.Centering.Click += new System.EventHandler(this.Centering_Click);
            // 
            // Right_Top_corner
            // 
            this.Right_Top_corner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Right_Top_corner.BackgroundImage")));
            this.Right_Top_corner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Right_Top_corner.Location = new System.Drawing.Point(217, 29);
            this.Right_Top_corner.Name = "Right_Top_corner";
            this.Right_Top_corner.Size = new System.Drawing.Size(58, 55);
            this.Right_Top_corner.TabIndex = 0;
            this.Right_Top_corner.UseVisualStyleBackColor = true;
            this.Right_Top_corner.Click += new System.EventHandler(this.Right_Top_corner_Click);
            // 
            // ResolutionAll
            // 
            this.ResolutionAll.BackColor = System.Drawing.Color.YellowGreen;
            this.ResolutionAll.Controls.Add(this.Resolution);
            this.ResolutionAll.Controls.Add(this.groupBox3);
            this.ResolutionAll.Controls.Add(this.Minus_resolution);
            this.ResolutionAll.Controls.Add(this.Plus_resolution);
            this.ResolutionAll.Location = new System.Drawing.Point(392, 27);
            this.ResolutionAll.Name = "ResolutionAll";
            this.ResolutionAll.Size = new System.Drawing.Size(300, 105);
            this.ResolutionAll.TabIndex = 1;
            this.ResolutionAll.TabStop = false;
            this.ResolutionAll.Text = "Разрешение";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(201, 158);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 148);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // Minus_resolution
            // 
            this.Minus_resolution.Location = new System.Drawing.Point(21, 37);
            this.Minus_resolution.Name = "Minus_resolution";
            this.Minus_resolution.Size = new System.Drawing.Size(60, 39);
            this.Minus_resolution.TabIndex = 5;
            this.Minus_resolution.Text = "-";
            this.Minus_resolution.UseVisualStyleBackColor = true;
            this.Minus_resolution.Click += new System.EventHandler(this.Minus_resolution_Click);
            // 
            // Plus_resolution
            // 
            this.Plus_resolution.Location = new System.Drawing.Point(222, 38);
            this.Plus_resolution.Name = "Plus_resolution";
            this.Plus_resolution.Size = new System.Drawing.Size(60, 39);
            this.Plus_resolution.TabIndex = 4;
            this.Plus_resolution.Text = "+";
            this.Plus_resolution.UseVisualStyleBackColor = true;
            this.Plus_resolution.Click += new System.EventHandler(this.Plus_resolution_Click);
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.LightPink;
            this.Menu.Controls.Add(this.Exit);
            this.Menu.Controls.Add(this.Min_size_window);
            this.Menu.Controls.Add(this.Max_size_window);
            this.Menu.Controls.Add(this.Restart);
            this.Menu.Location = new System.Drawing.Point(392, 185);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(300, 129);
            this.Menu.TabIndex = 2;
            this.Menu.TabStop = false;
            this.Menu.Text = "Меню";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(173, 80);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(109, 38);
            this.Exit.TabIndex = 11;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Min_size_window
            // 
            this.Min_size_window.Location = new System.Drawing.Point(21, 19);
            this.Min_size_window.Name = "Min_size_window";
            this.Min_size_window.Size = new System.Drawing.Size(109, 36);
            this.Min_size_window.TabIndex = 10;
            this.Min_size_window.Text = "Свернуть";
            this.Min_size_window.UseVisualStyleBackColor = true;
            this.Min_size_window.Click += new System.EventHandler(this.Min_size_window_Click);
            // 
            // Max_size_window
            // 
            this.Max_size_window.Location = new System.Drawing.Point(21, 80);
            this.Max_size_window.Name = "Max_size_window";
            this.Max_size_window.Size = new System.Drawing.Size(109, 38);
            this.Max_size_window.TabIndex = 6;
            this.Max_size_window.Text = "На весь экран";
            this.Max_size_window.UseVisualStyleBackColor = true;
            this.Max_size_window.Click += new System.EventHandler(this.Max_size_window_Click);
            // 
            // Restart
            // 
            this.Restart.Location = new System.Drawing.Point(173, 19);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(109, 36);
            this.Restart.TabIndex = 3;
            this.Restart.Text = "Исходный размер";
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // Resolution
            // 
            this.Resolution.Location = new System.Drawing.Point(107, 37);
            this.Resolution.Name = "Resolution";
            this.Resolution.Size = new System.Drawing.Size(87, 39);
            this.Resolution.TabIndex = 7;
            this.Resolution.Text = "500х800";
            this.Resolution.UseVisualStyleBackColor = true;
            this.Resolution.Click += new System.EventHandler(this.Resolution_Click);
            // 
            // WinSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(707, 376);
            this.Controls.Add(this.ResolutionAll);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Move);
            this.Name = "WinSize";
            this.Text = "Screen Resolution";
            this.Load += new System.EventHandler(this.WinSize_Load);
            this.Move.ResumeLayout(false);
            this.ResolutionAll.ResumeLayout(false);
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Move;
        private System.Windows.Forms.Button Right_low_corner;
        private System.Windows.Forms.Button Left_low_corner;
        private System.Windows.Forms.Button Left_Top_corner;
        private System.Windows.Forms.Button Centering;
        private System.Windows.Forms.Button Right_Top_corner;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox ResolutionAll;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Minus_resolution;
        private System.Windows.Forms.Button Plus_resolution;
        private System.Windows.Forms.GroupBox Menu;
        private System.Windows.Forms.Button Min_size_window;
        private System.Windows.Forms.Button Max_size_window;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Resolution;
    }
}

