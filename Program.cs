using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDouble
{
    
            class Program
        {
            static void Main(string[] args)
            {
                DLL ob = new DLL();
                int ch, ele = 0, pos, flag;
                flag = 1;

                while (flag == 1)
                {
                    Console.WriteLine("1 Insert begin");
                    Console.WriteLine("2 Insert end");
                    Console.WriteLine("3 Insert pos");
                    Console.WriteLine("4 Display ");
                    Console.WriteLine("5 Reverese Display");
                    Console.WriteLine("6 Print Last node");
                    Console.WriteLine("7 Find first occurance");
                    Console.WriteLine("8 Find nth occurance");
                    Console.WriteLine("9 Delete at the begin");
                    Console.WriteLine("10 Delete at the end");
                    Console.WriteLine("11 Delete at the pos");
                    Console.WriteLine("12 Exit");


                    ch = int.Parse(Console.ReadLine());
                    if ((ch >= 1 && ch <= 3) || ch == 7 || ch == 8)
                    {
                        Console.WriteLine("Enter the element ");
                        ele = int.Parse(Console.ReadLine());
                    }
                    switch (ch)
                    {
                        case 1: ob.insertbegin(ele); break;
                        case 2: ob.insertend(ele); break;
                        case 3:
                            do
                            {
                                Console.WriteLine("Enter pos between {0} to {1}", 1, ob.count + 1);
                                pos = int.Parse(Console.ReadLine());
                            } while (pos < 1 || pos > ob.count + 1);
                            ob.insertpos(ele, pos);
                            break;
                        case 4: ob.display(); break;
                        case 5: ob.printrev(); break;
                        case 6:
                            Node ln = ob.lastnode();
                            Console.WriteLine("the last node data is " + ln.data);
                            break;
                        case 7:
                            pos = ob.find(ele);
                            if (pos == -1)
                                Console.WriteLine("search key not found");
                            else
                                Console.WriteLine("search key found at {0} pos ", pos);
                            break;
                        case 8:
                            int occ;
                            Console.WriteLine("Enter occurance");
                            occ = int.Parse(Console.ReadLine());
                            pos = ob.find(ele, occ);
                            if (pos == -1)
                                Console.WriteLine("search key not found");
                            else if (pos == -2)
                                Console.WriteLine("found search key but not occurance");
                            else
                                Console.WriteLine("search key found at {0} pos ", pos);
                            break;
                        case 9: ob.deletebegin(); break;
                        case 10: ob.deleteend(); break;
                        case 11:
                            do
                            {
                                Console.WriteLine("Enter pos between {0} to {1}", 1, ob.count);
                                pos = int.Parse(Console.ReadLine());
                            } while (pos < 1 || pos > ob.count);
                            ob.deletepos(pos);
                            break;
                        case 12: flag = 0; break;
                        default: Console.WriteLine("invalid choice"); break;
                    }
                }
            }
        }
    }

    

