#include <stdlib.h>
#include <bits/stdc++.h>

using namespace std;

pair <int, int> mid;

//Determine in which quadrant the point p is located
int quad(pair<int, int> p){
    if(p.first >= 0 && p.second >= 0){
        return 1;
    }
    if(p.first <= 0 && p.second >= 0){
        return 2;
    }
    if(p.first <= 0 && p.second <= 0){
        return 3;
    }
    return 4;
}

//Checking slopes of AB and BC

int orientation(pair <int, int> a,pair <int, int> b, pair <int, int> c){
    int slopeAB = (b.second - a.second) / (b.first - a.first)
}


