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

namespace Scoop_Store
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            loadingMain.Foreground = mijnKleuren.nordTheme.Nord10;
            loadingSub.Foreground = mijnKleuren.nordTheme.Nord10;
            depGrid.Background = mijnKleuren.bgCol;

        }
        public class mijnKleuren
        {
            public static Brush bgCol = mijnKleuren.nordTheme.Nord0;
            public static Brush fgCol = mijnKleuren.nordTheme.Nord4;
            public static Brush cursorCol = mijnKleuren.nordTheme.Nord4;

            public class nordTheme
            {
                public static Brush Nord0 = new SolidColorBrush(Color.FromRgb(46, 52, 64));
                public static Brush Nord1 = new SolidColorBrush(Color.FromRgb(59, 66, 82));
                public static Brush Nord2 = new SolidColorBrush(Color.FromRgb(67, 76, 94));
                public static Brush Nord3 = new SolidColorBrush(Color.FromRgb(76, 86, 106));
                public static Brush Nord4 = new SolidColorBrush(Color.FromRgb(216, 222, 233));
                public static Brush Nord5 = new SolidColorBrush(Color.FromRgb(229, 233, 240));
                public static Brush Nord6 = new SolidColorBrush(Color.FromRgb(236, 239, 244));
                public static Brush Nord7 = new SolidColorBrush(Color.FromRgb(143, 188, 187));
                public static Brush Nord8 = new SolidColorBrush(Color.FromRgb(136, 192, 208));
                public static Brush Nord9 = new SolidColorBrush(Color.FromRgb(129, 161, 193));
                public static Brush Nord10 = new SolidColorBrush(Color.FromRgb(94, 129, 172));
                public static Brush Nord11 = new SolidColorBrush(Color.FromRgb(191, 97, 106));
                public static Brush Nord12 = new SolidColorBrush(Color.FromRgb(208, 135, 112));
                public static Brush Nord13 = new SolidColorBrush(Color.FromRgb(235, 203, 139));
                public static Brush Nord14 = new SolidColorBrush(Color.FromRgb(163, 190, 140));
                public static Brush Nord15 = new SolidColorBrush(Color.FromRgb(180, 142, 173));
            }
        }

    }
}
