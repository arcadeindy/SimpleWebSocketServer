﻿using System.Net.Sockets;

namespace SimpleWebSocketServerLibrary
{
    /// <summary>
    /// Provides information about a connected client.
    /// </summary>
    public class WebSocketClientInfo
    {
        /// <summary>
        /// TcpClient containing the socket handler.
        /// </summary>
        public TcpClient client { get; set; }
        /// <summary>
        /// ClientID generated by the server or set by the client.
        /// </summary>
        public string clientId { get; set; }
        /// <summary>
        /// BaseURL client used to connect to.
        /// </summary>
        public string clientBaseUrl { get; set; }
    }
}
