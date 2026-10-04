import os

def ping_kontrol(ip):
    komut = "ping -n 1 " + ip
    cevap = os.system(komut)
    
    if cevap == 0:
        print(ip + " -> Baglanti bulundu, cihaz aktif")
    else:
        print(ip + " -> Baglanti bulunamadi veya cihaz kapali")

ip_listesi = ["192.168.1.1", "8.8.8.8", "10.0.0.1"]

print("AG KONTROLU YAPILIYOR...")
print()

for ip in ip_listesi:
    ping_kontrol(ip)