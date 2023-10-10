using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_p1_template
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // 程式流程
                // 1. 輸入玩家1、玩家2初始金錢(需要格式檢查)
                Console.Write("玩家1初始金錢: ");
                int cost1 = int.Parse(Console.ReadLine());
                Console.Write("玩家2初始金錢: ");
                int cost2 = int.Parse(Console.ReadLine());
                Console.WriteLine("-------------------- ");

                while (true)
                {

                    bool[] cards = new bool[52];
                    for (int i = 0; i < cards.Length; i++)
                    {
                        cards[i] = false;
                    }
                    int[] p1Hand = new int[2];
                    int[] p2Hand = new int[2];
                    string[] color1 = new string[2];
                    string[] color2 = new string[2];
                    int total1 = 0;
                    int total2 = 0;

                    Random random = new Random();
                    void draw1(int i)
                    {

                        int cardnum = random.Next(52);
                        if (cards[cardnum] != true)
                        {
                            switch (cardnum / 13)
                            {
                                case 0:
                                    color1[i] = "Spade";
                                    break;
                                case 1:
                                    color1[i] = "Heart";
                                    break;
                                case 2:
                                    color1[i] = "Diamond";
                                    break;
                                case 3:
                                    color1[i] = "Club";
                                    break;
                            }
                            cards[cardnum] = true;
                            p1Hand[i] = cardnum % 13 + 1;
                            if (p1Hand[i]==1)
                            {
                                p1Hand[i] =11;
                                total1 += p1Hand[i];
                                if (total1>21)
                                    total1 -=10;
                                p1Hand[i] = 1;
                            }
                            else
                                total1 += p1Hand[i];
                        }
                        else
                            draw1(i);
                    }

                    for (int j = 0; j < p1Hand.Length; j++)
                    {
                        draw1(j);
                    
                    }

                    // 2. 顯示玩家1初始手牌、點數、金錢並下注，需檢查下注金額不能為0、金錢不足與格式檢查
                    //    手牌花色：Spade, Heart, Diamond, Club
                    //    手牌點數：1~13
                    //    手牌顯示格式: "花色 點數"
                    Console.WriteLine("玩家1手牌: " + color1[0] + p1Hand[0] + ", " + color1[1] + p1Hand[1]);
                    Console.WriteLine("玩家1目前點數: " + total1);
                    Console.WriteLine("玩家1目前金錢: " + cost1);
                    Console.Write("請輸入下注金額: ");
                    int bet1 = int.Parse(Console.ReadLine());
                    for (; bet1 > cost1 || bet1 == 0;)                                  //金錢不足並重新輸入
                    {
                        if (bet1 > cost1)
                        {
                            Console.WriteLine("金錢不足，請重新輸入!");
                            Console.Write("請輸入下注金額: ");
                            bet1 = int.Parse(Console.ReadLine());
                        }
                        else                                                         //下注金額0並重新輸入
                        {
                            Console.WriteLine("金錢不能為零，請重新輸入!");
                            Console.Write("請輸入下注金額: ");
                            bet1 = int.Parse(Console.ReadLine());
                        }
                    }
                    // 3. 顯示玩家2初始手牌、點數、金錢並下注，需檢查下注金額不能為0、金錢不足與格式檢查
                    void draw2(int i)
                    {
                        int cardnum = random.Next(52);
                        if (cards[cardnum] != true)
                        {
                            switch (cardnum / 13)
                            {
                                case 0:
                                    color2[i] = "Spade";
                                    break;
                                case 1:
                                    color2[i] = "Heart";
                                    break;
                                case 2:
                                    color2[i] = "Diamond";
                                    break;
                                case 3:
                                    color2[i] = "Club";
                                    break;
                            }
                            cards[cardnum] = true;
                            p2Hand[i] = cardnum % 13 + 1;
                            if (p2Hand[i] == 1)
                            {
                                p2Hand[i] = 11;
                                total2 += p2Hand[i];
                                if (total2 > 21)
                                    total2 -= 10;
                                p2Hand[i] = 1;
                            }
                            else
                                total2 += p2Hand[i];
                        }
                        else
                            draw2(i);
                    }

                    for (int k = 0; k < p2Hand.Length; k++)
                    {
                        draw2(k);
                    }




                    Console.WriteLine("玩家2手牌: " + color2[0] + p2Hand[0] + ", " + color2[1] + p2Hand[1]);
                    Console.WriteLine("玩家2目前點數: " + total2);
                    Console.WriteLine("玩家2目前金錢: " + cost2);
                    Console.Write("請輸入下注金額: ");
                    int bet2 = int.Parse(Console.ReadLine());
                    for (; bet2 > cost2 || bet2 == 0;)                                  //金錢不足並重新輸入
                    {
                        if (bet2 > cost2)
                        {
                            Console.WriteLine("金錢不足，請重新輸入!");
                            Console.Write("請輸入下注金額: ");
                            bet2 = int.Parse(Console.ReadLine());
                        }
                        else                                                         //下注金額0並重新輸入
                        {
                            Console.WriteLine("金錢不能為零，請重新輸入!");
                            Console.Write("請輸入下注金額: ");
                            bet2 = int.Parse(Console.ReadLine());
                        }
                    }
                    //
                    // 4. 兩位玩家依序行動(不斷抽牌或停止抽牌)
                    //    注意1：抽牌完要顯示玩家手牌與點數
                    //    注意2：選擇停止抽牌，需印出當前點數

                    int situation;

                    while (true)
                    {
                        Console.WriteLine("玩家1行動(輸入1抽1張排、輸入P停止抽牌):");
                        string enter = Console.ReadLine();
                        if (enter == "1")
                        {
                            Array.Resize(ref color1, color1.Length + 1);
                            Array.Resize(ref p1Hand, p1Hand.Length + 1);
                            for (int j = p1Hand.Length-1; j < p1Hand.Length; j++)
                            {
                                draw1(j);
                                int ace = Array.IndexOf(p1Hand, 1);
                                if (total1 > 21 && ace != -1)
                                {
                                    total1 = 0;
                                    for (int a = 0; a <= j; a++)
                                        total1 += p1Hand[a];

                                }
                            }
                            Console.Write("玩家1手牌: " + color1[0] + p1Hand[0] + ", " + color1[1] + p1Hand[1]);
                            for (int j = 2; j < p1Hand.Length; j++)
                                Console.Write(", " + color1[j] + p1Hand[j]);
                            Console.WriteLine();
                            Console.WriteLine("玩家1目前點數: " + total1);
                            if (total1 > 21)
                            {
                                situation = 1;
                                break;
                            }
                            else
                                continue;
                        }
                        else if (enter == "P")
                        {
                            Console.WriteLine("玩家1跳過，目前點數: " + total1);
                            Console.WriteLine();
                            situation = 2;
                            break;
                        }
                    }
                    if (situation == 1)
                    {
                        Console.WriteLine("玩家1爆了，玩家2獲勝!");
                        cost2 += bet1;
                        cost1 -= bet1;
                        Console.WriteLine();
                        Console.WriteLine("玩家2獲勝，獲得" + bet1 + "金錢");

                    }
                    else
                    {
                        while (true)
                        {
                            Console.WriteLine("玩家2行動(輸入1抽1張排、輸入P停止抽牌):");
                            string enter2 = Console.ReadLine();
                            if (enter2 == "1")
                            {
                                Array.Resize(ref color2, color2.Length + 1);
                                Array.Resize(ref p2Hand, p2Hand.Length + 1);
                                for (int j = p2Hand.Length-1; j < p2Hand.Length; j++)
                                {
                                    draw2(j);
                                    int ace = Array.IndexOf(p2Hand, 1);
                                    if (total2 > 21 && ace != -1)
                                    {
                                        total2 = 0;
                                        for (int a = 0; a <= j; a++)
                                            total2 += p2Hand[a];

                                    }
                                }
                                Console.Write("玩家2手牌: " + color2[0] + p2Hand[0] + ", " + color2[1] + p2Hand[1]);
                                for (int j = 2; j < p2Hand.Length; j++)
                                    Console.Write(", " + color2[j] + p2Hand[j]);
                                Console.WriteLine();
                                Console.WriteLine("玩家2目前點數: " + total2);
                                if (total2 > 21)
                                    break;
                                else
                                    continue;
                            }
                            else if (enter2 == "P")
                            {
                                situation = 3;
                                Console.WriteLine("玩家2跳過，目前點數: " + total2);
                                Console.WriteLine();
                                break;
                            }

                        }
                    }
                    if (situation == 2)
                    {
                        Console.WriteLine("玩家2爆了，玩家1獲勝!");
                        cost1 += bet2;
                        cost2 -= bet2;
                        Console.WriteLine("玩家1獲勝，獲得" + bet2 + "金錢");
                        Console.ReadKey();
                    }
                    else if (situation == 3)
                    {
                        if (total1 > total2)
                        {
                            Console.WriteLine("玩家1獲勝，獲得" + bet2 + "金錢");
                            cost1 += bet2;
                            cost2 -= bet2;
                        }
                        else if (total2 > total1)
                        {
                            Console.WriteLine("玩家2獲勝，獲得" + bet1 + "金錢");
                            cost2 += bet1;
                            cost1 -= bet1;
                        }
                        else
                        {
                            Console.WriteLine("平手!拿回各自的錢");
                        }
                    }
                    if (cost1 == 0 || cost2 == 0)
                        break;
                    else
                    {
                        Console.WriteLine("---------------------------------");
                        continue;
                    }


                }





                        //
                        // 5. 結果判定
                        //    case1 : 玩家1在抽牌時超過21點，直接判定玩家2獲勝(跳過玩家2行動)
                        //            Console.WriteLine("玩家1爆了，玩家2獲勝!");
                        //    case2 : 玩家2在抽牌時超過21點，直接判定玩家1獲勝
                        //            Console.WriteLine("玩家2爆了，玩家1獲勝!");
                        //    case3 : 若雙方都沒超過21點，比較點數大小並判斷勝敗平手
                        //
                        //    玩家1/2獲勝：Console.WriteLine("玩家1/2獲勝，獲得" + [玩家2/1下注金錢] + "金錢");
                        //    平手：Console.WriteLine("平手!拿回各自的錢");
                        //
                        // 6. 如果雙方都還有錢就回到步驟2，否則結束程式
                        //
                        // 格式檢查錯誤：Console.WriteLine("請輸入正確格式");、並直接結束程式
                   
            }
            catch (FormatException)
            {
                Console.WriteLine("請輸入正確格式");
            }

            Console.ReadKey();
        }
    }

}
