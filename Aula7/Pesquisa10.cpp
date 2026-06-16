#include <iostream>
#include <vector>
#include <limits>
using namespace std;

int main() {
    vector<int> numeros(10);
    cout << "Pedirei para que vc digite 10 numeros" << endl;
    for (size_t i = 0; i <numeros.size();i++) {
        cout << "Digite o " << i+1 << " numero: ";
        while (true){
            if (cin >> numeros[i]) break;
            cout << "Entrada invalida!" << endl << ": ";
            cin.clear();
            cin.ignore(numeric_limits<streamsize>::max(), '\n');
        }
    }

    cout << "Digite o numero que gostaria de buscar: ";
    int np;
    int contem = 0;
    while (true){
        if (cin >> np) break;
        cout << "Entrada inválida!" << endl << ": ";
        cin.clear();
        cin.ignore(numeric_limits<streamsize>::max(), '\n');
    }

    cout << "Este numero se encontra na(s) posicao:";
    for (size_t i=0; i<numeros.size();i++) {
        if (numeros[i] == np) cout << " " << i+1;
        contem++;
    }

    if (contem == 0) cout << "Numero nao encontrado!";
    return 0;
}
