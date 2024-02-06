using Business.Concrete;
using Entities.Concrete;

Person person = new Person();
person.FirstName = "Ahmet";
person.LastName = "Özkan";
person.DateOfBirthYear = 1999;
person.NationalIdentity = 123;

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person);


static void Variables()
{
    string message = "Merhaba";
    double total = 100000;
    int number = 100;
    bool isItLogIn = false;
    Console.WriteLine(total * 1.18);
    Console.WriteLine(total * 1.18);
}