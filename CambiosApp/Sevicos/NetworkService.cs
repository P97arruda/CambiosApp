using CambiosApp.Modelos;

namespace CambiosApp.Sevicos
{
    using Modelos;
    using System.Net;

    internal class NetworkService
    {
        //Primeiro Erro

        public Response CheckConnection()
        {
            var client = new HttpClient();

            try
            {
                var response = client.GetAsync("http://clients3.google.com/generate_204").Result;
                {
                    return new Response
                    {
                        IsSucces = response.IsSuccessStatusCode
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
