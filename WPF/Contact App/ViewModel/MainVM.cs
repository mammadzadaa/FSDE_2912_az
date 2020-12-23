using Contact_App.Messaging;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contact_App.ViewModel
{
    class MainVM : ViewModelBase
    {
        private ViewModelBase currentViewModel;
        public RelayCommand ChangeToStatistic => changeToStatistic ?? (changeToStatistic = new RelayCommand(() =>
             {
                 CurrentViewModel = App.Container.GetInstance<StatisticsVM>();
             }));
        public RelayCommand ChangeToContacts => changeToContacts ?? (changeToContacts = new RelayCommand(() =>
             {
                 CurrentViewModel = App.Container.GetInstance<ContactListVM>();
             }));
        private RelayCommand changeToAdd;
        private RelayCommand changeToContacts;
        private RelayCommand changeToStatistic;

        public RelayCommand ChangeToAdd => changeToAdd ??= new RelayCommand(() =>
        {
            CurrentViewModel = App.Container.GetInstance<AddCOntactsVM>();
        });

        public Messenger Mes { get; set; }
        public ViewModelBase CurrentViewModel { get => currentViewModel; set => Set(ref currentViewModel, value); }
        public MainVM()
        {
            CurrentViewModel = App.Container.GetInstance<ContactListVM>();
            Mes = App.Container.GetInstance<Messenger>();
            Mes.Register<VMChange>(this, x => CurrentViewModel = x.ViewModel);
        }



    }
}
