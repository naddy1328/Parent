﻿using System;
using System.Collections.Generic;
using System.Linq;
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

namespace parentCore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += OnInitLoaded;
        }

        private void OnInitLoaded(object sender, RoutedEventArgs e_)
        {
            this.tDebug.Click += (s, e) => childCore.Animal.Do();
            this.tDebug.Click += (s, e) => childCore.Animal.Do();
            this.tDebug.Click += (s, e) => childCore.Animal.Do();
            this.Loaded -= OnInitLoaded;
        }
    }
}
