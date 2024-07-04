using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CineVerse.Core.Events;
using CineVerse.Core.Interfaces;
using CineVerse.Core.Services;
using CineVerse.Data.Entities;
using CineVerse.Forms;
using CineVerse.Views.Forms;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.Drawing.Drawing2D;

namespace CineVerse.Views.UserControls
{
    public partial class MovieDetailsScreen : UserControlComponent
    {
        private MainForm _mainForm;
        private Movie _movie;

        private bool _isMovieInWatchlist = false;
        private bool _isMovieWatched = false;
        private bool _isMovieLiked = false;

        public Movie Movie
        {
            get
            {
                return _movie;
            }
        }

        public MovieDetailsScreen()
        {
            InitializeComponent();

            RegisterEventHandlers();
        }

        public async Task Initialize(MainForm mainForm, Movie movie, IMediator mediator)
        {
            _mainForm = mainForm;
            await SetMovieData(movie);
            SetMediator(mediator);
            await UpdateState();
        }

        private void RegisterEventHandlers()
        {
            EventManager.Instance.Subscribe<EventArgs>(EventType.ReviewAdded, OnReviewAdded);

            EventManager.Instance.Subscribe<RatingEventArgs>(EventType.RatingChanged, OnRatingChanged);
            EventManager.Instance.Subscribe<EventArgs>(EventType.UserMovieRated, OnUserMovieRated);

            EventManager.Instance.Subscribe<EventArgs>(EventType.WatchlistMovieAdded, OnWatchlistMovieAdded);
            EventManager.Instance.Subscribe<EventArgs>(EventType.WatchlistMovieRemoved, OnWatchlistMovieRemoved);

            EventManager.Instance.Subscribe<EventArgs>(EventType.WatchedListMovieAdded, OnWatchedListMovieAdded);
            EventManager.Instance.Subscribe<EventArgs>(EventType.WatchedListMovieRemoved, OnWatchedListMovieRemoved);

            EventManager.Instance.Subscribe<EventArgs>(EventType.LikedListMovieAdded, OnLikedListMovieAdded);
            EventManager.Instance.Subscribe<EventArgs>(EventType.LikedListMovieRemoved, OnLikedListMovieRemoved);
        }

        private async Task SetMovieData(Movie movie)
        {
            _movie = movie;

            lblMovieTitle.Text = movie.Title;

            pnBackdrop.BackgroundImage?.Dispose();
            //pnBackdrop.BackgroundImage = new Bitmap(movie.BackdropPath);
            using (var originalImage = new Bitmap(_movie.BackdropPath))
            {
                // Adjust this value to scale the image. 
                float scaleFactor = 0.2f;
                
                int newWidth = (int)(originalImage.Width * scaleFactor);
                int newHeight = (int)(originalImage.Height * scaleFactor);
                
                var resizedImage = new Bitmap(newWidth, newHeight);
                using (var graphics = Graphics.FromImage(resizedImage))
                {
                    graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    graphics.DrawImage(originalImage, 0, 0, newWidth, newHeight);
                }
                
                pnBackdrop.BackgroundImage = new Bitmap(resizedImage);
            }

            picMoviePoster.Image?.Dispose();
            //picMoviePoster.Image = new Bitmap(movie.PosterPath);
            using (var originalImage = new Bitmap(_movie.PosterPath))
            {
                // Adjust this value to scale the image. 
                float scaleFactor = 0.2f;
                
                int newWidth = (int)(originalImage.Width * scaleFactor);
                int newHeight = (int)(originalImage.Height * scaleFactor);
                
                var resizedImage = new Bitmap(newWidth, newHeight);
                using (var graphics = Graphics.FromImage(resizedImage))
                {
                    graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    graphics.DrawImage(originalImage, 0, 0, newWidth, newHeight);
                }
                
                picMoviePoster.Image = new Bitmap(resizedImage);
            }

            lblReleaseYear.Text = movie.ReleaseDate.HasValue ? movie.ReleaseDate.Value.Year.ToString() : "N/A";
            lblReleaseDate.Text = movie.ReleaseDate.HasValue ? movie.ReleaseDate.Value.ToString("MM/dd/yyyy") : "N/A";

            lblGenres.Text = String.Join(", ", movie.Genres);
            lblRuntime.Text = $"{movie.Runtime / 60}h{movie.Runtime % 60}m";

            var director = await MovieService.Instance.GetMovieDirectorAsync(movie.Id);
            lblDirectorName.Text = director.Name;

            lblTagline.Text = movie.TagLine.ToUpper();
            lblOverviewParagraph.Text = movie.Overview;

            lblStatus.Text = movie.Status;
            lblOriginalLanguage.Text = movie.OriginalLanguage;
            lblBudget.Text = movie.Budget.HasValue ? movie.Budget.Value.ToString("C") : "N/A";
            lblRevenue.Text = movie.Budget.HasValue ? movie.Budget.Value.ToString("C") : "N/A";

            await LoadCredits();
            await LoadReviews();
        }

