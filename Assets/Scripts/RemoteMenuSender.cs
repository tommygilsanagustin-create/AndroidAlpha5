using System.Net.Sockets;
using System.Text;
using UnityEngine;

public class RemoteMenuSender : MonoBehaviour
{
    public string pcIp = "192.168.1.162";
    public int pcPort = 7777;

    UdpClient udp;

    void Awake()
    {
        udp = new UdpClient();
    }

    public void SendDificil()
    {
        Debug.Log("[TABLET] BOTON DIFICIL");
        Send("ADULTO");
    }

    public void SendStandard()
    {
        Debug.Log("[TABLET] BOTON STANDARD");
        Send("NINO");
    }

    void Send(string message)
    {
        try
        {
            byte[] data = Encoding.UTF8.GetBytes(message);
            udp.Send(data, data.Length, pcIp, pcPort);
            Debug.Log("[TABLET] Enviado: " + message);
        }
        catch (System.Exception e)
        {
            Debug.LogError("[TABLET] Error UDP: " + e.Message);
        }
    }
}