using Aurora.Controls;
using Aurora.Profiles.Terraria.GSI;
using Aurora.Settings;
using Ionic.Zip;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Aurora.Profiles.Terraria
{
    /// <summary>
    /// Interaction logic for Control_TER.xaml
    /// </summary>
    public partial class Control_TER : UserControl
    {
        private ProfileManager profile_manager;

        public Control_TER(ProfileManager profile)
        {
            InitializeComponent();

            profile_manager = profile;

            SetSettings();

            profile_manager.ProfileChanged += Profile_manager_ProfileChanged;
        }

        private void Profile_manager_ProfileChanged(object sender, EventArgs e)
        {
            SetSettings();
        }

        private void SetSettings()
        {
            this.profilemanager.ProfileManager = profile_manager;
            this.scriptmanager.ProfileManager = profile_manager;

            this.game_enabled.IsChecked = (profile_manager.Settings as TERSettings15).isEnabled;
            this.cz.ColorZonesList = (profile_manager.Settings as TERSettings15).lighting_areas;
        }

        private void game_enabled_Checked(object sender, RoutedEventArgs e)
        {
            if (IsLoaded)
            {
                (profile_manager.Settings as TERSettings15).isEnabled = (this.game_enabled.IsChecked.HasValue) ? this.game_enabled.IsChecked.Value : false;
                profile_manager.SaveProfiles();
            }
        }

        private void get_hook_button_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(@"http://paydaymods.com/download/"));
        }

        private void install_mod_button_Click(object sender, RoutedEventArgs e)
        {
            string TERpath = Utils.SteamUtils.GetGamePath(105600);

            if(!String.IsNullOrWhiteSpace(TERpath))
            {
                if(Directory.Exists(TERpath))
                {
                    if(Directory.Exists(System.IO.Path.Combine(TERpath, "mods")))
                    {
                        using (MemoryStream gsi_TER_ms = new MemoryStream(Properties.Resources.TER_GSI))
                        {
                            using (ZipFile zip = ZipFile.Read(gsi_TER_ms))
                            {
                                foreach (ZipEntry entry in zip)
                                {
                                    entry.Extract(TERpath, ExtractExistingFileAction.OverwriteSilently);
                                }
                            }

                        }

                        System.Windows.MessageBox.Show("GSI for Terraria installed.");
                    }
                    else
                    {
                        System.Windows.MessageBox.Show("BLT Hook was not found.\r\nCould not install the GSI mod.");
                    }
                }
                else
                {
                    System.Windows.MessageBox.Show("Terraria directory is not found.\r\nCould not install the GSI mod.");
                }
            }
            else
            {
                System.Windows.MessageBox.Show("Terraria is not installed through Steam.\r\nCould not install the GSI mod.");
            }
        }

        private void preview_playerstate_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            return;
        }

        private void preview_health_slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int hp_val = (int)this.preview_health_slider.Value;
            if (this.preview_health_amount is Label)
            {
                this.preview_health_amount.Content = hp_val + "%";
                (profile_manager.Event._game_state as GameState_TER).LocalPlayer.Health.Current = hp_val;
                (profile_manager.Event._game_state as GameState_TER).LocalPlayer.Health.Max = 100;
            }
        }

        private void preview_mana_slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int mana_val = (int)this.preview_mana_slider.Value;
            if (this.preview_mana_amount is Label)
            {
                this.preview_mana_amount.Content = mana_val + "%";
                (profile_manager.Event._game_state as GameState_TER).LocalPlayer.Mana.Current = mana_val;
                (profile_manager.Event._game_state as GameState_TER).LocalPlayer.Mana.Max = 100;
            }
        }

        private void cz_ColorZonesListUpdated(object sender, EventArgs e)
        {
            if (IsLoaded)
            {
                (profile_manager.Settings as TERSettings15).lighting_areas = (sender as ColorZones).ColorZonesList;
                profile_manager.SaveProfiles();
            }
        }
    }
}
