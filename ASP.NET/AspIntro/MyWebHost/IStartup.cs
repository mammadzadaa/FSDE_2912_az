using AspIntro.MyWebHost;

namespace AspIntro
{
    public interface IStartup
    {
        public HttpHandle Configure(MiddlewareBuilder builder);
    }
}