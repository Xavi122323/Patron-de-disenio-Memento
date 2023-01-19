using Patron_de_diseño_Memento;

Originator originator = new Originator("Super-duper-super-puper-super.");
Caretaker caretaker = new Caretaker(originator);

caretaker.Respaldo();
originator.Accion();

caretaker.Respaldo();
originator.Accion();

caretaker.Respaldo();
originator.Accion();

Console.WriteLine();
caretaker.MostrarHistorial();

Console.WriteLine("\nClient: Comenzando restauración!\n");
caretaker.Deshacer();

Console.WriteLine("\n\nClient: Segunda vez\n");
caretaker.Deshacer();

Console.WriteLine("\n\nClient: Ultima vez\n");
caretaker.Deshacer();

Console.WriteLine();
