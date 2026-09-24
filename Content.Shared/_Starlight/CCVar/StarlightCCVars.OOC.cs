using Robust.Shared.Configuration;

namespace Content.Shared._Starlight.CCVar;

public sealed partial class StarlightCCVars
{
    /// <summary>
    ///     Allow Roleplaying Notes, both public and personal
    /// </summary>
    public static readonly CVarDef<bool> OOCNotes =
        CVarDef.Create("ooc.rp_notes", true, CVar.SERVER | CVar.REPLICATED); //Ronstation: Make having RP note functionality default to on.
}
