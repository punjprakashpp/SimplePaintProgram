using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pnt
{
    public partial class Pnt : Form
    {
        private Graphics draw;
        private int pen_x = -1, pen_y = -1;
        private bool pen_moving = false;
        private Pen pen_draw;

        public Pnt()
        {
            InitializeComponent();
            draw = panelDraw.CreateGraphics();
            draw.SmoothingMode = SmoothingMode.AntiAlias;
            pen_draw = new Pen(boxSelColor.BackColor, 3);
            pen_draw.StartCap = LineCap.Round;
            pen_draw.EndCap = LineCap.Round;
            txtLineSize.Text = pen_draw.Width.ToString();
        }

        private void btnMoreColor_Click(object sender, EventArgs e)
        {
            if (colorDialogBox.ShowDialog() == DialogResult.OK)
            {
                boxSelColor.BackColor = colorDialogBox.Color;
            }
        }

        private void btnWhite_Click(object sender, EventArgs e)
        {
            boxSelColor.BackColor = btnWhite.BackColor;
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            boxSelColor.BackColor = btnBlack.BackColor;
        }

        private void btnViolet_Click(object sender, EventArgs e)
        {
            boxSelColor.BackColor = btnViolet.BackColor;
        }

        private void btnPink_Click(object sender, EventArgs e)
        {
            boxSelColor.BackColor = btnPink.BackColor;
        }

        private void btnIndigo_Click(object sender, EventArgs e)
        {
            boxSelColor.BackColor = btnIndigo.BackColor;
        }

        private void btnPurple_Click(object sender, EventArgs e)
        {
            boxSelColor.BackColor = btnPurple.BackColor;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            boxSelColor.BackColor = btnBlue.BackColor;
        }

        private void btnRoyalBlue_Click(object sender, EventArgs e)
        {
            boxSelColor.BackColor = btnRoyalBlue.BackColor;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            boxSelColor.BackColor = btnGreen.BackColor;
        }

        private void btnLime_Click(object sender, EventArgs e)
        {
            boxSelColor.BackColor = btnLime.BackColor;
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            boxSelColor.BackColor = btnYellow.BackColor;
        }

        private void btnMarron_Click(object sender, EventArgs e)
        {
            boxSelColor.BackColor = btnMarron.BackColor;
        }

        private void btnOrange_Click(object sender, EventArgs e)
        {
            boxSelColor.BackColor = btnOrange.BackColor;
        }

        private void btnSaffron_Click(object sender, EventArgs e)
        {
            boxSelColor.BackColor = btnSaffron.BackColor;
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            boxSelColor.BackColor = btnRed.BackColor;
        }

        private void btnBrown_Click(object sender, EventArgs e)
        {
            boxSelColor.BackColor = btnBrown.BackColor;
        }

        private void Pnt_Resize(object sender, EventArgs e)
        {
            panelDraw.Height = Height - 172;
            panelDraw.Width = Width - 38;
            draw = panelDraw.CreateGraphics();
        }

        private void Pnt_ResizeBegin(object sender, EventArgs e)
        {
            panelDraw.Height = Height - 172;
            panelDraw.Width = Width - 38;
            draw = panelDraw.CreateGraphics();
        }

        private void Pnt_ResizeEnd(object sender, EventArgs e)
        {
            panelDraw.Height = Height - 172;
            panelDraw.Width = Width - 38;
            draw = panelDraw.CreateGraphics();
        }

        private void Pnt_Load(object sender, EventArgs e)
        {
            panelDraw.BackColor = Color.White;
            boxSelColor.BackColor = Color.Black;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("        A Simple Paint Program\n    Developed by Punj Prakash", "About Simple Paint Program");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            draw.Clear(Color.White);
        }

        private void panelDraw_MouseDown(object sender, MouseEventArgs e)
        {
            pen_draw.Color = boxSelColor.BackColor;
            pen_moving = true;
            pen_x = e.X;
            pen_y = e.Y;
        }

        private void panelDraw_MouseMove(object sender, MouseEventArgs e)
        {
            bool flag = pen_moving && pen_x != -1 && pen_y != -1;
            if (flag)
            {
                draw.DrawLine(pen_draw, new Point(pen_x, pen_y), e.Location);
                pen_x = e.X;
                pen_y = e.Y;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pen_draw.Width += 2f;
            bool flag = pen_draw.Width > 0f;
            if (flag)
            {
                txtLineSize.Text = pen_draw.Width.ToString();
            }
            else
            {
                txtLineSize.Text = Convert.ToString(1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pen_draw.Width -= 2f;
            bool flag = pen_draw.Width > 0f;
            if (flag)
            {
                txtLineSize.Text = pen_draw.Width.ToString();
            }
            else
            {
                txtLineSize.Text = Convert.ToString(1);
                pen_draw.Width = 1f;
            }
        }

        private void panelDraw_MouseUp(object sender, MouseEventArgs e)
        {
            this.pen_moving = false;
            this.pen_x = -1;
            this.pen_y = -1;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            boxSelColor.BackColor = Color.Black;
        }
    }
}
