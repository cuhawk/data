192.168.75.100 - Dev

192.168.75.120

Nmap scan report for 192.168.75.120
Host is up (0.30s latency).
Not shown: 65515 filtered tcp ports (no-response)
PORT      STATE SERVICE
53/tcp    open  domain
88/tcp    open  kerberos-sec
135/tcp   open  msrpc
139/tcp   open  netbios-ssn
389/tcp   open  ldap                      
445/tcp   open  microsoft-ds
464/tcp   open  kpasswd5
593/tcp   open  http-rpc-epmap
636/tcp   open  ldapssl
3268/tcp  open  globalcatLDAP
3269/tcp  open  globalcatLDAPssl
3389/tcp  open  ms-wbt-server
5985/tcp  open  wsman
9389/tcp  open  adws                      
49667/tcp open  unknown
49678/tcp open  unknown
49679/tcp open  unknown
49683/tcp open  unknown
49702/tcp open  unknown
49719/tcp open  unknown

PORT     STATE SERVICE       VERSION
53/tcp   open  domain        Simple DNS Plus
88/tcp   open  kerberos-sec  Microsoft Windows Kerberos (server time: 2021-11-30 18:06:13Z)
135/tcp  open  msrpc         Microsoft Windows RPC
139/tcp  open  netbios-ssn   Microsoft Windows netbios-ssn
389/tcp  open  ldap          Microsoft Windows Active Directory LDAP (Domain: infinity.com0., Site: Default-First-Site-Name)
445/tcp  open  microsoft-ds?
464/tcp  open  kpasswd5?
593/tcp  open  ncacn_http    Microsoft Windows RPC over HTTP 1.0
636/tcp  open  tcpwrapped
3268/tcp open  ldap          Microsoft Windows Active Directory LDAP (Domain: infinity.com0., Site: Default-First-Site-Name)
3269/tcp open  tcpwrapped
3389/tcp open  ms-wbt-server Microsoft Terminal Services
|_ssl-date: 2021-11-30T18:07:09+00:00; +1s from scanner time.
| rdp-ntlm-info: 
|   Target_Name: INFINITY
|   NetBIOS_Domain_Name: INFINITY
|   NetBIOS_Computer_Name: DC03
|   DNS_Domain_Name: infinity.com
|   DNS_Computer_Name: dc03.infinity.com
|   DNS_Tree_Name: infinity.com
|   Product_Version: 10.0.17763
|_  System_Time: 2021-11-30T18:06:30+00:00
| ssl-cert: Subject: commonName=dc03.infinity.com
| Not valid before: 2021-10-18T14:33:09
|_Not valid after:  2022-04-19T14:33:09
5985/tcp open  http          Microsoft HTTPAPI httpd 2.0 (SSDP/UPnP)
|_http-title: Not Found
|_http-server-header: Microsoft-HTTPAPI/2.0
9389/tcp open  mc-nmf        .NET Message Framing
Service Info: Host: DC03; OS: Windows; CPE: cpe:/o:microsoft:windows

Host script results:
| smb2-security-mode: 
|   3.1.1: 
|_    Message signing enabled and required
| smb2-time: 
|   date: 2021-11-30T18:06:29
|_  start_date: N/A

192.168.75.121

Nmap scan report for 192.168.75.121
Host is up (0.26s latency).
Not shown: 65531 filtered tcp ports (no-response)
PORT     STATE SERVICE
80/tcp   open  http
135/tcp  open  msrpc
445/tcp  open  microsoft-ds
3389/tcp open  ms-wbt-server

PORT     STATE SERVICE       VERSION
80/tcp   open  http          Microsoft IIS httpd 10.0
| http-methods: 
|_  Potentially risky methods: TRACE
|_http-server-header: Microsoft-IIS/10.0
|_http-title: Job Application Upload Site
135/tcp  open  msrpc         Microsoft Windows RPC
445/tcp  open  microsoft-ds?
3389/tcp open  ms-wbt-server Microsoft Terminal Services
| rdp-ntlm-info: 
|   Target_Name: INFINITY
|   NetBIOS_Domain_Name: INFINITY
|   NetBIOS_Computer_Name: WEB05
|   DNS_Domain_Name: infinity.com
|   DNS_Computer_Name: web05.infinity.com
|   DNS_Tree_Name: infinity.com
|   Product_Version: 10.0.17763
|_  System_Time: 2021-11-30T18:13:45+00:00
| ssl-cert: Subject: commonName=web05.infinity.com
| Not valid before: 2021-10-18T15:40:23
|_Not valid after:  2022-04-19T15:40:23
|_ssl-date: 2021-11-30T18:14:24+00:00; 0s from scanner time.
Service Info: OS: Windows; CPE: cpe:/o:microsoft:windows

Host script results:
| smb2-security-mode: 
|   3.1.1: 
|_    Message signing enabled but not required
| smb2-time: 
|   date: 2021-11-30T18:13:49
|_  start_date: N/A

192.168.75.122

Nmap scan report for 192.168.75.122
Host is up (0.26s latency).
Not shown: 65532 filtered tcp ports (no-response)
PORT     STATE SERVICE
135/tcp  open  msrpc
3389/tcp open  ms-wbt-server
5040/tcp open  unknown

PORT     STATE SERVICE       VERSION
135/tcp  open  msrpc         Microsoft Windows RPC
3389/tcp open  ms-wbt-server Microsoft Terminal Services
| rdp-ntlm-info: 
|   Target_Name: INFINITY
|   NetBIOS_Domain_Name: INFINITY
|   NetBIOS_Computer_Name: CLIENT
|   DNS_Domain_Name: infinity.com
|   DNS_Computer_Name: client.infinity.com
|   DNS_Tree_Name: infinity.com
|   Product_Version: 10.0.18362
|_  System_Time: 2021-11-30T18:17:53+00:00
| ssl-cert: Subject: commonName=client.infinity.com
| Not valid before: 2021-10-18T15:47:45
|_Not valid after:  2022-04-19T15:47:45
|_ssl-date: 2021-11-30T18:18:08+00:00; 0s from scanner time.
5040/tcp open  unknown
Service Info: OS: Windows; CPE: cpe:/o:microsoft:windows
