192.168.75.100  - Dev

172.16.75.180  
172.16.75.183  
172.16.75.184  
172.16.75.187  
172.16.75.188  
172.16.75.192  
172.16.75.194  
172.16.75.197  

192.168.75.181  

Nmap scan report for 192.168.75.181
Host is up (0.24s latency).
Not shown: 65532 filtered tcp ports (no-response)
PORT     STATE SERVICE       VERSION
80/tcp   open  http          Microsoft IIS httpd 10.0
|_http-server-header: Microsoft-IIS/10.0
|_http-title: Home Page - Final Application
| http-methods: 
|_  Potentially risky methods: TRACE
3389/tcp open  ms-wbt-server Microsoft Terminal Services
|_ssl-date: 2021-11-30T19:27:36+00:00; +1s from scanner time.
| ssl-cert: Subject: commonName=web05.final.com
| Not valid before: 2021-11-02T09:43:10
|_Not valid after:  2022-05-04T09:43:10
| rdp-ntlm-info: 
|   Target_Name: FINAL
|   NetBIOS_Domain_Name: FINAL
|   NetBIOS_Computer_Name: WEB05
|   DNS_Domain_Name: final.com
|   DNS_Computer_Name: web05.final.com
|   DNS_Tree_Name: final.com
|   Product_Version: 10.0.17763
|_  System_Time: 2021-11-30T19:27:32+00:00
9090/tcp open  zeus-admin?
| fingerprint-strings: 
|   NULL, NotesRPC: 
|_    This is Zen HelpDesk, please perform the required authentication

192.168.75.189

Nmap scan report for 192.168.75.189
Host is up (0.24s latency).
Not shown: 65530 filtered tcp ports (no-response)
PORT      STATE SERVICE       VERSION
80/tcp    open  http          Microsoft IIS httpd 10.0
| http-methods: 
|_  Potentially risky methods: TRACE
|_http-title: IIS Windows Server
|_http-server-header: Microsoft-IIS/10.0
135/tcp   open  msrpc         Microsoft Windows RPC
445/tcp   open  microsoft-ds?
3389/tcp  open  ms-wbt-server Microsoft Terminal Services
| rdp-ntlm-info: 
|   Target_Name: FIREWALL02
|   NetBIOS_Domain_Name: FIREWALL02
|   NetBIOS_Computer_Name: FIREWALL02
|   DNS_Domain_Name: firewall02
|   DNS_Computer_Name: firewall02
|   Product_Version: 10.0.17763
|_  System_Time: 2021-11-30T19:29:11+00:00
| ssl-cert: Subject: commonName=firewall02
| Not valid before: 2021-10-18T16:18:55
|_Not valid after:  2022-04-19T16:18:55
|_ssl-date: 2021-11-30T19:29:50+00:00; 0s from scanner time.
49669/tcp open  msrpc         Microsoft Windows RPC
Service Info: OS: Windows; CPE: cpe:/o:microsoft:windows

Host script results:
| smb2-time: 
|   date: 2021-11-30T19:29:11
|_  start_date: N/A
| smb2-security-mode: 
|   3.1.1: 
|_    Message signing enabled but not required
