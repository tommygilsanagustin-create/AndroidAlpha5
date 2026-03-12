import socket

ip = "192.168.1.162"
port = 7777
msg = b"DIFICIL"

sock = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
sock.sendto(msg, (ip, port))
sock.close()

print("Enviado")