
int number = 5;

ChangeNumber(ref number);
 void ChangeNumber(ref int number)
 {
  number *= 2; // ahora el number sera el valor previo * 2 
 }
 
 Console.WriteLine(number); // 10
 
 
 int result;
 int numbera = 1;
 int numberb=2;

AddNumbers(numbera,numberb, out result);
Console.WriteLine(result);
 void AddNumbers(int number, int numberb, out int result)
 {
  result = number + numberb;
 }