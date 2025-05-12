using HobbyManiaManager.Models;
using HobbyManiaManager.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HobbyManiaManager
{
    public partial class TicketForm : Form
    {
        Customer cust;
        Movie mov;
        Rental ren;
        public TicketForm(Customer a, Movie b, Rental r)
        {
            InitializeComponent();
            cust = a;
            mov = b;
            ren = r;
        }

        private void TicketForm_Load(object sender, EventArgs e)
        {
            MovieID.Text = mov.Id.ToString();
            MovieID.ReadOnly = true;
            MovieName.Text = mov.Title;
            MovieName.ReadOnly = true;
            CustomerID.Text = cust.Id.ToString();
            CustomerID.ReadOnly = true;
            CustomerName.Text = cust.Name;
            CustomerName.ReadOnly = true;
            StartDate.Text = ren.StartDate.ToString();
            StartDate.ReadOnly = true;
            FinishDate.Text = cust.RentalsHistory
                .Where(x => x.MovieId == mov.Id)
                .Select(x => x.StartDate)
                .FirstOrDefault()
                .ToString();
            FinishDate.ReadOnly = true;

            DateTime finishDateParsed = DateTime.Parse(FinishDate.Text);
            double time = DateTimeUtils.GetDifferenceInSeconds(ren.StartDate, finishDateParsed);
            time = time * 0.000001;
            Price.Text = time.ToString();
            Price.ReadOnly = true;




        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
