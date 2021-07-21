namespace AspIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new WebHost(5002);
            host.UseSturtup<Startup>();
            host.Run();
        }
    }
}
