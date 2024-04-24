//optimace legacy code
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#define MAX 100

int appendToFile() {
    char inputBuffer[MAX];
    FILE *outputFile;

    outputFile = fopen("crud.txt", "a");
    if (outputFile == NULL) {
        fprintf(stderr, "Unable to open the file.\n");
        return 1;
    }

    printf("Enter data: ");
    fgets(inputBuffer, MAX, stdin);
    fputs(inputBuffer, outputFile);
    fclose(outputFile);

    return 0;
}

int readFromFile() {
    char readBuffer[MAX];
    FILE *inputFile;

    inputFile = fopen("crud.txt", "r");
    if (inputFile == NULL) {
        fprintf(stderr, "Unable to open the file.\n");
        return 1;
    }

    printf("Data in the file:\n");
    while (fgets(readBuffer, MAX, inputFile) != NULL)
        printf("%s", readBuffer);

    fclose(inputFile);

    return 0;
}