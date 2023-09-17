﻿using System.Formats.Cbor;

namespace CatMessenger.Telegram.Connector.Packet.C2S;

public class C2SPublishPacket : C2SPacket
{
    private byte[] Payload { get; }
    
    public C2SPublishPacket(byte[] payload)
    {
        Payload = payload;
    }
    
    protected override void Write(CborWriter writer)
    {
        writer.WriteTextString(ConnectorConstants.RequestPublish);
        writer.WriteTextString(ConnectorConstants.ChannelId);
        writer.WriteByteString(Payload);
    }
}