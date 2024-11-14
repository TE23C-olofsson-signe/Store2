int kr = 100; 

Console.WriteLine("Du har 100 kr och u kan köpa det här");
Console.WriteLine(" 1.Colaflaska 10 kr ");
Console.WriteLine("2. Pripps grapefrukt 0.0% alkohol 20 kr"); 
Console.WriteLine("3. Tuggumi med smak av melon och mint 30 kr");

string vilken = Console.ReadLine(); 

Console.WriteLine("okej hur många"); 
string antal= Console.ReadLine(); 

int a =0; 

int.TryParse(antal,out a); 

int kostnad = 0;
if (vilken == "1")
{
    kostnad = a * 10;
}

if(vilken== "2")
{
    kostnad = a * 20;
}

if(vilken == "3")
{
    kostnad = a * 30; 
}



if(kostnad < 100 )
{
    Console.WriteLine("Ja det går bra "); 
}
else{
    Console.WriteLine("Nej du har för lite pengar"); 
}



Console.ReadLine(); 

// int a =0;
// int.TryParse(antal, out a);

// int ageNum = 0; 
// bool success = false;   
// while (success == false)
// {
// Console.WriteLine("Hur gammal är du?");
// string age = Console.ReadLine(); 
// success = int.TryParse(age, out ageNum); 

// if(success == false)
// {
//     Console.WriteLine("Du måste skriva en siffra, dumhuvve"); 
// }

// if(ageNum < 18)
// {
//     Console.WriteLine("Nä du är för ung"); 
// }
// else{
//     Console.WriteLine("okej, välkommen"); 
// }    
// }

// Console.ReadLine(); 
// det är är den bästa lektioner på hela veckan 