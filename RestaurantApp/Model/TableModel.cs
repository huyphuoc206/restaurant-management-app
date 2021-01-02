using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Model
{
    public class TableModel : AbstractModel
    {
        private string name;
        private int seats;
        private string status;

        public string Name { get => name; set => name = value; }
        public int Seats { get => seats; set => seats = value; }
        public string Status { get => status; set => status = value; }

        public static async Task<List<TableModel>> GetTablesAsync(HttpClient client, string path)
        {
            HttpResponseMessage response = await client.GetAsync(path);
            List<TableModel> tables = new List<TableModel>();
            if (response.IsSuccessStatusCode)        
                tables = await response.Content.ReadAsAsync<List<TableModel>>();
            return tables;
        }
    }
}
