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
using System.Windows.Shapes;
using System.Data.Entity;

namespace HelloWorldMicah
{
    /// <summary>
    /// Interaction logic for ComboWindow.xaml
    /// </summary>
    public partial class ComboWindow : Window
    {
        public ComboWindow()
        {
            InitializeComponent();

            var sample = new Test1Entities();
            sample.Users.Load();
            //uxComboBox.ItemsSource = sample.Users.Local;
            uxListBox.ItemsSource = sample.Users.Local;
        }

        private void uxComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //loose coupling
            uxGrid.DataContext = e.AddedItems[0];
            //Coupled
            //uxName.Text = ((User)uxComboBox.SelectedValue).UserName;
        }
    }
}
