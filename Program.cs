// mark Ramirez 
// 10/18/2022
// adding numbers
// you give me two numbers I add two numbers 
Console.Clear();
bool validation = true;
double idk=0;
Console.WriteLine("we are going to add two numbers.");
string Num1 = "";
string Num2 = "";
Double number1 = 0;
bool playing = true;

while(playing == true)
{
validation = true;
while(validation == true){
Console.WriteLine("Enter your first number now");

Num1 = Console.ReadLine();
    bool NuM1 = Double.TryParse(Num1, out idk);
    if(NuM1 == true ){
        validation = false;
    }else if(NuM1 == false){
    }
}
        number1 = Convert.ToDouble(Num1);

        validation = true;

while(validation == true){
Console.WriteLine("Enter your Second number now");

Num2 = Console.ReadLine();
    bool NuM2 = Double.TryParse(Num2, out idk);
    if(NuM2 == true ){
        validation = false;
    }else if(NuM2 == false){
    }
}


Double number2 = Convert.ToDouble(Num2);

Console.WriteLine("Your sum is:" + (number1 + number2));

bool yessir = true;
Console.WriteLine($"want to play again");
string responce = Console.ReadLine();
while(yessir == true)
{
responce.ToLower();
if(responce == "yes" ){
yessir = false;
playing = true;
}else if(responce == "no" ){
yessir = false;
playing = false;
}else{
Console.WriteLine($"so like i need a yes or no not this \"{responce}\" ");
responce = Console.ReadLine();
}
}
}