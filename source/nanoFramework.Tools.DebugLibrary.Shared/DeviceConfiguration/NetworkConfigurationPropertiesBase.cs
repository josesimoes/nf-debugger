﻿using System.Net;
using System.Net.NetworkInformation;

namespace nanoFramework.Tools.Debugger
{
    public class NetworkConfigurationPropertiesBase
    {
        public IPAddress IPv4Address { get; set; }
        public IPAddress IPv4DNSAddress1 { get; set; }
        public IPAddress IPv4DNSAddress2 { get; set; }
        public IPAddress IPv4GatewayAddress { get; set; }
        public IPAddress IPv4NetMask { get; set; }
        public IPAddress IPv6Address { get; set; }
        public IPAddress IPv6DNSAddress1 { get; set; }
        public IPAddress IPv6DNSAddress2 { get; set; }
        public IPAddress IPv6GatewayAddress { get; set; }
        public IPAddress IPv6NetMask { get; set; }
        public byte[] MacAddress { get; set; }
        public AddressMode StartupAddressMode { get; set; }
    }
}