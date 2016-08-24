﻿using EgoEngineLibrary.Graphics;
using EgoPssgEditor.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace EgoPssgEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly MainViewModel view;
        public MainWindow()
        {
            InitializeComponent();
            view = this.DataContext as MainViewModel;
        }

        private void websiteMenuItem_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.petartasev.com/modding/ego-engine/pssg-editor/");
        }
    }
}
