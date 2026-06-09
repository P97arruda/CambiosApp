using CambiosApp.Modelos;

namespace CambiosApp.Sevicos
{
    using Modelos;
    using System.Net;

    internal class NetworkService
    {
        public Response CheckConnection()
        {
            var client = new WebClient();

            try
            {
                using (client.OpenRead("http://clients3.google.com/generate_204"))
                {
                    return new Response
                    {
                        IsSucces = true,
                    };
                }
            }
            catch
            {
                return new Response
                {
                    IsSucces = false,
                    Message = "Configure a sua ligação a Internet",
                };

            }
        }

    }
}
