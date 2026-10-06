all: main
main: main.c	
	gcc -fsanitize=address,undefined -Wall -Wextra -Wshadow -Werror -o main main.c
.PHONY: clean all
clean:
	rm main
