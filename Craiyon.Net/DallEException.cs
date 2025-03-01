using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Craiyon.Net
{
    internal class DallEOutOfBounds : Exception
    {
        public DallEOutOfBounds() : base("Cannot generate image: Count exceeds 6.")
        {
        }
    }

    internal class DallEInvalidPrompt : Exception
    {
        public DallEInvalidPrompt() : base("Cannot generate image: Invalid prompt provided.")
        {
        }
    }
}
