using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SpiritMod.Items.Spirit
{
	public class SpiritStoneItem : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Spirit Stone";
			item.width = 16;
			item.height = 14;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("SpiritStone");
		}
	}
}