# 🪙 Explain this 
Take the provided legacy code and add the explanation of the piece of code
#  what lecacy code do
The provided C code contains two functions: dicaprio and denzel.

dicaprio: This function opens a file named "crud.txt" in append mode. If the file cannot be opened, it prints an error message and exits the program. If the file is successfully opened, it prompts the user to enter data, reads the data from the standard input (up to MAX characters), writes the data to the file, and then closes the file.

denzel: This function opens a file named "crud.txt" in read mode. If the file cannot be opened, it prints an error message and exits the program. If the file is successfully opened, it reads each line from the file (up to MAX characters per line) and prints the line to the standard output. The reading and printing continue until there are no more lines to read in the file.

In summary, dicaprio appends user input to a file, and denzel reads and prints the contents of the file.