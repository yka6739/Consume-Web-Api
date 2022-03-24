using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication21.Models;

namespace WebApplication21
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            IEnumerable<EmpClass> empobj = null;
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("https://localhost:44301/api/");
            var consumeapi = hc.GetAsync("Default");
            var readdata = consumeapi.Result;
            if(readdata.IsSuccessStatusCode)
            {
                var displayrecords = readdata.Content.ReadAsAsync<IList<EmpClass>>();
                displayrecords.Wait();
                empobj = displayrecords.Result;
                GridView1.DataSource= empobj ;
                GridView1.DataBind();

            }
        }
    }
}