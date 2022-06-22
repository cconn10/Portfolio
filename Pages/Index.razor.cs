using SpotifyAPI.Web;

namespace Portfolio.Pages
{
    public partial class Index
    {
        SpotifyClient spotify;
        FullTrack track;

        const string CLIENT_ID = "02b532a8a43748bba871395facd50d11";

        protected override async Task OnInitializedAsync()
        {
            var spotify = new SpotifyClient("BQCNzx84qd86DrDksdSdwRNW06gqu621p3l4NDA_rpPJvvxmazqQLn8O1FFyM_pwVesfxyVSTvDAkC1o78UVKqIvQu5LsTzHjUGEvECAbei5p1NLXYU2detYlUbyrQ4oox5gItl");

            var track = await spotify.Tracks.Get("1s6ux0lNiTziSrd7iUAADH");
            Console.WriteLine(track.Name);
        }
    }
}
