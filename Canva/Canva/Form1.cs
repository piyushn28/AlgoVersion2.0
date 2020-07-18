using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nevron.Nov.UI;
using Nevron.Nov;
using Nevron.Nov.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing.Drawing2D;

namespace Canva
{
    public partial class Form1 : Form
    {
        ElementSize elem;
        public Point x = new Point(), y = new Point();
        public Pen p = new Pen(Color.Purple, 3);
        public Graphics g;
        
        string hex = "^#(([0-9a-fA-F]{2}){3}|([0-9a-fA-F]){3})$";

        public Form1()
        {
            InitializeComponent();
            panel3.BackColor = Color.FromArgb(100, 0, 0, 0);
            g = drawPanel.CreateGraphics();
            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.ItemSize = new Size(0, 1);
            tabControl.SizeMode = TabSizeMode.Fixed;

            navigationBar.Width = 210;

            foreach (TabPage tab in tabControl.TabPages)
            {
                tab.Text = "";
            }

            colorPicker.SelectedColorChanged += new Nevron.Nov.Function<Nevron.Nov.Dom.NValueChangeEventArgs>(OnSelectedColorChanged);

        }

        private void OnSelectedColorChanged(Nevron.Nov.Dom.NValueChangeEventArgs arg1)
        {
            Nevron.Nov.Graphics.NColor selectedColor = (Nevron.Nov.Graphics.NColor)arg1.NewValue;
            hexCode.Text = selectedColor.GetHEX();
            
        }

        private void hexCode_TextChanged(object sender, EventArgs e)
        {
            if(Regex.Match(hexCode.Text,hex).Success)
            {
                System.Drawing.Color col = System.Drawing.ColorTranslator.FromHtml(hexCode.Text);
                colorPicker.Widget.SelectedColor = Nevron.Nov.Graphics.NColor.FromRGB(col.R, col.G, col.B);
            }       
        }

        private void hideTab_Click(object sender, EventArgs e)
        {
            navigationBar.Visible = false;
            hidePanel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
            hidePanel.Visible = true;

            if (navigationBar.Visible==false)
            {
                navigationBar.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
            hidePanel.Visible = true;

            if (navigationBar.Visible == false)
            {
                navigationBar.Visible = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            elem = new ElementSize(new Rectangle(10, 10, 100, 100));
            elem.SetPictureBox(this.drawPanel);
        }

        private void drawPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            {
                x = e.Location;
                g.DrawLine(p, x, y);
                y = x;
            }
        }

        private void drawPanel_MouseDown(object sender, MouseEventArgs e)
        {
            y = e.Location;
        }
    }
}
