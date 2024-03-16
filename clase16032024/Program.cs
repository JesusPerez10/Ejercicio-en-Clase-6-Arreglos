static void ejemplo1()
{
    // Declaracion de un arreglo
    int[] calificaciones;
    string[] nombres = new string[3];

    nombres[0] = "Juan";
    nombres[1] = "Ana";
    nombres[2] = "Pedro";
    // Creacion de un arreglo con valores iniciales
    calificaciones = new int[] { 85, 92, 77, 68, 98 };

    // Imprimir nombres
    foreach (string nombre in nombres)
    {
        Console.WriteLine(nombre);
    }

    // Imprimir calificaciones
    for (int i = 0; i < calificaciones.Length; i++)
    {
        Console.WriteLine($"Calificacion{i + 1}:{calificaciones[i]}");
    }

    // Calcular el promedio
    int suma = 0;
    foreach (int calificacion in calificaciones)
    {
        suma += calificacion;
    }
    double promedio = (double)suma / calificaciones.Length;
    Console.WriteLine($"El promedio de calificaciones es: {promedio}");

    // Acceso a un elemento del arreglo 
    Console.WriteLine(calificaciones[2]); // Imprime 77
}

ejemplo1();

static void despliegue(int[] arreglo)
{
    foreach (int item in arreglo)
    {
        Console.WriteLine(item);

    }
}

    static void ejemplo10()
    {
        int[] elementos = new int[] { 50, 20, 80, 90, 60 };
        Array.Sort(elementos);
        Console.WriteLine("Original:");
        despliegue(elementos);
        Console.WriteLine("Ordenado:");
        Array.Sort(elementos);
        despliegue(elementos);
    Console.WriteLine("Revertido:");
    Array.Reverse(elementos);
        despliegue(elementos);


    }

ejemplo10();