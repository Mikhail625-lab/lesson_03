using System;
using System.Text;

namespace _03_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1.Написать программу, выводящую элементы двумерного массива по диагонали.
            2.Написать программу «Телефонный справочник»: создать двумерный массив 5х2, хранящий список телефонных контактов: первый элемент хранит имя контакта, второй — номер телефона/ email.
            3.Написать программу, выводящую введённую пользователем строку в обратном порядке(olleH вместо Hello).
            *«Морской бой»: вывести на экран массив 10х10, состоящий из символов X и O, где Х — элементы кораблей, а О — свободные клетки.
            
            4. * **Написать программу, которая считывает с консоли число n и смешает одномерный массив и на n(может быть положительным, или отрицательным).Для усложнения задачи нельзя пользоваться вспомогательными массивами.
            */

            { // Task № 1.Написать программу, выводящую элементы двумерного массива по диагонали.
                
              // block declare init vars
              // int row1,  clmn1 , row2 , clmn2;
                int  row1;  // qty row  
                int  clmn;  // qty columnus 

                int  row2 = 11; // qty row  
                int  clmn2 = 11;  // qty  columnus 

                int x1;
                int y1;               
                string count1; 
                int [,] arrField1 = new int [row2, clmn2];

                Random rnd1 = new Random();
                Random rnd2 = new Random();

                // block executive

                // создаём массив\матрицу 11х11 с отображением для наглядности на экран 
                Console.WriteLine("");
                Console.WriteLine("      | А | Б | В | Г | Д | Е | Ё | Ж | З | И | К |");


                for (int i=0;i< row2; i++)
                {
                    // Вывод:
                    System.Threading.Thread.Sleep(5);
                    //  Draw massive 
                    if (i < 10) { count1 = "0" + i.ToString(); }
                    else { count1 = i.ToString();  }
                    Console.WriteLine( "      |---+---+---+---+---+---+---+---+---+---+---|" );
                    Console.Write     (" {0}:  |", count1 );
                    for ( int j =0; j < clmn2; j++)
                    {
                        x1 = rnd1.Next(11);
                        y1 = rnd1.Next(11); // - не используется. зарезирвированно для морского боя
                        arrField1[i, j] = x1;

                        if (arrField1[i, j] < 10) { Console.Write(" {0} |", arrField1[i, j]); ; }
                        else {                      Console.Write("{0} |", arrField1[i, j]); }
                    }

                    Console.WriteLine("");
                }
                //Console.WriteLine("      |---+---+---+---+---+---+---+---+---+---+---|");
                Console.WriteLine("      |___|___|___|___|___|___|___|___|___|___|___|");

                // Вывод "диагонали" в ряд . Начинаем с лев-верх (00)
                for (int i = 0; i < 11; i++)
                {
                    Console.WriteLine("№{0}    Pos[{1}:{2}] = {3} , ", i + 1, i, i, arrField1[i, i]);
                }

                    
            }// end of  Task № 1.Написать программу, выводящую элементы двумерного массива по диагонали.

                { // Task № 2.«Телефонный справочник»: создать двумерный массив 5х2, хранящий список телефонных контактов: первый элемент хранит имя контакта, второй — номер телефона/
                  // block declare init vars

                int row1 = 2; // qty row  
                int clmn1 = 12;  // qty  columnus 

                int row2 = 2; // qty row  
                int clmn2 = 5;  // qty  columnus 

                string firstName1;
                string telNumber1;
                string delimetr = " / ";
                string email1;

                string [,] arrNameList   = new string [row1,clmn1];
                string [,] arrPhoneBook1 = new string [row2, clmn2];

                Random rnd1 = new Random();
 
                // block executive


                // add names for select random 
                {
                    arrNameList[0, 0] = "Бунин";
                    arrNameList[0, 1] = "Лесков";
                    arrNameList[0, 2] = "Пушкин";
                    arrNameList[0, 3] = "Лермонтов";
                    arrNameList[0, 4] = "Булгаков";
                    arrNameList[0, 5] = "Достоевский";
                    arrNameList[0, 6] = "Толстой";
                    arrNameList[0, 7] = "Аксаков";
                    arrNameList[0, 8] = "Фет";
                    arrNameList[0, 9] = "Гумилев";
                    arrNameList[0, 10] = "Чехов";
                    arrNameList[0, 11] = "Волошин";

                    arrNameList[1, 0] = "Михаил";
                    arrNameList[1, 1] = "Александр";
                    arrNameList[1, 2] = "Федор";
                    arrNameList[1, 3] = "Григорий";
                    arrNameList[1, 4] = "Алексей";
                    arrNameList[1, 5] = "Николай";
                    arrNameList[1, 6] = "Антон";
                    arrNameList[1, 7] = "Иван";
                    arrNameList[1, 8] = "Пётр";
                    arrNameList[1, 9] = "Семён";
                    arrNameList[1, 10] = "Максимилиан";
                    arrNameList[1, 11] = "Дмитрий";
                }

                for (int i = 0; i < row2; i++)
                {
                    for (int j = 0; j < clmn2; j++)
                    {

                        Console.WriteLine(" Enter first name:");
                        firstName1 = Console.ReadLine();
                        if (firstName1 == "")
                        {
                            arrPhoneBook1[i, j] = arrNameList[rnd1.Next(arrNameList.Length + 1), 0]
                                        + " " +   arrNameList[rnd1.Next(arrNameList.Length + 1), 1];
                        } 
                        else 
                        {
                            arrPhoneBook1[i,j] = firstName1;
                            firstName1 = "";
                        }

                        Console.WriteLine(" Enter tel number :");
                        telNumber1 = Console.ReadLine();
                        Console.WriteLine(" Enter e-mail :");
                        email1 = Console.ReadLine();

                        arrPhoneBook1[i, j] = telNumber1+ delimetr + email1;

                    }

                    Console.WriteLine("");
                }




            }// end of  Task № 2.«Телефонный справочник»: создать двумерный массив 5х2, хранящий список телефонных контактов: первый элемент хранит имя контакта, второй — номер телефона/

                { // Task № xx
              // block declare init vars
              // block executive
              // end of  Task № xx
            }

            { // Task № xx
              // block declare init vars
              // block executive
              // end of  Task № xx
            }

            { // Task № xx
              // block declare init vars
              // block executive
              // end of  Task № xx
            }

            { // Task № xx
              // block declare init vars
              // block executive
              // end of  Task № xx
            }



            static void DrawArr(string[] args)
            {



            }

        }
    }
}
