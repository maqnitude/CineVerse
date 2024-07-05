using CineVerse.Core.Services;
using CineVerse.Data.Entities;
using CineVerse.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineVerse.Views.UserControls
{
    public partial class HomeScreen : UserControlComponent
    {
        private User _user;

        public HomeScreen()
        {
            InitializeComponent();
        }

        public void SetUser(User user)
        {
            _user = user;
            lblWelcomeMessage.Text = $"Welcome back, {_user.Username}. Let's see what your friends have been watching...";
        }

        public async Task LoadContents()
        {
            await LoadTopRatedMovies();
            await LoadMovieRecommendations();
            await LoadTopReviews();
            await LoadPopularLists();
            await LoadRecentCommentsAsync();
            await LoadUserAvatars();
        }

        private async Task LoadTopRatedMovies()
        {
            pnMovies.SuspendLayout();

            foreach (var card in pnMovies.Controls.OfType<MovieCard>().ToList())
            {
                pnMovies.Controls.Remove(card);
            }

            List<Movie> movies = await MovieService.Instance.GetMoviesAsync(1, 7, sortBy: "rating", sortValue: "highest first");

            var mainForm = this.FindForm() as MainForm;
            foreach (Movie movie in movies)
            {
                MovieCard card = new()
                {
                    Dock = DockStyle.Left,
                };
                await card.Initialize(mainForm, movie, _mediator);

                pnMovies.Controls.Add(card);
                card.BringToFront();
            }

            pnMovies.ResumeLayout();
        }

        private async Task LoadMovieRecommendations()
        {
            pnRecommendations.SuspendLayout();

            foreach (var card in pnRecommendations.Controls.OfType<MovieCard>().ToList())
            {
                pnRecommendations.Controls.Remove(card);
            }

            List<Movie> movies = await MovieService.Instance.GetMoviesAsync(1, 100);

            Random random = new Random();
            List<Movie> randomMovies = movies.OrderBy(m => random.Next()).Take(7).ToList();

            var mainForm = this.FindForm() as MainForm;
            foreach (Movie movie in randomMovies)
            {
                MovieCard card = new()
                {
                    Dock = DockStyle.Left,
                };
                await card.Initialize(mainForm, movie, _mediator);

                pnRecommendations.Controls.Add(card);
                card.BringToFront();
            }

            pnRecommendations.ResumeLayout();
        }

        private async Task LoadTopReviews()
        {
            pnReviews.SuspendLayout();

            foreach (var item in pnReviews.Controls.OfType<ActivityItemReview>().ToList())
            {
                pnReviews.Controls.Remove(item);
            }

            List<Review> reviews = await ReviewService.Instance.GetReviewsAsync(100, includeUser: true, includeMovie: true);

            Random random = new Random();
            List<Review> randomReviews = reviews.OrderBy(r => random.Next()).Take(10).ToList();

            var mainForm = this.FindForm() as MainForm;
            foreach (Review review in randomReviews)
            {
                if (review.Content == null)
                {
                    continue;
                }

                ActivityItemReview item = new(review)
                {
                    Dock = DockStyle.Top,
                };

                pnReviews.Controls.Add(item);
                item.BringToFront();
            }

            pnReviews.ResumeLayout();
        }

        private async Task LoadPopularLists()
        {
            pnLists.SuspendLayout();

            foreach (var item in pnLists.Controls.OfType<ListItemSummary>().ToList())
            {
                pnLists.Controls.Remove(item);
            }

            List<List> lists = await ListService.Instance.GetListsAsync(ListType.Public, includeUser: true, includeMovies: true);

            Random random = new Random();
            List<List> randomLists = lists.OrderBy(l => random.Next()).Take(5).ToList();

            foreach (List list in randomLists)
            {
                if (list.Id == _user.WatchlistId || list.Id == _user.WatchedListId || list.Id == _user.LikedListId)
                {
                    continue;
                }

                ListItemSummary item = new(list)
                {
                    Dock = DockStyle.Top,
                };
                item.SetMediator(_mediator);
                pnLists.Controls.Add(item);
                item.BringToFront();
            }

            pnLists.ResumeLayout();
        }

        private async Task LoadUserAvatars()
        {
            flpUserAvatars.SuspendLayout();

            foreach (var avatar in flpUserAvatars.Controls.OfType<CircularUserAvatar>().ToList())
            {
                flpUserAvatars.Controls.Remove(avatar);
            }

            List<User> followees = await UserService.Instance.GetFolloweesByIdAsync(_user.Id);

            foreach (User followee in followees) 
            {
                CircularUserAvatar avatar = new CircularUserAvatar(followee);
                flpUserAvatars.Controls.Add(avatar);
            }

            flpUserAvatars.ResumeLayout();
        }

        private async Task LoadRecentCommentsAsync()
        {
            pnActivities.SuspendLayout();

            foreach (var item in pnActivities.Controls.OfType<ActivityItemBasic>().ToList())
            {
                pnActivities.Controls.Remove(item);
            }

            List<Comment> comments = await CommentService.Instance.GetRecentCommentsAsync(5);

            foreach (Comment comment in comments)
            {
                ActivityItemBasic item = new(comment)
                {
                    Dock = DockStyle.Top,
                };
                pnActivities.Controls.Add(item);
                item.BringToFront();
            }

            pnActivities.ResumeLayout();
        }

        private async Task LoadDiscussions()
        {
            // Load random posts
            Label message = new Label
            {
                Text = "Please navigate to Discussion tab.",
                Dock = DockStyle.Fill,
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                AutoSize = true,
                Font = new Font("Segoe UI", 10),
            };
            pnDiscussion.Controls.Add(message);
        }
    }
}
