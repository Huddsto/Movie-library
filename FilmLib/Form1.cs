using FilmLib.Models;
using System;

namespace FilmLib
{
    public partial class Form1 : Form
    {
        private List<Movie> movies;

        public Form1()
        {
            InitializeComponent();
            movies = Data.LoadMovies();
            PopulateListBox();
        }

        private void PopulateListBox()
        {
            listBoxMovies.Items.Clear();
            foreach (var movie in movies)
            {
                listBoxMovies.Items.Add(movie.Title);
            }
        }

        private bool MovieCheck(string title)
        {
            foreach (var movie in movies)
            {
                if (movie.Title == title)
                {
                    return true;
                }
            }
            return false;
        }


        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            using (var dialog = new AddMovie())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string newMovieTitle = dialog.Title;
                    if (MovieCheck(newMovieTitle))
                    {
                        MessageBox.Show("Фільм з такою назвою вже існує.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!int.TryParse(dialog.YearOfRelease, out int year))
                    {
                        MessageBox.Show("Невірний формат року випуску. Будь ласка, введіть число.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!double.TryParse(dialog.Score, out double score))
                    {
                        MessageBox.Show("Невірний формат оцінки. Будь ласка, введіть число.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!long.TryParse(dialog.FileSize, out long fileSize))
                    {
                        MessageBox.Show("Невірний формат розміру файлу. Будь ласка, введіть число.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!int.TryParse(dialog.Lenght, out int length))
                    {
                        MessageBox.Show("Невірний формат тривалості. Будь ласка, введіть число.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    Movie newMovie = new Movie
                    {
                        Title = newMovieTitle,
                        Studio = dialog.Studio,
                        Genre = dialog.Genre,
                        YearOfRelease = year,
                        Director = dialog.Director,
                        LeadActors = dialog.LeadActors,
                        Summary = dialog.Summary,
                        Score = score,
                        Location = dialog.Location,
                        FileSize = Convert.ToInt64(dialog.FileSize),
                        Length = Convert.ToInt32(dialog.Lenght)
                    };

                    movies.Add(newMovie);
                    Data.SaveMovies(movies);
                    PopulateListBox();
                }
            }
        }

        private void buttonEdit_Click_1(object sender, EventArgs e)
        {
            if (listBoxMovies.SelectedIndex >= 0)
            {
                Movie selectedMovie = movies[listBoxMovies.SelectedIndex];

                using (var editForm = new EditMovie())
                {
                    editForm.Title = selectedMovie.Title;
                    editForm.Studio = selectedMovie.Studio;
                    editForm.Genre = selectedMovie.Genre;
                    editForm.YearOfRelease = selectedMovie.YearOfRelease;
                    editForm.Director = selectedMovie.Director;
                    editForm.LeadActors = selectedMovie.LeadActors;
                    editForm.Summary = selectedMovie.Summary;
                    editForm.Score = selectedMovie.Score;
                    editForm.Location = selectedMovie.Location;
                    editForm.FileSize = selectedMovie.FileSize;
                    editForm.Lenght = selectedMovie.Length;

                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        if (!int.TryParse(editForm.YearOfRelease.ToString(), out int yearOfRelease))
                        {
                            MessageBox.Show("Невірний формат року випуску. Будь ласка, введіть число.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (!double.TryParse(editForm.Score.ToString(), out double score))
                        {
                            MessageBox.Show("Невірний формат оцінки. Будь ласка, введіть число.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (!long.TryParse(editForm.FileSize.ToString(), out long fileSize))
                        {
                            MessageBox.Show("Невірний формат розміру файлу. Будь ласка, введіть число.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (!int.TryParse(editForm.Lenght.ToString(), out int length))
                        {
                            MessageBox.Show("Невірний формат тривалості. Будь ласка, введіть число.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        selectedMovie.Title = editForm.Title;
                        selectedMovie.Studio = editForm.Studio;
                        selectedMovie.Genre = editForm.Genre;
                        selectedMovie.YearOfRelease = editForm.YearOfRelease;
                        selectedMovie.Director = editForm.Director;
                        selectedMovie.LeadActors = editForm.LeadActors;
                        selectedMovie.Summary = editForm.Summary;
                        selectedMovie.Score = score;
                        selectedMovie.Location = editForm.Location;
                        selectedMovie.FileSize = editForm.FileSize;
                        selectedMovie.Length = editForm.Lenght;

                        Data.SaveMovies(movies);
                        PopulateListBox();
                    }
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxMovies.SelectedIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Ви впевнені що хочете видалити фільм з бібліотеки?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    movies.RemoveAt(listBoxMovies.SelectedIndex);
                    Data.SaveMovies(movies);
                    PopulateListBox();
                }
            }
        }

        private void listBoxMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxMovies.SelectedIndex >= 0)
            {
                Movie selectedMovie = movies[listBoxMovies.SelectedIndex];

                dataGridViewDetails.Rows.Clear();
                dataGridViewDetails.Columns.Clear();

                dataGridViewDetails.Columns.Add("Attribute", "Ознака");
                dataGridViewDetails.Columns.Add("Value", "Значення");

                dataGridViewDetails.RowTemplate.Height = 50;

                dataGridViewDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None; 
                dataGridViewDetails.Columns["Attribute"].Width = 120;
                dataGridViewDetails.Columns["Value"].Width = 280;


                dataGridViewDetails.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                string formattedLength = TimeSpan.FromSeconds(selectedMovie.Length).ToString(@"hh\:mm\:ss");

                dataGridViewDetails.Rows.Add("Назва", selectedMovie.Title);
                dataGridViewDetails.Rows.Add("Студія", selectedMovie.Studio);
                dataGridViewDetails.Rows.Add("Жанр", selectedMovie.Genre);
                dataGridViewDetails.Rows.Add("Рік випуску", selectedMovie.YearOfRelease.ToString());
                dataGridViewDetails.Rows.Add("Режисер", selectedMovie.Director);
                dataGridViewDetails.Rows.Add("У головних ролях", selectedMovie.LeadActors);
                dataGridViewDetails.Rows.Add("Короткий зміст", selectedMovie.Summary);
                dataGridViewDetails.Rows.Add("Оцінка", selectedMovie.Score.ToString());
                dataGridViewDetails.Rows.Add("Розташування на диску", selectedMovie.Location);
                dataGridViewDetails.Rows.Add("Розмір файлу", selectedMovie.FileSize.ToString());
                dataGridViewDetails.Rows.Add("Тривалість", formattedLength);
            }
        }


        private void PopulateFilter(List<Movie> movies)
        {
            listBoxFilter.Items.Clear();
            foreach (var movie in movies)
            {
                listBoxFilter.Items.Add(movie.Title);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            using (var filterForm = new MovieFilterForm())
            {
                if (filterForm.ShowDialog() == DialogResult.OK)
                {
                    List<Movie> filteredMovies = movies;

                    if (!string.IsNullOrEmpty(filterForm.Studio))
                    {
                        filteredMovies = filteredMovies.Where(movie => movie.Studio.Contains(filterForm.Studio, StringComparison.OrdinalIgnoreCase)).ToList();
                    }
                    if (!string.IsNullOrEmpty(filterForm.Genre))
                    {
                        filteredMovies = filteredMovies.Where(movie => movie.Genre.Contains(filterForm.Genre, StringComparison.OrdinalIgnoreCase)).ToList();
                    }
                    if (!string.IsNullOrEmpty(filterForm.Year))
                    {
                        filteredMovies = filteredMovies.Where(movie => movie.YearOfRelease.ToString() == filterForm.Year).ToList();
                    }
                    if (!string.IsNullOrEmpty(filterForm.Director))
                    {
                        filteredMovies = filteredMovies.Where(movie => movie.Director.Contains(filterForm.Director, StringComparison.OrdinalIgnoreCase)).ToList();
                    }
                    if (!string.IsNullOrEmpty(filterForm.LeadActor))
                    {
                        filteredMovies = filteredMovies.Where(movie => movie.LeadActors.Contains(filterForm.LeadActor, StringComparison.OrdinalIgnoreCase)).ToList();
                    }

                    PopulateFilter(filteredMovies);
                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            {
                using (var filterForm = new MovieCollectionForm())
                {
                    if (filterForm.ShowDialog() == DialogResult.OK)
                    {
                        List<Movie> filteredMovies = movies;
                        if (!string.IsNullOrEmpty(filterForm.Length) && int.TryParse(filterForm.Length, out int length))
                        {
                            filteredMovies = filteredMovies.Where(movie => movie.Length <= length).ToList();
                        }
                        if (!string.IsNullOrEmpty(filterForm.HardDriveSize) && long.TryParse(filterForm.HardDriveSize, out long size))
                        {
                            filteredMovies = filteredMovies.Where(movie => movie.FileSize <= size).ToList();
                        }
                        if (!string.IsNullOrEmpty(filterForm.Genre))
                        {
                            filteredMovies = filteredMovies.Where(movie => movie.Genre.Contains(filterForm.Genre, StringComparison.OrdinalIgnoreCase)).ToList();
                        }
                        if (!string.IsNullOrEmpty(filterForm.LeadActors))
                        {
                            filteredMovies = filteredMovies.Where(movie => movie.LeadActors.Contains(filterForm.LeadActors, StringComparison.OrdinalIgnoreCase)).ToList();
                        }
                        if (!string.IsNullOrEmpty(filterForm.Director))
                        {
                            filteredMovies = filteredMovies.Where(movie => movie.Director.Contains(filterForm.Director, StringComparison.OrdinalIgnoreCase)).ToList();
                        }
                        filteredMovies = filteredMovies.OrderBy(movie => movie.Length).ThenBy(movie => movie.FileSize).ThenBy(movie => movie.Genre)
                                                       .ThenBy(movie => movie.LeadActors).ThenBy(movie => movie.Director).ToList();
                        PopulateFilter(filteredMovies);
                    }
                }
            }
        }
    }
}


