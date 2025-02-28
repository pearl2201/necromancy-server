using Arrowgene.Buffers;
using Necromancy.Server.Common;
using Necromancy.Server.Model;
using Necromancy.Server.Packet.Id;

namespace Necromancy.Server.Packet.Receive.Area
{
    public class RecvVenturerMedalShopBuyR : PacketResponse
    {
        public RecvVenturerMedalShopBuyR()
            : base((ushort)AreaPacketId.recv_venturer_medal_shop_buy_r, ServerType.Area)
        {
        }

        protected override IBuffer ToBuffer()
        {
            IBuffer res = BufferProvider.Provide();
            res.WriteInt32(0);

            return res;
        }
    }
}
