using Aurora.Settings;
using System.Collections.Generic;
using System.Drawing;

namespace Aurora.Profiles.Terraria
{
    public class TERSettings15 : ProfileSettings
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


        public TERSettings15()
        {
            //General
            isEnabled = true;

            Layers = new System.Collections.ObjectModel.ObservableCollection<Settings.Layers.Layer>
            {
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
                        _PrimaryColor =  Color.FromArgb(0, 255, 255),
                        _SecondaryColor = Color.FromArgb(255, 255, 255),
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
                new Settings.Layers.Layer("Terraria Background", new Terraria.Layers.TERBackgroundLayerHandler())
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
            //health_sequence = new KeySequence(new Devices.DeviceKeys[] { Devices.DeviceKeys.F1, Devices.DeviceKeys.F2, Devices.DeviceKeys.F3, Devices.DeviceKeys.F4, Devices.DeviceKeys.F5, Devices.DeviceKeys.F6, Devices.DeviceKeys.F7, Devices.DeviceKeys.F8, Devices.DeviceKeys.F9, Devices.DeviceKeys.F10, Devices.DeviceKeys.F11, Devices.DeviceKeys.F12 });
            health_sequence = new KeySequence(new Devices.DeviceKeys[] { Devices.DeviceKeys.ESC, Devices.DeviceKeys.F1, Devices.DeviceKeys.F2, Devices.DeviceKeys.F3, Devices.DeviceKeys.F4, Devices.DeviceKeys.F5, Devices.DeviceKeys.F6, Devices.DeviceKeys.F7, Devices.DeviceKeys.F8, Devices.DeviceKeys.F9, Devices.DeviceKeys.F10, Devices.DeviceKeys.F12, Devices.DeviceKeys.TILDE, Devices.DeviceKeys.ONE, Devices.DeviceKeys.TWO, Devices.DeviceKeys.THREE, Devices.DeviceKeys.FOUR, Devices.DeviceKeys.FIVE, Devices.DeviceKeys.SIX, Devices.DeviceKeys.SEVEN, Devices.DeviceKeys.EIGHT, Devices.DeviceKeys.NINE, Devices.DeviceKeys.ZERO, Devices.DeviceKeys.MINUS, Devices.DeviceKeys.EQUALS, Devices.DeviceKeys.BACKSPACE, Devices.DeviceKeys.TAB, Devices.DeviceKeys.Q, Devices.DeviceKeys.W, Devices.DeviceKeys.E, Devices.DeviceKeys.R, Devices.DeviceKeys.T, Devices.DeviceKeys.Y, Devices.DeviceKeys.U, Devices.DeviceKeys.I, Devices.DeviceKeys.O, Devices.DeviceKeys.P, Devices.DeviceKeys.OPEN_BRACKET, Devices.DeviceKeys.CLOSE_BRACKET, Devices.DeviceKeys.BACKSLASH, Devices.DeviceKeys.CAPS_LOCK, Devices.DeviceKeys.A, Devices.DeviceKeys.S, Devices.DeviceKeys.D, Devices.DeviceKeys.F, Devices.DeviceKeys.G, Devices.DeviceKeys.H, Devices.DeviceKeys.J, Devices.DeviceKeys.K, Devices.DeviceKeys.L, Devices.DeviceKeys.SEMICOLON, Devices.DeviceKeys.APOSTROPHE, Devices.DeviceKeys.ENTER, Devices.DeviceKeys.LEFT_SHIFT, Devices.DeviceKeys.Z, Devices.DeviceKeys.X, Devices.DeviceKeys.C, Devices.DeviceKeys.V, Devices.DeviceKeys.B, Devices.DeviceKeys.N, Devices.DeviceKeys.M, Devices.DeviceKeys.COMMA, Devices.DeviceKeys.PERIOD, Devices.DeviceKeys.FORWARD_SLASH, Devices.DeviceKeys.RIGHT_SHIFT, Devices.DeviceKeys.LEFT_CONTROL, Devices.DeviceKeys.LEFT_WINDOWS, Devices.DeviceKeys.LEFT_ALT, Devices.DeviceKeys.SPACE, Devices.DeviceKeys.RIGHT_ALT, Devices.DeviceKeys.RIGHT_WINDOWS, Devices.DeviceKeys.RIGHT_CONTROL, Devices.DeviceKeys.G1, Devices.DeviceKeys.G2, Devices.DeviceKeys.G3, Devices.DeviceKeys.G4, Devices.DeviceKeys.G5, Devices.DeviceKeys.G6, Devices.DeviceKeys.G7, Devices.DeviceKeys.G8, Devices.DeviceKeys.G9, Devices.DeviceKeys.G10, Devices.DeviceKeys.G11, Devices.DeviceKeys.G12, Devices.DeviceKeys.G13, Devices.DeviceKeys.G14, Devices.DeviceKeys.G15, Devices.DeviceKeys.G16, Devices.DeviceKeys.G17, Devices.DeviceKeys.G18, Devices.DeviceKeys.G19, Devices.DeviceKeys.G20, Devices.DeviceKeys.ADDITIONALLIGHT1, Devices.DeviceKeys.ADDITIONALLIGHT2, Devices.DeviceKeys.ADDITIONALLIGHT3, Devices.DeviceKeys.ADDITIONALLIGHT4, Devices.DeviceKeys.ADDITIONALLIGHT5, Devices.DeviceKeys.ADDITIONALLIGHT6, Devices.DeviceKeys.ADDITIONALLIGHT7, Devices.DeviceKeys.ADDITIONALLIGHT8, Devices.DeviceKeys.ADDITIONALLIGHT9, Devices.DeviceKeys.ADDITIONALLIGHT10 });

            //// Ammo 
            mana_enabled = true;
            mana_color = Color.FromArgb(255, 0, 255);
            // noammo_color = Color.FromArgb(255, 0, 0);
            mana_effect_type = PercentEffectType.Progressive_Gradual;
            //mana_sequence = new KeySequence(new Devices.DeviceKeys[] { Devices.DeviceKeys.ONE, Devices.DeviceKeys.TWO, Devices.DeviceKeys.THREE, Devices.DeviceKeys.FOUR, Devices.DeviceKeys.FIVE, Devices.DeviceKeys.SIX, Devices.DeviceKeys.SEVEN, Devices.DeviceKeys.EIGHT, Devices.DeviceKeys.NINE, Devices.DeviceKeys.ZERO, Devices.DeviceKeys.MINUS, Devices.DeviceKeys.EQUALS });
            mana_sequence = new KeySequence(new Devices.DeviceKeys[] { Devices.DeviceKeys.PRINT_SCREEN, Devices.DeviceKeys.SCROLL_LOCK, Devices.DeviceKeys.PAUSE_BREAK, Devices.DeviceKeys.INSERT, Devices.DeviceKeys.HOME, Devices.DeviceKeys.PAGE_UP, Devices.DeviceKeys.DELETE, Devices.DeviceKeys.END, Devices.DeviceKeys.PAGE_DOWN, Devices.DeviceKeys.ARROW_UP, Devices.DeviceKeys.ARROW_LEFT, Devices.DeviceKeys.ARROW_DOWN, Devices.DeviceKeys.ARROW_RIGHT, Devices.DeviceKeys.BRIGHTNESS_SWITCH, Devices.DeviceKeys.LOCK_SWITCH, Devices.DeviceKeys.MEDIA_PLAY_PAUSE, Devices.DeviceKeys.MEDIA_PLAY, Devices.DeviceKeys.MEDIA_PAUSE, Devices.DeviceKeys.MEDIA_STOP, Devices.DeviceKeys.MEDIA_PREVIOUS, Devices.DeviceKeys.MEDIA_NEXT, Devices.DeviceKeys.VOLUME_MUTE, Devices.DeviceKeys.VOLUME_UP, Devices.DeviceKeys.NUM_LOCK, Devices.DeviceKeys.NUM_SLASH, Devices.DeviceKeys.NUM_ASTERISK, Devices.DeviceKeys.NUM_MINUS, Devices.DeviceKeys.NUM_SEVEN, Devices.DeviceKeys.NUM_EIGHT, Devices.DeviceKeys.NUM_NINE, Devices.DeviceKeys.NUM_PLUS, Devices.DeviceKeys.NUM_FOUR, Devices.DeviceKeys.NUM_FIVE, Devices.DeviceKeys.NUM_SIX, Devices.DeviceKeys.NUM_ONE, Devices.DeviceKeys.NUM_TWO, Devices.DeviceKeys.NUM_THREE, Devices.DeviceKeys.NUM_ENTER, Devices.DeviceKeys.NUM_ZERO, Devices.DeviceKeys.NUM_PERIOD });

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
