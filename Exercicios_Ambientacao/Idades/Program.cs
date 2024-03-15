// se idade <= 13: Criança, se idade > 13 e <= 18: Adolescente, se idade > 18 e <= 60: Adulto e se idade > 60: Idoso.

Console.WriteLine("Informe sua idade: ");
int idade = Convert.ToInt32(Console.ReadLine());

if(idade <= 13) {
    Console.WriteLine("Criança!");
} else if(idade > 13 && idade <= 18) {
    Console.WriteLine("Adolescente");
} else if(idade > 18 && idade <= 60) {
    Console.WriteLine("Adulto");
} else {
    Console.WriteLine("Idoso");
}