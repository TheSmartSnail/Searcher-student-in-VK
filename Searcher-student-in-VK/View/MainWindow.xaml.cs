using System;
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

namespace Searcher_student_in_VK
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
            

        }

        //Обработка закрытия окна. Предлагает вызывать или не вызывать комманду SaveData в MainViewModel
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //string messageBoxText = "Хотите сохранить данные?";
            //string messageBoxCaption = "Закрыть";
            //MessageBoxResult result;

            //result = MessageBox.Show(messageBoxText, messageBoxCaption,MessageBoxButton.YesNoCancel);

            //switch (result)
            //{
            //    case MessageBoxResult.Cancel:
            //        e.Cancel = true;
            //        break;
            //    case MessageBoxResult.Yes:
            //        mainViewModel.SaveDataCommand.Execute(null);
            //        break;
            //    case MessageBoxResult.No:
            //        break;
            //    default:
            //        break;
            //}
        }
    }
}
