using System.Windows;
using System.Windows.Input;
using Prism.Commands;

namespace WpfFeatureDemo
{
    public class MainWindowViewModel
    {
        public MainWindowViewModel()
        {
            CloseCommand = new DelegateCommand(CloseMethod);
            MinimizeCommand = new DelegateCommand(MinimizeMethod);
            MaximizeCommand = new DelegateCommand(MaximizeMethod);
        }

        private void MaximizeMethod()
        {
            switch (Application.Current.MainWindow.WindowState)
            {
                case WindowState.Normal:
                    Application.Current.MainWindow.WindowState = WindowState.Maximized;
                    break;
                case WindowState.Maximized:
                    Application.Current.MainWindow.WindowState = WindowState.Normal;
                    break;
                default:
                    Application.Current.MainWindow.WindowState = WindowState.Normal;
                    break;
            }
        }

        private void MinimizeMethod()
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        private void CloseMethod()
        {
            Application.Current.MainWindow.Close();
        }

        public ICommand CloseCommand { get; set; }
        public ICommand MinimizeCommand { get; set; }
        public ICommand MaximizeCommand { get; set; }
    }
}
