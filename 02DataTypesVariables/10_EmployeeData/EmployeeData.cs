using System;

class EmployeeData
{
    static void Main()
    {
        string firstName = "Emil";
        string lastName = "Tochev";
        byte age = 99;
        char gender = 'm';
        long idNumber = 8306112507;
        uint employeeNumber = 27561122;
        Console.WriteLine("First Name: {0}\nLast Name: {1}\nAge: {2}\nGender: {3}\nPersonal ID Number: {4}\nUnique Employee Number: {5}", firstName, lastName, age, gender, idNumber, employeeNumber);
    }
}