192.168.75.100 - Dev

172.16.75.150  
172.16.75.151  
172.16.75.152  
172.16.75.155  

192.168.75.159

PORT     STATE SERVICE       VERSION                                                                                                                                    
25/tcp   open  smtp          hMailServer smtpd                                                                                                                          
| smtp-commands: mail01.tricky.com, SIZE 20480000, AUTH LOGIN, HELP                                                                                                     
|_ 211 DATA HELO EHLO MAIL NOOP QUIT RCPT RSET SAML TURN VRFY
80/tcp   open  http          Microsoft IIS httpd 10.0
| http-methods: 
|_  Potentially risky methods: TRACE
|_http-title: Tricky.com Mail system information
|_http-server-header: Microsoft-IIS/10.0
110/tcp  open  pop3          hMailServer pop3d
|_pop3-capabilities: UIDL USER TOP
135/tcp  open  msrpc         Microsoft Windows RPC
139/tcp  open  netbios-ssn   Microsoft Windows netbios-ssn
143/tcp  open  imap          hMailServer imapd
|_imap-capabilities: IMAP4 SORT RIGHTS=texkA0001 ACL IMAP4rev1 completed CAPABILITY IDLE OK CHILDREN QUOTA NAMESPACE
445/tcp  open  microsoft-ds?
587/tcp  open  smtp          hMailServer smtpd
| smtp-commands: mail01.tricky.com, SIZE 20480000, AUTH LOGIN, HELP
|_ 211 DATA HELO EHLO MAIL NOOP QUIT RCPT RSET SAML TURN VRFY
3389/tcp open  ms-wbt-server Microsoft Terminal Services
| rdp-ntlm-info: 
|   Target_Name: TRICKY
|   NetBIOS_Domain_Name: TRICKY
|   NetBIOS_Computer_Name: MAIL01
|   DNS_Domain_Name: tricky.com
|   DNS_Computer_Name: mail01.tricky.com
|   DNS_Tree_Name: tricky.com
|   Product_Version: 10.0.17763
|_  System_Time: 2021-11-30T19:05:40+00:00 
| ssl-cert: Subject: commonName=mail01.tricky.com
| Not valid before: 2021-10-18T16:07:05
|_Not valid after:  2022-04-19T16:07:05
|_ssl-date: 2021-11-30T19:05:50+00:00; +1s from scanner time.
Service Info: Host: mail01.tricky.com; OS: Windows; CPE: cpe:/o:microsoft:windows

Host script results:
| smb2-time: 
|   date: 2021-11-30T19:05:42
|_  start_date: N/A
| smb2-security-mode: 
|   3.1.1: 
|_    Message signing enabled but not required
