using Aurora.Profiles.Terraroa.GSI;
using Aurora.Settings;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Aurora.Profiles.Terraria
{
    public class TERProfileManager : ProfileManager
    {
        public TERProfileManager()
            : base("Terraria", "ter", "Terraria.exe", typeof(TERSettings), typeof(Control_TER), new GameEvent_TER())
        {
            this.AvailableLayers.Add(Aurora.Settings.Layers.LayerType.TERBackground);
            // this.AvailableLayers.Add(Aurora.Settings.Layers.LayerType.PD2Flashbang);
            this.AvailableLayers.Add(Aurora.Settings.Layers.LayerType.TERStates);

            IconURI = "Resources/ter_64x64.png";
        }
    }
}
