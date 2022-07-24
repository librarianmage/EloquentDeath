using HarmonyLib;
using XRL;

namespace EloquentDeath.HarmonyPatches
{
    [HarmonyPatch(typeof(CheckpointingSystem))]
    [HarmonyPatch(nameof(CheckpointingSystem.ShowDeathMessage))]
    class DeathMessagePatcher
    {
        static void Prefix(ref string message)
        {
            message = message.Replace("You died.", "You became a cord in time's silly carpet.");
        }
    }
}
