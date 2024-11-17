#include <iostream>

int main() {
    int number;
    std::cout << "Введіть число від 1 до 100: ";
    std::cin >> number;

    if (number < 1 || number > 100) {
        std::cout << "Помилка: число повинно бути в діапазоні від 1 до 100." << std::endl;
    } else {
        if (number % 3 == 0 && number % 5 == 0) {
            std::cout << "Fizz Buzz" << std::endl;
        } else if (number % 3 == 0) {
            std::cout << "Fizz" << std::endl;
        } else if (number % 5 == 0) {
            std::cout << "Buzz" << std::endl;
        } else {
            std::cout << number << std::endl;
        }
    }

    return 0;
}
