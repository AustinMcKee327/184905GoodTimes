/*Austin McKee
 * March 28th, 2019
 * This program takes the Input as in Ottawa Time, changes Ottawa Time into each other major City's Time zone, 
 * and outputs them in 24 hour time.
 */


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

namespace _184905Goodtimes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Background = Brushes.DarkOrange;
        }

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            string TempTime = InputBox.Text;
            int.TryParse(TempTime, out int OttawaTime);
            int VictoriaTime = OttawaTime - 300;
            int EdmontonTime = OttawaTime - 200;
            int WinnipegTime = OttawaTime - 100;
            int HalifaxTime = OttawaTime + 100;
            int StJohnsTime = OttawaTime + 130;
            
            if (StJohnsTime > 2359) StJohnsTime = StJohnsTime - 2400;
            if (StJohnsTime % 100 > 59) StJohnsTime = StJohnsTime - 60 + 100;
            if (HalifaxTime > 2359) HalifaxTime = HalifaxTime - 2400;
            if (VictoriaTime > 2359) VictoriaTime = VictoriaTime - 2400;
            if (WinnipegTime < 0) WinnipegTime = WinnipegTime + 2400;
            if (EdmontonTime < 0) EdmontonTime = EdmontonTime + 2400;
            if (VictoriaTime < 0) VictoriaTime = VictoriaTime + 2400;
            if(OttawaTime%100 > 59) OttawaTime = OttawaTime - 60 + 100;
            
            
            OutputLabel.Content = "The Time in Vitoria is... " + VictoriaTime.ToString() + Environment.NewLine + "The Time in Edmonton is... " 
                + EdmontonTime.ToString() + Environment.NewLine + "The Time in Ottawa and Toronto is... " + OttawaTime.ToString() 
                + Environment.NewLine + "The Time in Winnipeg is... " + WinnipegTime.ToString() + Environment.NewLine +
                "The Time in Halifax is... " + HalifaxTime.ToString() + Environment.NewLine + "The Time in St. John's is... " 
                + StJohnsTime.ToString() + Environment.NewLine;
        }
    }
}
