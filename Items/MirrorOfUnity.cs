using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MirrorOfReturn.Items
{
	public class MirrorOfUnity : ModItem
	{
        public override void SetStaticDefaults()
        {
            var l = Lang.GetTooltip(ItemID.WormholePotion);
            //Tooltip.SetDefault("Teleports you to a party member\nClick their head on the fullscreen map");
            Tooltip.SetDefault($"{l.GetLine(0)}\n{l.GetLine(1)}");
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.useTurn = true;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.useTime = 90;
            Item.useAnimation = 90;
            Item.UseSound = SoundID.Item6;
            Item.rare = ItemRarityID.Blue;
            Item.value = 55000;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddRecipeGroup(nameof(ItemID.MagicMirror));
            recipe.AddIngredient(ItemID.WormholePotion, 10);
            recipe.AddTile(TileID.AlchemyTable);
            recipe.Register();
        }
    }
}
