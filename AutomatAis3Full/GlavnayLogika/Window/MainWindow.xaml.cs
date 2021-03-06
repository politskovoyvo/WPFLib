﻿using System;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using ViewModelLib.ModelTestAutoit.PublicModel.ButtonStartAutomat;


namespace AutomatAis3Full.GlavnayLogika.Window
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new Mvvm.WindowsMvvmAuto();
        }

        private void UIElement_OnMouseWheel(object sender, MouseWheelEventArgs e)
        {
            ScrollViewer scr = (ScrollViewer) sender;
            scr.ScrollToVerticalOffset(scr.VerticalOffset-e.Delta);
            e.Handled = true;
        }

    }
}
