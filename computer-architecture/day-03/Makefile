exe.x:obj.o
	ld -m elf_i386 -o exe.x obj.o
obj.o:prog.asm
	nasm -f elf32 -g -F stabs -l lst.l -o obj.o prog.asm
