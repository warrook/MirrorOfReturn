using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MirrorOfReturn.Items
{
    public class MirrorOfTravel : ModItem
    {
        public override void SetStaticDefaults()
        {
            var l1 = Lang.GetTooltip(ItemID.PotionOfReturn);
            var l2 = Lang.GetTooltip(ItemID.WormholePotion);
            //Tooltip.SetDefault("Teleports you home and creates a portal\nUse portal to return when you are done\nClick a party member's head on the fullscreen map to teleport to them");
            Tooltip.SetDefault($"{l2.GetLine(0)}\n{l1.GetLine(0)}");
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
            Item.rare = ItemRarityID.LightRed;
            Item.value = 110000;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<MirrorOfReturn>());
            recipe.AddIngredient(ModContent.ItemType<MirrorOfUnity>());
            recipe.AddTile(TileID.CrystalBall);
            recipe.Register();
        }
    }
}