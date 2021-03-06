﻿using NosCore.Core.Serializing;

namespace NosCore.Packets
{
    [PacketHeader("in_item_subpacket")]
    public class InItemSubPacket : PacketDefinition
    {
        #region Properties
        [PacketIndex(0)]
        public int Amount { get; set; }

        [PacketIndex(1)]
        public bool IsQuestRelative { get; set; }
        
        #endregion
    }
}