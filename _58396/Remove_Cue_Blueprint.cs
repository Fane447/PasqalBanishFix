using System;
using HarmonyLib;

using Kingmaker.Blueprints;
using Kingmaker.Blueprints.JsonSystem;
using Kingmaker.DialogSystem.Blueprints;
using Kingmaker.ElementsSystem;


namespace _58396;



[HarmonyPatch(typeof(BlueprintsCache))]
static class Remove_Cue_Blueprint_Patch
{
    private static bool loaded = false;
    [HarmonyPatch(typeof(BlueprintsCache), "Init")]
    static void Postfix()
    {
        if (loaded) return;
        loaded = true;

        var dialog = ResourcesLibrary.TryGetBlueprint<BlueprintDialog>("c4131a3d9a594c9b99e0d729d5422a71");
        dialog.FirstCue.Cues.RemoveAt(0);

    }
}
