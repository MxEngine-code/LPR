#include <iostream>

using namespace std;

int main() {
    float horasPD;
    float totalHS = 0;
    const float META_H = 1000.0;

    cout << "=== SIMULADOR DE TREINAMENTO JEDI ===" << endl;
    cout << "Insira a carga horaria de treino para cada dia util da semana:\n" << endl;

    for (int dia = 1; dia <= 5; dia++) {
        cout << "Horas de treinamento no Dia " << dia << ": ";
        cin >> horasPD;
        totalHS += horasPD;
    }

    if (totalHS <= 0) {
        cout << "\nCom 0 horas de treino por semana, voce nunca se tornara um Jedi!" << endl;
        return 0;
    }

    float semanasN = META_H / totalHS;
    float diasN = semanasN * 5;
    float mesesN = semanasN / 4.5;

    cout << "\n=== RELATORIO DE TREINAMENTO ===" << endl;
    cout << "Total de horas treinadas por semana: " << totalHS << " horas." << endl;
    cout << "Para alcancar a meta de " << META_H << " horas voce precisara de:" << endl;
    cout << " - " << diasN << " dias uteis de treino." << endl;
    cout << " - " << semanasN << " semanas." << endl;
    cout << " - " << mesesN << " meses (base: 4.5 semanas/mes)." << endl;

    return 0;
}
