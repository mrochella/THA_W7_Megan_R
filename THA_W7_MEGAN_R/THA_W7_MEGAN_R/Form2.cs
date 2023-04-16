using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W7_MEGAN_R
{
    public partial class Form2 : Form
    {
        Button[,] buttons;
        List<Button> selectedSeats;
        public Form1 frm1;
        Random randomly;
        int unavailable, abjadKursi, stat, bookedSeats;
        string msg;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            randomly = new Random();
            unavailable = randomly.Next(1, 71);
            bookedSeats = 0;
            abjadKursi = 65;
            int x = 10;
            int y = 10;
            buttons = new Button[10,10];
            selectedSeats = new List<Button>();
            Button seatings = new Button();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                abjadKursi = 65 + i;
                for (int j = 0; j < 10; j++)
                {
                    stat = randomly.Next(2);
                    buttons[i, j] = new Button();
                    buttons[i, j].Size = new Size(33, 33);
                    buttons[i, j].Location = new Point(x, y);
                    buttons[i, j].Tag = Convert.ToChar(abjadKursi) + (j + 1).ToString();
                    buttons[i, j].Text = buttons[i, j].Tag.ToString();
                    buttons[i, j].Font = new Font("Arial", 7);
                    selectedSeats.Add(buttons[i, j]);
                    if (stat == 0 && bookedSeats <= unavailable)
                    {
                        buttons[i, j].BackColor = Color.Tomato;
                        bookedSeats++;
                        if (buttons[i, j].BackColor == Color.Tomato)
                        {
                            buttons[i, j].Enabled = false;
                            /*msg = "Sorry, this seat is taken.";
                            MessageBox.Show(msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
                        }
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.LightGray;
                        buttons[i, j].Click += changeSeatColor;
                    }
                    this.Controls.Add(buttons[i, j]);
                    y += 35;
                }
                x += 35;
                y = 10;
            }
            /*Label lbl_ticket = new Label();
            lbl_ticket.Font = new Font("Arial", lbl_ticket.Font.Size, FontStyle.Bold);
            lbl_ticket.Text = "Total of ticket:";
            lbl_ticket.Location = new Point(90, 370);
            this.Controls.Add(lbl_ticket);

            tbox_ticket.Location = new Point(190, 368);
            this.Controls.Add(tbox_ticket);*/

            Label lbl_whatSeat = new Label();
            lbl_whatSeat.Font = new Font("Arial", lbl_whatSeat.Font.Size, FontStyle.Bold);
            lbl_whatSeat.Text = "Seat Number:";
            lbl_whatSeat.Size = new Size(95, 20);
            lbl_whatSeat.Location = new Point(130, 370);
            this.Controls.Add(lbl_whatSeat);

            Label lbl_seatNum = new Label();
            lbl_seatNum.Font = new Font("Arial", lbl_seatNum.Font.Size, FontStyle.Bold);
            lbl_seatNum.Text = "100";
            lbl_seatNum.Location = new Point(220, 370);
            this.Controls.Add(lbl_seatNum);

            Button butt_reserve = new Button();
            butt_reserve.Text = "Reserve";
            butt_reserve.Font = new Font("Arial", butt_reserve.Font.Size, FontStyle.Bold);
            butt_reserve.Location = new Point(145,400);
            this.Controls.Add(butt_reserve);
            butt_reserve.Click += butt_reserve_click;

            Button butt_reset = new Button();
            butt_reset.Text = "Reset";
            butt_reset.Font = new Font("Arial", butt_reset.Font.Size, FontStyle.Bold);
            butt_reset.Location = new Point(145, 430);
            this.Controls.Add(butt_reset);
            butt_reset.Click += butt_reset_click;
        }

        private void butt_reserve_click(object sender, EventArgs e)
        {
            int hijau = 0;
            foreach (Button coba in selectedSeats)
            {
                if (coba.BackColor == Color.SpringGreen)
                {
                    coba.BackColor = Color.Tomato;
                    hijau++;
                }
            }
            msg = "Your booking has completed.";
            MessageBox.Show(msg, "Thank you for your purchase!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void butt_reset_click(object sender, EventArgs e)
        {
            msg = "You're about to clear all the seats.";
            MessageBox.Show(msg, "Hello!", MessageBoxButtons.OK);
            foreach (Button coba in selectedSeats)
            {
                if (coba.BackColor == Color.Tomato)
                {
                    coba.BackColor = Color.LightGray;
                }
            }
        }

        private void changeSeatColor(object sender, EventArgs e)
        {
            var button = sender as Button;
            button.BackColor = Color.SpringGreen;
        }
    }
}
