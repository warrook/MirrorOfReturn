using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace MirrorOfReturn
{
    public class MirrorOfReturnSystem : ModSystem
    {
        public override void AddRecipeGroups()
        {
            RecipeGroup group = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.MagicMirror)}", ItemID.IceMirror, ItemID.MagicMirror); //LegacyMisc.37 = "Any"
            RecipeGroup.RegisterGroup(nameof(ItemID.MagicMirror), group);
        }
    }
}
