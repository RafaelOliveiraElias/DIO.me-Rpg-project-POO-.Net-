using DIORpg.src.Entities;

Hero arus = new Knight("Arus", 42, "Knight", 469);
Hero jenica = new Wizard("Jenica", 42, "White Wizard", 474);
Hero wedge = new Wizard("Wedge", 42, "Ninja", 292);
Hero topapa = new BlackWizard("Topapa", 42, "Black Wizard", 611);




//hero sozinho já chama o .tostring()

System.Console.WriteLine(arus);
System.Console.WriteLine(jenica);
System.Console.WriteLine(wedge);
System.Console.WriteLine(topapa);
System.Console.WriteLine();
System.Console.WriteLine("----------Enter para atacar----------");
Console.ReadLine();

System.Console.WriteLine("-----Ataques Arus-----");
System.Console.WriteLine(arus.Attack());
System.Console.WriteLine(arus.Attack(1));
System.Console.WriteLine("-----Ataques Jenica-----");
System.Console.WriteLine(jenica.Attack());
System.Console.WriteLine(jenica.Attack(1));
System.Console.WriteLine("-----Ataques Wedge-----");
System.Console.WriteLine(wedge.Attack());
System.Console.WriteLine(wedge.Attack(1));
System.Console.WriteLine("-----Ataques Topapa-----");
System.Console.WriteLine(topapa.Attack());
System.Console.WriteLine(topapa.Attack(1));

//Listagem ruim sem POO
// string nome = "Arus";
// int level = 12;
// string tipoHeroi = "Guerreiro";