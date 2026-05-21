#include <iostream>
#include <iomanip>

using namespace std;

int main() {
    int codigo1, codigo2;
    int quantidade1, quantidade2;
    double valor1, valor2, total;

    cout << "Digite o codigo da primeira peca: ";
    cin >> codigo1;
    cout << "Digite A quantidade: ";
    cin >> quantidade1;
    cout << "Digite o valor: ";
    cin >> valor1;
    cout << "Digite o codigo da segunda peca: ";
    cin >> codigo2;
    cout << "Digite A quantidade: ";
    cin >> quantidade2;
    cout << "Digite o valor: ";
    cin >> valor2;

    total = (quantidade1 * valor1) + (quantidade2 * valor2);

    cout << fixed << setprecision(2);
    cout << "VALOR A PAGAR: " << total << endl;

    return 0;
}