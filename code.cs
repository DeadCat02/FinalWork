using System;

class Program {
  public static void Main (string[] args) {
    int i1 = 0; 
    int i2 = 0;
    string[] N = {"hi", "hello world", "173", "goodbye"};
    string[] NewN;
    NewN = new string[N.Length];
    for(i1 = 0; i1<N.Length; i1++){
      if(N[i1].Length <= 3){
        NewN[i2] = N[i1];
        i2++;
      }
    }
    // Вывод массива
    for(i1 = 0; i1<i2+1; i1++){
      Console.WriteLine(NewN[i1]);
    }
  }
}