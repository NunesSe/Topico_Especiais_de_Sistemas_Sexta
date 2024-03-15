Console.WriteLine("Informe numero 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe numero 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 == num2) {
    Console.WriteLine("Sao iguais");
} else if(num1 > num2) {
    Console.WriteLine(num1 + " é maior que " + num2);
} else {
    Console.WriteLine(num2 + " é maior que " + num1);
}