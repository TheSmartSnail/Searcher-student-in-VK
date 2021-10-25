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

namespace Searcher_student_in_VK.ViewModel
{
    internal class MainViewModel: BaseViewModel
    {
        #region Main Propertys
        private List<University> universities;
        private List<Student> students;
        private University currentUniversity;
        private Student currentStudent;
        public List<University> Universities { get => universities; set => universities = value; }
        public List<Student> Students { get => students; set => students = value; }
        public University CurrentUniversity { get => currentUniversity; set => currentUniversity = value; }
        public Student CurrentStudent { get => currentStudent; set => currentStudent = value; }
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
            db.Universities.Load();
            Universities = db.Universities.ToList();
            
            
            #endregion

            #region Command init
            CloseAppCommand = new RelayCommand(OnCloseAppCommandExecute, CanCloseAppCommandExecute);
            #endregion
        }
    }
}
