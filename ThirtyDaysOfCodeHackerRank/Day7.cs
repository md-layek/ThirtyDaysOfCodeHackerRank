using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        
        int N=int.Parse(Console.ReadLine());
        for(int i=0; i < N; i++){
            string myString=Console.ReadLine();
            
            for(int j=0;j<myString.Length;j++){
                
                if(j%2 = =0) Console.Write(myString[j]);
                
            }
            
            Console.Write(" ");
            
            for(int j=0;j<myString.Length;j++){
                if(j%2 !=0;j<myString.Length;j++) Console.Write(myString[j]);
            }
            
            Console.Write(Environment.NewLine);
        }
        
        
    }
}