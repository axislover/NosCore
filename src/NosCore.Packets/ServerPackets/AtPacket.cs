﻿using NosCore.Core.Serializing;

namespace NosCore.Packets
{
    [PacketHeader("at")]
    public class AtPacket : PacketDefinition
    {
        #region Properties

        [PacketIndex(0)]
        public long CharacterId { get; set; }

        [PacketIndex(1)]
        public short MapId { get; set; }

        [PacketIndex(2)]
        public short PositionX { get; set; }

        [PacketIndex(3)]
        public short PositionY { get; set; }

        [PacketIndex(4)]
        public byte Unknown1 { get; set; }

        [PacketIndex(5)]
        public byte Unknown2 { get; set; }

        [PacketIndex(6)]
        public int Music { get; set; }

        [PacketIndex(7)]
        public short Unknown3 { get; set; }
        #endregion
    }
}