using System; 

class URI {

    static void Main(string[] args) { 
        
        int Numero = int.Parse(Console.ReadLine());
        
        for(int i=2; i <=Numero; i+=2){
            Console.WriteLine("{0}^2 = {1}", i, i * i);
        }

    }

}