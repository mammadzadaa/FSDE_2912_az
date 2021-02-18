using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using PropertyChanged;
using System;
using System.ComponentModel;
using System.Windows;

namespace AcademyApp
{
    [AddINotifyPropertyChangedInterface]
    public class MainVievModel 
    {
        public string Text { get; set; }


        public MainVievModel()
        {
            Text = "Hello, is it me you are looking for?";
            ButtonCommand = new RelayCommand(() =>
            {
                Text = "I can see it in your eyes!";
                MessageBox.Show(Text);
            });
        }

        public RelayCommand ButtonCommand { get; set; }


    }
}
