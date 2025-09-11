#include <iostream>
#include <string>

using namespace std;

int count = 0;

int gcd(int a, int b){
    count++;
    return b == 0 ? a : gcd(b, a % b);
}

int main(int argc, char* argv[]){
    if(argc < 3){
        cout << "Provide 2 numbers to find GCD of them" <<endl;
        return 0;
    }
    cout <<"GCD of the given numbers (" << argv[1] <<" "<<argv[2] << ") = ";
    int a = stoi(argv[1]), b = stoi(argv[2]);
    cout << gcd(a,b) << endl;
    cout << "Count gcd called = " << count;
} 