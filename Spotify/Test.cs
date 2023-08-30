using Spotify;

internal class Test
{
    private static void Main(string[] args)
    {
        UkrtifyDbContext ukrtifyDbContext = new UkrtifyDbContext();

        foreach (var i in ukrtifyDbContext.Genres) Console.WriteLine(i.Name);
    }
}