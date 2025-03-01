using DallE.Net;

namespace DallE.Net.Tests
{
    public class GalleryDl
    {
        public static async Task Main(string[] args)
        {

            Console.WriteLine("Give me a prompt to generate:");
            string prompt = Console.ReadLine();

            Console.WriteLine("Where would you like to save these images?: ");
            string loc = Console.ReadLine();
            bool exists = Directory.Exists(loc);

            while(!exists)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Directory does not exist! Please enter a valid directory: ");
                Console.ForegroundColor = ConsoleColor.White;
                loc = Console.ReadLine();
                exists = Directory.Exists(loc);
            }

            var dalle = new DallEService(); // Gallery index isn't needed if you are downloading the entire gallery.
            Console.ForegroundColor = ConsoleColor.White;
            try
            {
                await dalle.DownloadGalleryAsync(prompt, loc);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Image successfully saved to: {loc}!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
