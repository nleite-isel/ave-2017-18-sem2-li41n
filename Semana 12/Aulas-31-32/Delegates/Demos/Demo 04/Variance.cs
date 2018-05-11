
public class Vehicle { /* ... */ }
public class Car : Vehicle { /* ... */ }
public class Bike : Vehicle { /* ... */ }

public class Bike1 : Bike {}
public class Bike2 : Bike { }

delegate Vehicle DelegateA();
delegate void DelegateB(Bike b);

public static class Examples {
    public static Car MethodA() { /* ... */ return new Car(); }
    public static void MethodB(Vehicle v) { /* ... */ }  // OK
    //public static void MethodB(Bike b) { /* ... */ } // OK
    //public static void MethodB(Bike1 b) { /* ... */ } // Error, No overload for 'MethodB' matches 'DelegateB'
    // Usando DelegateB posso passar Bike ou qualquer subtipo (Bike1, Bike2). No caso de passar Bike2, iria falhar 
    // porque MethodB recebe Bike1.
    
    public static void DelegateVarianceExample() { 
        // Co-variancia 
        DelegateA delA = MethodA;
        Vehicle v = delA(); // Ok
        Car c = (Car)delA(); // Ok
        //Bike b = (Bike)delA(); // InvalidCastException
        
        // Contra-variancia
        DelegateB delB = MethodB; 
        delB( new Bike() ); // Ok
        delB( new Bike1() ); // Ok
        v = new Bike();
        delB( (Bike)v ); // Ok
        //delB( new Car() ); // Error, cannot convert from 'Car' to 'Bike'
        //delB( new Vehicle() ); // Error, cannot convert from 'Vehicle' to 'Bike'
        // O tipo do argumento passado tem que ser um "tipo compativel" com aquele especificado no delegate (Bike)
        
        // Com a Contra-variancia, podemos associar delegate com um parametro mais especifico (Bike) 
        // a um metodo que recebe um parametro mais geral, MethodB (Vehicle) 
    }
    
    public static void Main1() {
        DelegateVarianceExample();
    }
}
