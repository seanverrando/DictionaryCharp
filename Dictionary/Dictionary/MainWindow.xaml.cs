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

namespace Dictionary
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LookUpWord dictionary = new LookUpWord();
        }

        private void buttonClick_Search(object sender, RoutedEventArgs e)
        {

            LookUpWord dictionary = new LookUpWord();
            //dictionary.ReturnDef(textBox.Text);
            object term = new object();
            term = dictionary.ReturnDef(textBox.Text);
            string s = term.ToString();
            txtBlock.Text = s;
        }
    }
}
