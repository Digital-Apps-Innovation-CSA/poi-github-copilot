// See https://aka.ms/new-console-template for more information
//function that concat nombre apellido paterno apellido materno
//take first two leters from apellido paterno, first letter from apellido materno and firs letter of nombre
//add fecha nacimiento como datetime y formatea dia mes y año
//create a function whit 3 random letters and numbers
//generate unit testing from ConcatenateFullNameAndBirthdate
//remove 3 last letters
using UnitTesting;

var generator = new rfcgenerator();
Console.WriteLine(generator.ConcatenateFullNameAndBirthdate("Rodrigo","Vera","Romero",new DateTime(1985,7,18)));

