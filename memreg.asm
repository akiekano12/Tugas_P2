section .text
    global _start

_start:
    mov rax, 1      ; syscall number for sys_write
    mov rdi, 1      ; file descriptor 1 (stdout)
    mov rsi, msg    ; pointer to message
    mov rdx, msglen ; message length
    syscall         ; invoke syscall

    mov rax, 60     ; syscall number for sys_exit
    xor rdi, rdi    ; exit status 0
    syscall         ; invoke syscall

section .data
msg: db "Hello from Assembly!", 10
msglen: equ $ - msg
