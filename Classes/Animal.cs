namespace Kescha.Classes
{

   public  class Animal{
    public string Name {get ; set ;}
    public int Age { get; set; }
    public int AgeDiffrence { get; set; }

        public Animal(){
            Name = "no name ";
            Age = 4;
        }
        public Animal(string name , int age ){
            Name = name;
            Age = age ;

        }
        public Animal(  
            string name,
            int userAge,
            int animalAge)
            {
           
             Name = name  ;
            Age = animalAge;
            AgeDiffrence = CalculatorDiffrence(userAge,animalAge);

        }
        public int  CalculatorDiffrence(int userAge,int animalAge){
            return userAge- animalAge;
        }
        public void Greet(string userName ){
            if (userName=="")
            {
                System.Console.WriteLine("Unknown person");
            }
            Console.WriteLine($"Hello {userName }   how is it going ");
        }
         public void    PrintAgediffrence(){
            Console.WriteLine($"The diffrence between   your and   {Name}`s  age is {AgeDiffrence}");
        }
        public void CompareAge(int userAge){
            
            if (userAge<Age) {
                System.Console.WriteLine("you are  younger ");
            }
            else if(userAge==Age){
                Console.WriteLine("you are same age ");
            }
            else {
               Console.WriteLine("you are older  ");
            }
        }
        public void tellAboutFrieds(int userAge , string userName ){

                Console.WriteLine("Let me tell you about my friends");
                string[] friendsName = new string[3];
                friendsName[0] = "Kasee" ;
                friendsName[1] = "Vasya" ;
                friendsName[2] = userName;

                int[] friendsAge = {1,2,userAge };
                for(int iteration = 0; iteration<friendsName.Length; iteration++)
                {
                    Console.WriteLine($"{friendsName[iteration]} is {friendsAge[iteration] } year old !");
                }
        }
        public void  CalculatorDiffrenceWithnoReturn(int userAge ){
            AgeDiffrence= userAge- Age ;
        }

        
    }

}