Console.WriteLine("Digite até qual digito a sequencia de Fibonnaci vai ir: ");
int limite = Convert.ToInt32(Console.ReadLine());

int atual=0, proximo=1, temp;

while(atual <= limite) {
    Console.Write(atual+ " ");
    temp = proximo;
    proximo = atual + proximo;
    atual = temp;
    
}