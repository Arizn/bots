using System.Runtime.Serialization;
using Nethereum.JsonRpc.Client;

namespace EhterDelta.Bots.Dontnet
{
  public class EtherDeltaConfiguration
  {
    public string AddressEtherDelta { get; set; }
    public string Provider { get; set; }
    public string SocketUrl { get; set; }
    public string AbiFile { get; internal set; }
    public string TokenFile { get; internal set; }
    public string Token { get; internal set; }
    public string User { get; internal set; }

    public string PrivateKey { get; internal set; }

    public int UnitDecimals { get; internal set; }
    public int GasLimit { get; internal set; }
    public uint GasPrice { get; internal set; }
  }
}