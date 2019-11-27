#include <iostream>



void fun_func() {
  std::cout<<"This is a fun func"<<std::endl;
}

int calling() {
  int a = 5;
  return a / 5 + 3;
  fun_func();
}

int main(int argc, char** argv) {
  int calling_val = calling();
  return calling_val;
}
