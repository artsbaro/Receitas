using Microsoft.AspNetCore.Http;
using System.IO;

namespace DevWebReceitas.Application.Extensions
{
    public static class ReceitaExtensions
    {
        public static byte[] ConvertToBytes(this IFormFile image)
        {
            if (image == null)
            {
                return new byte[] { };
            }
            using (var inputStream = image.OpenReadStream())
            using (var stream = new MemoryStream())
            {
                inputStream.CopyTo(stream);
                return stream.ToArray();
            }
        }
    }
}
