using System.Runtime.InteropServices;
using CoreHtmlToImage.Configurations;

namespace CoreHtmlToImage.Core
{
    public class HtmlConverter : CoreDriver
    {
        /// <summary>
        /// wkhtmltopdf only has a .exe extension in Windows.
        /// </summary>
        private static readonly string WkhtmlPdfExe =
            RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? "wkhtmltopdf.exe" : "wkhtmltopdf";

        /// <summary>
        /// wkhtmltopdf only has a .exe extension in Windows.
        /// </summary>
        private static readonly string WkhtmlImageExe =
            RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? "wkhtmltoimage.exe" : "wkhtmltoimage";

        /// <summary>
        /// Converts given HTML string to PDF.
        /// </summary>
        /// <param name="html">String containing HTML code that should be converted to PDF.</param>
        /// <param name="configuration"></param>
        /// <returns>PDF as byte array.</returns>
        public static byte[] ConvertHtmlToPdf(string html, PdfConfiguration configuration)
        {
            return Convert(configuration.WkhtmlPath, configuration.GetConvertOptions(), html, WkhtmlPdfExe);
        }
    }
}