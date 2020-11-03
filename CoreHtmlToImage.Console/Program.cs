using CoreHtmlToImage.Configurations;
using System.IO;

namespace CoreHtmlToImage.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // From HTML string
            const string html = "<div><strong>Hello</strong> World!</div>";
            var bytes = Core.HtmlConverter.ConvertHtmlToPdf(html, new PdfConfiguration
            {
                WkhtmlPath = "C:\\Program Files\\wkhtmltopdf\\bin"
            });

            // From URL
            //var urlBytes = HtmlConverter.FromUrl("http://google.com", 800, format: ImageFormat.Png, quality: 90);
            File.WriteAllBytes("C:\\Users\\WDTN4590\\Pictures\\test.pdf", bytes);
        }
    }
}