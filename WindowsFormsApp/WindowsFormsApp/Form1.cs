using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 3; i++)
            {
                Button button = new Button();
                button.DialogResult = DialogResult.OK;
                button.Text = "확인"+i;
                button.Size = new Size(100, 50);
                button.TextAlign = ContentAlignment.MiddleCenter;
                button.Location = new Point(100*i+30, 30);
                
                Controls.Add(button);
                button.Click += button_click;
                button.Cursor = Cursors.Hand;
            }
            
        }

        private void button_click(object o, EventArgs a)
        {
            Button btn = (Button)o;
            btn.BackColor = (btn.BackColor != Color.GreenYellow) ? btn.BackColor = Color.GreenYellow : btn.BackColor = Color.Silver;

            //if (btn.BackColor != Color.GreenYellow)
            //    btn.BackColor = Color.GreenYellow;
            //else
            //    btn.BackColor = Color.Silver;
        }

        
    }
}
