﻿using System.Runtime.InteropServices;
using FFXIVClientStructs.Common;

namespace FFXIVClientStructs.FFXIV.Client.Game.Character
{
    [StructLayout(LayoutKind.Explicit, Size = 0x338)]
    public unsafe partial struct CharacterManager
    {
        [StaticAddress("8B D0 48 8D 0D ?? ?? ?? ?? E8 ?? ?? ?? ?? 48 8B D8 48 85 C0 74 3A")]
        public static partial CharacterManager* Instance();

        [MemberFunction("E8 ?? ?? ?? ?? 48 85 C0 74 55 49 63 8E")]
        public partial BattleChara* LookupBattleCharaByObjectId(int objectId);
    }
}