namespace FFXIVClientStructs.FFXIV.Client.Game.InstanceContent;

// E9 ?? ?? ?? ?? 3D ?? ?? ?? ?? 0F 87 ?? ?? ?? ?? 3D ?? ?? ?? ?? 0F 83 ?? ?? ?? ?? 05 ?? ?? ?? ?? 83 F8 05
// has id >63000 in InstanceContent sheet
[StructLayout(LayoutKind.Explicit, Size = 0x1CA8 + 0x650)]
public struct InstanceContentOceanFishing {
    [FieldOffset(0x0)] public InstanceContentDirector InstanceContentDirector;

    // Row ID for IKDRoute sheet
    // Each zone (and their time of day) can be extracted from sheet
    [FieldOffset(0x1CD0)] public uint CurrentRoute;

    [FieldOffset(0x1CD8)] public byte CurrentZone; // 0, 1, 2

    // InstanceContentDirector.ContentDirector.ContentTimeLeft - TimeOffset = time left in current zone
    // After changing zones, seems to tick down independent of the UI and then jump up
    [FieldOffset(0x1CE0)] public uint TimeOffset;

    [FieldOffset(0x1CE8)] public bool SpectralCurrentActive;

    // Row ID for IKDPlayerMissionCondition sheet
    // Description and required amount can be extracted from sheet
    [FieldOffset(0x22E0)] public uint Mission1Type;
    [FieldOffset(0x22E4)] public uint Mission2Type;
    [FieldOffset(0x22E8)] public uint Mission3Type;

    // Progress can be larger than the mission's required amount
    [FieldOffset(0x22EC)] public ushort Mission1Progress;
    [FieldOffset(0x22EE)] public ushort Mission2Progress;
    [FieldOffset(0x22F0)] public ushort Mission3Progress;
}
