﻿using Prism.Mvvm;

namespace ViewModelLib.ModelTestAutoit.ModelFormirovanie.CheckBoxModel
{
   public class CheckBoxModel : BindableBase
   {
       private bool _ischekced = false;

       public bool IsCheced
       {
           get { return _ischekced; }
           set
           {
               _ischekced = value;
                RaisePropertyChanged();
            }
       }

       public void IsChek()
       {
           if (IsCheced)
           {
               IsCheced = false;
            }
           else
           {
               IsCheced = true;
           }
       }
   }
}