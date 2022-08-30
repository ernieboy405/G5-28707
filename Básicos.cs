//Skeleton of C#

using System;

//Definir variables, hacer operaciones básicas

int x = 0;
int y = 0;
int z = 0;

console.writeline("Dame un número: ");
x = console.readline();

console.writeline("Dame otro número: ");
y = console.readline();

console.writeline("Qué operación quieres hacer?");
console.writeline("1 = suma");
console.writeline("2 = resta");
console.writeline("3 = multiplicación");
console.writeline("4 = división");

switch(z) {
    case 1:
         console.writeline(x + y);
         break;
    case 2:
         console.writeline(x - y);
         break;
    case 3:
         console.writeline(x * y);
         break;
    case 4:
         console.writeline(x / y);
         break;
 
  default:
          console.writeline("Introduzca un número del menú");
          break;
}