%macro put_chars 2              ;no of parameters
    pusha
    mov eax, 4
    mov ebx, 1
    mov ecx, %1                 ;buf , 1st parameter
    mov edx, %2                 ;length, 2nd paramter
    int 0x80
    popa
%endmacro