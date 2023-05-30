// Programa que permita visualizar los departamentos de nicaragua
// con su cantidad poblacional
// Encuentre: mayor, menor, sumas y ordene los datos
using System.Collections.Generic;
String[] Departamento = { "Boaco", "Carazo", "Chinandega", "Chontales", "Costa Caribe Norte", "Costa Caribe Sur", "Estelí", "Granada", "Jinotega", "León", "Madriz", "Managua", "Masaya", "Matagalpa", "Nueva Segovia", "Río San Juan", "Rivas" };
int[] Poblacion = { 185013, 197139, 439906, 190863, 530586, 414543, 229866, 214317, 475630, 421050, 174744, 1546939, 391903, 593503, 271581, 135446, 182645 };
Dictionary<string, int> diccionario = Departamento
.Zip(Poblacion, (k, v) => new { Clave = k, Valor = v })
.ToDictionary(x => x.Clave, x => x.Valor);
//Encontrar el mayor y menor (poblacion)
String minDep = Poblacion.Min();
String maxDep = Poblacion.Max();
string maxDepKey="", minDepKey="";
//Encotrar el nombre del departamento que tiene la mayor y menor poblacion
for (var i = 0; i < Poblacion.Length; i++){
    if (Poblacion[i] == maxDep)
    {maxDepKey= Departamento[i];}
    if (Poblacion[i] == minDep)
    { minDepKey= Departamento[i];}   
}
//Mostrar diccionario sin ordenar
Console.WriteLine($"Datos desordenados");
foreach (var item in diccionario)
{ Console.WriteLine($"{item.Key,-20} ==> {item.Value,10:N0}");
Console.WriteLine();}
// Mostrar  resultado
for (int i = 0; i < Poblacion.length; i++)
{ Console.WriteLine($"{Departamento[i],20} ==> {Poblacion[i],10:N0}");
}
//Suma de toda la poblacion y nombre de mayor y menor
Console.WriteLine($"Población General:{diccionario.Values.Sum():N0}"); 
Console.WriteLine($"Departamento  con mayor Población:{maxDepKey}");
Console.WriteLine($"Departamento con menor Población:{minDepKey}");
//poblacion promedio
Console.WriteLine($"poblacion promedio {diccionario.Values.Average():N2}");

