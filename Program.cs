// Programa que permita visualizar los departamentos de nicaragua
// con su cantidad poblacional
// Encuentre: mayor, menor, sumas y ordene los datos
using DepartamentosClass;

List<Dpto> isDeptos = new List<Dpto>()
{
    new Dpto("Boaco", 185013 ),
    new Dpto("Carazo", 197139 ),
    new Dpto("Chinandega", 439906 ),
    new Dpto("Chontales", 190863 ),
    new Dpto("Costa Caribe Norte", 530586 ),
    new Dpto("Costa Caribe Sur", 414543 ),
    new Dpto("Estelí", 229866 ),
    new Dpto("Granada", 214317 ),
    new Dpto("Jinotega", 475630 ),
    new Dpto("León", 421050 ),
    new Dpto("Madriz", 174744 ),
    new Dpto("Managua", 1546939 ),
    new Dpto("Masaya", 391903 ),
    new Dpto("Matagalpa", 593503 ),
    new Dpto("Nueva Segovia", 271581 ),
    new Dpto("Río San Juan", 135446 ),
    new Dpto("Rivas", 182645 )
};

//Encontrar el mayor y menor (poblacion)
Dpto minDep = isDeptos.OrderBy(d => d.population).First();
Dpto maxDep = isDeptos.OrderBy(d => d.population).Last();
//Ordenar los departaments
var DeptOrdenado = isDeptos.OrderBy(d => d.population);
//Mostrar departamentos ordenados
foreach (var item in DeptOrdenado)
{ 
Console.WriteLine($"{item.Name,-20} ==> {item.population,10:N0}");

}
// Mostrar  el mayor y el menor
Console.WriteLine($"Departamento  con menor Población:{minDep.Name}");
Console.WriteLine($"Departamento  con mayor Población:{maxDep.Name}");
//Sumar todas las poblaciones con Linq
int total = isDeptos.Select( d=> d.population).Sum();
Console.WriteLine($"Población General:{total:N0}"); 

