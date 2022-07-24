using HarmonyLib;

namespace EloquentDeath.HarmonyPatches
{
    [HarmonyPatch(typeof(XRL.CheckpointingSystem),nameof(XRL.CheckpointingSystem.ShowDeathMessage))]
    class LorePatcher
    {
        static void Prefix(ref string message)
        {
            message = message.Replace("You died.", "You became a cord in time's silly carpet.");
        }
    }
}
