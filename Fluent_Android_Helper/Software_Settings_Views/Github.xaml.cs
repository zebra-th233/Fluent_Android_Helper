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

namespace Fluent_Android_Helper.Software_Settings_Views
{
    /// <summary>
    /// Github.xaml 的交互逻辑
    /// </summary>
    public partial class Github : Page
    {
        public Github()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/hanning-wang/Fluent_Android_Helper");
        }

        private void Lanzou_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://hanning.lanzous.com/b0102hvli");
            ModernWpf.MessageBox.Show("访问密码是1234");
        }
    }
}
