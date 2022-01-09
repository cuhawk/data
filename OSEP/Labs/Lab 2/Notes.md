192.168.75.100  - Dev

192.168.75.140  

Nmap scan report for 192.168.75.140
Host is up (0.24s latency).
Not shown: 65532 filtered tcp ports (no-response)
PORT     STATE SERVICE
80/tcp   open  http
1433/tcp open  ms-sql-s
3389/tcp open  ms-wbt-server

PORT     STATE SERVICE       VERSION
80/tcp   open  http          Microsoft IIS httpd 10.0
|_http-server-header: Microsoft-IIS/10.0
|_http-title: Music Inventory
| http-methods: 
|_  Potentially risky methods: TRACE
| http-cookie-flags: 
|   /: 
|     ASPSESSIONIDSCBBCSDA: 
|_      httponly flag not set
1433/tcp open  ms-sql-s      Microsoft SQL Server 2019 15.00.2000.00; RTM
| ms-sql-ntlm-info: 
|   Target_Name: SQL11
|   NetBIOS_Domain_Name: SQL11
|   NetBIOS_Computer_Name: SQL11
|   DNS_Domain_Name: sql11
|   DNS_Computer_Name: sql11
|_  Product_Version: 10.0.17763
| ssl-cert: Subject: commonName=SSL_Self_Signed_Fallback
| Not valid before: 2021-11-30T18:26:39
|_Not valid after:  2051-11-30T18:26:39
|_ssl-date: 2021-11-30T18:40:57+00:00; +1s from scanner time.
3389/tcp open  ms-wbt-server Microsoft Terminal Services
| rdp-ntlm-info: 
|   Target_Name: SQL11
|   NetBIOS_Domain_Name: SQL11
|   NetBIOS_Computer_Name: SQL11
|   DNS_Domain_Name: sql11
|   DNS_Computer_Name: sql11
|   Product_Version: 10.0.17763
|_  System_Time: 2021-11-30T18:40:51+00:00 
|_ssl-date: 2021-11-30T18:40:56+00:00; 0s from scanner time.
| ssl-cert: Subject: commonName=sql11
| Not valid before: 2021-10-20T10:01:53
|_Not valid after:  2022-04-21T10:01:53
Service Info: OS: Windows; CPE: cpe:/o:microsoft:windows

Host script results:
| ms-sql-info: 
|   192.168.75.140:1433: 
|     Version: 
|       name: Microsoft SQL Server 2019 RTM
|       number: 15.00.2000.00
|       Product: Microsoft SQL Server 2019 
|       Service pack level: RTM
|       Post-SP patches applied: false
|_    TCP port: 1433

192.168.75.141  

Nmap scan report for 192.168.75.141
Host is up (0.24s latency).
Not shown: 65533 filtered tcp ports (no-response)
PORT     STATE SERVICE
1433/tcp open  ms-sql-s
3389/tcp open  ms-wbt-server

PORT     STATE    SERVICE       VERSION
1433/tcp open     ms-sql-s      Microsoft SQL Server 2019 15.00.2000.00; RTM
| ssl-cert: Subject: commonName=SSL_Self_Signed_Fallback
| Not valid before: 2021-11-30T18:27:25
|_Not valid after:  2051-11-30T18:27:25
| ms-sql-ntlm-info: 
|   Target_Name: SQL27
|   NetBIOS_Domain_Name: SQL27
|   NetBIOS_Computer_Name: SQL27
|   DNS_Domain_Name: sql27
|   DNS_Computer_Name: sql27
|_  Product_Version: 10.0.17763
|_ssl-date: 2021-11-30T18:41:23+00:00; 0s from scanner time.
3389/tcp open     ms-wbt-server Microsoft Terminal Services
|_ssl-date: 2021-11-30T18:41:23+00:00; +1s from scanner time.
| rdp-ntlm-info: 
|   Target_Name: SQL27
|   NetBIOS_Domain_Name: SQL27
|   NetBIOS_Computer_Name: SQL27
|   DNS_Domain_Name: sql27
|   DNS_Computer_Name: sql27
|   Product_Version: 10.0.17763
|_  System_Time: 2021-11-30T18:41:17+00:00 
| ssl-cert: Subject: commonName=sql27
| Not valid before: 2021-10-20T10:11:51
|_Not valid after:  2022-04-21T10:11:51
Service Info: OS: Windows; CPE: cpe:/o:microsoft:windows

Host script results:
| ms-sql-info: 
|   192.168.75.141:1433: 
|     Version: 
|       name: Microsoft SQL Server 2019 RTM
|       number: 15.00.2000.00
|       Product: Microsoft SQL Server 2019 
|       Service pack level: RTM
|       Post-SP patches applied: false
|_    TCP port: 1433

192.168.75.142

Nmap scan report for 192.168.75.142
Host is up (0.24s latency).
Not shown: 65533 filtered tcp ports (no-response)
PORT     STATE SERVICE
1433/tcp open  ms-sql-s
3389/tcp open  ms-wbt-server

PORT     STATE    SERVICE       VERSION
1433/tcp open     ms-sql-s      Microsoft SQL Server 2019 15.00.2000.00; RTM
| ms-sql-ntlm-info: 
|   Target_Name: SQL53
|   NetBIOS_Domain_Name: SQL53
|   NetBIOS_Computer_Name: SQL53
|   DNS_Domain_Name: sql53
|   DNS_Computer_Name: sql53
|_  Product_Version: 10.0.17763
| ssl-cert: Subject: commonName=SSL_Self_Signed_Fallback
| Not valid before: 2021-11-30T18:27:38
|_Not valid after:  2051-11-30T18:27:38
|_ssl-date: 2021-11-30T18:41:53+00:00; 0s from scanner time.
3389/tcp open     ms-wbt-server Microsoft Terminal Services
| rdp-ntlm-info: 
|   Target_Name: SQL53
|   NetBIOS_Domain_Name: SQL53
|   NetBIOS_Computer_Name: SQL53
|   DNS_Domain_Name: sql53
|   DNS_Computer_Name: sql53
|   Product_Version: 10.0.17763
|_  System_Time: 2021-11-30T18:41:48+00:00 
|_ssl-date: 2021-11-30T18:41:53+00:00; 0s from scanner time.
| ssl-cert: Subject: commonName=sql53
| Not valid before: 2021-10-20T10:19:42
|_Not valid after:  2022-04-21T10:19:42
Service Info: OS: Windows; CPE: cpe:/o:microsoft:windows

Host script results:
| ms-sql-info: 
|   192.168.75.142:1433: 
|     Version: 
|       name: Microsoft SQL Server 2019 RTM
|       number: 15.00.2000.00
|       Product: Microsoft SQL Server 2019 
|       Service pack level: RTM
|       Post-SP patches applied: false
|_    TCP port: 1433
