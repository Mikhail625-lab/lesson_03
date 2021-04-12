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

                int row1 = 3; // qty row  
                int clmn1 = 12;  // qty  columnus 

                int row2 = 2; // qty row  
                int clmn2 = 5;  // qty  columnus 

                int pos1; // position (in array )

                string firstName1;
                string telNumber1;
                string delimetr = " / ";
                string email1;
                string stmp;

                string [,] arrNameList   = new string [row1,clmn1];
                string [,] arrPhoneBook1 = new string [row2, clmn2];

                Random rnd1 = new Random();

                // block executive

                //Console.WriteLine("arrNameList.Rank   :   " + arrNameList.Rank );
                //Console.WriteLine("arrNameList.Length :   " + arrNameList.Length );

                // add names to pool massive for select random 
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

                    arrNameList[1, 0] = "Иван";
                    arrNameList[1, 1] = "Николай";
                    arrNameList[1, 2] = "Александр";
                    arrNameList[1, 3] = "Михаил";
                    arrNameList[1, 4] = "Михаил";
                    arrNameList[1, 5] = "Федор";
                    arrNameList[1, 6] = "Алексей";
                    arrNameList[1, 7] = "Сергей";
                    arrNameList[1, 8] = "Афанасий";
                    arrNameList[1, 9] = "Николай ";
                    arrNameList[1, 10] = "Антон";
                    arrNameList[1, 11] = "Максимилиан";

                    arrNameList[2, 0] = "Алексеевич";
                    arrNameList[2, 1] = "Семёнович";
                    arrNameList[2, 2] = "Сергеевич";
                    arrNameList[2, 3] = "Юрьевич";
                    arrNameList[2, 4] = "Афанасьевич";
                    arrNameList[2, 5] = "Михайлович";
                    arrNameList[2, 6] = "Константинович";
                    arrNameList[2, 7] = "Тимофеевич";
                    arrNameList[2, 8] = "Афанасьевич";
                    arrNameList[2, 9] = "Степанович";
                    arrNameList[2, 10] = "Павлович";
                    arrNameList[2, 11] = "Александрович";
                }

                for (int i = 0; i < row2; i++)
                {
                    for (int j = 0; j < clmn2; j++)
                    {

                        Console.WriteLine(" Enter first name:");
                        firstName1 = Console.ReadLine();
                        
                        if (firstName1 == "") 
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("You enter EMPTY value. Now generete random name...");

                            pos1 = Convert.ToInt32(rnd1.Next(clmn1));
                            stmp =Convert.ToString(arrNameList[0, pos1]
                                + " " + arrNameList[1, pos1]
                                + " " + arrNameList[2, pos1]
                                );
                            arrPhoneBook1[i, j] = stmp;

                            { // Output

                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write("... all right. Create name :");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine(arrPhoneBook1[i, j]);
                                Console.ForegroundColor = ConsoleColor.Gray;
                            }
                            pos1 = 0 ; stmp = "";
                        } 
                        else 
                        {
                            arrPhoneBook1[i,j] = firstName1;
                            firstName1 = "";
                        }

                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine(" Enter tel number :");
                        telNumber1 = Console.ReadLine();

                        if (telNumber1 == "" | telNumber1.Length<8 )
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("You enter EMPTY value. ");
                            Console.WriteLine("or telephon nuber not correct");
                            Console.WriteLine(" Now generete random number tel...");
                            var rnd2 = new Random();
                            var s = new StringBuilder();

                            for (int k = 0; k < 10  ; k++)
                            {
                                telNumber1 = telNumber1 + Convert.ToString ( rnd2.Next(0,10)   ) ;
                            }
                        }
                        telNumber1 = "+7" + telNumber1;
                        telNumber1 = telNumber1.Insert(2, "(");
                        telNumber1 = telNumber1.Insert(6, ")");
                        telNumber1 = telNumber1.Insert(10, "-");
                        telNumber1 = telNumber1.Insert(13, "-");

                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("... all right. Create tel : ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(telNumber1);
                        Console.ForegroundColor = ConsoleColor.Gray;

                        Console.WriteLine(" Enter e-mail :");
                        email1 = Console.ReadLine();
                        if (email1 == "")
                        {
                            Console.WriteLine("You enter EMPTY value. Now generete random e-mail...");
                            var rnd2 = new Random();
                            var s = new StringBuilder();

                            for (int k = 0; k < (Convert.ToInt32((rnd2.Next(5) + 5))); k++)
                            {
                                s.Append((char)rnd2.Next('a', 'z'));
                                email1= (s.ToString()) + "@" + "yopmail" + ".com";
                            }
                        }

                        arrPhoneBook1[i, j] = telNumber1+ delimetr + email1;

                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("... all right. Create e-mail : ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(arrPhoneBook1[i, j]);
                        Console.ForegroundColor = ConsoleColor.Gray;

                        email1 = "";
                        telNumber1 = "";
                    }
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
