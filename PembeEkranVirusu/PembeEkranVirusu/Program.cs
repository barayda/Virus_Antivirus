using System;
using System.Drawing;
using System.Windows.Forms;

namespace PembeEkranVirusu
{
    class Program
    {
        [STAThread] 
        static void Main(string[] args)
        {
            System.Windows.Forms.Form pembePencere = new System.Windows.Forms.Form();

            pembePencere.BackColor = Color.Pink;
            pembePencere.FormBorderStyle = FormBorderStyle.None;
            pembePencere.WindowState = FormWindowState.Maximized;
            pembePencere.TopMost = true;

            System.Windows.Forms.Label mesaj = new System.Windows.Forms.Label();
            mesaj.AutoSize = true;
            mesaj.Font = new Font("Arial", 30, FontStyle.Bold);
            mesaj.Location = new Point(100, 100);

            pembePencere.Controls.Add(mesaj);

            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.Run(pembePencere);
        }
    }
}