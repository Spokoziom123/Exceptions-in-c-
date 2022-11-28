//napisz program który podzieli dwie liczby podane od użytkownika
try{
    Console.WriteLine("Podaj x: ");
    double x = int.Parse(Console.ReadLine());
    Console.WriteLine("Podaj y: ");
    double y = int.Parse(Console.ReadLine());
    if(y == 0) throw new DivideByZeroException("Nie dziel przez zero");
    Console.WriteLine($"wynik dzielenia {x} przez {y} to {x/y}");
}
catch(FormatException e){
    Console.WriteLine("Błąd konwersjii: "+e.Message);
}
catch(OutOfMemoryException e){
    Console.WriteLine("Zbyt mało pamięci: "+e.Message);
}
catch(StackOverflowException e){
    Console.WriteLine("Przepełnienie Stosu"+e.Message);
}
catch(ArithmeticException e){
    Console.WriteLine("Błąd Arytmatyczny: " + e.Message);
}
catch(NullReferenceException e){
    Console.WriteLine("Nic nie podano: "+e.Message);
}
catch(Exception e){
    Console.WriteLine("Error: "+e.Message);
}
finally{
    Console.WriteLine(":)");
}
 



 
