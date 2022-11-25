using System;

class Solution {
    
     public static void Main(string[] args)  
      {  
          
         int num1, num2, num3;
         
         Console.Write("Enter 1st value = ");
         
         num1 = int.Parse(Console.ReadLine());
         
         Console.Write("Enter 2nd value = ");
         
         num2 = int.Parse(Console.ReadLine());
         
         Console.Write("Enter 3rd value = ");
         
         num3 = int.Parse(Console.ReadLine());
         
         if (num1 > num2) {
             
            if (num1 > num3) {
                
               Console.Write("Number one is the largest!");
               
            } 
            else {
                
               Console.Write("Number three is the largest!");
               
         }
      }
      
      else if (num2 > num3){
          
         Console.Write("Number two is the largest!");
         
      }
      else{
          
         Console.Write("Number three is the largest!");
         
      }
      
      }
}  
