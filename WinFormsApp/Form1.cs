using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;
using SharedLibrary;
using SharedLibrary.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var services = new ServiceCollection();
            services.AddMudServices();
            services.AddWindowsFormsBlazorWebView();
            
            services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("wwwroot\\\\index.html\"") });


            blazorWebView1.HostPage = "wwwroot\\index.html";



            blazorWebView1.Services = services.BuildServiceProvider();



            blazorWebView1.RootComponents.Add<App>("#app");

        }
    }
}
