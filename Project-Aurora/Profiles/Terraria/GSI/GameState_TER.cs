using Aurora.Profiles.Terraria.GSI.Nodes;
using Aurora.Settings;
using Newtonsoft.Json.Linq;
using System;

namespace Aurora.Profiles.Terraria.GSI
{
    /// <summary>
    /// A class representing various information retaining to Payday 2
    /// </summary>
    public class GameState_TER : GameState<GameState_TER>
    {
        private ProviderNode _Provider;
        private PlayerNode _LocalPlayer;

        /// <summary>
        /// Information about the provider of this GameState
        /// </summary>
        public ProviderNode Provider
        {
            get
            {
                if (_Provider == null)
                    _Provider = new ProviderNode(_ParsedData["provider"]?.ToString() ?? "");

                // System.Diagnostics.Debug.WriteLine(_Provider);
                return _Provider;
            }
        }

        /// <summary>
        /// Information about the local player
        /// </summary>
        public PlayerNode LocalPlayer
        {
            get
            {
                if (_LocalPlayer == null)
                    _LocalPlayer = new PlayerNode(_ParsedData["player"]?.ToString() ?? "");

                // System.Diagnostics.Debug.WriteLine(_LocalPlayer);
                return _LocalPlayer;
            }
        }

        /// <summary>
        /// Creates a default GameState_TER instance.
        /// </summary>
        public GameState_TER()
        {
            json = "{}";
            _ParsedData = Newtonsoft.Json.Linq.JObject.Parse(json);

            System.Diagnostics.Debug.WriteLine("\n=======================================");
            System.Diagnostics.Debug.WriteLine("Creating GameState_TER - 1");
            System.Diagnostics.Debug.WriteLine(_ParsedData);
            System.Diagnostics.Debug.WriteLine("=======================================\n");
        }

        /// <summary>
        /// Creates a GameState_TER instance based on the passed json data.
        /// </summary>
        /// <param name="JSONstring">The passed json data</param>
        public GameState_TER(string JSONstring)
        {
            if (String.IsNullOrWhiteSpace(JSONstring))
                JSONstring = "{}";

            json = JSONstring;
            _ParsedData = JObject.Parse(JSONstring);
            System.Diagnostics.Debug.WriteLine("\n=======================================");
            System.Diagnostics.Debug.WriteLine("Creating GameState_TER - 2");
            System.Diagnostics.Debug.WriteLine("=======================================\n");
        }

        /// <summary>
        /// A copy constructor, creates a GameState_CSGO instance based on the data from the passed GameState instance.
        /// </summary>
        /// <param name="other_state">The passed GameState</param>
        public GameState_TER(IGameState other_state) : base(other_state)
        {
            System.Diagnostics.Debug.WriteLine("\n=======================================");
            System.Diagnostics.Debug.WriteLine("Creating GameState_TER - 3");
            System.Diagnostics.Debug.WriteLine("=======================================\n");
        }
    }
}
