using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buton_hareket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Timer l = new Timer();
        Timer r = new Timer();
        Timer u = new Timer();
        Timer d = new Timer();
        int gecikme = 20;
        int adımboyutu = 2;

        private void Form1_Load(object sender, EventArgs e)
        {
            l.Interval = gecikme;
            l.Tick += timersol;
            r.Interval = gecikme;
            r.Tick += timersag;
            u.Interval = gecikme;
            u.Tick += timeryukari;
            d.Interval = gecikme;
            d.Tick += timerasagi;

        }


      
        private void timersol(object sender, EventArgs e)
        {
            Point p = new Point(button1.Location.X, button1.Location.Y);
            p.X = p.X - adımboyutu;
            button1.Location = p;
        }

        private void timersag(object sender, EventArgs e)
        {
            Point p = new Point(button1.Location.X, button1.Location.Y);
            p.X = p.X + adımboyutu;
            button1.Location = p;
        }

        private void timerasagi(object sender, EventArgs e)
        {
            Point p = new Point(button1.Location.X, button1.Location.Y);
            p.Y = p.Y + adımboyutu;
            button1.Location = p;
        }

        private void timeryukari(object sender, EventArgs e)
        {
            Point p = new Point(button1.Location.X, button1.Location.Y);
            p.Y = p.Y - adımboyutu;
            button1.Location = p;
        }



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.A)
            {
                l.Start();
            }
            if (e.KeyCode == Keys.D)
            {
                r.Start();
            }
            if (e.KeyCode == Keys.W)
            {
                u.Start();
            }
            if (e.KeyCode == Keys.S)
            {
                d.Start();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                l.Stop();
            }
            if (e.KeyCode == Keys.D)
            {
                r.Stop();
            }
            if (e.KeyCode == Keys.W)
            {
                u.Stop();
            }
            if (e.KeyCode == Keys.S)
            {
                d.Stop();
            }

        }
    }
}
