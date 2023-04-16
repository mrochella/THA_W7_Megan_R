using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace THA_W7_MEGAN_R
{
    public partial class Form1 : Form
    {
        public Form2 bookSeats;
        public movieList mList;
        public static Panel panel_seating1;
        public static Form1 form1;
        Button buttons = new Button();
        public Form1()
        {
            form1 = this;
            panel_seating1 = panel_seating;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          /*bookSeats = new Form2();
            bookSeats.TopLevel = false;
            bookSeats.Dock = DockStyle.Fill;
            bookSeats.MdiParent = this;
            this.panel_seating.Controls.Add(bookSeats);
            bookSeats.Show();*/

            mList = new movieList();
            mList.TopLevel = false;
            mList.Dock = DockStyle.Fill;
            mList.MdiParent = this;
            this.panel_mvList.Controls.Add(mList);
            mList.Show();
        }

        public void nampilKursi(Form obj)
        {
            panel_seating.Controls.Clear();
            //var obj = form as Form2;
            obj.Dock = DockStyle.Fill;
            obj.TopLevel = false;
            panel_seating.Controls.Add(obj);
            obj.Show();
        }
    }
}
