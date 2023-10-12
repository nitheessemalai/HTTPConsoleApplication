using HTTPConsole_ApplicationLibrary.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace HTTPConsole_ApplicationLibrary.Repository
{
    public class HTTPRepository
    {

        public HTTPmodel GetStaff()
        {
            IEnumerable<HTTPmodel> Staff = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44319/");

                //Called Member default GET All records  
                //GetAsync to send a GET request   
                // PutAsync to send a PUT request  
                var responseTask = client.GetAsync("api/Staff");
                responseTask.Wait();

                //To store result of web api response.   
                var result = responseTask.Result;

                //If success received   
                if (result.IsSuccessStatusCode)
                {
                    var readTask =  result.Content.ReadAsAsync<List<HTTPmodel>>();
                    readTask.Wait();

                    Staff = readTask.Result;
                }
                else
                {
                    //Error response received   
                    Staff = Enumerable.Empty<HTTPmodel>();
                    //  ModelState.AddModelError(string.Empty, "Server error try after some time.");
                }

            }
            return (HTTPmodel)Staff;
        }

    }
}
