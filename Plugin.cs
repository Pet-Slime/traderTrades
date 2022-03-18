using BepInEx;
using BepInEx.Logging;
using HarmonyLib;


namespace traderTrades
{
	[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
	[BepInDependency(APIGUID, BepInDependency.DependencyFlags.HardDependency)]
	public partial class Plugin : BaseUnityPlugin
	{
		public const string APIGUID = "cyantist.inscryption.api";
		public const string PluginGuid = "extraVoid.inscryption.traderTrades";
		private const string PluginName = "Trader's Menagerie of Tokensk";
		private const string PluginVersion = "2.0.0";

		public static string Directory;
		internal static ManualLogSource Log;

		private void Awake()
		{

			Log = base.Logger;
			Directory = this.Info.Location.Replace("traderTrades.dll", "");

			Harmony harmony = new(PluginGuid);
			harmony.PatchAll();

		}

		private void Start()
		{
			traderTrades.cards.Vanilla_Tweaks.AddCard();
			
		}
	}
}