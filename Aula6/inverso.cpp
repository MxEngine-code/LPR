#include <iostream>
#include <cstdlib>

using namespace std;

void limpar() {
    #ifdef _WIN32
        system("cls");
    #else
        system("clear");
    #endif
}
int inverter(int n) {
    int r = 0;
    while(n != 0) {
        int dig = n % 10;
        r = r * 10 + dig;
        n /= 10;
    }
    return r;
}

int main() {
    while(true) {
        int n;
        string ns;
        cout << "Digite um numero: ";
        getline(cin, ns);
        n = stoi(ns);
        cout << "Numero invertido: " << inverter(n) << endl;
        cout << "Digite qualquer coisa para continuar ou exit para sair: ";
        string entrada;
        getline(cin, entrada);
        if(entrada == "exit") break;
        //cout <<endl;
        limpar();
    }
    return 0;
}