using Spotify;

internal class Test
{
    private static void Main(string[] args)
    {
        UkrtifyDbContext dbContext= new UkrtifyDbContext();

        foreach(var i in dbContext.Artists)
        {
            Console.WriteLine(i.Nickname + " " + i.Country.Name);
        }
    }
}