//Factoria Concreta
class motoFactory: Ivehiculo
{
    public Neumatico CreateNeumatico()
     {
        return new MotoNeumatico();

     }

     public Freno CreateFreno()
     {
        return new MotoFreno();
     }
}