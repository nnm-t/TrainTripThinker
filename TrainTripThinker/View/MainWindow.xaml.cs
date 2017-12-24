using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using MahApps.Metro.Controls;

using TrainTripThinker.ViewModel;

namespace TrainTripThinker.View
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private readonly MainWindowViewModel vm;

        public MainWindow()
        {
            InitializeComponent();

            vm = DataContext as MainWindowViewModel;
        }

        private void OnClosing(object sender, CancelEventArgs e)
        {
            // Windowが落とされた時にViewModelの終了確認を呼び出す
            // Command経由でコールできなかったのでコードビハインド使用(Modelは直接触らない)
            vm.OnClosingWindow(e);
        }
    }
}
