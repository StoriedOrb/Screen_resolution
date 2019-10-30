using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Screen_resolution
{
    public partial class WinSize : Form
    {
        public WinSize()
        {
            InitializeComponent();
        }

        private void Left_Top_corner_Click(object sender, EventArgs e)
        {
            Left = 0;
            Top = 0;
        }

        private void Centering_Click(object sender, EventArgs e)
        {
            int s = Screen.AllScreens.ElementAt(0).WorkingArea.Width;
            this.Left = s / 2 - this.Width / 2;

            int a = Screen.AllScreens.ElementAt(0).WorkingArea.Height;
            this.Top = a / 2 - this.Height / 2;
        }

        private void Right_Top_corner_Click(object sender, EventArgs e)
        {
            this.Top = 0;
            int s = Screen.AllScreens.ElementAt(0).WorkingArea.Width;
            this.Left = s - this.Width;
        }

        private void Left_low_corner_Click(object sender, EventArgs e)
        {
            Left = 0;

            int a = Screen.AllScreens.ElementAt(0).WorkingArea.Height;
            this.Top = a - this.Height;
        }

        private void Right_low_corner_Click(object sender, EventArgs e)
        {
            int s = Screen.AllScreens.ElementAt(0).WorkingArea.Width;
            this.Left = s - this.Width;

            int a = Screen.AllScreens.ElementAt(0).WorkingArea.Height;
            this.Top = a - this.Height;
        }

        private void WinSize_Load(object sender, EventArgs e)
        {
            ToolTip w = new ToolTip();
            w.SetToolTip(Max_size_window, "На весь экран");

            ToolTip f = new ToolTip();
            f.SetToolTip(Restart, "Вернуть в исходное положение");

            ToolTip r = new ToolTip();
            r.SetToolTip(Minus_resolution, "Уменьшить");

            ToolTip t = new ToolTip();
            t.SetToolTip(Plus_resolution, "Увеличить");

            ToolTip y = new ToolTip();
            y.SetToolTip(Centering, "Переместить окно в центр экрана");

            ToolTip u = new ToolTip();
            u.SetToolTip(Right_Top_corner, "Переместить окно в правый верхний угол экрана");

            ToolTip i = new ToolTip();
            i.SetToolTip(Right_low_corner, "Переместить окно в правый нижний угол экрана");

            ToolTip o = new ToolTip();
            o.SetToolTip(Left_low_corner, "Переместить окно в левый нижний угол экрана");

            ToolTip p = new ToolTip();
            p.SetToolTip(Left_Top_corner, "Переместить окно в левый верхний угол экрана");

            ToolTip a = new ToolTip();
            a.SetToolTip(Min_size_window, "Свернуть");

            ToolTip g = new ToolTip();
            g.SetToolTip(Move, "Перемещение окна");

            ToolTip z = new ToolTip();
            z.SetToolTip(ResolutionAll, "Разрешение окна");

            ToolTip x = new ToolTip();
            x.SetToolTip(Menu, "Дополнительное меню");

            ToolTip b = new ToolTip();
            b.SetToolTip(Exit, "Закрытие программы");

            this.ControlBox = false;

            this.Text = "";
        }

        private void Min_size_window_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Max_size_window_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Height = 392;
            this.Width = 723;
        }

        private void Resolution_Click(object sender, EventArgs e)
        {
            this.Height = 500;
            this.Width = 800;
        }

        private void Minus_resolution_Click(object sender, EventArgs e)
        {
            this.Height = this.Height - 25;
            this.Width = this.Width - 25;
        }

        private void Plus_resolution_Click(object sender, EventArgs e)
        {
            this.Height = this.Height + 25;
            this.Width = this.Width + 25;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
