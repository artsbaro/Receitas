using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SIP.Infra.CrossCutting.ViaCep
{
    /// <summary>
    /// The Via CEP client class.
    /// </summary>
    public static class ViaCEPClient
    {
        #region Private fields

        /// <summary>
        /// The base URL
        /// </summary>
        private const string BaseUrl = "https://viacep.com.br";

        #endregion

        #region Public methods

        /// <summary>
        /// Searches the specified zip code.
        /// </summary>
        /// <param name="zipCode">The zip code.</param>
        /// <returns></returns>
        public static ViaCEPResult Search(string zipCode)
        {
            return SearchAsync(zipCode).Result;
        }

        /// <summary>
        /// Searches the asynchronous.
        /// </summary>
        /// <param name="zipCode">The zip code.</param>
        /// <param name="token">The token.</param>
        /// <returns></returns>
        public static async Task<ViaCEPResult> SearchAsync(string zipCode)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                var response = await client.GetAsync($"/ws/{zipCode}/json").ConfigureAwait(false);
                response.EnsureSuccessStatusCode();

                return JsonConvert.DeserializeObject<ViaCEPResult>(await response.Content.ReadAsStringAsync()); 
            }
        }

        /// <summary>
        /// Searches the specified state initials.
        /// </summary>
        /// <param name="stateInitials">The state initials.</param>
        /// <param name="city">The city.</param>
        /// <param name="address">The address.</param>
        /// <returns></returns>
        public static IEnumerable<ViaCEPResult> Search(string stateInitials, string city, string address)
        {
            return SearchAsync(stateInitials, city, address).Result;
        }

        /// <summary>
        /// Searches the asynchronous.
        /// </summary>
        /// <param name="stateInitials">The state initials.</param>
        /// <param name="city">The city.</param>
        /// <param name="address">The address.</param>
        /// <returns></returns>
        public static async Task<IEnumerable<ViaCEPResult>> SearchAsync(
            string stateInitials,
            string city,
            string address)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                var response = await client.GetAsync($"/ws/{stateInitials}/{city}/{address}/json").ConfigureAwait(false);
                response.EnsureSuccessStatusCode();
                return JsonConvert.DeserializeObject<List<ViaCEPResult>>(await response.Content.ReadAsStringAsync());
            }
        }

        #endregion
    }
}
