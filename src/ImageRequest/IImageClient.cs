using SharedModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageRequest
{
    public interface IImageClient
    {
        Task<IList<PowerPointImage>> MakeRequest(string query);
    }
}
