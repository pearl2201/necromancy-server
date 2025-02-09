using Arrowgene.Buffers;
using Necromancy.Server.Common;
using Necromancy.Server.Model;
using Necromancy.Server.Packet.Id;

namespace Necromancy.Server.Packet.Receive.Area
{
    public class RecvCashShop2NotifyOpen : PacketResponse
    {
        public RecvCashShop2NotifyOpen()
            : base((ushort)AreaPacketId.recv_cash_shop2_notify_open, ServerType.Area)
        {
        }

        protected override IBuffer ToBuffer()
        {
            IBuffer res = BufferProvider.Provide();
            res.WriteInt16(0);
            res.WriteByte(0);
            res.WriteInt32(0);
            return res;
        }
    }
}
