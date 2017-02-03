using Aurora.Settings;
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

namespace Aurora.Profiles.Terraria.Layers
{
    /// <summary>
    /// Interaction logic for Control_TERStatesLayer.xaml
    /// </summary>
    public partial class Control_TERStatesLayer : UserControl
    {
        private bool settingsset = false;
        private bool profileset = false;

        public Control_TERStatesLayer()
        {
            InitializeComponent();
        }

        public Control_TERStatesLayer(TERStatesLayerHandler datacontext)
        {
            this.DataContext = datacontext.Properties;
            InitializeComponent();
        }


        internal void SetProfile(ProfileManager profile)
        {
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

            this.Loaded -= UserControl_Loaded;
        }

        private void sldSwanSongSpeed_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            this.lblSwanSongSpeed.Content = $"x {sldSwanSongSpeed.Value.ToString("0.00")}";
        }
    }
}
