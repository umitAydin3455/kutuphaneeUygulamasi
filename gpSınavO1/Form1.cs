using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gpSınavO1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void formGetir(Form Form2)
        {
            panel.Controls.Clear();
            Form2.MdiParent = this;
            Form2.FormBorderStyle = FormBorderStyle.None;
            panel.Controls.Add(Form2);
            Form2.Show();
            panel.Controls.Add(Form2);
        }

        private void üyeİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("üye girişi yapıldı");
        }

        private void üToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            uyeEkle form2 = new uyeEkle();
            form2.MdiParent = this;
            form2.Show();
            formGetir(form2);

        }
        private void kitapEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            kitapEkle form3 = new kitapEkle();
            form3.MdiParent = this;
            form3.Show();
            formGetir(form3);
        }
        private void kullanıcıGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            kullaniciGiris form4 = new kullaniciGiris();
            form4.MdiParent = this;
            form4.Show();
            formGetir(form4);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AnaSayfa_Paint(object sender, PaintEventArgs e)
        {

        }
    }




    /*bool move;
    int mouse_x;
    int mouse_y;
    private void Form1_MouseDown(object sender, MouseEventArgs e)
    {
        move = true;
        mouse_x = e.X;
        mouse_y = e.Y;
    }
    private void Form1_MouseUp(object sender, MouseEventArgs e)
    {
        move = false;
    }
    private void Form1_MouseMove(object sender, MouseEventArgs e)
    {
        if (move)
        {
            this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
        }
    }*/

}
