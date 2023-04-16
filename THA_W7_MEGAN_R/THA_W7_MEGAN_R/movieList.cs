using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W7_MEGAN_R
{
    public partial class movieList : Form
    {
        public movieList()
        {
            kursi = new Form2[24];
            InitializeComponent();
        }
        private Form2[] kursi;
        List<string> perantara;
        public static List<string> moviePosters;
        private void movieList_Load(object sender, EventArgs e)
        {

            this.BackColor = Color.Beige;
            Label title = new Label();
            title.Text = "Welcome to Wonderland Cinema! Pick a movie and time.";
            title.ForeColor = Color.Salmon;
            title.Font = new Font("Arial", 11, FontStyle.Bold);
            title.Location = new Point(25, 10);
            title.Size = new Size(430, 20);
            this.Controls.Add(title);

            string file = "myMovies.txt";
            string[] lines = File.ReadAllLines(file);
            perantara = new List<string>();
            foreach (string line in lines)
            {
                perantara.AddRange(line.Split(','));
            }
            moviePosters = new List<string>();
            foreach (string baris in perantara)
            {
                if (baris[0] == 'W')
                {
                    moviePosters.Add(baris);
                }
            }

            PictureBox movPoster1 = new PictureBox();
            movPoster1.SizeMode = PictureBoxSizeMode.StretchImage;
            movPoster1.Size = new Size(75, 100);
            movPoster1.Location = new Point(15, 50);
            movPoster1.ImageLocation = moviePosters[0];
            this.Controls.Add(movPoster1);

            PictureBox movPoster2 = new PictureBox();
            movPoster2.SizeMode = PictureBoxSizeMode.StretchImage;
            movPoster2.Size = new Size(75, 100);
            movPoster2.Location = new Point(15, 190);
            movPoster2.ImageLocation = moviePosters[1];
            this.Controls.Add(movPoster2);

            PictureBox movPoster3 = new PictureBox();
            movPoster3.SizeMode = PictureBoxSizeMode.StretchImage;
            movPoster3.Size = new Size(75, 100);
            movPoster3.Location = new Point(60, 325);
            movPoster3.ImageLocation = moviePosters[2];
            this.Controls.Add(movPoster3);

            PictureBox movPoster4 = new PictureBox();
            movPoster4.SizeMode = PictureBoxSizeMode.StretchImage;
            movPoster4.Size = new Size(75, 100);
            movPoster4.Location = new Point(165, 50);
            movPoster4.ImageLocation = moviePosters[3];
            this.Controls.Add(movPoster4);

            PictureBox movPoster5 = new PictureBox();
            movPoster5.SizeMode = PictureBoxSizeMode.StretchImage;
            movPoster5.Size = new Size(75, 100);
            movPoster5.Location = new Point(165, 190);
            movPoster5.ImageLocation = moviePosters[4];
            this.Controls.Add(movPoster5);

            PictureBox movPoster6 = new PictureBox();
            movPoster6.SizeMode = PictureBoxSizeMode.StretchImage;
            movPoster6.Size = new Size(75, 100);
            movPoster6.Location = new Point(240, 325);
            movPoster6.ImageLocation = moviePosters[5];
            this.Controls.Add(movPoster6);

            PictureBox movPoster7 = new PictureBox();
            movPoster7.SizeMode = PictureBoxSizeMode.StretchImage;
            movPoster7.Size = new Size(75, 100);
            movPoster7.Location = new Point(310, 50);
            movPoster7.ImageLocation = moviePosters[6];
            this.Controls.Add(movPoster7);

            PictureBox movPoster8 = new PictureBox();
            movPoster8.SizeMode = PictureBoxSizeMode.StretchImage;
            movPoster8.Size = new Size(75, 100);
            movPoster8.Location = new Point(310, 190);
            movPoster8.ImageLocation = moviePosters[7];
            this.Controls.Add(movPoster8);

            Label movLab1 = new Label();
            string pj = File.ReadAllText("pj.txt");
            movLab1.Text = pj;
            movLab1.Font = new Font("Arial", movLab1.Font.Size, FontStyle.Bold);
            movLab1.Location = new Point(8, 155);
            movLab1.Size = new Size(120, 35);
            this.Controls.Add(movLab1);

            Label movLab2 = new Label();
            string nf = File.ReadAllText("four.txt");
            movLab2.Text = nf;
            movLab2.Font = new Font("Arial", movLab2.Font.Size, FontStyle.Bold);
            movLab2.Location = new Point(8, 295);
            movLab2.Size = new Size(130, 35);
            this.Controls.Add(movLab2);

            Label movLab3 = new Label();
            string dnd = File.ReadAllText("DD.txt");
            movLab3.Text = dnd;
            movLab3.Font = new Font("Arial", movLab2.Font.Size, FontStyle.Bold);
            movLab3.Location = new Point(30, 430);
            movLab3.Size = new Size(150, 35);
            this.Controls.Add(movLab3);

            Label movLab4 = new Label();
            string aq = File.ReadAllText("aq.txt");
            movLab4.Text = aq;
            movLab4.Font = new Font("Arial", movLab4.Font.Size, FontStyle.Bold);
            movLab4.Location = new Point(171, 155);
            movLab4.Size = new Size(100, 35);
            this.Controls.Add(movLab4);

            Label movLab5 = new Label();
            string ps = File.ReadAllText("ps.txt");
            movLab5.Text = ps;
            movLab5.Font = new Font("Arial", movLab5.Font.Size, FontStyle.Bold);
            movLab5.Location = new Point(175, 295);
            movLab5.Size = new Size(122, 35);
            this.Controls.Add(movLab5);

            Label movLab6 = new Label();
            string hq = File.ReadAllText("bof.txt");
            movLab6.Text = hq;
            movLab6.Font = new Font("Arial", movLab6.Font.Size, FontStyle.Bold);
            movLab6.Location = new Point(304, 155);
            movLab6.Size = new Size(100, 35);
            this.Controls.Add(movLab6);

            Label movLab7 = new Label();
            string gon = File.ReadAllText("gj.txt");
            movLab7.Text = gon;
            movLab7.Font = new Font("Arial", movLab7.Font.Size, FontStyle.Bold);
            movLab7.Location = new Point(324, 295);
            movLab7.Size = new Size(122, 35);
            this.Controls.Add(movLab7);

            Label movLab8 = new Label();
            string bt = File.ReadAllText("bt.txt");
            movLab8.Text = bt;
            movLab8.Font = new Font("Arial", movLab7.Font.Size, FontStyle.Bold);
            movLab8.Location = new Point(245, 430);
            movLab8.Size = new Size(120, 35);
            this.Controls.Add(movLab8);

            Button percy_1230 = new Button();
            percy_1230.Tag = "0";
            percy_1230.Text = "12:30";
            percy_1230.Location = new Point(95, 60);
            percy_1230.Size = new Size(60, 25);
            this.Controls.Add(percy_1230);
            percy_1230.Click += kursiApa_Click;

            Button percy_1645 = new Button();
            percy_1645.Tag = "1";
            percy_1645.Text = "16:45";
            percy_1645.Location = new Point(95, 90);
            percy_1645.Size = new Size(60, 25);
            this.Controls.Add(percy_1645);
            percy_1645.Click += kursiApa_Click;

            Button percy_2030 = new Button();
            percy_2030.Tag = "2";
            percy_2030.Text = "20:30";
            percy_2030.Location = new Point(95, 120);
            percy_2030.Size = new Size(60, 25);
            this.Controls.Add(percy_2030);
            percy_2030.Click += kursiApa_Click;

            Button aquaman_1145 = new Button();
            aquaman_1145.Tag = "3";
            aquaman_1145.Text = "11:45";
            aquaman_1145.Location = new Point(245, 60);
            aquaman_1145.Size = new Size(60, 25);
            this.Controls.Add(aquaman_1145);
            aquaman_1145.Click += kursiApa_Click;

            Button aquaman_1730 = new Button();
            aquaman_1730.Tag = "4";
            aquaman_1730.Text = "17:30";
            aquaman_1730.Location = new Point(245, 90);
            aquaman_1730.Size = new Size(60, 25);
            this.Controls.Add(aquaman_1730);
            aquaman_1730.Click += kursiApa_Click;

            Button aquaman_2330 = new Button();
            aquaman_2330.Tag = "5";
            aquaman_2330.Text = "23:30";
            aquaman_2330.Location = new Point(245, 120);
            aquaman_2330.Size = new Size(60, 25);
            this.Controls.Add(aquaman_2330);
            aquaman_2330.Click += kursiApa_Click;

            Button harley_945 = new Button();
            harley_945.Tag = "6";
            harley_945.Text = "9:45";
            harley_945.Location = new Point(390, 60);
            harley_945.Size = new Size(60, 25);
            this.Controls.Add(harley_945);
            harley_945.Click += kursiApa_Click;

            Button harley_1545 = new Button();
            harley_1545.Tag = "7";
            harley_1545.Text = "15:45";
            harley_1545.Location = new Point(390, 90);
            harley_1545.Size = new Size(60, 25);
            this.Controls.Add(harley_1545);
            harley_1545.Click += kursiApa_Click;

            Button harley_2130 = new Button();
            harley_2130.Tag = "8";
            harley_2130.Text = "21:30";
            harley_2130.Location = new Point(390, 120);
            harley_2130.Size = new Size(60, 25);
            this.Controls.Add(harley_2130);
            harley_2130.Click += kursiApa_Click;

            Button four_1130 = new Button();
            four_1130.Tag += "9";
            four_1130.Text = "11:30";
            four_1130.Location = new Point(95, 200);
            four_1130.Size = new Size(60, 25);
            this.Controls.Add(four_1130);
            four_1130.Click += kursiApa_Click;

            Button four_1545 = new Button();
            four_1545.Tag = "10";
            four_1545.Text = "15:45";
            four_1545.Location = new Point(95, 230);
            four_1545.Size = new Size(60, 25);
            this.Controls.Add(four_1545);
            four_1545.Click += kursiApa_Click;

            Button four_1850 = new Button();
            four_1850.Tag = "11";
            four_1850.Text = "18:50";
            four_1850.Location = new Point(95, 260);
            four_1850.Size = new Size(60, 25);
            this.Controls.Add(four_1850);
            four_1850.Click += kursiApa_Click;

            Button par_945 = new Button();
            par_945.Tag = "12";
            par_945.Text = "9:45";
            par_945.Location = new Point(245, 200);
            par_945.Size = new Size(60, 25);
            this.Controls.Add(par_945);
            par_945.Click += kursiApa_Click;

            Button par_1755 = new Button();
            par_1755.Tag = "13";
            par_1755.Text = "17:55";
            par_1755.Location = new Point(245, 230);
            par_1755.Size = new Size(60, 25);
            this.Controls.Add(par_1755);
            par_1755.Click += kursiApa_Click;

            Button par_2015 = new Button();
            par_2015.Tag = "14";
            par_2015.Text = "20:15";
            par_2015.Location = new Point(245, 260);
            par_2015.Size = new Size(60, 25);
            this.Controls.Add(par_2015);
            par_2015.Click += kursiApa_Click;

            Button gon_945 = new Button();
            gon_945.Tag = "15";
            gon_945.Text = "9:45";
            gon_945.Location = new Point(390, 200);
            gon_945.Size = new Size(60, 25);
            this.Controls.Add(gon_945);
            gon_945.Click += kursiApa_Click;

            Button gon_1545 = new Button();
            gon_1545.Tag = "16";
            gon_1545.Text = "15:45";
            gon_1545.Location = new Point(390, 230);
            gon_1545.Size = new Size(60, 25);
            this.Controls.Add(gon_1545);
            gon_1545.Click += kursiApa_Click;

            Button gon_2130 = new Button();
            gon_2130.Tag = "17";
            gon_2130.Text = "21:30";
            gon_2130.Location = new Point(390, 260);
            gon_2130.Size = new Size(60, 25);
            this.Controls.Add(gon_2130);
            gon_2130.Click += kursiApa_Click;

            Button dnd_1445 = new Button();
            dnd_1445.Tag = "18";
            dnd_1445.Text = "14:45";
            dnd_1445.Location = new Point(140, 335);
            dnd_1445.Size = new Size(60, 25);
            this.Controls.Add(dnd_1445);
            dnd_1445.Click += kursiApa_Click;

            Button dnd_1845 = new Button();
            dnd_1845.Tag = "19";
            dnd_1845.Text = "18:45";
            dnd_1845.Location = new Point(140, 365);
            dnd_1845.Size = new Size(60, 25);
            this.Controls.Add(dnd_1845);
            dnd_1845.Click += kursiApa_Click;

            Button dnd_2130 = new Button();
            dnd_2130.Tag = "20";
            dnd_2130.Text = "21:30";
            dnd_2130.Location = new Point(140, 395);
            dnd_2130.Size = new Size(60, 25);
            this.Controls.Add(dnd_2130);
            dnd_2130.Click += kursiApa_Click;

            Button bt_1440 = new Button();
            bt_1440.Tag = "21";
            bt_1440.Text = "14:40";
            bt_1440.Location = new Point(320, 335);
            bt_1440.Size = new Size(60, 25);
            this.Controls.Add(bt_1440);
            bt_1440.Click += kursiApa_Click;

            Button bt_1830 = new Button();
            bt_1830.Tag = "22";
            bt_1830.Text = "18:30";
            bt_1830.Location = new Point(320, 365);
            bt_1830.Size = new Size(60, 25);
            this.Controls.Add(bt_1830);
            bt_1830.Click += kursiApa_Click;

            Button bt_2150 = new Button();
            bt_2150.Tag = "23";
            bt_2150.Text = "21:50";
            bt_2150.Location = new Point(320, 395);
            bt_2150.Size = new Size(60, 25);
            this.Controls.Add(bt_2150);
            bt_2150.Click += kursiApa_Click;
        }

        private void kursiApa_Click(object sender, EventArgs e)
        {
            Button seat = (Button)sender;
            int tagApa = Convert.ToInt32(seat.Tag.ToString());
            if (kursi[tagApa] == null)
            {
                kursi[tagApa] = new Form2();
                
            }
            kursi[tagApa].TopLevel = false;
            kursi[tagApa].Dock = DockStyle.Fill;
            Form1.form1.nampilKursi(kursi[tagApa]);
            kursi[tagApa].Show();
        }
    }
}
