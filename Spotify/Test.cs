using Spotify;

internal class Test
{
    private static void Main(string[] args)
    {
        UkrtifyDbContext dbContext = new UkrtifyDbContext();

        foreach(var i in dbContext.Users)
        {
            Console.WriteLine(i.Nickname);
        }
    }
}