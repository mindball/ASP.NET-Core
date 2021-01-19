namespace CameraBazaar.Data.Models.Enums
{
    using System;

    [Flags]
    public enum LightMetering
    {
        Spot = 0,
        CenterWeighted = 1,
        Evaluative = 2
    }
}
