bool opcion = true;

int contadorA = 0;
int contadorR = 0;
int contadorN = 0;
int contadorB = 0;

int uAceptan = 0;
int uRechazan = 0;
int uEmpate = 0;

do
{
    bool x = true;

    Console.Write("\nIngrese el nombre de la universidad: ");
    string nombre = Console.ReadLine();

    Console.WriteLine("\nIngrese el voto: \nAceptar(A) \nRechazar(R) \nNulo(N) \nBlanco(B) \nTerminar votación(X)");

    do
    {
        string voto = Console.ReadLine().ToLower();
        switch (voto)
        {
            case "a":
                contadorA += 1;
                break;

            case "r":
                contadorR += 1;
                break;

            case "n":
                contadorN += 1;
                break;

            case "b":
                contadorB += 1;
                break;

            default:
                Console.WriteLine($"Universidad: {nombre}");
                Console.WriteLine($"{nombre}: {contadorA} aceptan, {contadorR} rechazan, {contadorB} blancos, {contadorN} nulos.");

                x = false;
                break;
        }
    } while (x);

    if(contadorA > contadorB && contadorA > contadorR  && contadorA > contadorN)
    {
        uAceptan += 1;
    }
    if(contadorR > contadorB && contadorR > contadorA  && contadorR > contadorN)
    {
        uRechazan += 1;
    }
    if(contadorA == contadorR)
    {
        uEmpate += 1;
    }

    int numero = uAceptan + uEmpate + uRechazan;

    Console.WriteLine("\n¿Desea ingresar otra universidad? S/N");
    string seguir = Console.ReadLine().ToLower();

    if (seguir == "n")
    {
        opcion = false;
        Console.WriteLine($"\nNúmero de universidades: {numero}");
        Console.WriteLine($"Universidades que aceptan: {uAceptan}");
        Console.WriteLine($"Universidades que rechazan: {uRechazan}");
        Console.WriteLine($"Universidades con empate:: {uEmpate}");
    }

} while (opcion);

