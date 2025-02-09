using Arrowgene.Buffers;
using Necromancy.Server.Common;
using Necromancy.Server.Model;
using Necromancy.Server.Packet.Id;

namespace Necromancy.Server.Packet.Receive.Area
{
    public class RecvRoguemapUpdatePoint : PacketResponse
    {
        public RecvRoguemapUpdatePoint()
            : base((ushort)AreaPacketId.recv_roguemap_update_point, ServerType.Area)
        {
        }

        protected override IBuffer ToBuffer()
        {
            IBuffer res = BufferProvider.Provide();
            res.WriteInt64(0);

            return res;
        }
    }
}
