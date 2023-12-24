using Terraria;
using Terraria.ModLoader;
using On.Terraria;

namespace MirrorOfReturn
{
	public class MirrorOfReturn : Mod
	{
		public override void Load()
		{
			On.Terraria.Player.HasUnityPotion += Player_HasUnityPotion;
			On.Terraria.Player.TakeUnityPotion += Player_TakeUnityPotion;
		}

		private static bool Player_HasUnityPotion(On.Terraria.Player.orig_HasUnityPotion original, Terraria.Player player)
		{
			if (!player.HasItem(ModContent.ItemType<Items.MirrorOfUnity>()) || !player.HasItem(ModContent.ItemType<Items.MirrorOfTravel>()))
			{
				return original(player);
			}
			return true;
		}

		private static void Player_TakeUnityPotion(On.Terraria.Player.orig_TakeUnityPotion original, Terraria.Player player)
		{
			if (!player.HasItem(ModContent.ItemType<Items.MirrorOfUnity>()) || !player.HasItem(ModContent.ItemType<Items.MirrorOfTravel>()))
			{
				original(player);
			}
		}
	}
}