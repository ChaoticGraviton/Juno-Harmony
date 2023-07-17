namespace Assets.Scripts
{
    using HarmonyLib; // Including the Harmony Library

    public class Mod : ModApi.Mods.GameMod
    {
        private Mod() : base()
        {
        }
        public static Mod Instance { get; } = GetModInstance<Mod>();

        protected override void OnModInitialized()
        {
            Harmony harmony = new Harmony("Juno Harmony");
            harmony.PatchAll();
        }
    }
}