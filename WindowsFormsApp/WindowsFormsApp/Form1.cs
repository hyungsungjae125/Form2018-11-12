using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }
        private Button button;
        private Label lb;
        private void Form1_Load(object sender, EventArgs e)
        {
            ArrayList lists = new ArrayList();
            lists.Add(new Item("button",30,30,"button_1"));
            lists.Add(new Item("label",130,30,"label_1"));
            lists.Add(new Item("button",230,30,"button_3"));

            for(int a = 0; a < lists.Count; a++)
            {
                Control_create((Item) lists[a]);
            }
            //string[] ctrList = { "button", "label", "button" };

            //for (int i = 0; i < ctrList.Length; i++)
            //{
            //    if (ctrList[i] == "button")
            //    {
            //        Controls.Add(btn_create(i));
            //    }
            //    else if (ctrList[i] == "label")
            //    {
            //        Controls.Add(lb_create(i));
            //    }
            //}
        }
        private void Control_create(Item item)
        {
            Control ctr = new Control();
            
            switch (item.getType)
            {
                case "button":
                    Button btn = new Button();
                    btn.DialogResult = DialogResult.OK;
                    btn.Cursor = Cursors.Hand;
                    btn.Click += button_click;
                    ctr = btn;
                    break;
                case "label":
                    ctr = new Label();
                    break;
                default:
                    break;
            }
            ctr.Name = item.getTxt;
            ctr.Text = item.getTxt;
            ctr.Size = new Size(100, 50);
            ctr.Location = new Point(item.getX, item.getY);
            Controls.Add(ctr);
        }
        private Button btn_create(Item item)
        {
            
                button = new Button();
                button.DialogResult = DialogResult.OK;
                button.Name = item.getTxt;

                button.Text = item.getTxt;
                button.Size = new Size(100, 50);
                button.TextAlign = ContentAlignment.MiddleCenter;
                button.Location = new Point(item.getX, item.getY);
                button.Cursor = Cursors.Hand;
                button.Click += button_click;

                return button;
        }
        private Label lb_create(Item item)
        {

            lb = new Label();
            
            lb.Name = item.getTxt;

            lb.Text = item.getTxt;
            lb.Size = new Size(100, 50);
            lb.TextAlign = ContentAlignment.MiddleCenter;
            lb.Location = new Point(item.getX, item.getY);
            //lb.Cursor = Cursors.Hand;

            return lb;
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

    public class Item
    {
        string type;
        int x;
        int y;
        string txt;
        public Item(string type,int x,int y,string txt)
        {
            this.type = type;
            this.x = x;
            this.y = y;
            this.txt = txt;
        }
        public string getType
        {
            get { return type; }
        }
        public int getX
        {
            get { return x; }
        }
        public int getY
        {
            get { return y; }
        }
        public string getTxt
        {
            get { return txt; }
        }
    }

}
