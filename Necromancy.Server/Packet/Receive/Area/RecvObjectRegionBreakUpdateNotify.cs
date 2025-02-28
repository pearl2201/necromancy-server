using Arrowgene.Buffers;
using Necromancy.Server.Common;
using Necromancy.Server.Model;
using Necromancy.Server.Packet.Id;

namespace Necromancy.Server.Packet.Receive.Area
{
    public class RecvObjectRegionBreakUpdateNotify : PacketResponse
    {
        public RecvObjectRegionBreakUpdateNotify()
            : base((ushort)AreaPacketId.recv_object_region_break_update_notify, ServerType.Area)
        {
        }

        protected override IBuffer ToBuffer()
        {
            IBuffer res = BufferProvider.Provide();
            res.WriteInt32(0);
            res.WriteInt64(0);
            return res;
        }
    }
}
