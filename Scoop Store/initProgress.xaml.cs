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
using System.Windows.Shapes;
using static Scoop_Store.MainWindow;

namespace Scoop_Store
{
    /// <summary>
    /// Interaction logic for initProgress.xaml
    /// </summary>
    public partial class initProgress : Window
    {
        public initProgress()
        {
            InitializeComponent();
            InitializeComponent();
            loadingMain.Foreground = mijnKleuren.nordTheme.Nord10;
            loadingSub.Foreground = mijnKleuren.nordTheme.Nord10;
            depGrid.Background = mijnKleuren.bgCol;
        }
    }
}
