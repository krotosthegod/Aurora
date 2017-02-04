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
    public class TERStatesLayerHandlerProperties : LayerHandlerProperties2Color<TERStatesLayerHandlerProperties>
    {
        public Color? _DownedColor { get; set; }

        [JsonIgnore]
        public Color DownedColor { get { return Logic._DownedColor ?? _DownedColor ?? Color.Empty; } }

        public Color? _ArrestedColor { get; set; }

        [JsonIgnore]
        public Color ArrestedColor { get { return Logic._ArrestedColor ?? _ArrestedColor ?? Color.Empty; } }

        public Color? _SwanSongColor { get; set; }

        [JsonIgnore]
        public Color SwanSongColor { get { return Logic._SwanSongColor ?? _SwanSongColor ?? Color.Empty; } }

        public bool? _ShowSwanSong { get; set; }

        [JsonIgnore]
        public bool ShowSwanSong { get { return Logic._ShowSwanSong ?? _ShowSwanSong ?? false; } }

        public float? _SwanSongSpeedMultiplier { get; set; }

        [JsonIgnore]
        public float SwanSongSpeedMultiplier { get { return Logic._SwanSongSpeedMultiplier ?? _SwanSongSpeedMultiplier ?? 0.0F; } }

        public TERStatesLayerHandlerProperties() : base() { }

        public TERStatesLayerHandlerProperties(bool assign_default = false) : base(assign_default) { }

        public override void Default()
        {
            base.Default();

            _DownedColor = Color.White;
            _ArrestedColor = Color.DarkRed;
            _ShowSwanSong = true;
            _SwanSongColor = Color.FromArgb(158, 205, 255);
            _SwanSongSpeedMultiplier = 1.0f;
        }

    }

    public class TERStatesLayerHandler : LayerHandler<TERStatesLayerHandlerProperties>
    {
        public TERStatesLayerHandler() : base()
        {
            _Type = LayerType.TERStates;
        }

        protected override UserControl CreateControl()
        {
            return new Control_TERStatesLayer(this);
        }

        public override EffectLayer Render(IGameState state)
        {
            EffectLayer states_layer = new EffectLayer("Terraria - States");

            if (state is GameState_TER)
            {
                GameState_TER TERstate = (GameState_TER)state;
            }

            return states_layer;
        }

        public override void SetProfile(ProfileManager profile)
        {
            (_Control as Control_TERStatesLayer)?.SetProfile(profile);
        }
    }
}