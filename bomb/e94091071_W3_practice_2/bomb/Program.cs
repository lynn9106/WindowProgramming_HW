using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bomb
{
    class Program
    {
        static void Main(string[] args)
        {

            try                     //檢查地圖大小與地雷數量輸入格式
            {
                Console.Write("地圖大小(1~10):");
                int size = int.Parse(Console.ReadLine());
                if (size > 0 && size < 11)                      //檢查地圖大小範圍
                {
                    Console.Write("地雷數量(1~10):");
                    int num = int.Parse(Console.ReadLine());
                    if (num > 0 && num < 11)                    //檢查地雷數量範圍
                    {
                        int count = 0;
                        int a;
                        int b;

                        int[,] map = new int[size, size];       //建立地圖

                        for (int r = 0; r < size; r++)          //將各座標預設為0
                        {
                            for (int s = 0; s < size; s++)
                            {
                                map[r, s] = 0;
                            }
                        }

                        try                                     //檢查地雷座標格式
                        {
                            for (int i = 0; i < num; i++)
                            {

                                Console.Write("第 {0} 個地雷的位置(以空白區隔):", i);
                                string get = Console.ReadLine();
                                string[] position = get.Split(' ');
                                a = int.Parse(position[1]);
                                b = int.Parse(position[0]);


                                if (a < 0 || a > size - 1 || b < 0 || b > size - 1)
                                {
                                    Console.WriteLine("地雷超出位置");
                                    Console.ReadKey();

                                }

                                map[a, b] = -1;                 //標示地雷為-1

                                if (a > 0)
                                {
                                    if (map[a - 1, b] != -1)    //標示地雷左邊
                                        map[a - 1, b] += 1;
                                    if (b > 0)                  //標示地雷左上
                                    {
                                        if (map[a - 1, b - 1] != -1)
                                            map[a - 1, b - 1] += 1;
                                    }
                                    if (b < size - 1)           //標示地雷左下
                                    {
                                        if (map[a - 1, b + 1] != -1)
                                            map[a - 1, b + 1] += 1;
                                    }
                                }
                                if (b > 0)                      //標示地雷上方
                                {
                                    if (map[a, b - 1] != -1)
                                        map[a, b - 1] += 1;
                                }
                                if (b < size - 1)               //標示地雷下方
                                {
                                    if (map[a, b + 1] != -1)
                                        map[a, b + 1] += 1;
                                }
                                if (a < size - 1)               //標示地雷右方
                                {
                                    if (map[a + 1, b] != -1)
                                        map[a + 1, b] += 1;
                                    if (b > 0)                  //標示地雷右上
                                    {
                                        if (map[a + 1, b - 1] != -1)
                                            map[a + 1, b - 1] += 1;
                                    }
                                    if (b < size - 1)           //標示地雷右下
                                    {
                                        if (map[a + 1, b + 1] != -1)
                                            map[a + 1, b + 1] += 1;
                                    }
                                }
                            }
                            Console.WriteLine("---");

                            for (int j = 0; j < size; j++)
                            {
                                for (int k = 0; k < size; k++)
                                {
                                    if (map[j, k] == -1)
                                        Console.Write("X");                 //標示地雷為X
                                    else
                                        Console.Write(map[j, k]);           //其餘顯示統計之數值
                                    count++;
                                    if (count == size)                      //依照輸入之地圖大小換行
                                    {
                                        Console.WriteLine();
                                        count = 0;                          //換行後重新計數
                                    }
                                }
                            }
                            Console.ReadKey();
                        }
                        catch (FormatException)                 //地雷座標格式錯誤，結束程式
                        {
                            Console.WriteLine("請輸入兩個以空白區隔的整數");
                            Console.ReadKey();

                        }

                    }
                    else                                        //地雷數量超出範圍，結束程式
                    {
                        Console.WriteLine("超出範圍");
                        Console.ReadKey();
                    }
                }
                else                                            //地圖大小超出範圍，結束程式
                {
                    Console.WriteLine("超出範圍");
                    Console.ReadKey();
                }
            }
            catch(FormatException)                              //地圖大小與地雷數量輸入格式錯誤，結束程式
            {
                Console.WriteLine("請輸入範圍內的整數");
                Console.ReadKey();
            }


        }
    }
}
