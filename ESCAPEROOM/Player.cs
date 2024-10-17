using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Media;

namespace ESCAPEROOM
{
    public class Player
    {
        private int _hp;
        public int hp
        {
            get { return _hp; }
            set
            {
                if (value < 0)
                    _hp = 0;
                else
                    _hp = value;
            }
        }
        public int sp;
        public int exp;
        public int lev;
        public bool tool;
        public static List<Item> inventory = new List<Item>();
        public Item Equippeditem;

        public void Equipitem(Item item)
        {
            if (inventory.Contains(item))
            {
                if (Equippeditem == item)
                {
                    sp -= item.isp;
                    Equippeditem = null;
                    Console.WriteLine($"{item.iname} 아이템을 해제했습니다...");
                    return;
                }
                else if (item != null && item.iname == "사과")
                {
                    Heal(item.ihp);
                    item.cnt--;
                    if (item.cnt <= 0)
                    {
                        Item.items.Remove(item);
                    }
                    return;
                }

                else
                {
                    if (Equippeditem != null)
                    {
                        sp -= Equippeditem.isp;
                    }
                    Equippeditem = item;
                    sp += item.isp;
                    Console.WriteLine($"{item.iname} 아이템을 착용했습니다...효과가 적용됩니다...");
                    Console.WriteLine($"{item.isp} 만큼 세진 느낌이 듭니다...");
                    Status.Line();
                    return;
                }
            }
        }
        public void Heal(int amount)
        {
            hp += amount;
            Console.WriteLine($"알수없는 곳에서 발견한 음식을 먹는것이 괜찮을지는 모르지만...");
            Story.BTWS();
            Console.WriteLine($"당신은 사과를 섭취했습니다...");
            Story.BTWS();
            Console.WriteLine($"플레이어의 HP가 {amount}만큼 회복되었습니다. 현재 HP: {hp}");
            Thread.Sleep(1000);
            Console.WriteLine("진행하시려면 아무버튼이나 눌러주세요...");
            string input21 = Console.ReadLine();
            return;
        }

        public void Unequipitem()
        {
            if (Equippeditem != null)
            {
                sp -= Equippeditem.isp;
                Console.WriteLine($"{Equippeditem.iname} 아이템을 해제했습니다...");
                Status.Line();
                Equippeditem = null;
                return;
            }
        }

        public static void Getitem(Item item) //아이템얻기
        {
            inventory.Add(item);
            return;
        }

        public Player() //생성자
        {
            hp = 100;
            sp = 6;
            exp = 0;
            lev = 1;
            tool = false;
            Equippeditem = null;
        }
        public int Gettotalsp()
        {
            if (Equippeditem != null)
            {
                return sp + Equippeditem.isp;
            }
            return sp;
        }
        public void Useitem()
        {
            if (Equippeditem != null)
            {
                Equippeditem.cnt--;
                if (Equippeditem.cnt <= 0)
                {
                    Console.WriteLine($"{Equippeditem.iname} 아이템의 사용가능횟수가 다 되었습니다...");
                    Console.WriteLine("이제 더이상 해당 아이템을 사용할 수 없습니다...");
                    Status.Line();
                    inventory.Remove(Equippeditem);
                    sp -= Equippeditem.isp;
                    Equippeditem = null;
                }
                return;
            }
        }

    }
}

