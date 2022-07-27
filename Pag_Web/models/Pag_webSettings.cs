namespace Pag_Web.models
{
    public class Pag_webSettings : Ipag_webSettings
    {
        public string Server { get; set; }
        public string Database { get; set; }
        public string Collection { get; set; }
    }
    public interface Ipag_webSettings
    {
        string Server { get; set; }
        string Database { get; set; }
        string Collection { get; set; }
    }
}
