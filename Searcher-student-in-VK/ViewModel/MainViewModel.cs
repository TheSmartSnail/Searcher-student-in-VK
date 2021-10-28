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
        private List<University> universities;
        public List<University> Universities { get => universities; set=> Set(ref universities, value); }
        public List<Student> Students { get; set; }

        private University _CurrentUniversity;
        public University CurrentUniversity { get => _CurrentUniversity; set => Set(ref _CurrentUniversity, value); }
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

        #region Add Uni Command
        public ICommand AddUniCommand { get; }
        public string NameNewUni { get => nameNewUni; set => Set(ref nameNewUni,value); }
        

        private string nameNewUni;
        private bool CanAddUniAppCommandExecute(object p) => true;
        private void OnAddUniCommandExecute(object p)
        {
            Universities.Add(new University(NameNewUni));
        }
        #endregion
        #endregion


        public MainViewModel()
        {
            #region Command init
            CloseAppCommand = new RelayCommand(OnCloseAppCommandExecute, CanCloseAppCommandExecute);
            AddUniCommand = new RelayCommand(OnAddUniCommandExecute, CanAddUniAppCommandExecute);
            #endregion
            #region DB conntection
            using UniversityDB db = new UniversityDB();

            #endregion

            #region Propertys init
            Universities=db.Universities.Include(i=>i.GroupsVK).ToList();
            CurrentUniversity = Universities[9];
            
            
            #endregion

            
        }
    }
}
