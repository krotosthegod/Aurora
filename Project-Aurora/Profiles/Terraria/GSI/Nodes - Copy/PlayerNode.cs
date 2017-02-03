using System.ComponentModel;

namespace Aurora.Profiles.Payday_2.GSI.Nodes
{
    /// <summary>
    /// Information about a player
    /// </summary>
    public class PlayerNode : Node<PlayerNode>
    {
        /// <summary>
        /// Tick
        /// </summary>
        public int Tick;

        /// <summary>
        /// Player health information
        /// </summary>
        public HealthNode Health;

        /// <summary>
        /// Player mana information
        /// </summary>
        public ManaNode Mana;

        internal PlayerNode(string JSON) : base(JSON)
        {
            Tick = GetInt("tick");
            Health = new HealthNode(_ParsedData["health"]?.ToString() ?? "");
            Mana = new ManaNode(_ParsedData["mana"]?.ToString() ?? "");
        }
    }

    /// <summary>
    /// Information about player's health
    /// </summary>
    public class HealthNode : Node<HealthNode>
    {
        /// <summary>
        /// Current health amount
        /// </summary>
        public float Current;

        /// <summary>
        /// Maximum health amount
        /// </summary>
        public float Max;

        internal HealthNode(string JSON) : base(JSON)
        {
            Current = GetFloat("hp");
            Max = GetFloat("hp_max");
        }
    }

    /// <summary>
    /// Information about player's mana
    /// </summary>
    public class ManaNode : Node<ManaNode>
    {
        /// <summary>
        /// Current amount of armor
        /// </summary>
        public float Current;

        /// <summary>
        /// Maximum amount of armor
        /// </summary>
        public float Max;

        internal ManaNode(string JSON) : base(JSON)
        {
            Current = GetFloat("current");
            Max = GetFloat("max");
        }
    }
}
