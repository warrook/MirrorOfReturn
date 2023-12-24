using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MirrorOfReturn.Items
{
    public class MirrorOfReturn : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.useTurn = true;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.useTime = 90;
            Item.useAnimation = 90;
            Item.UseSound = SoundID.Item6;
            Item.rare = ItemRarityID.Orange;
            Item.value = 55000;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddRecipeGroup(nameof(ItemID.MagicMirror))
                .AddIngredient(ItemID.PotionOfReturn, 10)
                .AddTile(TileID.AlchemyTable)
                .Register();
        }

        public override bool? UseItem(Player player)
        {
            return true;
        }

		public override void UseItemFrame(Player player)
		{
            if (player.itemTime == Item.useTime / 2)
			{
                SpawnDust(player, 70);
                player.DoPotionOfReturnTeleportationAndSetTheComebackPoint();
                SpawnDust(player, 70);
            }
        }

		private void SpawnDust(Player player, int amount)
		{
            for (int i = 0; i < amount; i++)
            {
                Main.dust[Dust.NewDust(player.position, player.width, player.height, DustID.MagicMirror, player.velocity.X * 0.2f, player.velocity.Y * 0.2f, 150, default(Color), 1.2f)].velocity *= 0.5f;
            }
        }
	}
}
