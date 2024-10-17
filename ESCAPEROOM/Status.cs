using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Media;

namespace ESCAPEROOM
{
    class Status
    {
        public static void Line()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("============================================================================");
            Console.ResetColor();
        }

        public static void Levelup(Player player)
        {
            if (player.exp >= 10)
            {
                player.lev++;
                Thread.Sleep(1000);
                Console.WriteLine("⠀⠀⢀⣀⣀⡀⠀⠀⣀⣀⣀⣀⣀⣀⣀⣀⣀⡀⣀⣀⣀⣀⣀⣀⣀⣀⣀⣀⣀⣀⠀⠀⠀⠀⢀⣀⣀⡀⣀⣀⣀⣀⣀⣀⣀⣀⡀⠀⠀⠀");
                Console.WriteLine("⠂⠀⢸⡋⢩⣷⠂⠀⡿⠉⣩⣩⣩⣭⣿⠍⢹⣾⡏⠉⣿⡏⢉⣍⣍⣍⣽⡯⠉⣿⡆⠀⢀⠀⢸⠏⢙⣷⣟⠉⣿⡏⠉⣍⣍⠩⢳⣅⠀⠀");
                Console.WriteLine("⠀⠀⢸⡅⢸⣷⠀⠀⡿⠀⣙⣙⣙⣿⣿⣅⠸⣿⠏⢄⣿⡇⢐⣙⣙⣹⣿⣟⠀⣿⡇⠀⠀⠀⢸⡃⢸⣿⣯⠀⣿⡇⢈⠿⠿⢐⣸⣟⠀⠀");
                Console.WriteLine("⠁⠀⢸⢆⢪⢺⢺⣲⣿⢌⢞⢟⢟⢟⣯⠝⣶⣍⣼⣿⣿⣇⣒⢟⢟⢟⣿⣿⢐⡻⡳⡳⣧⠄⠸⣧⡪⡻⡳⣢⣿⣗⢔⣷⡾⡾⡽⠋⠀⠀");
                Console.WriteLine("⠀⠀⠈⠻⠿⠿⠿⠻⠿⠿⠿⠿⠿⠿⠿⠂⠈⠽⠿⠋⠀⠻⠟⠿⠿⠿⠟⠿⠿⠿⠿⠿⠿⠃⠀⠈⠿⠿⠿⠿⠟⠹⠿⠟⠇⠀⠀⠀⠈⠀");
                Console.WriteLine("⠀⠂⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠄⠀");
                Console.WriteLine("");
                Console.WriteLine("★ 레벨이 1 증가하였습니다. ★");
                Console.WriteLine($"현재 레벨 : {player.lev}\n");
                player.sp += 2;
                player.hp += 30;
                Console.WriteLine($"플레이어가 2 만큼 강해졌습니다. \n");
                Console.WriteLine($"플레이어 체력이 30 만큼 회복되었습니다. \n");
                player.exp = 0;
                Thread.Sleep(3000);
            }
            return;
        }

        public static void EnterField(Player player) //방 넘어갈때
        {
            while (true)
            {
                Status.Line();
                Console.WriteLine("당신은 장소를 이동했습니다... ");
                Console.WriteLine("");
                Console.WriteLine("어둠 속 어떤 기척이 느껴집니다... ");
                Console.WriteLine("");
                Console.WriteLine("싸우거나 도망을 시도하거나 선택은 당신의 몫입니다... ");
                Console.WriteLine("");
                Monster monster = Monster.CreateMonster();
                Console.WriteLine("");
                Console.WriteLine("");
                Status.Line();
                Console.WriteLine("[1] 싸운다. ");
                Console.WriteLine("[2] 일정 확률로 도망친다. ");
                Console.WriteLine("[3] 인벤토리를 연다. ");
            go1:
                string input = Console.ReadLine();
                if (input.Equals("1"))
                {
                    Fight(player, monster);
                    break;
                }
                else if (input.Equals("2"))
                {
                    Random rand = new Random();
                    int randValue = rand.Next(0, 101);
                    if (randValue <= 40)
                    {
                        Console.WriteLine("도망치는데 성공했습니다.");
                        Status.Line();
                        Thread.Sleep(3000);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("도망치는데 실패했습니다. 싸우는 방법 밖에 없습니다...");
                        Status.Line();
                        Fight(player, monster);
                        break;
                    }
                }
                else if (input.Equals("3"))
                {
                    Item.showInven(Player.inventory, player);
                    continue;
                }
                else
                    Console.WriteLine("잘못된 입력입니다... ");
                goto go1;

            }
        }
        public static void Fight(Player player, Monster monster) //전투
        {
            while (true)
            {
                monster.mhp -= player.Gettotalsp();
                player.Useitem();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"플레이어가 몬스터에게 {player.Gettotalsp()} 의 데미지를 가했습니다...");
                Console.WriteLine($"몬스터의 남은 체력: {monster.mhp}");
                Console.WriteLine($"진행을 원하시면 아무 버튼이나 눌러주세요...");
                Console.ResetColor();
                Status.Line();
                string input11 = Console.ReadLine();

                if (monster.mhp <= 0)
                {

                    Program.Playmusic("victory.wav");
                    Console.WriteLine("승리했습니다!");
                    Console.WriteLine($"남은 체력: {player.hp}\n");
                    Console.WriteLine($"획득경험치:{ monster.mexp}\n");
                    Thread.Sleep(3000);
                    Status.Line();
                    player.exp += monster.mexp;
                    Levelup(player);
                    Program.PlayMusicLoop("bgm.wav");
                    break;

                }
                player.hp -= monster.msp;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"몬스터가 플레이어에게 {monster.msp} 의 데미지를 가했습니다...");
                Console.WriteLine($"플레이어의 남은 체력: {player.hp}");
                Console.WriteLine($"진행을 원하시면 아무 버튼이나 눌러주세요...");
                Console.ResetColor();
                Status.Line();
                string input12 = Console.ReadLine();

