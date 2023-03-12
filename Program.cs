using Kescha.Classes;

string password = "";
do{
    System.Console.WriteLine("enter your password for Kescha ");
    password = Console.ReadLine();
}
while (password != "password");
Animal kescha = new Animal(name : "kescha", age :3);


System.Console.WriteLine("Enter your name ");
string userName = Console.ReadLine();
kescha.Greet(userName);
System.Console.WriteLine("Enter write  age ");
int userAge = Convert.ToInt32(Console.ReadLine());
int yourAge = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter your age    ");
// conditional

// int AgeDiffrence = yourAge - keshaAge ;
System.Console.WriteLine("you are operation  is ");
string operation = Console.ReadLine();
// start Object ;

 kescha.Age = 3;
 kescha.CalculatorDiffrenceWithnoReturn(userAge);
 kescha.PrintAgediffrence();
 kescha.CompareAge(userAge:userAge);
 kescha.tellAboutFrieds(userAge,  userName );
 

//   End object 


string fristresult =
     yourAge> 0
            ? "1 nd is  positive "
            :" 1nd  is negative " ;
            System.Console.WriteLine(fristresult);       

 string secondresult =
     kescha.Age > 0
            ? "1 nd is positive  "
            :" 1nd  is negative " ;
            System.Console.WriteLine(secondresult);           
// switchcase

string switchResult  = operation switch  {
    "+" => $"{yourAge} + {kescha.Age} = {yourAge + kescha.Age} " ,
    "-" => $"{yourAge} - {kescha.Age} = {yourAge - kescha.Age}" ,
    "/" => $"{yourAge} / {kescha.Age} = {yourAge / kescha.Age} " ,
    "*" => $"{yourAge} * {kescha.Age} =  {yourAge * kescha.Age} " ,
    "%" => $"{yourAge} % {kescha.Age} =  {yourAge % kescha.Age} " ,
    _   => "Operation is not found !"
};
System.Console.WriteLine(switchResult);

string[] random  = {"demo2123" ,"salom111","muborak2323"};
System.Console.WriteLine(random[2]);


