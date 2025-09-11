#include <iostream>
#include <format>
#include <string>

using namespace std;


int gcd(int a, int b){
    int result = min(a, b);

    while(result > 0){
        if(a % result == 0 && b % result == 0){
            break;
        }
        result--;
    }

    return result;
}

int main(int argc, char* argv[]){
    if(argc < 3 ){
        cout<<"Provide 2 numbers to find GCD of them" << endl;
        return 0;
    }
    cout <<"GCD of the given numbers (" << argv[1] <<" "<<argv[2] << ") = ";
    int a = stoi(argv[1]), b = stoi(argv[2]);
    cout<<gcd(a,b);
    return 0;
}