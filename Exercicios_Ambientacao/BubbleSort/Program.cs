Random alea = new Random();
int[] lista = new int[1000];
int[] lista2 = new int[1000];

// Da valores aleatorios (1-2000) para a lista
for(int i=0; i< lista.Length; i++) {
    lista[i] = alea.Next(2000) + 1;
    lista2[i] = lista[i];
}

// Ordena a lista com Bubble Sort
bool trocado;
do
{
    trocado = false;
    for(int i=0; i<lista.Length - 1; i++) {
        if(lista[i] > lista[i + 1]) {
            trocado = true;
            int temp = lista[i];
            lista[i] = lista[i+1];
            lista[i+1] = temp;
        }
    }
} while (trocado == true);

// Mostra a lista ordenada
for(int i=0; i< lista.Length; i++) {
   Console.Write(lista[i]+" ");
}  

Console.WriteLine("\n===========================================================================\n");
// Usando a função do C#
Array.Sort(lista2);
// Mostrando a array ordenada
for(int i=0; i< lista.Length; i++) {
   Console.Write(lista2[i]+" ");
}  