        private void ClearReviews()
        {
            List<ReviewItem> reviewItemsToRemove = new List<ReviewItem>();

            foreach (Control control in pnReviews.Controls)
            {
                if (control is ReviewItem reviewItem)
                {
                    reviewItemsToRemove.Add(reviewItem);
                }
            }

            foreach (ReviewItem reviewItem in reviewItemsToRemove)
            {
                pnReviews.Controls.Remove(reviewItem);
            }
        }

        private async Task LoadReviews()
        {
            pnReviews.SuspendLayout();

            ClearReviews();

            List<Review> reviews = await ReviewService.Instance.GetMovieReviewsAsync(_movie.Id);

            foreach (Review review in reviews)
            {
                if (review.Content != null)
                {
                    ReviewItem reviewItem = new(review);
                    pnReviews.Controls.Add(reviewItem);
                }
            }

            pnReviews.ResumeLayout();
        }

        private void ClearCredits()
        {
            List<PersonCard> castsToRemove = new List<PersonCard>();
            List<PersonCard> crewMembersToRemove = new List<PersonCard>();

            foreach (Control control in pnCast.Controls)
            {
                if (control is PersonCard personCard)
                {
                    castsToRemove.Add(personCard);
                }
            }
            foreach (Control control in pnCrew.Controls)
            {
                if (control is PersonCard personCard)
                {
                    crewMembersToRemove.Add(personCard);
                }
            }

            foreach (PersonCard personCard in castsToRemove)
            {
                pnCast.Controls.Remove(personCard);
            }
            foreach (PersonCard crew in crewMembersToRemove)
            {
                pnCrew.Controls.Remove(crew);
            }
        }

        private async Task LoadCredits()
        {
            pnCast.SuspendLayout();

            ClearCredits();

            List<Person> casts = await MovieService.Instance.GetTopCastsByMovieIdAsync(_movie.Id, 10);

            foreach (Person cast in casts)
            {
                PersonCard castItem = new(_mainForm.GetNavService());
                castItem.SetPersonData(cast);
                pnCast.Controls.Add(castItem);
                castItem.BringToFront();
                castItem.Dock = DockStyle.Left;
            }

            pnCast.ResumeLayout();

            pnCrew.SuspendLayout();

            List<Person> crews = await MovieService.Instance.GetTopCrewsByMovieIdAsync(_movie.Id, 10);

            foreach (Person crew in crews)
            {
                PersonCard crewItem = new(_mainForm.GetNavService());
                crewItem.SetPersonData(crew);
                pnCrew.Controls.Add(crewItem);
                crewItem.BringToFront();
                crewItem.Dock = DockStyle.Left;
            }

            pnCrew.ResumeLayout();
        }

        private async Task UpdateActionIcons()
        {
            var user = _mainForm.GetCurrentUser();
            _isMovieInWatchlist = await MovieService.Instance.IsMovieInListAsync(user.WatchlistId, _movie.Id);
            _isMovieWatched = await MovieService.Instance.IsMovieInListAsync(user.WatchedListId, _movie.Id);
            _isMovieLiked = await MovieService.Instance.IsMovieInListAsync(user.LikedListId, _movie.Id);

            if (_isMovieLiked)
            {
                btnLike.Image?.Dispose();
                btnLike.Image = Properties.Resources.like_fill_big;
            }
            else
            {
                btnLike.Image?.Dispose();
                btnLike.Image = Properties.Resources.like_big;
            }

            if (_isMovieWatched)
            {
                btnWatch.Image?.Dispose();
                btnWatch.Image = Properties.Resources.eye_fill_big;
            }
            else
            {
                btnWatch.Image?.Dispose();
                btnWatch.Image = Properties.Resources.eye_big;
            }

            if (_isMovieInWatchlist)
            {
                btnWatchlist.Image?.Dispose();
                btnWatchlist.Image = Properties.Resources.add_fill_big;
            }
            else
            {
                btnWatchlist.Image?.Dispose();
                btnWatchlist.Image = Properties.Resources.add_big;
            }
        }

