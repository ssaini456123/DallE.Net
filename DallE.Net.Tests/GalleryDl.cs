﻿using DallE.Net;

namespace DallE.Net.Tests
{
    public class GalleryDl
    {
        public static async Task Main(string[] args)
        {

            Console.WriteLine("Give me a prompt to generate:");
            string prompt = Console.ReadLine();

            var craiyonService = new DallEService(); // Gallery index isn't needed if you are downloading the entire gallery.

            try
            {
                await craiyonService.DownloadGalleryAsync(prompt, "testFolder");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
