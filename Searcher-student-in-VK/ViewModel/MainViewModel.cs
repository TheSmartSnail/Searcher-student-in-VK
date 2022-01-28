using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Searcher_student_in_VK.Infrastructure.Command;
using System.Windows.Input;
using System.Windows;
using Microsoft.EntityFrameworkCore;
using Searcher_student_in_VK.Infrastructure.Data.EntityDbContext;
using Searcher_student_in_VK.Model;
using System.Linq;
using System.Windows.Media.Imaging;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Threading;

namespace Searcher_student_in_VK.ViewModel
{
    internal class MainViewModel: BaseViewModel
    {


        #region Main Propertys
        private ObservableCollection<University> universities = AccessUniDB.GetUniversities();
        public ObservableCollection<University> Universities { get => universities; set=> Set(ref universities, value); }
        public List<Student> Students { get; set; }

        private University currentUniversity;
        public University CurrentUniversity { get => currentUniversity; set => Set(ref currentUniversity, value); }
        private Student currentStudent;
        public Student CurrentStundent { get => currentStudent; set => Set(ref currentStudent, value);
    }

    public BitmapImage BitImage { get; set; }


        #endregion

        #region Commands

        #region Add Uni
        public ICommand AddUniCommand { get; }
        private string nameNewUni;
        public string NameNewUni { get => nameNewUni; set => Set(ref nameNewUni,value); }
      
        private bool CanAddUniAppCommandExecute(object p) => true;
        private void OnAddUniCommandExecute(object p)
        {
            University uni = new University(nameNewUni);
            Universities.Add(uni);
            AccessUniDB.Add(uni);
            
        }
        #endregion


        #region Del Uni 
        public ICommand DelUniCommand { get; }
        
        private bool CanDelUniAppCommandExecute(object p) => true;
        private void OnDelUniCommandExecute(object p)
        {
            Universities.Remove(CurrentUniversity);
            AccessUniDB.Remove(currentUniversity);
        }
        #endregion

        #region Edit Uni 
        public ICommand EditUniCommand { get; }
        private bool CanEditUniAppCommandExecute(object p) => true;
        private void OnEditUniCommandExecute(object p)
        {
            int ind = Universities.IndexOf(CurrentUniversity);
            universities[ind].Name = nameNewUni;
            AccessUniDB.Edit(ind, nameNewUni);
            
        }
        #endregion

        #region SaveData
        public ICommand SaveDataCommand { get; }
        private bool SaveDataAppCommandExecute(object p) => true;
        private void OnSaveDataCommandExecute(object p)
        {
            AccessUniDB.Save();

        }
        #endregion

        #endregion


        public MainViewModel()
        {
            #region Command init
            AddUniCommand = new RelayCommand(OnAddUniCommandExecute, CanAddUniAppCommandExecute);
            EditUniCommand = new RelayCommand(OnEditUniCommandExecute, CanEditUniAppCommandExecute);
            DelUniCommand = new RelayCommand(OnDelUniCommandExecute, CanDelUniAppCommandExecute);
            SaveDataCommand = new RelayCommand(OnSaveDataCommandExecute, SaveDataAppCommandExecute);
            #endregion

            #region Propertys init

            
            
            #endregion

            
        }
    }
}
