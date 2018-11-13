//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Collections;

//namespace WindowsFormsApp
//{
//    public partial class Form3 : Form
//    {
//        public Form3()
//        {
//            InitializeComponent();
//            Load += Form3_Load;
//        }

//        ListView listView1;

//        private void Form3_Load(object sender, EventArgs e)
//        {
//            listView1 = new System.Windows.Forms.ListView();
//            SuspendLayout();
//            // 
//            // listView1
//            // 
//            listView1.Location = new System.Drawing.Point(242, 225);
//            ColumnHeader columnHeader1 = new ColumnHeader();
//            ColumnHeader columnHeader2 = new ColumnHeader();
//            ColumnHeader columnHeader3 = new ColumnHeader();
//            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
//            listView1.GridLines = true;
//            listView1.Location = new Point(12, 12);
//            listView1.Name = "listView1";
//            listView1.Size = new System.Drawing.Size(800, 500);
//            listView1.TabIndex = 0;
//            listView1.UseCompatibleStateImageBehavior = false;
//            listView1.View = View.Details;
//            ListviewItemAdd();
//            Controls.Add(listView1);           
//        }
//        private void ListviewItemAdd()
//        {
//            ListViewItem item1 = new ListViewItem("item1",0);
//            item1.SubItems.Add("1");
//            item1.SubItems.Add("2");

//            ListViewItem item2 = new ListViewItem("item2", 0);
//            item2.SubItems.Add("3");
//            item2.SubItems.Add("4");

//            ListViewItem item3 = new ListViewItem("item3", 0);
//            item3.SubItems.Add("5");
//            item3.SubItems.Add("6");

//            listView1.Items.AddRange(new ListViewItem[] {item1,item2,item3 });
//        }

//    }
//    public class MyItem
//    {

//    }

//}
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Load += Form3_Load;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ListView listView1 = new ListView();

            ColumnHeader columnHeader1 = new ColumnHeader();
            ColumnHeader columnHeader2 = new ColumnHeader();
            ColumnHeader columnHeader3 = new ColumnHeader();
            // listView1.Columns.AddRange(new ColumnHeader[] {columnHeader1,columnHeader2,columnHeader3});
            listView1.Columns.Add(columnHeader1);
            listView1.Columns.Add(columnHeader2);
            listView1.Columns.Add(columnHeader3);

            columnHeader1.Text = "Column 1";
            columnHeader1.Width = 100;
            columnHeader1.TextAlign = HorizontalAlignment.Center;

            columnHeader2.Text = "Column 2";
            columnHeader2.Width = 150;
            columnHeader2.TextAlign = HorizontalAlignment.Left;

            columnHeader3.Text = "Column 3";
            columnHeader3.Width = 200;
            columnHeader3.TextAlign = HorizontalAlignment.Right;

            /*
            listView1.Columns.Add("Column 1", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Column 2", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("Column 3", 200, HorizontalAlignment.Right);
            */

            listView1.GridLines = true;
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(776, 426);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;

            Controls.Add(listView1);

            //ListViewItem item1 = new ListViewItem("item1");
            //item1.SubItems.Add("1");
            //item1.SubItems.Add("2");
            //ListViewItem item2 = new ListViewItem("item2");
            //item2.SubItems.Add("4");
            //item2.SubItems.Add("5");
            //ListViewItem item3 = new ListViewItem("item3");
            //item3.SubItems.Add("7");
            //item3.SubItems.Add("8");

            // listView1.Items.AddRange(new ListViewItem[] { item1, item2, item3 });
            //listView1.Items.Add(item1);
            //listView1.Items.Add(item2);
            //listView1.Items.Add(item3);
            ListViewItem item;
            for(int i = 0; i < 3; i++)
            {
                item = new ListViewItem("item" + (i + 1));
                item.SubItems.Add(""+((i*2)+1));
                item.SubItems.Add("" + ((i*2)+2));
                listView1.Items.Add(item);
            }
        }
    }

    public class MyClass
    {

    }
}