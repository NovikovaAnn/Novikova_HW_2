//задача1. принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

Console.WriteLine ("Input three-digit number ");
int num = Convert.ToInt32(Console.ReadLine());

void ShowSecondDigit(){
    int num1 = num / 10 % 10;
    Console.Write("Second digit is " + num1);
}

ShowSecondDigit();

//Задача2. Выводит третью цифру заданного числа 

void ShowThirdDigit(int num){
    if (num > 99){
            int num1 = num;
            while (num1 > 999){
                num1 = num1 / 10;
            }
            int third = num1 % 10;
            Console.Write("Third digit is " + third);
    }
    else
    Console.Write("There is no third digit " );
}
Console.WriteLine ("Input number ");
int num = Convert.ToInt32(Console.ReadLine());
ShowThirdDigit(num);


// Задача 3. принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine ("Input number from 1 to 7");
int num = Convert.ToInt32(Console.ReadLine());

void CheckWeekend(){
    if (num >=1 && num <= 7){
        if (num == 6 || num == 7){
        Console.WriteLine ("This is a weekend");
    }
        else
        Console.WriteLine ("This is not a weekend");
    }
    else
    Console.WriteLine ("You entered the wrong number");
    
    }
    
CheckWeekend();

