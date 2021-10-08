using System;
using System.Collections.Generic;
using System.Text;
using Searcher_student_in_VK.Infrastructure.Command;
using System.Windows.Input;
using System.Windows;

namespace Searcher_student_in_VK.ViewModel
{
    internal class MainViewModel: BaseViewModel
    {
        #region Commands

        #region Close app command

        public ICommand CloseAppCommand { get; }

        private bool CanCloseAppCommandExecute(object p) => true;
        private void OnCloseAppCommandExecute(object p)
        {
            Application.Current.Shutdown();
        }

        #endregion

        #endregion

        public MainViewModel()
        {
            #region Command init
            CloseAppCommand = new RelayCommand(OnCloseAppCommandExecute, CanCloseAppCommandExecute);
            #endregion
        }

    }
}
