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
using AutomatAis3Full.Form.Automat.Okp4.MassSnuForm.DataContext;

namespace AutomatAis3Full.Form.Automat.Okp4.MassSnuForm.MassSnuForm
{
    /// <summary>
    /// Логика взаимодействия для MassSnuForm.xaml
    /// </summary>
    public partial class MassSnuForm : UserControl
    {
        public MassSnuForm()
        {
            InitializeComponent();
            DataContext = new MassSnuDataContext();
        }
    }
}
