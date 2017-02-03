using Aurora.Settings;
using System.Collections.Generic;
using System.Drawing;

namespace Aurora.Profiles.Terraria
{
    public class TERSettings : ProfileSettings
    {
        //Effects 
        //// Background 
        public bool bg_enabled;
        // public Color assault_color;
        // public Color winters_color;
        // public Color assault_fade_color;
        // public float assault_speed_mult;
        // public bool assault_animation_enabled;
        public Color ambient_color;
        // public Color low_suspicion_color;
        // public Color medium_suspicion_color;
        // public Color high_suspicion_color;
        // public bool bg_show_suspicion;
        // public PercentEffectType suspicion_effect_type;
        public bool bg_peripheral_use;

        //// Health 
        public bool health_enabled;
        public Color health_color;
        // public Color hurt_color;
        public PercentEffectType health_effect_type;
        public KeySequence health_sequence;

        //// Mana
        public bool mana_enabled;
        public Color mana_color;
        // public Color noammo_color;
        public PercentEffectType mana_effect_type;
        public KeySequence mana_sequence;

        //// States 
        // public Color downed_color;
        // public Color arrested_color;

        //// Swan Song 
        // public bool swansong_enabled;
        // public Color swansong_color;
        // public float swansong_speed_mult;

        //// Lighting Areas 
        public List<ColorZone> lighting_areas { get; set; }


        public TERSettings()
        {
            //General
            isEnabled = true;

            Layers = new System.Collections.ObjectModel.ObservableCollection<Settings.Layers.Layer>
            {
                // new Settings.Layers.Layer("Payday 2 Flashbang", new Payday_2.Layers.PD2FlashbangLayerHandler()),
                new Settings.Layers.Layer("Health Indicator", new Settings.Layers.PercentLayerHandler()
                {
                    Properties = new Settings.Layers.PercentLayerHandlerProperties()
                    {
                        _PrimaryColor =  Color.FromArgb(0, 255, 0),
                        _SecondaryColor = Color.FromArgb(255, 0, 0),
                        _PercentType = PercentEffectType.Progressive_Gradual,
                        _Sequence = new KeySequence(new Devices.DeviceKeys[] {
                            Devices.DeviceKeys.F1, Devices.DeviceKeys.F2, Devices.DeviceKeys.F3, Devices.DeviceKeys.F4,
                            Devices.DeviceKeys.F5, Devices.DeviceKeys.F6, Devices.DeviceKeys.F7, Devices.DeviceKeys.F8,
                            Devices.DeviceKeys.F9, Devices.DeviceKeys.F10, Devices.DeviceKeys.F11, Devices.DeviceKeys.F12
                        }),
                        _BlinkThreshold = 0.0,
                        _BlinkDirection = false,
                        _VariablePath = "LocalPlayer/Health/Current",
                        _MaxVariablePath = "LocalPlayer/Health/Max"
                    },
                }),
                new Settings.Layers.Layer("Mana Indicator", new Settings.Layers.PercentLayerHandler()
                {
                    Properties = new Settings.Layers.PercentLayerHandlerProperties()
                    {
                        _PrimaryColor =  Color.FromArgb(0, 0, 255),
                        _SecondaryColor = Color.FromArgb(0, 0, 255),
                        _PercentType = PercentEffectType.Progressive_Gradual,
                        _Sequence = new KeySequence(new Devices.DeviceKeys[] {
                            Devices.DeviceKeys.ONE, Devices.DeviceKeys.TWO, Devices.DeviceKeys.THREE, Devices.DeviceKeys.FOUR,
                            Devices.DeviceKeys.FIVE, Devices.DeviceKeys.SIX, Devices.DeviceKeys.SEVEN, Devices.DeviceKeys.EIGHT,
                            Devices.DeviceKeys.NINE, Devices.DeviceKeys.ZERO, Devices.DeviceKeys.MINUS, Devices.DeviceKeys.EQUALS
                        }),
                        _BlinkThreshold = 0.0,
                        _BlinkDirection = false,
                        _VariablePath = "LocalPlayer/Mana/Current",
                        _MaxVariablePath = "LocalPlayer/Mana/Max"
                    },
                }),
                // new Settings.Layers.Layer("Payday 2 States", new Payday_2.Layers.PD2StatesLayerHandler()),
                new Settings.Layers.Layer("Payday 2 Background", new Payday_2.Layers.PD2BackgroundLayerHandler())
            };

            //Effects 
            //// Background 
            bg_enabled = true;
            // assault_color = Color.FromArgb(158, 205, 255);
            // winters_color = Color.FromArgb(221, 99, 33);
            // assault_fade_color = Color.FromArgb(255, 255, 255);
            // assault_speed_mult = 1.0f;
            // assault_animation_enabled = true;
            ambient_color = Color.FromArgb(158, 205, 255);
            // low_suspicion_color = Color.FromArgb(0, 0, 0, 255);
            // medium_suspicion_color = Color.FromArgb(255, 0, 0, 255);
            // high_suspicion_color = Color.FromArgb(255, 255, 0, 0);
            // bg_show_suspicion = true;
            // suspicion_effect_type = PercentEffectType.Progressive;
            bg_peripheral_use = true;

            //// Health 
            health_enabled = true;
            // gold_health_color = Color.FromArgb(255, 215, 0);
            health_color = Color.FromArgb(255, 0, 0);
            // hurt_color = Color.FromArgb(255, 0, 0);
            health_effect_type = PercentEffectType.Progressive_Gradual;
            health_sequence = new KeySequence(new Devices.DeviceKeys[] { Devices.DeviceKeys.F1, Devices.DeviceKeys.F2, Devices.DeviceKeys.F3, Devices.DeviceKeys.F4, Devices.DeviceKeys.F5, Devices.DeviceKeys.F6, Devices.DeviceKeys.F7, Devices.DeviceKeys.F8, Devices.DeviceKeys.F9, Devices.DeviceKeys.F10, Devices.DeviceKeys.F11, Devices.DeviceKeys.F12 });

            //// Ammo 
            mana_enabled = true;
            mana_color = Color.FromArgb(0, 0, 255);
            // noammo_color = Color.FromArgb(255, 0, 0);
            mana_effect_type = PercentEffectType.Progressive;
            mana_sequence = new KeySequence(new Devices.DeviceKeys[] { Devices.DeviceKeys.ONE, Devices.DeviceKeys.TWO, Devices.DeviceKeys.THREE, Devices.DeviceKeys.FOUR, Devices.DeviceKeys.FIVE, Devices.DeviceKeys.SIX, Devices.DeviceKeys.SEVEN, Devices.DeviceKeys.EIGHT, Devices.DeviceKeys.NINE, Devices.DeviceKeys.ZERO, Devices.DeviceKeys.MINUS, Devices.DeviceKeys.EQUALS });

            //// States 
            // downed_color = Color.White;
            // arrested_color = Color.DarkRed;

            //// Swan Song 
            // swansong_enabled = true;
            // swansong_color = Color.FromArgb(158, 205, 255);
            // swansong_speed_mult = 1.0f;

            //// Lighting Areas 
            lighting_areas = new List<ColorZone>();
        }
    }
}
