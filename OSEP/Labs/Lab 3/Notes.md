192.168.75.171  

Nmap scan report for 192.168.75.171
Host is up (0.25s latency).
Not shown: 65021 filtered tcp ports (no-response), 511 filtered tcp ports (admin-prohibited)
PORT     STATE  SERVICE
22/tcp   open   ssh
80/tcp   open   http
9090/tcp closed zeus-admin

PORT     STATE  SERVICE    VERSION
22/tcp   open   ssh        OpenSSH 8.0 (protocol 2.0)
| ssh-hostkey: 
|   3072 0c:f7:57:49:fc:d4:4e:73:97:2c:25:a2:6a:36:5b:2c (RSA)
|   256 87:35:fd:bc:0a:69:ff:e7:7f:4c:54:c7:bd:29:1d:b9 (ECDSA)
|_  256 2d:8b:f2:70:c4:57:44:62:d5:80:d6:0b:6e:31:a9:75 (ED25519)
80/tcp   open   http       Apache httpd 2.4.37 ((centos))
| http-methods: 
|_  Potentially risky methods: TRACE
|_http-title: CentOS \xE6\x8F\x90\xE4\xBE\x9B\xE7\x9A\x84 Apache HTTP \xE6\x9C\x8D\xE5\x8A\xA1\xE5\x99\xA8\xE6\xB5\x8B\xE8\xAF\x95\xE9\xA1\xB5
|_http-server-header: Apache/2.4.37 (centos)
9090/tcp closed zeus-admin

192.168.75.172  

Nmap scan report for 192.168.75.172
Host is up (0.24s latency).
Not shown: 65534 filtered tcp ports (no-response)
PORT   STATE SERVICE
22/tcp open  ssh

PORT   STATE SERVICE VERSION
22/tcp open  ssh     OpenSSH 8.2p1 Ubuntu 4ubuntu0.1 (Ubuntu Linux; protocol 2.0)
| ssh-hostkey: 
|   3072 5f:05:52:08:c6:45:b7:3b:9b:ae:f4:da:12:e0:2f:10 (RSA)
|   256 dd:e2:b9:d3:92:3e:ac:12:e2:a7:fd:36:75:d8:60:88 (ECDSA)
|_  256 b0:0a:6f:c0:e8:71:8b:9a:91:c0:fc:7d:67:48:69:a5 (ED25519)
Service Info: OS: Linux; CPE: cpe:/o:linux:linux_kernel

192.168.75.173

Nmap scan report for 192.168.75.173
Host is up (0.24s latency).
Not shown: 65532 filtered tcp ports (no-response)
PORT     STATE SERVICE
22/tcp   open  ssh
8081/tcp open  blackice-icecap
8082/tcp open  blackice-alerts

PORT     STATE SERVICE          VERSION                                                                                                                                 
22/tcp   open  ssh              OpenSSH 7.4p1 Debian 10+deb9u7 (protocol 2.0)                                                                                           
| ssh-hostkey:                                                                                                                                                          
|   2048 1f:11:e4:0b:3b:8a:e3:12:e9:44:10:7a:c9:64:98:f3 (RSA)                                                                                                          
|   256 8a:f7:59:6b:af:db:14:0a:e8:4f:2a:4d:c9:66:04:e7 (ECDSA)                                                                                                         
|_  256 d7:cf:21:25:eb:d2:7e:1a:b4:6b:77:41:56:bf:c8:c1 (ED25519)                                                                                                       
8081/tcp open  blackice-icecap?                                                                                                                                         
| fingerprint-strings:                                                                                                                                                  
|   FourOhFourRequest:                                                                                                                                                  
|     HTTP/1.1 404 Not Found                                                                                                                                            
|     Content-Type: text/html;charset=utf-8                                                                                                                             
|     Content-Language: en                                                                                                                                              
|     Content-Length: 431                                                                                                                                               
|     Date: Tue, 30 Nov 2021 18:56:28 GMT                                                                                                                               
|     Connection: close                                                                                                                                                 
|     <!doctype html><html lang="en"><head><title>HTTP Status 404                                                                                                       
|     Found</title><style type="text/css">body {font-family:Tahoma,Arial,sans-serif;} h1, h2, h3, b {color:white;background-color:#525D76;} h1 {font-size:22px;} h2 {fon
t-size:16px;} h3 {font-size:14px;} p {font-size:12px;} a {color:black;} .line {height:1px;background-color:#525D76;border:none;}</style></head><body><h1>HTTP Status 404
                                                                                                                                                                        
|     Found</h1></body></html>                                                                                                                                          
|   GetRequest:                                                                                                                                                         
|     HTTP/1.1 200 OK                                                                                                                                                   
|     Accept-Ranges: bytes                                                                                                                                              
|     ETag: W/"878-1597226105000"                                                                                                                                       
|     Last-Modified: Wed, 12 Aug 2020 09:55:05 GMT                                                                                                                      
|     Content-Type: text/html                                                                                                                                           
|     Content-Length: 878                                                                                                                                               
|     Date: Tue, 30 Nov 2021 18:56:27 GMT                                                                                                                               
|     Connection: close                                                                                                                                                 
|     <!--                                                                                                                                                              
|     Artifactory is a binaries repository manager.                                                                                                                     
|     Copyright (C) 2018 JFrog Ltd.                                                                                                                                     
|     Artifactory is free software: you can redistribute it and/or modify                                                                                               
|     under the terms of the GNU Affero General Public License as published by                                                                                          
|     Free Software Foundation, either version 3 of the License, or                                                                                                     
|     your option) any later version.                                                                                                                                   
|     Artifactory is distributed in the hope that it will be useful,                                                                                                    
|     WITHOUT ANY WARRANTY; without even the implied warranty of                                                                                                        
|     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the                                                                                                      
|     Affero General Public License for more details.
|_    should have received a copy of the GNU Affero General P
8082/tcp open  http             Golang net/http server (Go-IPFS json-rpc or InfluxDB API)
|_http-title: JFrog
