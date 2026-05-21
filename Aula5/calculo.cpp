#include <iostream>

using namespace std;

int main() {
    long long numero;
    
    cout << "Digite um numero inteiro: ";
    cin >> numero;
    
    long long quadrado = numero * numero;
    long long copiaQuadrado = quadrado;
    
    long long somaDigitos = 0;
    
    while (quadrado > 0) {
        somaDigitos += quadrado % 10;
        quadrado /= 10;
    }
    
    cout << "O quadrado de " << numero << " e: " << copiaQuadrado << endl;
    cout << "A soma dos digitos de " << copiaQuadrado << " e: " << somaDigitos << endl;
    
    return 0;
}
