# DallE.Net
DallE.Net (Formerly Craiyon.NET) is a library that allows you to interact with Craiyon. An AI Image generation service powered by DALL-E.
<br>
## Usage

Bulk gallery downloads can be done as such:

```cs
using DallE.Net;

namespace Craiyon.Net.Tests
{
    public class GalleryDl
    {
        public static async Task Main(string[] args)
        {

            Console.WriteLine("Give me a prompt to generate:");
            string prompt = Console.ReadLine();

            var dallEService = new DallEService(); // Gallery index isn't needed if you are downloading the entire gallery.

            try
            {
                await dallEService.DownloadGalleryAsync(prompt, "testFolder");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
```

