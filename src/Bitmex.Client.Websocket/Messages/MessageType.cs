﻿namespace Bitmex.Client.Websocket.Messages
{
    public enum MessageType
    {
        // Do not rename, used in requests
        Ping,
        Help,
        AuthKey,
        Subscribe,
        Unsubscribe,
        CancelAllAfter,

        // Can be renamed, only for responses
        Error,
        Info,
        Trade,
        OrderBook,
        Wallet,
        Order,
        Position,
        Quote,
        Instrument,
        Margin,
        Execution,
        Funding
    }
}
