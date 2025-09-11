#include <iostream>
#include <string>
using namespace std;

int gcd(int a, int b){
    if( a == 0 ){
        return b;
    }
    if( b == 0 ){
        return a;
    }
    if( a == b ){
        return a;
    }

    //a is greater
    if( a > b ){
        if( a % b == 0 ){
            return b;
        }
        return gcd( a-b, b);
    }

    //else b is greater
    if( b % a == 0 ){
        return a;
    }

    return gcd(a, b-a);
}

int main(int argc, char* argv[]){
    if(argc < 3){
        cout << "Provide 2 numbers to find GCD of them" <<endl;
        return 0;
    }
    cout <<"GCD of the given numbers (" << argv[1] <<" "<<argv[2] << ") = ";
    int a = stoi(argv[1]), b = stoi(argv[2]);
    cout << gcd(a,b);
} 