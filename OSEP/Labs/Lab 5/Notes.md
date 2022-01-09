192.168.75.100  - Dev

172.16.75.160  
172.16.75.165  
172.16.75.166  
172.16.75.167  
172.16.75.168  

192.168.75.164  

Nmap scan report for 192.168.75.164
Host is up (0.25s latency).
Not shown: 998 closed tcp ports (reset)
PORT   STATE SERVICE VERSION
22/tcp open  ssh     OpenSSH 7.6p1 Ubuntu 4ubuntu0.3 (Ubuntu Linux; protocol 2.0)
| ssh-hostkey: 
|   2048 68:7a:c0:de:12:a9:07:98:1a:52:f8:45:ea:24:68:79 (RSA)
|   256 5c:b3:b9:48:73:e9:e4:01:6b:b7:9f:ee:0d:0c:ba:eb (ECDSA)
|_  256 ee:97:de:dd:52:f5:e1:bf:28:b4:4a:6b:93:42:ce:ee (ED25519)
80/tcp open  http    Apache httpd 2.4.29
| http-cookie-flags: 
|   /: 
|     ONA_SESSION_ID: 
|_      httponly flag not set
|_http-title: OpenNetAdmin :: 0wn Your Network
|_http-server-header: Apache/2.4.29 (Ubuntu)
Service Info: Host: web05.complyedge.com; OS: Linux; CPE: cpe:/o:linux:linux_kernel

192.168.75.169

Nmap scan report for 192.168.75.169
Host is up (0.24s latency).
Not shown: 65533 filtered tcp ports (no-response)
PORT      STATE SERVICE VERSION
80/tcp    open  http    Microsoft IIS httpd 10.0
|_http-title: IIS Windows Server
| http-methods: 
|_  Potentially risky methods: TRACE
|_http-server-header: Microsoft-IIS/10.0
49670/tcp open  msrpc   Microsoft Windows RPC
Service Info: OS: Windows; CPE: cpe:/o:microsoft:windows
