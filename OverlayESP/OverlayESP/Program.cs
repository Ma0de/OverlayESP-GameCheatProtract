using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverlayESP
{
    
    class Overlay
    {
        private Pen _Pen = new Pen(Color.Red, 1);
        private Form _overlay = new Form();
        public Overlay() 
        {
            _overlay.Left = 0;
            _overlay.Top = 0;
            _overlay.Width = 1024;
            _overlay.Height = 768;

            _overlay.BackColor = Color.White;
            _overlay.TransparencyKey = Color.White;
            _overlay.FormBorderStyle = FormBorderStyle.None;
            _overlay.TopMost = true;

            _overlay.Paint += _overlay_Paint;
            _overlay.ShowDialog();
        }
        private void _overlay_Paint (object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(_Pen,new Rectangle(300,300,80,160));
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Overlay overlay = new Overlay();
        }
    }
}
