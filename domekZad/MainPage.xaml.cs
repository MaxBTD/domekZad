namespace domekZad
{
    public partial class MainPage : ContentPage
    {
        int likeCount = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void onLikeClicked(object sender, EventArgs e)
        {
            likeCount++;
            lblLike.Text = $"{likeCount} Polubień";
        }

        private void onDislikeClicked(object sender, EventArgs e)
        {
            if (likeCount > 0)
                likeCount--;
            lblLike.Text = $"{likeCount} Polubień";
        }
    }

}
