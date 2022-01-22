using MelonLoader;

namespace TestMod
{
    public static class BuildInfo
    {
        public const string Name = "TestMod"; // Name of the mod
        public const string Description = "Mod for Testing"; // Description of the Mod.
        public const string Author = "TestAuthor"; // Author of the Mod. 
        public const string Company = null; // Company that made the Mod, just set it to null if there is none.
        public const string Version = "1.0.0"; // Version of the Mod.
        public const string DownloadLink = null; // Download Link for the Mod, just set it to null if there is none
    }

    public class TestMod : MelonMod
    {
        public override void OnApplicationStart() // Runs after Game Initialization.
        {
            MelonLogger.Msg("Hello, world!");
        }

        public override void OnApplicationLateStart() // Runs after OnApplicationStart.
        {
            MelonLogger.Msg("OnApplicationLateStart");
        }

        public override void OnSceneWasLoaded(int buildindex, string sceneName) // Runs when a Scene has Loaded and prints the scene buildindex (ususally 0) and the name.
        {
            MelonLogger.Msg("OnSceneWasLoaded: " + buildindex.ToString() + " | " + sceneName);
        }

        public override void OnSceneWasInitialized(int buildindex, string sceneName) // Runs when a Scene has Initialized and prints the scene buildindex (usually 0) and the name.
        {
            MelonLogger.Msg("OnSceneWasInitialized: " + buildindex.ToString() + " | " + sceneName);
        }

        public override void OnUpdate() // Runs once per frame.
        {
            MelonLogger.Msg("OnUpdate");
        }

        public override void OnFixedUpdate() // Can run multiple times per frame. Mostly used for Physics.
        {
            MelonLogger.Msg("OnFixedUpdate");
        }

        public override void OnLateUpdate() // Runs once per frame after OnUpdate and OnFixedUpdate have finished, good for updating things a bit slower.
        {
            MelonLogger.Msg("OnLateUpdate");
        }

        public override void OnGUI() // Can run multiple times per frame. Mostly used for GUI applications or things needing to be done fast.
        {
            MelonLogger.Msg("OnGUI");
        }

        public override void OnApplicationQuit() // Runs when the Game is closing.
        {
            MelonLogger.Msg("OnApplicationQuit");
        }

        public override void OnPreferencesSaved() // Runs when Melons Preferences get saved.
        {
            MelonLogger.Msg("OnPreferencesSaved");
        }

        public override void OnPreferencesLoaded() // Runs when Melons Preferences get loaded.
        {
            MelonLogger.Msg("OnPreferencesLoaded");
        }
    }
}