                if (player.hp <= 0)
                {
                    Program.Playmusic("패배.wav");
                    Thread.Sleep(1000);
                    Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿");
                    Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿");
                    Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿");
                    Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿");
                    Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⡿⠿⠿⠿⠿⠿⢿⣿⣿⣿⡿⠿⠿⠿⣿⣿⣿⣿⡿⠿⢿⣿⣿⣿⠿⠿⢿⣿⠿⠿⠿⠿⠿⠿⠿⠿⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠿⠿⠿⠿⠿⣿⣿⣿⠿⠿⢿⣿⣿⡿⠿⠿⣿⣿⠿⠿⠿⠿⠿⠿⠿⠿⣿⣿⠿⠿⠿⠿⠿⠿⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿");
                    Console.WriteLine("⣿⣿⣿⣿⣿⡿⠏⢁⢐⣴⣶⣶⣶⣵⣿⡿⢏⢃⢐⣔⡀⡈⠻⣿⣿⡂⠀⠀⠙⢝⠉⠀⠀⢸⡿⡀⠀⢐⣶⣶⣶⣶⣶⣽⣿⣿⣿⣿⣿⣿⣿⣿⣿⠋⠂⢐⣶⣶⡆⠀⠊⣻⡯⡂⠀⢸⣿⣿⡇⠀⢀⢺⣯⠀⠀⠢⣶⣶⣶⣶⣶⣽⡷⡁⠀⢰⣶⣶⢆⠀⠙⢽⣿⣿⣿⣿⣿⣿⣿⣿");
                    Console.WriteLine("⣿⣿⣿⣿⣿⠅⠀⠐⣿⣟⢛⠛⠛⢻⣿⠅⠀⠀⢿⡿⣗⠄⠀⢢⣿⢂⠀⠀⡀⠀⡀⠀⠀⢸⣟⠄⠀⠐⡙⡛⡛⡛⣻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀⠀⢐⣿⣿⡇⠀⠐⢼⡯⡂⠀⢸⣽⣿⢕⠀⠠⣹⣯⠀⠀⢑⢛⢛⢛⢛⣻⣿⡯⡂⠀⢸⣻⡋⠃⡀⡈⣺⣿⣿⣿⣿⣿⣿⣿⣿");
                    Console.WriteLine("⣿⣿⣿⣿⣿⣥⠄⠈⠺⣻⣗⠀⠀⣘⣯⠇⠀⠨⣠⣬⡤⡀⠀⡘⣿⠄⠀⢐⣵⣔⡼⠀⠀⢸⣯⠂⠀⠨⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀⠀⢐⣿⣿⡇⠄⠈⣺⣿⣿⣤⠀⠐⠑⠠⣨⣾⣿⡷⠀⠀⠢⣿⣿⣿⣷⣿⣿⡯⡂⠀⢠⠀⠀⠐⠝⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿");
                    Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣎⣄⣌⣌⣄⣄⣜⣿⣅⣄⣄⣿⣿⣯⣢⣠⣸⣿⣅⣄⣄⣿⣿⣯⣠⣠⣸⣷⣡⣠⣨⣨⣨⣨⣨⣨⣸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣅⣄⣅⣅⣅⣄⣳⣷⣿⣿⣿⣷⣅⣌⣾⣿⣿⣿⣯⣠⣠⣡⣩⣨⣨⣨⣨⣹⣯⣂⣄⣸⣷⣕⣠⣠⣈⣾⣿⣿⣿⣿⣿⣿⣿⣿");
                    Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿");
                    Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿");
                    Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿");
                    Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿");
                    Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("죽었습니다...");
                    Thread.Sleep(3000);
                    Status.Line();
                    Environment.Exit(0);
                }
            }
        }
    }
}
