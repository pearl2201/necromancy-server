using Arrowgene.Buffers;
using Necromancy.Server.Common;
using Necromancy.Server.Model;
using Necromancy.Server.Packet.Id;

namespace Necromancy.Server.Packet.Receive.Area
{
    public class RecvSoulPartnerSummonCastCancelNotify : PacketResponse
    {
        public RecvSoulPartnerSummonCastCancelNotify()
            : base((ushort)AreaPacketId.recv_soul_partner_summon_cast_cancel_notify, ServerType.Area)
        {
        }

        protected override IBuffer ToBuffer()
        {
            IBuffer res = BufferProvider.Provide();
            //No Structure

            return res;
        }
    }
}
