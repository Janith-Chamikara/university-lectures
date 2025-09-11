     1                                  section .data
     2 00000000 48656C6C6F2C20576F-     	msg db 'Hello, World!', 0xA
     2 00000009 726C64210A         
     3                                  	len equ $ - msg
     4                                  
     5                                  section .text
     6                                  	global _start
     7                                  
     8                                  _start:
     9                                  
    10 00000000 B804000000              	mov eax, 4
    11 00000005 BB01000000              	mov ebx, 1
    12 0000000A B9[00000000]            	mov ecx, msg
    13 0000000F BA0E000000              	mov edx, len
    14 00000014 CD80                    	int 0x80
    15                                  
    16 00000016 B801000000              	mov eax, 1
    17 0000001B BB00000000              	mov ebx, 0
    18 00000020 CD80                    	int 0x80
