using Aurora.EffectsEngine;
using Aurora.Profiles.Terraria.GSI;
using Aurora.Profiles.Terraria.GSI.Nodes;
using Aurora.Settings;
using Aurora.Settings.Layers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Aurora.Profiles.Terraria.Layers
{
    public class TERBackgroundLayerHandlerProperties : LayerHandlerProperties2Color<TERBackgroundLayerHandlerProperties>
    {
        public Color? _AmbientColor { get; set; }

        [JsonIgnore]
        public Color AmbientColor { get { return Logic._AmbientColor ?? _AmbientColor ?? Color.Empty; } }

        public Color? _AssaultColor { get; set; }

        [JsonIgnore]
        public Color AssaultColor { get { return Logic._AssaultColor ?? _AssaultColor ?? Color.Empty; } }

        public Color? _WintersColor { get; set; }

        [JsonIgnore]
        public Color WintersColor { get { return Logic._WintersColor ?? _WintersColor ?? Color.Empty; } }

        public float? _AssaultSpeedMultiplier { get; set; }

        [JsonIgnore]
        public float AssaultSpeedMultiplier { get { return Logic._AssaultSpeedMultiplier ?? _AssaultSpeedMultiplier ?? 0.0F; } }

        public Color? _AssaultFadeColor { get; set; }

        [JsonIgnore]
        public Color AssaultFadeColor { get { return Logic._AssaultFadeColor ?? _AssaultFadeColor ?? Color.Empty; } }

        public bool? _AssaultAnimationEnabled { get; set; }

        [JsonIgnore]
        public bool AssaultAnimationEnabled { get { return Logic._AssaultAnimationEnabled ?? _AssaultAnimationEnabled ?? false; } }

        public Color? _LowSuspicionColor { get; set; }

        [JsonIgnore]
        public Color LowSuspicionColor { get { return Logic._LowSuspicionColor ?? _LowSuspicionColor ?? Color.Empty; } }

        public Color? _MediumSuspicionColor { get; set; }

        [JsonIgnore]
        public Color MediumSuspicionColor { get { return Logic._MediumSuspicionColor ?? _MediumSuspicionColor ?? Color.Empty; } }

        public Color? _HighSuspicionColor { get; set; }

        [JsonIgnore]
        public Color HighSuspicionColor { get { return Logic._HighSuspicionColor ?? _HighSuspicionColor ?? Color.Empty; } }

        public bool? _ShowSuspicion { get; set; }

        [JsonIgnore]
        public bool ShowSuspicion { get { return Logic._ShowSuspicion ?? _ShowSuspicion ?? false; } }

        public PercentEffectType? _SuspicionEffectType { get; set; }

        public PercentEffectType SuspicionEffectType { get { return Logic._SuspicionEffectType ?? _SuspicionEffectType ?? PercentEffectType.AllAtOnce; } }

        public bool? _PeripheralUse { get; set; }

        [JsonIgnore]
        public bool PeripheralUse { get { return Logic._PeripheralUse ?? _PeripheralUse ?? false; } }


        public TERBackgroundLayerHandlerProperties() : base() { }

        public TERBackgroundLayerHandlerProperties(bool assign_default = false) : base(assign_default) { }

        public override void Default()
        {
            base.Default();

            _AmbientColor = Color.FromArgb(158, 205, 255);
            _AssaultColor = Color.FromArgb(158, 205, 255);
            _WintersColor = Color.FromArgb(221, 99, 33);
            _AssaultSpeedMultiplier = 1.0f;
            _AssaultFadeColor = Color.FromArgb(255, 255, 255);
            _AssaultAnimationEnabled = true;
            _LowSuspicionColor = Color.FromArgb(0, 0, 0, 255);
            _MediumSuspicionColor = Color.FromArgb(255, 0, 0, 255);
            _HighSuspicionColor = Color.FromArgb(255, 255, 0, 0);
            _ShowSuspicion = true;
            _SuspicionEffectType = PercentEffectType.Progressive;
            _PeripheralUse = true;
        }

    }

    public class TERBackgroundLayerHandler : LayerHandler<TERBackgroundLayerHandlerProperties>
    {
        private float no_return_flashamount = 1.0f;
        private float no_return_timeleft;

        public TERBackgroundLayerHandler() : base()
        {
            _Type = LayerType.TERBackground;
        }

        protected override UserControl CreateControl()
        {
            return new Control_TERBackgroundLayer(this);
        }

        public override EffectLayer Render(IGameState state)
        {
            EffectLayer bg_layer = new EffectLayer("Terraria - Background");

            if (state is GameState_TER)
            {

                GameState_TER TER = (GameState_TER)state;

                Color bg_color = Properties.AmbientColor;

                long currenttime = Utils.Time.GetMillisecondsSinceEpoch();
            }

            return bg_layer;
        }

        public override void SetProfile(ProfileManager profile)
        {
            (_Control as Control_TERBackgroundLayer)?.SetProfile(profile);
        }
    }
}