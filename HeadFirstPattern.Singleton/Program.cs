using HeadFirstPattern.Singleton;

// MySingletonclass mySingletonclass = new MySingletonclass(); // ist public, also kein Problem
// MySingletonclass mySingletonclass = new MySingletonclass(); // ist public, aber nur ein private Construktor. Instatiieren geht nicht.
 MySingletonclass mySingletonclass =  MySingletonclass.Instance; // ist public, und ein static Property welches new MySingletonclass zurueck liefert. Wir haben unsere Instanz von der Klasse.
 MySingletonclass mySingletonclass2 =  MySingletonclass.Instance; // ist public, und ein static Property welches new MySingletonclass zurueck liefert. Wir haben unsere Instanz von der Klasse.

Console.WriteLine($"{mySingletonclass.MyGuid}") ;
Console.WriteLine($"{mySingletonclass2.MyGuid}") ;

var chocoBoiler = ChocolateBoiler.Instance;
var chocoBoiler2 = ChocolateBoiler.Instance;
Console.WriteLine($"schoco {chocoBoiler.MyGuid}");
Console.WriteLine($"schoco2 {chocoBoiler2.MyGuid}");