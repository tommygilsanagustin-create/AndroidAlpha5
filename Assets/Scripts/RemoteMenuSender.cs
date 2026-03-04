using System.Net.Sockets;
using System.Text;
using UnityEngine;

public class RemoteMenuSender : MonoBehaviour
{
    public string pcIp = "192.168.1.154"; // CAMBIAR POR TU IP REAL
    public int pcPort = 7777;

    UdpClient udp;

    void Start()
    {
        udp = new UdpClient();
    }

    public void SendAdulto()
    {
        Send("ADULTO");
    }

    public void SendNino()
    {
        Send("NINO");
    }

    void Send(string message)
    {
        byte[] data = Encoding.UTF8.GetBytes(message);
        udp.Send(data, data.Length, pcIp, pcPort);
        Debug.Log("Enviado: " + message);
    }
}
