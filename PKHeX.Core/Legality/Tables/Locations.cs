﻿namespace PKHeX.Core
{
    /// <summary>
    /// Decoration and logic for Met Location IDs
    /// </summary>
    public static class Locations
    {
        public const int LinkTrade4 = 2002;
        public const int LinkTrade5 = 30003;
        public const int LinkTrade6 = 30002;
        public const int LinkGift6 = 30011;

        public const int Daycare4 = 2000;
        public const int Daycare5 = 60002;

        public const int LinkTrade2NPC = 126;
        public const int LinkTrade3NPC = 254;
        public const int LinkTrade4NPC = 2001;
        public const int LinkTrade5NPC = 30002;
        public const int LinkTrade6NPC = 30001;

        public const int PokeWalker4 = 233;
        public const int Ranger4 = 3001;
        public const int Faraway4 = 3002;

        /// <summary> Goldenrod City in <see cref="GameVersion.C"/> </summary>
        public const int HatchLocationC = 16;

        /// <summary> Route 117 in <see cref="GameVersion.RSE"/> </summary>
        public const int HatchLocationRSE = 32;

        /// <summary> Four Island in <see cref="GameVersion.FRLG"/> </summary>
        public const int HatchLocationFRLG = 146;

        /// <summary> Solaceon Town in <see cref="GameVersion.DPPt"/> </summary>
        public const int HatchLocationDPPt = 4;

        /// <summary> Route 34 in <see cref="GameVersion.HGSS"/> </summary>
        public const int HatchLocationHGSS = 182;

        /// <summary> Route 3 in <see cref="GameVersion.Gen5"/> </summary>
        public const int HatchLocation5 = 16;

        /// <summary> Route 7 in <see cref="GameVersion.XY"/> </summary>
        public const int HatchLocation6XY = 38;

        /// <summary> Battle Resort in <see cref="GameVersion.ORAS"/> </summary>
        public const int HatchLocation6AO = 318;

        /// <summary> Route 4 in <see cref="GameVersion.Gen7"/> </summary>
        public const int HatchLocation7 = 50;

        /// <summary> Route 5 in <see cref="GameVersion.SWSH"/> </summary>
        public const int HatchLocation8 = 40;

        /// <summary> Generation 3 -> Generation 4 Transfer Location (Pal Park) </summary>
        public const int Transfer3 = 0x37;

        /// <summary> Generation 4 -> Generation 5 Transfer Location (Poké Transporter) </summary>
        public const int Transfer4 = 30001;

        /// <summary> Generation 4 -> Generation 5 Transfer Location (Crown Celebi - Event not activated in Gen 5) </summary>
        public const int Transfer4_CelebiUnused = 30010;

        /// <summary> Generation 4 -> Generation 5 Transfer Location (Crown Celebi - Event activated in Gen 5) </summary>
        public const int Transfer4_CelebiUsed = 30011;

        /// <summary> Generation 4 -> Generation 5 Transfer Location (Crown Beast - Event not activated in Gen 5) </summary>
        public const int Transfer4_CrownUnused = 30012;

        /// <summary> Generation 4 -> Generation 5 Transfer Location (Crown Beast - Event activated in Gen 5) </summary>
        public const int Transfer4_CrownUsed = 30013;

        public static int TradedEggLocationNPC(int gen)
        {
            return gen switch
            {
                1 => LinkTrade2NPC,
                2 => LinkTrade2NPC,
                3 => LinkTrade3NPC,
                4 => LinkTrade4NPC,
                5 => LinkTrade5NPC,
                _ => LinkTrade6NPC
            };
        }

        public static int TradedEggLocation(int gen)
        {
            return gen switch
            {
                4 => LinkTrade4,
                5 => LinkTrade5,
                _ => LinkTrade6
            };
        }

        public static bool IsPtHGSSLocation(int location) => 111 < location && location < 2000;
        public static bool IsPtHGSSLocationEgg(int location) => 2010 < location && location < 3000;
        public static bool IsEventLocation5(int location) => 40000 < location && location < 50000;
    }
}