        //

        private async Task UpdateStarRatingControl()
        {
            var user = _mainForm.GetCurrentUser();
            var rating = await ReviewService.Instance.GetUserMovieRatingAsync(user.Id, _movie.Id);

            starRatingControl.Rating = rating;
        }

        private async Task UpdateRatingInfo()
        {
            int totalReviews = await ReviewService.Instance.CountMovieReviewsAsync(_movie.Id);
            lblNumReviews.Text = $"({totalReviews})";

            double avgRating = await MovieService.Instance.GetMovieAverageRatingAsync(_movie.Id);
            lblAvgRating.Text = avgRating.ToString();
        }

        private async Task UpdateState()
        {
            await UpdateActionIcons();
            await UpdateStarRatingControl();
            await UpdateRatingInfo();
        }

        private async void OnWatchlistMovieAdded(object sender, EventArgs e)
        {
            await UpdateState();
        }

        private async void OnWatchlistMovieRemoved(object sender, EventArgs e)
        {
            await UpdateState();
        }

        private async void OnWatchedListMovieAdded(object sender, EventArgs e)
        {
            await UpdateState();
        }

        private async void OnWatchedListMovieRemoved(object sender, EventArgs e)
        {
            await UpdateState();
        }

        private async void OnLikedListMovieAdded(object sender, EventArgs e)
        {
            await UpdateState();
        }

        private async void OnLikedListMovieRemoved(object sender, EventArgs e)
        {
            await UpdateState();
        }

        private async void OnReviewAdded(object sender, EventArgs e)
        {
            await LoadReviews();
            await UpdateState();
        }

        private async void OnRatingChanged(object sender, RatingEventArgs e)
        {
            // This works, but there should be a better way
            if (sender is StarRatingControl ratingControl && !ratingControl.CanSaveRating)
            {
                return;
            }

            var user = _mainForm.GetCurrentUser();
            await UserService.Instance.RateMovieAsync(user.Id, _movie.Id, e.Rating);
        }

        private async void OnUserMovieRated(object sender, EventArgs e)
        {
            await UpdateState();
        }
        
        //

        private void MovieDetailsScreen_Load(object sender, EventArgs e)
        {
            pnHeader.BackColor = Color.FromArgb(150, 0, 0, 0);
            pnHeaderInfo.BackColor = Color.Transparent;
            pnMovieTitle.BackColor = Color.Transparent;
            pnMovieFacts.BackColor = Color.Transparent;
            pnDirector.BackColor = Color.Transparent;
            pnlRatingInfo.BackColor = Color.Transparent;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var navService = _mainForm.GetNavService();
            navService.NavigateBack();
        }

        private void lblReviewOrLog_Click(object sender, EventArgs e)
        {
            var newReviewForm = new NewReviewForm(_movie);
            newReviewForm.ShowDialog();
        }

        private void lblAddToLists_Click(object sender, EventArgs e)
        {
            _mediator?.Notify(this, "OpenAddToListForm");
        }

        private async void btnWatch_Click(object sender, EventArgs e)
        {
            var user = _mainForm.GetCurrentUser();

            if (_isMovieWatched)
            {
                await ListService.Instance.RemoveMovieFromWatchedListAsync(user.WatchedListId, user.LikedListId, _movie.Id);
            }
            else
            {
                await ListService.Instance.AddMovieToWatchedListAsync(user.WatchedListId, user.WatchlistId, user.LikedListId, _movie.Id);
            }
        }

        private async void btnLike_Click(object sender, EventArgs e)
        {
            var user = _mainForm.GetCurrentUser();

            if (_isMovieLiked)
            {
                await ListService.Instance.RemoveMovieFromLikedListAsync(user.LikedListId, _movie.Id);
            }
            else
            {
                await ListService.Instance.AddMovieToLikedListAsync(user.LikedListId, user.WatchlistId, user.WatchedListId, _movie.Id);
            }
        }

        private async void btnWatchlist_Click(object sender, EventArgs e)
        {
            var user = _mainForm.GetCurrentUser();

            if (_isMovieInWatchlist)
            {
                await ListService.Instance.RemoveMovieFromWatchlistAsync(user.WatchlistId, _movie.Id);
            }
            else
            {
                await ListService.Instance.AddMovieToWatchlistAsync(user.WatchlistId, user.WatchedListId, user.LikedListId, _movie.Id);
            }
        }
    }
}
