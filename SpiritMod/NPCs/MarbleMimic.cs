using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace SpiritMod.NPCs
{
    public class MarbleMimic : ModNPC
    {
        public override void SetDefaults()
        {
            npc.name = "Big Mimic";
            npc.displayName = "Marble Mimic";
            npc.width = 17;
            npc.height = 21;
            npc.damage = 39;
            npc.defense = 8;
            npc.lifeMax = 3500;
            npc.soundHit = 1;
            npc.soundKilled = 1;
            npc.value = 60f;
            npc.knockBackResist = .30f;
            npc.aiStyle = 87;
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[475];
            aiType = NPCID.Zombie;
            animationType = 475;
        }

        public override float CanSpawn(NPCSpawnInfo spawnInfo)
        {
            return spawnInfo.spawnTileY < Main.rockLayer ? 0.5f : 0f;
        }
    }
}