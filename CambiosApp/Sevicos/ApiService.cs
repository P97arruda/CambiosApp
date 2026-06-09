namespace CambiosApp.Sevicos
{

    using Modelos;
    using Newtonsoft.Json;

    public class ApiService
    {
        public async Task<Response> GetRates(string urlBase, string controller)
        {
            try
            {
                var cliente = new HttpClient();
                cliente.BaseAddress = new Uri(urlBase);

                var response = await cliente.GetAsync(controller);

                var result = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return new Response
                    {
                        IsSucces = false,
                        Message = result,
                    };
                }

                var rates = JsonConvert.DeserializeObject<List<Rate>>(result);

                return new Response
                {
                    IsSucces = true,
                    Result = rates
                };
            }

            catch (Exception ex)
            {
                return new Response
                {
                    IsSucces = false,
                    Message = ex.Message,
                };
            }
        }

    }
}
