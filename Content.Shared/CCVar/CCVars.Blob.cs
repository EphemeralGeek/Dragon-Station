using Robust.Shared;
using Robust.Shared.Configuration;
public sealed partial class CCVars : CVars
{
    /// <summary>
    /// Set Blob.max to change the maximum number of blobs
    /// Set Blob players per to limit ghost role creation by blob
    /// Set blob can growin in space to toggle space blob
    /// </summary>
    public static readonly CVarDef<int> BlobMax =
        CVarDef.Create("blob.max", 3, CVar.SERVERONLY);

    public static readonly CVarDef<int> BlobPlayersPer =
        CVarDef.Create("blob.players_per", 20, CVar.SERVERONLY);

    public static readonly CVarDef<bool> BlobCanGrowInSpace =
        CVarDef.Create("blob.grow_space", true, CVar.SERVER);
}
