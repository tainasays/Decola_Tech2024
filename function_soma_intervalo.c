/******************************************************************************

Função para calcular a soma de um intervalo, utilizando linguagem C, com base 
na atividade realizada no Módulo I - Introdução à Lógica de Programação e Pensamento
Computacional. A soma de Gauss que foi ensinada em Portugal, adaptada para C.

*******************************************************************************/
#include <stdio.h>

// Protótipo da função
int soma_do_intervalo(int a, int b);

int main()
{
    int a;
    int b;
    int resultado;
    
    printf("Calculando a soma de um intervalo (Soma de Gauss)\n");
    printf("Digite um valor inteiro: \n");
    scanf("%d", &a);
    printf("Digite outro valor inteiro: \n");
    scanf("%d", &b);
    
    resultado = soma_do_intervalo(a,b);
    printf("A soma do intervalo é: %d\n", resultado);

    return 0;
}

int soma_do_intervalo(int a, int b) {
    int total;
    int resultado_parcial;
    int result;
    total = b + 1;
    resultado_parcial = b/2;
    
    result = total * resultado_parcial;
    return(result);
}


