using System;
using System.Collections.Generic;
using System.Text;
using Searcher_student_in_VK.Infrastructure.Command;
using System.Windows.Input;
using System.Windows;
using Microsoft.EntityFrameworkCore;
using Searcher_student_in_VK.Infrastructure.Data.EntityDbContext;
using Searcher_student_in_VK.Model;
using System.Linq;
using System.Windows.Media.Imaging;

namespace Searcher_student_in_VK.ViewModel
{
    internal class MainViewModel: BaseViewModel
    {
        #region Main Propertys
        public List<University> Universities { get; set; }
        public List<Student> Students { get; set; }
        public University CurrentUniversity { get; set; }
        public Student CurrentStudent { get; set; }

        public BitmapImage BitImage { get; set; }
        #endregion

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
            #region DB conntection
            using UniversityDB db = new UniversityDB();

            #endregion

            #region Propertys init
            Universities=db.Universities.Include(i=>i.GroupsVK).ToList();
            CurrentUniversity = Universities[9];
            
            
            #endregion

            #region Command init
            CloseAppCommand = new RelayCommand(OnCloseAppCommandExecute, CanCloseAppCommandExecute);
            #endregion
        }
    }
}
