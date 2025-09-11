section .data ; initialized memory (data) segment

section .bss  ; Uninitialized data segment
    buf resb 1 ; reserve 1 byte at the address "buf"

section .text ; text segment
    global _start

_start: ; Starting point of the program

    mov eax, 3 ; system call (number 3) read
    mov ebx, 0 ; 0 -> read from stdin (key board)
    mov ecx, buf ; store data read from stdin at buf
    mov edx,1 ; 1-> No of bytes to read
    int 0x80 ; interrupt 0x80 (call kernal)

    mov al, Byte[buf] ; Copy content at buf to the register "al"
    inc al ; Increase value of al by 1
    mov byte[buf], al ; Copy value of al into [buf]

    mov eax, 4 ; system call (number 4) write
    mov ebx, 1 ; 1 -> stdout 
    mov ecx, buf ; Get data to write from buf
    mov edx, 1 ; length of bytes to write
    int 0x80 ; Call kernal

    mov eax, 1 ; system call (number 1) exit to os
    mov ebx, 0 ; value to return to os
    int 0x80   ; call kernal 