// See https://aka.ms/new-console-template for more information
int quantidade,contador=1;
double n,soma=0, media=0, maior=0, menor=0;



Console.Write("Quantos Números: ");
quantidade = Convert.ToInt32(Console.ReadLine());

while(contador<=quantidade){
    Console.Write($"Número #{contador}: ");
    n = Convert.ToDouble(Console.ReadLine());
    if (contador == 1){
        maior = n;
        menor = n;
    }else if (n>maior){
        maior = n;
    }else if(n<menor){
        menor = n;
    }
    contador+=1;
    soma+=n;
    media = soma/quantidade;
}

Console.WriteLine($"A soma é.... {soma:N} ");
Console.WriteLine($"A média é... {media:N} ");
Console.WriteLine($"O maior número é {maior:N}");
Console.WriteLine($"O menor número é {menor:N}");