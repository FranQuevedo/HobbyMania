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
    public partial class ImbdForm : Form
    {
        private Movie _movie;
        public ImbdForm(Movie movie)
        {
            InitializeComponent();
            _movie = movie;
        }

        private void ImbdForm_Load(object sender, EventArgs e)
        {
            string url = $"https://www.imdb.com/es-es/title/{_movie.Imdb_id}";

            MovieWebView.Source = new Uri(url);


        }
    }
}
