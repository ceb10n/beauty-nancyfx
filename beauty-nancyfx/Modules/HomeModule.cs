namespace beauty_nancyfx.Modules
{
    public class HomeModule : Nancy.NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => "Hello World!";
        }
    }
}