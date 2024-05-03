#include <stdio.h>
#include <stdlib.h>
#include <math.h>

void dot_Product(int Dimensi, float* A, int* B);

int main(void) {
    int* Vektor;
    int a,B,x=3;
    float A;

    Vektor = (int*)malloc(x*sizeof(int));

    printf("input\nMasukkan dimensi :");
    scanf_s("%d", &x);

    printf("Vektor a :\n");
    for (a = 0; a < x; a++) {
        scanf_s("%d", Vektor + a);
        dot_Product(*(Vektor + a), &A, &B);
    }
    printf("output :\nA . A = ");
    for (a = 0; a < x; a++) {
        if ((a + 1) == x)
            printf("%d.%d = ", *(Vektor + a), *(Vektor + a));
        if ((a + 1) != x)
            printf("%d.%d + ", *(Vektor + a), *(Vektor + a));
    }
    printf("%d\n\n||A|| = %.2f", B, A);
    free(Vektor);
    return 0;
}

void dot_Product(int x, float* A, int* B) {
    *B += pow(x, 2);
    *A = sqrt(*B);
}