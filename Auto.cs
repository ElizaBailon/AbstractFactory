//Factoria Concreta
class autoFactory: Ivehiculo
{
     public Neumatico CreateNeumatico()
     {
        return new AutoNeumatico();
     }

     public Freno CreateFreno()
     {
        return new AutoFreno();
     }
}