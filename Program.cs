internal class Program
{
    private static void Main(string[] args)
    {
        //Objetos para el auto
        //Llamada a la factoria de autos
        Ivehiculo factory = new autoFactory(); 
        Freno freno = factory.CreateFreno();
        Neumatico neumatico = factory.CreateNeumatico();

        neumatico.Pintar();
        freno.Pintar();

        //Objetos para la moto
        //Llamada a la factoria de motos
        factory = new motoFactory(); 
        freno = factory.CreateFreno();               // Al cambiar el tipo de factoria, todos los objetos 
        neumatico = factory.CreateNeumatico();       // que se crean mediante ella son de la misma familia 
                                                     // como podemos ver en el resto de lineas de codigo
        neumatico.Pintar();                          // son identicas para el auto y para la moto.
        freno.Pintar();
        Console.ReadKey();

    }
}