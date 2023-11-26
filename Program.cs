//Task 3
//Task was completed 23rd November 2023

/*1) 4 reqemli eded verilib. Bu ededin eveline 7 reqemini , axirinada 8 reqemini artir.
Example1: 3333 = 73338*/

#region first
int number = 3333;
Console.WriteLine("7" + number + "8");
#endregion

//2) 3 reqemli eded verilib. Bu ededin axirina hemin ededdin ozunu yapishdir. example: 333 = 333333;

#region second
/*int originalNumber = 333;

string originalString = originalNumber.ToString();
string resultString = originalString + originalString;
int resultNumber = int.Parse(resultString);

Console.WriteLine("Original number: " + originalNumber);
Console.WriteLine("Result: " + resultNumber);*/
#endregion

//3) 5 reqemli eded verilib. Bu ededin evvel 18 % sonra ise 3 % tap.

#region third
/*// Initial number provided
double initialNumber = 99999;

// Calculate 18% of the initial number
double percentageFirst = (initialNumber * 18) / 100;

// Further operation: Calculate 3% of the previously calculated 18%
double percentageSecond = (percentageFirst * 3) / 100;

Console.WriteLine("Given Number: " + initialNumber);
Console.WriteLine("18% of the same number: " + percentageFirst);
Console.WriteLine("Latter Operation (3% of the 18% of the given number): " + percentageSecond);*/
#endregion

//4) 3 reqemli eded verilib. Bu ededin axirina 7 artir. Sonra cavabin 7% tap;

#region fourth
/*// Original number provided
int originalNumber = 345;

// Append '7' to the original number as a string
string numberString = originalNumber.ToString() + "7";

// Convert the string to a double
double modifiedNumber = double.Parse(numberString);

// Calculate 7% of the modified number
double result = (modifiedNumber * 7) / 100;


Console.WriteLine("Given Number: " + originalNumber);
Console.WriteLine("Number with '7' at the end: " + modifiedNumber);
Console.WriteLine("Seven percent of the modified number: " + result);*/
#endregion

//5) 4 reqemli eded verilib. Bu ededin evvelin 4 reqemi, axirina ise 44 ededini artir. Alinan cavabin 44 % tap.

#region fifth
/*// Original number provided
short originalNumber = 2003;

//Append '4' to the beginning and '44' to the end of the original number as a string, then, convert it to 'double' type
double modifiedNumber = double.Parse("4"+originalNumber.ToString()+"44");

//Calculate 44% of the number with double type
double result = (modifiedNumber * 44) / 100;

Console.WriteLine("Given Number: " + originalNumber);
Console.WriteLine("Modified Number: " + modifiedNumber);
Console.WriteLine("44% of the given number: " + result);*/
#endregion

//6) 4 reqemli eded verilib. Bu ededin evvel 20%-ni , sonra ise cavabin 10% tap. Alinan cavabin kvadratini tap.

#region sixth

/*// The original number provided
double originalNumber = 9003;

// Calculate 20% of the original number
double firstOperation = (originalNumber * 20) / 100;

// Calculate 10% of the result of the first operation
double secondOperation = (firstOperation * 10) / 100;

// Square the result of the second operation
double lastOperation = (secondOperation * secondOperation);

// Display the results

// Display the original number
Console.WriteLine("Given Number: " + originalNumber);

// Display the result of 20% of the given number
Console.WriteLine("20% of the given number: " + firstOperation);

// Display the result of 10% after the first operation
Console.WriteLine("10% after the first operation: " + secondOperation);

// Display the square of the result after the second operation
Console.WriteLine("Square after the second operation: " + lastOperation);*/

#endregion

//7) 2 dene 5 reqemli eded verilib. Bu ededleri toplayib. Alinan cavabin evveline ve axirina 5 artir. Neticenin 5 % tap

#region seventh

/*// Declare variables for the two numbers
int firstNumber, secondNumber;

// Assign values to the numbers
firstNumber = 12345;
secondNumber = 23456;

// Create a modified number by combining the sum of the two numbers with a prefix and suffix
double firstOperation = double.Parse("5" + (firstNumber + secondNumber).ToString() + "5");

// Calculate 5% of the modified number
double result = (firstOperation * 5) / 100;

// Display the results

// Display the given numbers
Console.WriteLine("Given Numbers: " + firstNumber + ";" + secondNumber);

// Display the modified number
Console.WriteLine("Modified Number: " + firstOperation);

// Display the result of the task
Console.WriteLine("Result of the task: " + result);*/

#endregion

/*8) 2 dene eded verilib. I eded 4 reqemli II eded 7 reqemlidir.
I ededin 4%-ni tap.
Sonra II ededin 9% ni tap.
Sonra Cavalari toplayib 10 %ni tap.*/

#region eighth

/*// Declare and initialize two double variables
double firstNumber = 1357;
double secondNumber = 1357902;

// Calculate 4% of the first number
double firstOperation = (firstNumber * 4) / 100;

// Calculate 9% of the second number
double secondOperation = (secondNumber * 9) / 100;

// Calculate the final result by summing the two operations and taking 10%
double result = ((firstOperation + secondOperation) * 10) / 100;

// Display the results

// Display the given numbers
Console.WriteLine("Given Numbers: " + firstNumber + " ; " + secondNumber);

// Display the result of 4% of the first number
Console.WriteLine("4% of the first number: " + firstOperation);

// Display the result of 9% of the second number
Console.WriteLine("9% of the second number: " + secondOperation);

// Display the result of the overall task
Console.WriteLine("Result of the task: " + result);*/
#endregion

//9) 3 dene 6 reqemli eded verilib. Her birinin 10 faizini tapib neticeleri topla. Alinan cavabin 10% tap.

#region ninth

// Declare and initialize three integer variables
/*double firstNumber, secondNumber, thirdNumber;
firstNumber = 123456;
secondNumber = 789012;
thirdNumber = 135790;

// Calculate the sum of 10% of each of the three numbers
double firstOperation = ((firstNumber * 10) / 100 + (secondNumber * 10) / 100 + (thirdNumber * 10) / 100);

// Calculate 10% of the overall sum
double result = (firstOperation * 10) / 100;

// Display the results

// Display the given numbers
Console.WriteLine("Given Numbers: " + firstNumber + " ; " + secondNumber + " ; " + thirdNumber);

// Display the result of the task
Console.WriteLine("Result of the task: " + result);*/

#endregion

/*10) 3 dene 4 reqemli eded verilib. I ededin 1%-ni, II ededin 2% , III ededin 3 % tap.
Neticeleri bir birinden cix. Alinan cavabin ustune III ededin 7% faizini gel*/

#region tenth 

/*// Declare and initialize three double variables
double firstNumber, secondNumber, thirdNumber;
firstNumber = 1234;
secondNumber = 7890;
thirdNumber = 1357;

// Calculate the difference of 10% of each of the three numbers
double firstOperation = ((firstNumber * 10) / 100 - (secondNumber * 10) / 100 - (thirdNumber * 10) / 100);

// Calculate the sum of the result from the first operation and 7% of the third number
double result = firstOperation + ((thirdNumber * 7) / 100);

// Display the results

// Display the given numbers
Console.WriteLine("Given Numbers: " + firstNumber + " ; " + secondNumber + " ; " + thirdNumber);

// Display the result of the task
Console.WriteLine("Result of the task: " + result);*/
#endregion
