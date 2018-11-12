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
                button.Name = "button" + (i+1);
               
                button.Text = "확인"+(i+1);
                button.Size = new Size(100, 50);
                button.TextAlign = ContentAlignment.MiddleCenter;
                button.Location = new Point(100*i+30, 30);
                button.Cursor = Cursors.Hand;

                Controls.Add(button);
                button.Click += button_click;
                
            }
            
        }

        private void button_click(object o, EventArgs a)
        {
            //string names = "";
            foreach(Control c in Controls)
            {
                if(c.Name!="button3") c.BackColor = Color.Silver;
            }
            Button btn = (Button)o;
            btn.BackColor = (btn.BackColor != Color.GreenYellow) ? btn.BackColor = Color.GreenYellow : btn.BackColor = Color.Silver;

            //if (btn.BackColor != Color.GreenYellow)
            //    btn.BackColor = Color.GreenYellow;
            //else
            //    btn.BackColor = Color.Silver;
        }

        
    }
}
