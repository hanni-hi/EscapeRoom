using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Media;

namespace ESCAPEROOM
{
    class Monster
    {
        public static Monster mon = new Monster();

        public int _mhp;
        public int mhp
        {
            get { return _mhp; }
            set
            {
                if (value < 0)
                    _mhp = 0;
                else
                    _mhp = value;
            }
        }
        public int msp;
        public int mexp;

        public enum MonsterType
        {
            None = 0,
            Cockroach = 1,
            Rat = 2,
            Crazydog = 3,
            Darkman = 4
        }

        public Monster()
        {
            mhp = 0;
            msp = 0;
            mexp = 0;
        }

        public static Monster CreateMonster() //몬스터랜덤발생
        {
            Random rand = new Random();
            int randMonster = rand.Next(1, 5);
            Monster monster = new Monster();

            switch (randMonster)
            {
                case (int)MonsterType.Cockroach:
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠐⡀⠀⠀⠀⠀⠀⠀⠀⠀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠡⢀⠀⠀⠀⠀⠀⠀⠐⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠂⢄⠀⠀⠀⠀⠀⢰⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠑⡬⣆⢄⣔⢔⠢⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠈⠀⠁⠈⠀⠁⠂⢂⠆⢼⡯⣃⢝⠎⡏⢂⢺⣜⣔⠤⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡈⠜⣽⡳⢕⠨⡐⡵⡕⡳⣝⣖⢭⢢⣀⠢⡑⠉⠂⠆⢄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡀⠀⠐⢌⡪⣲⣜⢮⢺⡸⡭⡲⣕⢯⣗⢕⡇⣄⠀⠀⡀⣀⠉⠒⠐⠂⠂⠂⠁⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠄⠂⠒⠁⢈⢫⢯⡿⣧⡫⡮⣣⢳⢳⢽⢽⣺⣲⡱⡘⡰⠐⠙⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠈⠀⢀⠳⣝⡷⡯⣮⢳⡹⡸⡪⡳⡕⡵⣻⣪⢄⠄⠀⠑⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢖⠑⠁⢏⢟⢮⣳⢕⢧⡣⣇⢗⢝⢜⢎⢷⢕⢄⠀⠘⢆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠀⠘⡄⠠⠀⠌⠳⡱⡻⣼⡸⣪⢺⡸⡱⡹⡸⡸⡑⣆⠀⠈⡲⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠐⠀⠱⡠⠀⠐⢀⠨⢪⠺⡸⡮⣣⢣⢫⢪⡪⡪⡪⡂⡓⡁⠠⠑⠄⡀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢐⠁⠀⠠⠀⡊⡎⠀⠄⠑⠙⢎⡇⡇⡇⡇⢇⠕⡈⡢⠀⠀⠀⠈⠐⠠⢀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡂⠀⠀⠀⠀⠘⢔⡀⠄⠈⠀⠄⠈⠊⢎⠪⡂⢅⢂⠐⠀⠀⠀⠀⠀⠀⠀⠈⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠀⠀⠀⠀⠀⠁⠀⠈⠓⣄⠂⢀⠀⠁⠠⠁⠈⠐⠀⠀⠄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⠤⣐⢀⠈⠀⠈⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("");
                    Console.WriteLine("바퀴벌레 가 나타났습니다! \n");
                    monster.mhp = 5;
                    monster.msp = 2;
                    monster.mexp = 2;
                    break;
                case (int)MonsterType.Rat:
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⢀⣀⢄⢤⠤⡤⡤⡤⣠⣀⢀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⢰⣢⣀⢴⢖⢄⢠⡠⡦⣪⢮⣳⣳⡳⡽⣵⣫⣞⢮⣫⢮⢮⡳⡳⡦⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⡠⡰⣓⢵⣱⣱⣝⣗⢷⢽⢽⢽⣝⣞⡮⣯⣻⣺⣺⣺⢽⣺⢽⢵⢝⣝⢮⢯⣻⣢⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⢀⢄⡧⣯⡺⣪⡳⣵⣳⣳⡳⡯⡯⡯⣗⢗⣗⢟⣞⢞⣞⢞⡾⡽⡺⣝⣕⢏⢮⣳⢽⣺⣪⢯⣆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⡠⡰⡸⡜⣞⢝⣗⣝⢮⣞⣗⣗⢷⢽⢝⡽⣹⢪⣳⣝⣗⣗⢽⣪⢯⢾⢽⢝⡎⡮⣪⢗⡷⣽⣺⢞⣗⡽⣕⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠙⢮⡳⡹⣜⢵⡳⡵⣻⣺⣪⢾⢽⢕⣟⡺⡜⣕⢷⢵⣳⡳⡯⣞⡽⣳⣫⢗⡝⡮⣳⢯⣻⣺⢽⣽⣺⢽⡽⡦⡄⡀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠙⠙⠺⢙⠪⠋⠑⠁⠑⢩⡓⡝⡒⢕⢽⢪⡳⣫⡾⡽⡝⠗⠝⠸⠸⣫⢞⡽⡽⡽⡾⡽⡝⣞⡺⠙⠊⠋⠗⠽⡼⣄⣂⡀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠠⡨⡲⡝⠝⠘⠀⠀⠑⠙⡜⡾⡽⣀⠀⠀⠀⠈⠐⢝⢎⡯⡟⠉⠈⢐⢵⠁⠀⠀⠀⠀⠀⠀⠈⠘⠪⡪⡠⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⡀⡀⢀⢔⠕⠙⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⢱⠑⠁⠀⠀⠀⡐⡌⠮⠚⠀⡀⡀⡕⠅⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠨⡂⡇");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠊⠈⠈⠈⠀⠀⠀⠀⠀⠀⠀⠀⠐⠀⠀⠂⠊⠀⠀⠂⠐⠈⠈⠀⠀⠀⠀⢁⢁⢁⢡⢠⢠⡠⡠⣀⣀⣀⡀⡄⡄⣔⢕⠎⠂");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡠⡰⠐⠑⠁⠁⠈⠀⠀⠀⠀⠈⠀⠀⠈⠈⠈⠁⠀⠀⠀⠀");
                    Console.WriteLine("");
                    Console.WriteLine("쥐 가 나타났습니다! \n");
                    monster.mhp = 15;
                    monster.msp = 5;
                    monster.mexp = 3;
                    break;
                case (int)MonsterType.Crazydog:
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣿⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣷⣦⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣴⣿⣿⣿⣿⣿⣷⣦⡄⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣴⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣠⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣟⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡀⠀⢀⢀⣀⣀⣀⣀⣄⣄⣄⣤⣶⣾⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡛⠃⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⣤⣀⢴⣔⡶⣿⣿⣿⣿⣽⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠟⠙⠙⠛⠛⠛⠿⠿⠟⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⣨⣿⣾⡽⣮⣿⣻⢵⣳⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⢸⣿⣿⣿⣿⣟⣞⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⢼⣿⣽⢿⣿⣳⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⣿⣿⣿⣿⣷⣿⣿⣿⠏⠙⠹⠿⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠄");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⣿⣿⣿⣿⣿⣿⣿⡏⠀⠀⠀⠀⠀⠉⠻⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠟⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⢨⣿⣿⣿⣿⣿⡿⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠉⠙⢻⣿⣿⣿⣿⣿⡟⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⢀⣾⣿⣿⣿⠟⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣿⣿⣿⣿⣿⡃⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⢠⣿⣿⣿⣿⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⡯⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⣰⣿⣿⠋⠈⢿⡅⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢾⣿⠅⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⢹⣿⠃⠀⠀⠸⣿⣷⣦⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣻⣿⠵⣿⣿⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⣺⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣺⣿⠁⠘⣿⣄⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠠⣿⣿⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣺⣿⡅⠀⠛⠿⠛⠂⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠘⢿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣺⣿⣿⣆⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⢀⢀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠍⠡⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("");
                    Console.WriteLine("미친개 가 나타났습니다! \n");
                    monster.mhp = 30;
                    monster.msp = 10;
                    monster.mexp = 5;
                    break;
                case (int)MonsterType.Darkman:
                    Console.WriteLine("⡝⡜⡎⡎⡎⡎⡎⢎⢎⠪⡊⢆⢕⠱⡘⢔⢑⢌⠢⡑⢅⠕⡘⢌⠢⠢⡡⡑⢌⠢⡑⢌⠆⡣⢑⢌⠢⢣⠱⡰⢡⠣⡱⡘⡜⢜⢌⢎⢎⢎");
                    Console.WriteLine("⢜⢎⢎⢎⢎⢎⢎⢪⠢⡣⡑⢕⢌⠪⡨⠢⡑⢔⠡⡑⢅⠪⠨⡂⠕⡑⡐⢌⠢⡑⢌⠢⡑⢌⠢⡂⢇⠕⡑⡌⢆⠣⡊⢆⢣⢱⢡⢣⢪⢪");
                    Console.WriteLine("⡪⡪⡪⡪⡪⡢⡣⡑⡕⢌⠪⡂⡆⠕⢌⠪⠨⡂⠕⢌⠢⠡⡃⢌⠪⡐⡡⢑⠌⠔⡡⠊⢔⠡⡊⢌⠢⡑⢅⢪⢘⢌⢎⢪⠸⡐⡕⢜⢔⢕");
                    Console.WriteLine("⡜⡜⡜⡜⡔⢕⠜⡌⡜⢌⢊⢆⠪⡊⡢⡑⡑⢌⢊⠢⡑⡑⢌⢢⢑⠔⢌⢂⠪⡈⡢⢑⠡⡊⢔⠡⡑⠜⢌⢢⠱⡐⢕⠌⡎⡪⡸⡘⡌⡎");
                    Console.WriteLine("⡱⡱⡱⡱⡸⡘⡌⡆⡣⡑⢅⢆⢃⠪⡐⢌⢌⠢⡡⡑⡌⡎⣮⢾⡼⣜⢔⠅⡕⡨⢂⠅⢕⠨⡂⢕⢘⠜⢌⢢⠱⡑⢅⢣⠱⡑⡜⢜⢜⢜");
                    Console.WriteLine("⢎⢎⢎⢜⢔⢕⢱⢘⠔⡅⡣⠢⡑⡑⡌⢆⠪⡨⢂⢎⢜⢾⡽⣟⣯⡿⣵⢱⢂⠪⡐⢅⠕⡨⠢⡑⢌⠪⡨⢢⠱⡘⡜⢌⢎⢪⠪⡪⡢⡣");
                    Console.WriteLine("⢕⢕⢕⢕⢱⠸⡐⡅⢇⢪⠨⢪⠨⡂⡪⡐⢅⢊⠢⡑⡕⡯⣟⣯⣿⡽⣗⡇⡇⢕⢌⠢⡑⢌⠪⡨⢂⠣⡊⢆⠣⡱⡘⡌⡆⢇⢣⢣⢪⢪");
                    Console.WriteLine("⢪⢪⢢⢣⢱⢑⢅⠇⡕⢌⠪⠢⡑⢌⠢⡊⢔⠡⡑⢅⢇⢯⢯⡷⣿⡽⣗⡇⡇⡕⣐⢑⢌⢢⢑⢌⠪⡨⡊⡢⠣⡑⡌⢆⢣⢃⢇⢕⢕⢱");
                    Console.WriteLine("⢸⢸⢨⢪⠢⡣⡑⢕⠸⡨⢊⠕⢌⠢⡑⢌⠢⡑⢌⢢⠱⡱⣹⣺⢷⣟⣯⣞⢜⢔⢢⢱⢨⣢⢕⢔⠱⡐⠕⡌⡪⡘⡌⢎⢢⢣⠱⡱⡸⡸");
                    Console.WriteLine("⢕⠕⡅⡇⡣⡱⡑⡅⢇⠪⠢⡑⢅⠕⢌⠢⡑⢌⢢⢡⢱⢱⣱⣳⢿⣽⢷⣳⣝⢮⡪⣎⢮⡷⣻⢜⢜⢌⠪⢢⢑⢌⢪⠸⡐⡅⡇⡣⡪⡪");
                    Console.WriteLine("⡜⡜⡜⡌⢎⢢⠱⡘⢔⢑⠕⡡⡑⢌⠢⡑⡌⢆⢇⢮⣪⢞⣞⣾⢿⡽⣟⣷⣟⣯⣟⣷⣻⣽⣯⡯⡢⢣⢑⠕⢌⠆⡕⢅⢣⢱⠸⡘⡌⡎");
                    Console.WriteLine("⡇⡕⡜⢜⢸⠨⡪⡘⡌⢆⠕⢌⠢⡡⠱⡨⡊⣎⢮⣗⣯⡿⣽⣯⢿⣻⣯⡷⣿⣞⣯⣯⣿⣳⣯⢷⡩⡢⢣⢑⢅⠕⢜⢌⢪⠢⡣⢣⠣⡃");
                    Console.WriteLine("⡣⡣⢣⢃⢇⢕⠱⡨⢌⢢⢑⠅⢕⢌⠪⡂⡇⣗⡽⣞⣷⢿⣻⡾⣟⣿⢾⣻⣷⣻⣗⡿⣞⣯⣿⣳⣇⢇⢇⠪⡂⡣⡃⢎⢢⠣⡱⡑⡕⢕");
                    Console.WriteLine("⡪⡊⡎⡪⢢⠱⡑⢜⢐⠕⡐⡅⢕⢐⠅⡇⡇⡷⣽⢯⣟⣿⡽⣟⣿⣽⣟⣿⣞⡿⣞⡿⡯⡿⣞⡿⡮⣇⢇⢇⢕⢑⠜⡌⢆⢣⢱⢑⢕⠕");
                    Console.WriteLine("⡣⡱⡡⡣⢣⢑⢅⢣⢡⢑⢅⢊⢢⠡⡣⡱⣱⢻⣺⡿⣽⢷⣿⣻⡷⣿⣽⡾⣯⡿⣯⢿⣝⢯⢯⢿⢽⡺⣜⢢⠱⡡⡱⡘⡌⢎⠆⡇⡕⢕");
                    Console.WriteLine("⡨⡪⡢⢣⠱⡡⡱⡨⢢⠱⡐⡱⠨⡊⢆⢇⢗⡽⡷⣟⣿⢯⣷⣿⣻⣽⡾⣟⣯⣿⢽⡳⣝⣝⢽⢝⡽⣝⢼⢸⠸⡐⢕⠌⡎⡪⡊⡎⡜⡜");
                    Console.WriteLine("⡑⡕⡜⢜⢸⠨⡢⠪⡂⢇⠪⡨⠪⡘⡜⡜⡵⣻⣻⢿⣽⣟⣷⢿⣽⣯⡿⣟⣿⣞⡯⡯⣺⢸⢜⢵⢹⢜⢜⢜⠸⡘⡔⢕⢱⢘⢌⢎⢜⢜");
                    Console.WriteLine("⡪⡊⡎⡪⡊⡎⢜⠜⡌⡪⡘⡌⡪⡊⡎⣎⢯⢯⣟⣯⣷⢿⣽⣟⣷⢿⣽⢿⣳⣿⢽⢝⡎⡎⡎⡪⡊⡪⡸⠰⡑⢕⢸⢨⠢⡣⢣⢱⢑⢕");
                    Console.WriteLine("⡪⡪⡊⡎⡜⡌⡆⢇⢪⠢⡱⡨⢢⢃⢇⢗⡽⣽⢯⣷⢿⣻⡷⣟⣿⣻⣽⡿⣯⡿⣝⣗⢝⢜⢌⢆⢕⢑⢜⢘⠜⡌⢆⢣⢱⠱⡑⡕⡕⡕");
                    Console.WriteLine("⢱⢸⢸⢨⢢⢣⠪⡊⡆⡣⢪⢨⢢⢣⢣⡳⡽⡽⣯⣟⣿⣽⣟⣿⣽⣯⣿⣽⢿⣽⣟⢮⣳⢱⢱⢨⠢⡃⡎⢜⢌⢎⢪⢪⢸⢸⢸⢸⢸⢸");
                    Console.WriteLine("⡪⡪⡪⡪⡪⡢⡣⡣⡱⡸⡨⡢⢣⠪⡪⡺⣺⢽⣻⡾⣷⣻⣾⣻⡾⣷⢿⡾⣿⢷⣻⣽⡪⣇⢇⢇⢣⢱⢸⢨⠢⡣⡱⡸⡰⡱⡑⡕⡕⡕");
                    Console.WriteLine("⡕⡕⡕⡕⡜⡌⡆⡇⡎⢆⢣⢊⢎⢪⢪⢳⣹⢽⢷⣻⣯⢿⡾⣯⣿⣻⣟⣿⣻⣟⡿⣾⣝⢮⡣⡇⡇⡇⡕⡜⢜⢌⢎⢜⢌⢎⢎⢎⢎⢎");
                    Console.WriteLine("⡪⡪⡪⡪⡪⡪⡪⡪⡸⡸⡘⡌⡎⢎⢎⢧⡳⣻⢯⣟⣾⣟⣿⣽⡾⣿⣽⣯⢿⡾⣟⣷⢯⣗⣝⢎⢎⢎⢜⢜⠜⡜⢜⢜⢜⢜⢜⢜⢜⡜");
                    Console.WriteLine("");
                    Console.WriteLine("어둠속괴한 이 나타났습니다! \n");
                    monster.mhp = 50;
                    monster.msp = 12;
                    monster.mexp = 10;
                    break;
                default:
                    monster.mhp = 0;
                    monster.msp = 0;
                    monster.mexp = 0;
                    break;
            }
            return monster;
        }
    }
}