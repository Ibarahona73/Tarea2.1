﻿using Tarea2._1.Views;

namespace Tarea2._1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Inicio());
        }
    }
}
