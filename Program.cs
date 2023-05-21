int numero;

Console.WriteLine("digite um numero");
numero =Convert.ToInt32(Console.ReadLine());
int definiçao = numero % 2;

if(definiçao == 0){
    Console.WriteLine($"{numero} e par");
}
else{
    Console.WriteLine($"{numero} e impar");
}


