using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatak12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void but1_Click_1(object sender, EventArgs e)
        {
            DateTime start = mCal1.SelectionStart;
            DateTime end = mCal1.SelectionEnd;

            if (start == end)
            {
                MessageBox.Show("Molimo vas da odaberete opseg datuma.");
                return;
            }

            int days = (int)(end - start).TotalDays + 1; // dodajemo 1 da bismo uključili i poslednji dan
            MessageBox.Show($"Broj odabranih dana: {days}");

            string startDateString = start.ToShortDateString();
            string endDateString = end.ToShortDateString();
            MessageBox.Show($"Izabrani opseg datuma: od {startDateString} do {endDateString}");

        }
    }
}
