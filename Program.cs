using DIORpg.src.Entities;

Hero arus = new Knight("Arus", 23, "Knight");
Hero wizard = new Wizard("Jennica", 23, "White Wizard");


//Listagem ruim sem POO
// string nome = "Arus";
// int level = 12;
// string tipoHeroi = "Guerreiro";

System.Console.WriteLine(arus.Attack(1));
System.Console.WriteLine(wizard.Attack(0));


//hero sozinho já chama o .tostring()
System.Console.WriteLine(arus);
System.Console.WriteLine(wizard);