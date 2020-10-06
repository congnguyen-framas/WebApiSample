using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfClientTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static HttpClient _client;
        //public HttpResponseMessage _response;

        public MainWindow()
        {
            InitializeComponent();

            _client = new HttpClient();
            _client.BaseAddress = new Uri("http://localhost/Api/");
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<BrandModel> GetRequest(string api)
        {
            var _response = await _client.GetAsync(api);

            var json = await _response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<BrandModel>(json);
            return data;
        }


        public async Task<List<BrandModel>> GetRequestAll(string api)
        {
            var _response = await _client.GetAsync(api);

            var json = await _response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<List<BrandModel>>(json);
            return data;
        }

        private async void LoadData()
        {
            var listData = await GetRequest($"api/brandget/14");
            labConten.Content = $"id:{listData.BrandId}|Name:{listData.BrandName}|createdDate:{listData.CreatedDate}";
        }

        private async void btnGet_Click(object sender, RoutedEventArgs e)
        {
            //LoadData();

            var listData = await GetRequest(txtApiName.Text);
            labConten.Content = $"id:{listData.BrandId}|Name:{listData.BrandName}|createdDate:{listData.CreatedDate}";
        }

        private async void btnGetAll_Click(object sender, RoutedEventArgs e)
        {
            var listData = await GetRequestAll(txtApiName.Text);
            labConten.Content = $"So luong record:{listData.Count}|id:{listData[0].BrandId}|Name:{listData[0].BrandName}|createdDate:{listData[0].CreatedDate}";

            gridData.DataContext = listData;
        }

        private async void btnPost_Click(object sender, RoutedEventArgs e)
        {
            //BrandModel data = new BrandModel() { BrandName = "WiformClient", Active = true, CreatedBy = 120 };

            //var httpClient = new HttpClient();
            //var url = "http://localhost/Api/api/brandPost";

            //var _response = await httpClient.PostAsJsonAsync(url,data);

            //var json = await _response.Content.ReadAsStringAsync();

            //var result = JsonConvert.DeserializeObject<BrandModel>(json);

            //labConten.Content = $"id:{data.BrandId}|Name:{data.BrandName}|createdDate:{data.CreatedDate}";
        }
    }
}
