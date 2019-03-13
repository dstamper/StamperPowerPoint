using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageRequest
{
    public static class ImageClientFactory
    {
        public static IImageClient Create()
        {
            return new UnsplashImageClient();
        }
    }
}
