#define My_Debug
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myfirstgame
{
    public partial class Form1 : Form
    {
#if My_Debug
        int _cursX = 0;
        int _cursY = 0;
#endif
        CMole _mole;
        public Form1()
        {
            InitializeComponent();
            _mole = new CMole() { Left = 100,Top = 200};
        }

        private void TimerGameStart_Tick(object sender, EventArgs e)
        {

        }
       protected override void OnPaint(PaintEventArgs e)
        {
            Graphics dc = e.Graphics;
#if My_Debug
            TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.EndEllipsis;
            Font _font = new System.Drawing.Font("Stencil", 12, FontStyle.Regular);
            TextRenderer.DrawText(dc, "x=" + _cursX.ToString() + ":" + "Y=" + _cursY.ToString(), _font,
                new Rectangle(100, 28, 120, 20), SystemColors.ControlText, flags);
#endif
            _mole.DrawImage(dc);
            base.OnPaint(e);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
#if My_Debug
            _cursX = e.X;
            _cursY = e.Y;
        
#endif
            this.Refresh();
        }
    }
}
