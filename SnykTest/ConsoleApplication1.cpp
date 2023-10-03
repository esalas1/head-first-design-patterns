// ConsoleApplication1.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <iostream>  

int main()
{
    std::cout << "Hello World!\n";


    using namespace std;
    int main() {
        int n1 = 0, n2 = 1, n3, i, number;
        cout << "Enter the number of elements: ";
        cin >> number;
        cout << n1 << " " << n2 << " "; //printing 0 and 1    
        for (i = 2; i < number; ++i) //loop starts from 2 because 0 and 1 are already printed    
        {
            n3 = n1 + n2;
            cout << n3 << " ";
            n1 = n2;
            n2 = n3;
        }
        return 0;
    }

#include<iostream>    
    using namespace std;
    void printFibonacci(int n) {
        static int n1 = 0, n2 = 1, n3;
        if (n > 0) {
            n3 = n1 + n2;
            n1 = n2;
            n2 = n3;
            cout << n3 << " ";
            printFibonacci(n - 1);
        }
    }
    int main() {
        int n;
        cout << "Enter the number of elements: ";
        cin >> n;
        cout << "Fibonacci Series: ";
        cout << "0 " << "1 ";
        printFibonacci(n - 2);  //n-2 because 2 numbers are already printed    
        return 0;
    }
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
