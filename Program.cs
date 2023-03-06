
string password = "";
do{
    System.Console.WriteLine("enter your password for Kescha ");
    password = Console.ReadLine();

}
while (password != "password");

string[] random  = {"demo2123" ,"salom111","muborak2323"};
System.Console.WriteLine(random[2]);

















































System.Console.WriteLine("Enter your name ");
int keshaAge = 3;
string name = Console.ReadLine();
System.Console.WriteLine("Enter your age ");

int yourAge = Convert.ToInt32(Console.ReadLine());
int result = yourAge - keshaAge ;
System.Console.WriteLine("you are operation  is ");
string operation = Console.ReadLine();



if(yourAge<keshaAge) {
    System.Console.WriteLine("you are  younger ");
}
else if(yourAge==keshaAge){
    System.Console.WriteLine("you are same age ");
}
else {
    System.Console.WriteLine("you are older  ");
}

string fristresult =
     yourAge> 0
            ? "1 nd is  positive "
            :" 1nd  is negative " ;
            System.Console.WriteLine(fristresult);

 string secondresult =
     keshaAge > 0
            ? "1 nd is positive  "
            :" 1nd  is negative " ;
            System.Console.WriteLine(secondresult);           


string switchResult  = operation switch  {
    "+" => $"{yourAge} + {keshaAge} = {yourAge + keshaAge} " ,
    "-" => $"{yourAge} - {keshaAge} = {yourAge - keshaAge}" ,
    "/" => $"{yourAge} / {keshaAge} = {yourAge / keshaAge} " ,
    "*" => $"{yourAge} * {keshaAge} =  {yourAge * keshaAge} " ,
    "%" => $"{yourAge} % {keshaAge} =  {yourAge % keshaAge} " ,
    _   => "Operation is not found !"
};
System.Console.WriteLine(switchResult);

