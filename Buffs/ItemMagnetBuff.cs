﻿using Terraria;
using Terraria.ModLoader;

namespace ItemMagnetPlus.Buffs
{
    public class ItemMagnetBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Item Magnet");
            Description.SetDefault("A magnetic field surrounds you!");
            Main.buffNoTimeDisplay[Type] = true;
        }

        public override void ModifyBuffTip(ref string tip, ref int rare)
        {
            ItemMagnetPlusPlayer mPlayer = Main.LocalPlayer.GetModPlayer<ItemMagnetPlusPlayer>(mod);
            string add = "\nCurrent Range: " + mPlayer.magnetGrabRadius;
            //Feeling Cute, Might Delete Later
            mPlayer.UpdateMagnetValues(mPlayer, mPlayer.magnetGrabRadius);
            add += "\nCurrent Velocity: " + mPlayer.magnetVelocity;
            add += "\nCurrent Acceleration: " + mPlayer.magnetAcceleration;
            tip = tip + add;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            if (player.HasItem(mod.ItemType("ItemMagnet")))
            {
                player.buffTime[buffIndex] = 60;
                player.GetModPlayer<ItemMagnetPlusPlayer>(mod).magnetActive = 1;
            }
        }
    }
}