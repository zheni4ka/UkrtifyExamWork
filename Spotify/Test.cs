using Spotify;

internal class Test
{
    private static void Main(string[] args)
    {
        SpotifyDbContext dbContext = new SpotifyDbContext();

        foreach(var i in dbContext.Users)
        {
            Console.WriteLine(i.Nickname);
        }
    }
}