namespace domekZad
{
    public partial class MainPage : ContentPage
    {
        int likeCount = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        /*
            Nazwa:                  onLikeClicked()
            Opis:                   Zwiększa ilość polubień o jeden, gdy przycisk "POLUB" jest kliknięty
            Parametry wejściowe:    sender - kliknięty objekt
            Zwracana wartość:       brak
            Autor:                  10231203102
         */
        private void onLikeClicked(object sender, EventArgs e)
        {
            likeCount++;
            lblLike.Text = $"{likeCount} Polubień";
        }

        /*
            Nazwa:                  onDislikeClicked()
            Opis:                   Zmniejsza ilość polubień o jeden, gdy przycisk "USUŃ" jest kliknięty
            Parametry wejściowe:    sender - kliknięty objekt
            Zwracana wartość:       brak
            Autor:                  10231203102
         */
        private void onDislikeClicked(object sender, EventArgs e)
        {
            if (likeCount > 0)
                likeCount--;
            lblLike.Text = $"{likeCount} Polubień";
        }
    }

}
