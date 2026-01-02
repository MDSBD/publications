using publications.Models;

namespace publications.Services.Remote
{
    public class ChercheurService : IChercheur
    {
        private readonly HttpClient _httpClient;
        public ChercheurService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://localhost:7225/");
        }
        public Chercheur GetChercheurById(long id)
        {
            //https://localhost:7225/api/ChercheurApi/2
           
            var response = _httpClient.GetAsync($"api/ChercheurApi/{id}").Result;
            if (response.IsSuccessStatusCode)
            {
                var chercheur = response.Content.ReadFromJsonAsync<Chercheur>().Result;
                return chercheur ;
            }
            return null;

        }

        public IEnumerable<Chercheur> GetChercheursByIds(List<long> ids)
        {
            throw new NotImplementedException();
        }
    }
}
