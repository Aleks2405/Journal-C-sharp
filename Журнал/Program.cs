using System;
using one;

//using static System.Console;

/*Ранее в одном из практических заданий вы создавали
класс «Журнал». Добавьте к уже созданному классу информацию о количестве сотрудников. Выполните перегрузку
+ (для увеличения количества сотрудников на указанную
величину), — (для уменьшения количества сотрудников
на указанную величину), == (проверка на равенство количества сотрудников), < и > (проверка на меньше или
больше количества сотрудников), != и Equals. Используйте
механизм свойств для полей класса.*/

namespace one
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal staff = new Journal { Value = 5} ;
            Journal staff1 = new Journal { Value = 5 };
           Journal staff2 = staff + staff1;

            Console.WriteLine(staff2.Value);

           



        }
    }
}
