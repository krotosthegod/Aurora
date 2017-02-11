using System;
using System.Collections.Generic;
using Aurora.EffectsEngine;
using Aurora.Profiles.Terraria.GSI;
using System.Drawing;
using Aurora.Profiles.Terraria.GSI.Nodes;
using System.Linq;

namespace Aurora.Profiles.Terraria
{
    public class GameEvent_TER : LightEvent
    {
        public GameEvent_TER() : base()
        {
            System.Diagnostics.Debug.WriteLine("\n=======================================");
            System.Diagnostics.Debug.WriteLine("Creating GameEvent_TER");
            System.Diagnostics.Debug.WriteLine("=======================================\n");
        }

        public override void UpdateLights(EffectFrame frame)
        {
            Queue<EffectLayer> layers = new Queue<EffectLayer>();

            TERSettings settings = (TERSettings)this.Profile.Settings;

            foreach (var layer in settings.Layers.Reverse().ToArray())
            {
                if (layer.Enabled && layer.LogicPass)
                    layers.Enqueue(layer.Render(_game_state));
            }

            //Scripts
            this.Profile.UpdateEffectScripts(layers, _game_state);

            //ColorZones
            layers.Enqueue(new EffectLayer("TER - Color Zones").DrawColorZones((this.Profile.Settings as TERSettings).lighting_areas.ToArray()));

            frame.AddLayers(layers.ToArray());

            System.Diagnostics.Debug.WriteLine("\n=======================================");
            System.Diagnostics.Debug.WriteLine("UpdateLights() - 1");
            System.Diagnostics.Debug.WriteLine("=======================================\n");
        }

        public override void UpdateLights(EffectFrame frame, IGameState new_game_state)
        {
            if (new_game_state is GameState_TER)
            {
                _game_state = new_game_state;
                GameState_TER gs = (new_game_state as GameState_TER);

                try
                {
                    UpdateLights(frame);
                }
                catch (Exception e)
                {
                    Global.logger.LogLine("Exception during OnNewGameState. Error: " + e, Logging_Level.Error);
                    Global.logger.LogLine(gs.ToString(), Logging_Level.None);
                }
            }
            System.Diagnostics.Debug.WriteLine("\n=======================================");
            System.Diagnostics.Debug.WriteLine("UpdateLights() - 2");
            System.Diagnostics.Debug.WriteLine("=======================================\n");
        }

        public override void ResetGameState()
        {
            _game_state = new GameState_TER();
        }

        public override bool IsEnabled()
        {
            return this.Profile.Settings.isEnabled;
        }
    }
}
