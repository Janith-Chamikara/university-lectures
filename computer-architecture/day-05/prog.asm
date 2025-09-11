section .data ; initialized memory (data) segment

section .bss  ; Uninitialized data segment
    buf resb 1 ; reserve 1 byte at the address "buf"

section .text ; text segment
    global _start

_start: ; Starting point of the program

    mov al, 0x9; Load the single digit number ( 1, 2, 3 ) to al

    add al, '0'; Convert cl to ASCII
    add ah, '0';

    mov byte[buf], al; Dislplay [buf]
    mov byte[buf + 1], ah;

    mov eax, 4; sys call 4 = write to file

    mov ebx, 1; 1=file=stdout

    mov ecx, buf; get data to write from buf

    mov edx, 2; Length of the byte to wrie

    int 0x80; call kernal

    mov eax, 1 ; system call (number 1) exit to os
    mov ebx, 0 ; value to return to os
    int 0x80   ; call kernal 