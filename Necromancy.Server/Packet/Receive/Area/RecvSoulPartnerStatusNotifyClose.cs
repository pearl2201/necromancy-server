using Arrowgene.Buffers;
using Necromancy.Server.Common;
using Necromancy.Server.Model;
using Necromancy.Server.Packet.Id;

namespace Necromancy.Server.Packet.Receive.Area
{
    public class RecvSoulPartnerStatusNotifyClose : PacketResponse
    {
        public RecvSoulPartnerStatusNotifyClose()
            : base((ushort)AreaPacketId.recv_soul_partner_status_notify_close, ServerType.Area)
        {
        }

        protected override IBuffer ToBuffer()
        {
            IBuffer res = BufferProvider.Provide();
            //no structure

            return res;
        }
    }
}
