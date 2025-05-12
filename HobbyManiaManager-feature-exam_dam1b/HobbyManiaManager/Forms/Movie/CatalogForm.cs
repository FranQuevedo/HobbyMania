using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using HobbyManiaManager.Repositories;
using HobbyManiaManager.ViewModels;

namespace HobbyManiaManager
{
    public partial class CatalogForm : Form
    {
        private readonly MoviesRepository _moviesRepository;
        private readonly RentalsRepository _rentalsRepository;

        public CatalogForm()
        {
            InitializeComponent();
            _moviesRepository = MoviesRepository.Instance;
            _rentalsRepository = RentalsRepository.Instance;
        }

        private void CatalogForm_Load(object sender, EventArgs e)
        {
            movieUserControl.Load(_moviesRepository.GetAll().First());
;
            ReloadMoviesGrid();
            ConfigureMoviesDatagrid();
            movieUserControl._refreshAction = () => ReloadMoviesGrid();
            
            
        }

        private void ConfigureMoviesDatagrid()
        {
            dataGridViewMoviesList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMoviesList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMoviesList.ReadOnly = true;
            dataGridViewMoviesList.Columns["Id"].Visible = false;
            dataGridViewMoviesList.Columns["VoteAverage"].HeaderText = "Votes Average";
            movieUserControl.Parent = this;
        }

        private void dataGridViewMoviesList_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewMoviesList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewMoviesList.SelectedRows[0];
                var id = (int) selectedRow.Cells["Id"].Value;

                var selected = _moviesRepository.GetById(id);
                movieUserControl.Load(selected);
            }
        }

        public void ReloadMoviesGrid()
        {
            var list = _moviesRepository
                .GetAll()
                .Select(m => new MovieDataGridViewModel(m))
                .ToList();

            dataGridViewMoviesList.DataSource = null;
            dataGridViewMoviesList.DataSource = list;
            dataGridViewMoviesList.Columns["Id"].Visible = false;
        }

    }
}
