using System.Numerics;
using Robust.Shared.GameStates;

namespace Content.Client.Traits
{
    /// <summary>
    ///     Adjusts an entities height and zoom.
    /// </summary>
    [RegisterComponent, NetworkedComponent]
    public sealed partial class HeightAdjustedComponent : Component
    {
        [ViewVariables(VVAccess.ReadWrite)]
        public Vector2 OriginalScale { get; set; } = Vector2.One;
        [ViewVariables(VVAccess.ReadOnly)]
        public Vector2 NewScale { get; set; } = Vector2.One;

        [DataField("width", required: true), ViewVariables(VVAccess.ReadWrite)]
        public float Width { get; set; }

        [DataField("height", required: true), ViewVariables(VVAccess.ReadWrite)]
        public float Height { get; set; }
    }
}
