using Arrowgene.Buffers;
using Necromancy.Server.Common;
using Necromancy.Server.Model;
using Necromancy.Server.Packet.Id;

namespace Necromancy.Server.Packet.Receive.Area
{
    public class RecvStallUpdateFeatureItem : PacketResponse
    {
        public RecvStallUpdateFeatureItem()
            : base((ushort)AreaPacketId.recv_stall_update_feature_item, ServerType.Area)
        {
        }

        protected override IBuffer ToBuffer()
        {
            IBuffer res = BufferProvider.Provide();
            res.WriteInt32(0);

            res.WriteInt32(0);
            res.WriteByte(0);
            res.WriteByte(0);
            res.WriteByte(0);

            res.WriteInt32(0);
            res.WriteInt16(0);
            res.WriteInt32(0);

            res.WriteByte(0); // bool

            res.WriteInt32(0);
            return res;
        }
    }
}
