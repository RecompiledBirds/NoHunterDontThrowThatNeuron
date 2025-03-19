using BepInEx;
using MoreSlugcats;

namespace NoHunterPatches
{
    [BepInPlugin("RecompiledBirds.HunterKeepsNeuron", "No Hunter! Don't throw that neuron!", "0.0.1")]
    public class KeepNeuron : BaseUnityPlugin
    {

        public void Awake()
        {
            On.Player.IsObjectThrowable += IsThrowableHook;
            Logger.LogInfo("NSH has realized Hunter should not be allowed to throw the slag keys off a cliff.. finally.");
        }


        public bool IsThrowableHook(On.Player.orig_IsObjectThrowable orig, Player self, PhysicalObject obj)
        {
            if ((obj is NSHSwarmer) || (obj is SpearMasterPearl)) return false;

            return orig(self, obj);
        }
    }
}
