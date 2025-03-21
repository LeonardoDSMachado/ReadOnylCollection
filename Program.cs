﻿using System.Collections.ObjectModel;

var planetas = new List<string>()
{
    "Mercúrio", "Vênus", "Terra", "Marte"
};

var listaPlanetas = new ReadOnlyCollection<string> (planetas);

Console.WriteLine("\nPlanetas não gasosos do sistema solar:");
foreach (var planeta in planetas)
{
    Console.WriteLine($"{planeta} ");
}

Console.WriteLine($"\n\nPlanetas na coleção : {listaPlanetas.Count}");

Console.WriteLine($"\nJúpiter esta na coleção ?");
Console.WriteLine(listaPlanetas.Contains("Júpiter") ? "Sim" : "Não");

Console.WriteLine($"\nPlaneta de índice 3 : {listaPlanetas[3]}");

Console.WriteLine($"\nIndice do planeta Terra : {listaPlanetas.IndexOf("Terra")}");

planetas.Insert(4,"Plutão");
Console.WriteLine("\nExibindo o novo planeta na lista");
foreach (var planeta in planetas)
{
    Console.WriteLine($"{planeta}");
}

Console.WriteLine("\n\nCopiando os elementos da coleção para um Array unidimensional");
string[] planetasArray = new string[listaPlanetas.Count + 2];
listaPlanetas.CopyTo (planetasArray, 1);

Console.WriteLine($"\nO Array copiado possui {planetasArray.Length} elementos");
foreach (var planeta in planetasArray)
{
    Console.WriteLine($"\"{planeta}\"");
}

Console.ReadKey();