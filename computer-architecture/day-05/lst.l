     1                                  section .data ; initialized memory (data) segment
     2                                  
     3                                  section .bss  ; Uninitialized data segment
     4 00000000 ??                          buf resb 1 ; reserve 1 byte at the address "buf"
     5                                  
     6                                  section .text ; text segment
     7                                      global _start
     8                                  
     9                                  _start: ; Starting point of the program
    10                                  
    11 00000000 B009                        mov al, 0x9; Load the single digit number ( 1, 2, 3 ) to al
    12                                  
    13 00000002 0430                        add al, '0'; Convert cl to ASCII
    14 00000004 80C430                      add ah, '0'
    15                                  
    16 00000007 A2[00000000]                mov byte[buf], al; Dislplay [buf]
    17 0000000C 8825[01000000]              mov byte[buf + 1], ah;
    18                                  
    19 00000012 B804000000                  mov eax, 4; sys call 4 = write to file
    20                                  
    21 00000017 BB01000000                  mov ebx, 1; 1=file=stdout
    22                                  
    23 0000001C B9[00000000]                mov ecx, buf; get data to write from buf
    24                                  
    25 00000021 BA02000000                  mov edx, 2; Length of the byte to wrie
    26                                  
    27 00000026 CD80                        int 0x80; call kernal
    28                                  
    29 00000028 B801000000                  mov eax, 1 ; system call (number 1) exit to os
    30 0000002D BB00000000                  mov ebx, 0 ; value to return to os
    31 00000032 CD80                        int 0x80   ; call kernal 
