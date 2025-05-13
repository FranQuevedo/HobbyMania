using HobbyManiaManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HobbyManiaManager
{
    public partial class ImdbForm : Form
    {
        private Movie _movie;
        public ImdbForm(Movie movie)
        {
            InitializeComponent();
            _movie = movie;
        }

        private void ImdbForm_Load(object sender, EventArgs e)

        {
            string url = $"https://www.imdb.com/es-es/title/{_movie.Imbd_id}";

            MoviewebView.Source = new Uri(url);

        }





    }
}
