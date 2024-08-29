using App1.Model.Turismo;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Linq; // Asegúrate de agregar esta referencia

namespace App1.Services
{
    public class TurismoService
    {
        public async Task<List<MTurismoFormGoogle>> GetDataFromApi(string apiUrl)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();

                    using (Stream stream = await response.Content.ReadAsStreamAsync())
                    using (StreamReader reader = new StreamReader(stream))
                    using (CsvReader csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                    {
                        return csv.GetRecords<MTurismoFormGoogle>().ToList();
                    }
                }
            }
            catch (HttpRequestException httpEx)
            {
                Console.WriteLine($"Error de solicitud HTTP: {httpEx.Message}");
                throw;
            }
            catch (CsvHelperException csvEx)
            {
                Console.WriteLine($"Error al leer el CSV: {csvEx.Message}");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado: {ex.Message}");
                throw;
            }
        }
    }
}
