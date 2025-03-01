
using DallE.Net;

namespace Craiyon.Net.Tests
{
    public class ImageDl
    {
        public static async Task Main(string[] args)
        {
            
            Console.WriteLine("Generating Image...");
            var craiyonService = new DallEService(1); // Get the 2nd image within the image gallery.

            try
            {
                await craiyonService.DownloadImageSpecificAsync("Space man", "specific.jpg");
            } catch(Exception e) {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
