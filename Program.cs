
int[] numeros = [1, 2, 3, 4, 5, 6, 7, 8,9]; 
static int? busquedabinaria(int[] lista,int elemento) {

    int menor = 0;
    int mayor=lista.Length-1;

    while (menor<=mayor) {
        int medio = (menor + mayor) / 2;
        int estimado = lista[medio];
        if (estimado == elemento) {
            return medio;
         }
        if (estimado > elemento) {
            mayor = medio - 1;
        }
        else {
            menor = medio + 1;
        } 
    }

    return null;

}

Console.WriteLine(busquedabinaria(numeros, 10));

