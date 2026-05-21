#include <iostream>
#include <iomanip>

using namespace std;

int main() {
    int numeroF;
    int horasT;
    double valorH, salario;

    cout << "Digite seu numero: ";
    cin >> numeroF;
    cout << "Digite quantidade de horas: ";
    cin >> horasT;
    cout << "Digite o valor por hora: ";
    cin >> valorH;

    salario = horasT * valorH;

    cout << "Numero = " << numeroF << endl;
    cout << fixed << setprecision(2);
    cout << "Salario = " << salario << endl;

    return 0;
}