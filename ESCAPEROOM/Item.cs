using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Media;

namespace ESCAPEROOM
{
    public class Item
    {
        public int ikey;
        public string iname;
        public int isp;
        public bool us = false;
        public int cnt; //아이템 사용 가능 횟수
        public int ihp;

        public Item(int ikey, string iname, int isp, int cnt, int ihp)
        {
            this.ikey = ikey;
            this.iname = iname;
            this.isp = isp;
            this.cnt = cnt;
            this.ihp = ihp;
        }

        public static List<Item> items = new List<Item>()
        {
            new Item(0, "커터칼", 3, 3,0),
            new Item(1, "야구방망이", 10, 3,0),
            new Item(2, "부엌칼", 5, 3,0),
            new Item(3, "지하실열쇠", 0, 1,0),
            new Item(4, "낡은총", 20, 2,0),
            new Item(5, "집키1", 0, 1,0),
            new Item(6, "집키2", 0, 1,0),
            new Item(7, "집키3", 0, 1,0),
            new Item(8, "사과", 0, 1,50)
        };

        public static void showInven(List<Item> inventory, Player player) //인벤보기
        {
            while (true)
            {
                Story.check(player);
                Status.Line();
                Console.WriteLine("현재 당신이 소지하고있는 아이템 목록입니다...");
                Console.WriteLine("");
                if (inventory == null || inventory.Count == 0)
                {
                    Console.WriteLine("인벤토리에 아무것도 없습니다...");
                    Status.Line();
                    Thread.Sleep(1500);
                    Console.Clear();
                    break;
                }

                for (int i = 0; i < inventory.Count; i++)
                {
                    var item = inventory[i];
                    Console.WriteLine($" {i + 1}. {item.iname }, 공격력 : { item.isp}, 사용 가능 횟수 : { item.cnt} \n");
                }
                Status.Line();
                Console.WriteLine("아이템 번호를 누르면 착용과 해제가 가능합니다...");
                Console.WriteLine("아이템을 착용하면 그 효과가 플레이어에게 적용됩니다...");
                Console.WriteLine("그러나 조심하세요...");
                Console.WriteLine("아이템은 사용 가능 횟수가 정해져있으니까요...");
                Status.Line();
                Thread.Sleep(1000);
                Console.WriteLine("");
                Console.WriteLine("이전 화면으로 돌아가시려면 아무버튼이나 눌러주세요...");
                string input6 = Console.ReadLine();

                if (int.TryParse(input6, out int itemIndex) && itemIndex > 0 && itemIndex <= inventory.Count)
                {
                    var selectedItem = inventory[itemIndex - 1];
                    Console.WriteLine($"{selectedItem.iname} 아이템을 선택했습니다.");
                    Thread.Sleep(500);
                    Console.WriteLine("[1] 해당 아이템을 착용하길 희망하면 1번을 눌러주세요...");
                    Console.WriteLine("[2] 해당 아이템을 버리길 희망하면 2번을 눌러주세요...");
                    Console.WriteLine("다른 버튼을 누르시면 이전 화면으로 돌아갑니다...");
                    string input8 = Console.ReadLine();
                    switch (input8)
                    {
                        case "1":
                            if (player.Equippeditem != null && player.Equippeditem == selectedItem)
                            {
                                Console.WriteLine("이미 아이템을 착용하고 있습니다...");
                                Console.WriteLine("착용하고 있는 아이템을 해제하시겠습니까?...");
                                Status.Line();
                                Console.WriteLine("[1] 현재 상태를 유지 하려면 1번을 눌러주세요...");
                                Console.WriteLine("[2] 착용한 아이템을 해제 하려면 2번을 눌러주세요...");
                                string input7 = Console.ReadLine();

                                switch (input7)
                                {
                                    case "1":
                                        Console.WriteLine("착용 아이템을 현재 상태로 유지합니다... \n");
                                        Thread.Sleep(1000);
                                        break;
                                    case "2":
                                        Console.WriteLine("현재 착용하고 있는 아이템을 해제합니다... \n");
                                        player.Unequipitem();
                                        Thread.Sleep(1000);
                                        break;
                                }
                            }
                            else
                            {
                                player.Equipitem(selectedItem);
                                Console.WriteLine($"{selectedItem.iname } 아이템을 착용했습니다...효과가 적용됩니다.");
                                Thread.Sleep(1000);
                                Status.Line();
                            }
                            break;
                        case "2":
                            Deleteitem(inventory, selectedItem);
                            break;
                        default:
                            Console.WriteLine("이전 화면으로 돌아갑니다... \n");
                            Thread.Sleep(1000);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");
                }
                Console.Clear();
                break;
            }
        }
        public static void Deleteitem(List<Item> inventory, Item selectedItem)
        {
            Status.Line();
        go15:
            Console.WriteLine($"정말 {selectedItem.iname} 아이템을 버리길 희망하십니까?... ");
            Console.WriteLine("[1] 아이템을 버리려면 1번을 눌러주세요...");
            Console.WriteLine("[2] 아이템을 버리지 않으려면 2번을 눌러주세요...");
            Status.Line();
            Story.BTWS();
            String input22 = Console.ReadLine();
            if (input22.Equals("1"))
            {
                inventory.Remove(selectedItem);
                Console.WriteLine($"{ selectedItem.iname} 아이템을 버렸습니다...");
                Thread.Sleep(500);
                Story.BTWS();
            }
            else if (input22.Equals("2"))
            {
                Console.WriteLine($"{ selectedItem.iname} 아이템을 버리지 않았습니다...");
                Thread.Sleep(500);
                Story.BTWS();

            }
            else
            {
                Console.WriteLine("잘못된 입력입니다.");
                goto go15;
            }
        }

    }
}
