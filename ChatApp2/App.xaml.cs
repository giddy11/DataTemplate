﻿using ChatApp2.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ChatApp2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            //ServiceCollection services = new();
            //ConfigureServices(services);
            //_serviceProvider = services.BuildServiceProvider();
        }

        //private static void ConfigureServices(ServiceCollection services)
        //{
        //    services.AddScoped<MainWindow>();
        //    services.AddScoped<SignUpViewModel>();
        //    services.AddScoped<SignUpPage>();
        //}


        //protected override void OnStartup(StartupEventArgs e)
        //{
        //    base.OnStartup(e);

        //    var mainWindow = _serviceProvider.GetService<MainWindow>();
        //    mainWindow.Show();
        //}

        //private readonly ServiceProvider _serviceProvider;
    }
}
