﻿using HarmonyLib;
using Verse;

namespace PsychicDryadsPatch
{
    public class Mod: Verse.Mod
    {
        public Mod(ModContentPack content) : base(content)
        {
#if DEBUG
            Harmony.DEBUG = true;
#endif
            new Harmony("Garethp.rimworld.PsychicDryadsPatch.main").PatchAll();
        }
    }
}