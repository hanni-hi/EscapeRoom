using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Media;

namespace ESCAPEROOM
{
    public class Story
    {
        public static void BTWS()
        {
            Console.WriteLine("");
            Thread.Sleep(300);
        }

        private static Player player = new Player();

        public static void check(Player player)// 플레이어 상태 확인하는 메서드
        {
            if (player == null)
            {
                return;
            }

            Console.Clear();
            Thread.Sleep(1000);
            Status.Line();
            BTWS();
            BTWS();
            Console.WriteLine("현재 플레이어의 상태입니다. ");
            Thread.Sleep(300);
            Console.WriteLine($"체력 : {player.hp}");
            Thread.Sleep(300);
            Console.WriteLine($"공격력 : {player.sp}");
            Thread.Sleep(300);
            Console.WriteLine($"추가 공격력 : {(player.Equippeditem != null ? player.Equippeditem.isp : 0)}");
            Thread.Sleep(300);
            Console.WriteLine($"경험치 : {player.exp}");
            Thread.Sleep(300);
            Console.WriteLine($"레벨 : {player.lev}");
            Thread.Sleep(300);
            Console.WriteLine("장착 장비 : " + (player.Equippeditem != null ? player.Equippeditem.iname : "없음"));
            Thread.Sleep(300);
            Console.WriteLine("");
            Status.Line();
        }

        public static void Intro()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("⡯⣫⢯⡻⡯⣯⡫⡯⣫⢯⣏⢯⡫⡯⣫⢯⡻⣝⡯⣯⡻⣝⡯⣯⣻⢽⣝⡯⣟⣽⣫⢿⢽⣻⢽⣫⣟⣽⡻⡯⡯⣟⣽⣫⢯⢯⢯⢯⣻⢽⣻⣻⢯⣟⡿⣽⣻⣻⣻⣟⣿⣻⣟⣿⣻⣻⣻⣻⣻⣟⣿⣻⣟⣿⣻⣟⣿⣻⣟⣿⣻⣟⣿⣻⣟⣿⣻⢿⣻⢿⣻⢿⣻⢿⣻⣟⣟⣟⢿⣝");
            Thread.Sleep(300);
            Console.WriteLine("⢽⢽⢽⢽⣽⣺⢾⢽⣽⣳⣗⣯⢯⣯⢯⣗⣯⢷⡯⣷⣻⣳⣟⣵⡯⣷⣗⡿⣽⣞⣾⣻⡽⣞⣿⣺⣞⣷⣻⣻⢯⣟⡾⣞⣯⢿⣽⣻⢞⣯⢷⣻⢽⣞⢯⣟⢾⢽⢞⡾⣺⢳⡳⣻⡺⡯⡿⡽⡳⣟⢗⢿⢽⢺⢻⢺⢳⢻⢺⢳⢻⢺⢳⢻⢺⢝⢞⢟⢝⢯⠻⡝⡝⢯⢫⢞⢷⣝⢷⢽");
            Thread.Sleep(300);
            Console.WriteLine("⡳⡯⡻⡽⡺⡝⡯⡟⡞⡗⣟⢞⡟⣞⢯⢗⢟⢽⢝⢗⢽⢺⢕⢯⡫⡳⣝⢽⡱⡯⡺⣪⢫⡳⣱⡳⣱⢣⡳⣹⡱⣕⣝⢼⡸⣕⢵⣱⣝⢼⢜⡼⡼⣜⡵⡵⣝⣮⣣⣣⡣⡧⣳⣕⢧⡳⣕⢧⣣⡣⣫⡺⣜⢮⡳⡕⡗⡗⡧⡳⡣⢗⢧⠳⠵⢝⢎⠗⠝⠎⠯⡺⡽⢱⢳⠅⣗⡽⣝⢷");
            Thread.Sleep(300);
            Console.WriteLine("⢮⡻⣜⡮⣞⣞⣞⣞⢞⢞⢞⢞⢞⢞⠮⡗⢯⢳⠫⢏⢯⢳⢫⢳⢫⠫⡚⡓⠯⠻⠹⠹⡙⠝⢕⠫⠫⠫⠫⡓⡙⡑⡙⡑⡙⡘⡙⡘⠌⠍⠍⠪⠩⢈⠪⠩⡈⡂⢑⠐⠡⠁⠅⠌⠂⠅⠡⠁⡂⠅⠂⠌⠄⠅⢂⠂⢂⠂⡐⠠⢈⠐⡐⠈⠌⡀⢂⠨⠈⠌⢜⣞⣿⢢⡫⡆⢮⢯⢯⢯");
            Thread.Sleep(300);
            Console.WriteLine("⢗⡽⣪⢯⡢⣺⣷⣳⠅⠅⢅⠑⠄⢅⢑⢈⢂⠂⠅⠅⡂⡂⡂⡂⡂⠅⡂⠌⠌⠌⠌⡐⠠⢁⠂⠌⠌⠌⡐⡐⡐⡐⢐⢐⢀⠂⡂⠂⢅⠡⡁⠅⠨⡐⠨⠀⡂⢐⠠⠨⠠⠡⠈⠌⠠⠁⠌⡀⢂⠨⢀⠡⠈⡐⠠⠈⠄⢂⠐⡈⠄⠂⠄⡁⢂⠐⡀⢂⠡⠈⠌⢊⠣⢁⢯⡊⣞⡽⡽⣵");
            Thread.Sleep(300);
            Console.WriteLine("⣳⢽⡪⣿⢘⠽⢾⢫⠣⡑⠄⢅⢑⢐⢐⠐⠄⠅⠅⠅⡂⢂⠂⡂⡂⠅⡂⠅⠅⠅⢅⠂⠅⡂⡌⢌⢌⢐⢐⠀⠢⡦⣖⡖⡶⢕⠎⣎⢂⢕⢬⡬⣦⢦⣧⢷⡆⠄⡃⠌⠠⠁⠌⠨⠀⠅⢂⠐⢀⠂⠄⠂⡁⠄⠂⠡⠈⠄⠂⡐⠈⠄⠡⠐⡀⢂⠐⡀⢂⠡⠈⠄⠌⡐⡝⡆⣺⣽⢯⣷");
            Thread.Sleep(500);
            Console.WriteLine("⢮⢯⣳⣻⠄⢅⠣⡑⢕⠌⢌⢂⢂⢂⠢⠡⠡⠡⢡⡱⣔⣦⣗⣶⣺⡐⠠⣱⣽⢻⡳⣧⣅⠂⢯⣷⣳⣢⢱⢈⠐⣽⡂⢄⢂⣔⣐⠄⢳⡸⢸⡯⣏⢫⣪⣫⢮⣺⠄⠌⠄⠡⠈⢄⢅⠨⠠⡈⢄⢐⢀⠁⠄⠂⠡⢈⠐⡈⠄⢐⠈⠄⠨⠠⠐⡀⢂⠐⡐⠈⠌⢆⠅⡂⣗⡕⢼⢝⡯⡯");
            Thread.Sleep(300);
            Console.WriteLine("⡽⣽⣺⡺⡕⢄⠑⠌⡎⣎⡦⣦⣖⣦⣧⠅⠅⠅⡪⣿⠽⠊⡓⣷⣻⡊⣺⣽⢊⢊⢻⡺⡾⡈⣺⣳⢇⢧⢷⡐⢀⢳⡇⠐⣟⡾⣽⡣⢐⢧⠣⡿⣏⢎⠪⢈⠃⡓⠅⠅⠅⠅⠅⣻⡇⠡⡁⠅⠅⠫⣗⢡⢬⡶⣵⡴⣄⢂⢨⣰⢤⡥⣌⠄⡁⡢⡐⡀⠢⣡⠌⡐⢐⠠⡳⡕⢕⣟⢮⢯");
            Thread.Sleep(300);
            Console.WriteLine("⢞⣗⣗⢯⢇⠢⠡⡁⢗⢯⣟⢗⢝⣕⣽⢼⡎⡂⣪⣟⡇⠡⢀⠢⢁⠂⣞⣾⡂⡂⡐⠨⠐⡀⣟⣾⡃⢺⣯⡇⠄⢕⣇⠂⡬⣯⢷⡗⡐⣽⠸⡽⣧⣡⣁⡂⡂⡂⠅⠅⠅⠡⢁⢳⡯⠀⡯⡿⡥⠡⠱⣹⣏⠊⠅⡙⣷⠅⣿⡊⢋⠋⢯⡷⣽⣳⢕⠠⣱⡽⢐⠐⡐⠨⡺⡕⣕⡯⣯⣳");
            Thread.Sleep(300);
            Console.WriteLine("⡽⣺⢮⢿⡅⢅⠑⢌⠪⣻⣽⡪⠫⡃⠫⡑⡓⡐⢸⣺⢧⣁⡂⡌⡂⢌⢪⢾⡆⡂⡂⠅⠡⠀⢗⡷⡇⢸⣳⢯⠨⢸⢧⢑⢘⠨⠡⢁⢢⢽⠨⣺⣟⠾⠝⢇⢂⠂⠅⠅⠅⠅⡂⡷⡏⠄⠽⡉⡃⢅⠕⣼⢮⠨⢐⢸⢽⠨⣾⡂⡂⠌⣺⣝⢾⡽⣖⢸⡾⣝⢐⢐⠠⠡⣹⢕⢼⣝⣞⢮");
            Thread.Sleep(300);
            Console.WriteLine("⣽⢽⣳⡻⡎⠢⡑⡐⡱⣱⣿⡸⣑⣌⢂⢂⠢⡈⠢⠙⠯⢯⢿⢽⢾⣐⢜⣟⡮⢐⠠⠡⠡⢈⢺⣻⣇⠂⣿⣻⡕⡘⣯⡂⢲⡳⣟⣾⢽⢽⡊⢮⣟⠌⢌⢐⢐⠘⠌⠌⠌⡐⡀⣟⡇⠥⣕⠀⢮⢾⠅⣯⢧⠨⢐⢸⣻⠨⣷⡁⡂⠅⣗⣗⣯⠻⣽⢯⢻⡇⢐⢐⠨⢐⢜⡧⣱⣳⢵⢯");
            Thread.Sleep(300);
            Console.WriteLine("⡺⣝⣗⡽⣇⢑⢐⢐⠐⢼⣞⡿⡽⠾⡐⢄⠑⠌⠌⠌⠌⡐⠠⠩⣻⣳⢭⢷⢯⢐⠨⠨⠨⡐⢼⣳⣗⢌⣺⣳⡇⠌⣷⢅⢢⣪⢿⣺⣗⣯⡇⢱⢿⣑⢐⢐⢐⠨⠨⠨⢐⢐⠨⡯⡧⢡⡽⡌⢸⢝⡊⣾⠇⠌⡐⣸⡽⢸⢷⠑⠌⡂⣟⣞⡞⢌⢚⠣⣹⡎⢐⢐⠨⢀⢳⡳⡸⣞⡯⡿");
            Thread.Sleep(300);
            Console.WriteLine("⣝⢗⣗⢝⡧⡂⡂⠢⡑⡜⣾⡣⠨⡢⡈⡂⠣⠡⠡⠡⠑⠌⠌⠌⣾⣻⠌⣿⢽⢐⠨⠨⢰⣄⢝⡷⣯⣟⣗⣯⢿⡀⢿⡐⡘⢜⢯⢷⣻⣞⡧⠨⣟⣷⣳⢷⡯⡿⠌⡎⡐⠠⠑⢟⠕⡘⢞⡇⠌⡳⢐⡽⡇⡁⢂⢪⡯⢸⣻⠨⢐⢐⡽⣞⣝⢐⠠⠑⣵⠣⢐⢐⠨⢀⢳⡳⢸⡳⡽⣝");
            Thread.Sleep(300);
            Console.WriteLine("⢮⡳⣯⡳⣏⢂⠪⡈⡂⡃⣯⣟⡐⡐⡐⠌⠌⠌⢌⢺⡷⣅⢅⢅⣷⣟⠕⡸⣿⣔⢌⣌⣮⣯⢫⣟⡷⡐⠨⣺⣟⡎⣺⣳⡬⣎⡮⣟⢗⠯⢏⠂⠅⢅⢑⢑⢑⢘⢈⠂⠄⠅⢱⣳⡡⣢⡑⢽⡰⣘⢐⢽⣅⣢⡠⡽⣏⢸⢯⣈⢐⣐⣽⣟⡎⡐⠨⢀⣯⢃⠐⡐⠨⢀⢳⢝⢜⡽⣝⡮");
            Thread.Sleep(500);
            Console.WriteLine("⣝⢮⣗⡯⡷⡐⡑⡐⡐⡐⢼⣗⡷⣗⣯⢿⢇⢕⠄⢝⣯⢿⡽⡯⡗⠣⢁⢊⠺⡺⡻⠞⠞⠌⢌⢓⢋⠢⠡⡑⢅⠑⠌⠌⠌⡂⡂⡂⡂⢌⢐⠨⢈⢂⢂⢂⢂⢂⠂⠌⠌⠌⠌⡃⡋⡑⡉⡃⡛⠸⡠⠉⠗⠗⠟⠏⠡⢈⠻⡺⡻⡺⡓⠱⠃⠄⠅⡂⢟⢐⢐⠠⢁⠢⡱⡯⡸⣺⣕⣟");
            Thread.Sleep(300);
            Console.WriteLine("⢞⡵⣷⡹⣽⢐⢐⢐⠐⠌⢌⠪⡙⠜⢌⢑⢑⠑⠅⠅⠍⠌⠌⠌⠄⡑⡐⢄⢑⠐⠌⠌⠌⢌⣂⣂⡢⣡⡑⢌⡢⣡⢥⢥⡅⡂⡂⡂⡂⣆⢦⡑⡐⡴⣔⢐⠰⣔⠅⠅⡱⡅⢕⣖⠶⡲⡐⡐⠠⢁⠢⡡⠁⠅⠌⠨⠐⡐⡀⡂⡐⡀⡂⠅⠅⠅⠅⡂⡂⡂⡂⠌⡐⡐⢜⡗⢜⣗⡷⣵");
            Thread.Sleep(500);
            Console.WriteLine("⢝⣽⣺⡺⣽⢐⠐⠄⢅⠑⢄⠑⠌⢌⢂⢂⠢⠡⠡⠡⠡⠡⠡⠡⢁⠢⡈⡂⠢⠡⠡⡡⠡⠩⢹⡪⡑⢼⡪⢸⡣⣹⠅⠅⠅⡂⡂⠢⢘⠐⢌⢊⠂⣟⣷⠠⢑⡽⡎⢄⡏⢇⢸⡆⡂⡂⡂⡂⠅⡂⡂⠌⠌⠌⠌⠌⠄⡂⡐⡀⡂⡂⡂⠅⠅⠅⠅⡂⡂⡐⠠⢁⠂⢌⢪⣏⢪⢿⢽⣻");
            Thread.Sleep(300);
            Console.WriteLine("⣗⣗⢷⢽⡺⡄⢅⢑⢄⠑⠄⢅⢑⢐⠐⠄⠅⠅⠅⠅⠅⠅⠅⠅⡂⠅⠢⠨⠨⡈⠢⢑⠡⢑⢰⡳⠠⢹⠮⢾⢕⢜⡗⢗⢅⢂⠂⠅⠪⢇⢓⡇⠅⡗⠸⣇⠂⡿⢝⢷⠣⡣⠸⡝⡙⡑⡐⠠⢁⢂⠂⠅⠅⠅⠅⠅⠅⡂⢐⢀⢂⢂⠂⠅⠅⠅⠅⡂⡂⡂⢅⢢⡪⣢⢳⢵⢱⣻⣻⢮");
            Thread.Sleep(300);
            Console.WriteLine("⣪⢾⣝⢷⢽⡈⣂⢢⢢⠡⡑⡐⡐⠄⠅⠅⠅⠅⠅⠅⠅⠅⢅⠑⠄⠅⠅⠅⡑⠌⢌⢐⠨⢐⢸⡕⠅⡹⡅⠨⡇⢕⢇⢂⢂⠢⠨⠨⢨⡐⢠⠣⠢⢙⠚⢗⡅⣗⠄⢇⠡⣫⠨⣇⣐⣄⠂⠅⡂⡂⠅⠅⠅⠅⠅⠅⡂⢂⠂⡐⡀⡂⠌⠌⠌⠌⡐⡐⡐⡐⡐⣗⣯⣷⣻⢵⢑⡷⡯⡿");
            Thread.Sleep(300);
            Console.WriteLine("⣗⢯⢾⢍⣟⢆⡷⣯⢷⢕⢔⠐⠌⠌⠌⠌⠌⠌⠌⠌⠌⢌⠂⠅⠅⠅⠅⠅⠌⠌⡐⡐⠨⡐⡘⠝⠄⡚⠢⡑⠫⠘⢕⠙⠕⠅⠅⢅⠂⢍⠊⢅⢑⢐⠨⢈⢂⢑⠡⠠⠡⢑⠨⠨⠨⠨⠨⢐⢐⠠⠡⠡⠡⠡⠡⡁⡂⡂⣂⢂⣂⢢⢡⢡⢡⣑⣐⣐⣐⢔⡌⣎⣟⢎⡮⡯⡢⣻⣝⢯");
            Thread.Sleep(300);
            Console.WriteLine("⡮⡯⡯⡇⡯⡇⡿⣻⢯⣃⢢⢡⢡⢡⢡⢡⢡⢡⢡⡡⣑⢄⢅⢅⢅⢅⡅⣅⢅⡕⣔⡌⣆⣆⢬⢌⣆⣌⢦⢬⢬⢌⣆⢮⢬⢬⢬⡢⣕⢴⢬⡲⣔⢦⢮⡲⣲⡢⣗⢵⢣⢣⢗⢵⢳⢝⢮⠳⢕⠯⡫⡫⡫⡫⡫⡺⡹⡪⡳⡹⡪⡳⡹⡹⣑⡓⣕⡓⡝⣕⡫⣓⢕⢝⢜⣍⡢⣳⡽⣝");
            Thread.Sleep(300);
            Console.WriteLine("⢽⣻⢯⢇⠿⠽⣝⢷⢯⢾⢽⢝⣝⢗⡯⡯⡯⡯⡷⡯⡫⡫⡫⡫⡫⡫⣫⣓⢏⣏⡎⣏⢇⡫⣍⣝⣜⢬⢭⣱⢭⣕⣭⢯⣳⢽⡵⣽⢽⣝⢷⢽⣺⢵⣳⡵⣣⢷⢵⣳⡳⣵⣳⢵⢧⣳⢵⢯⣞⣞⣞⣞⣞⣞⡾⡵⣯⣻⣺⢽⣺⡽⡽⡽⣕⣟⣮⢿⡽⣗⡿⡽⣯⢟⣟⡾⣽⣻⢽⡻");
            Thread.Sleep(300);
            Console.WriteLine("⡿⡽⣽⣳⡽⣽⢾⢽⡽⣽⢽⡽⡾⣯⢯⢯⢾⢽⢽⣺⢽⡽⣽⢽⡽⣽⣳⡽⣟⣮⣟⡾⣯⢯⡷⣗⣯⢿⡽⣞⣟⣾⣺⢽⣺⣽⣺⣽⢽⢾⢽⢽⣺⣟⡾⣽⢽⣽⣳⣳⣽⡺⡮⡯⡯⡯⣫⣟⢞⡮⣞⡾⣞⣷⣻⢽⣺⣞⢾⢽⣕⡯⡯⡯⣗⣽⣺⢽⣝⣗⣯⣻⣺⡽⡾⣝⡷⣽⣳⢯");
            Thread.Sleep(1000);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("[진행을 원하시면 아무 버튼이나 눌러주세요...] ");
            string input1 = Console.ReadLine();
            Console.Clear();
            Thread.Sleep(1000);
            Thread.Sleep(300);
            Console.WriteLine("⢕⠠⠐⢀⠡⠐⠠⠈⠄⡑⠄⠅⠅⠅⠅⡂⠌⢌⠠⠁⠐⢈⠀⠄⢀⠂⡈⠄⠂⠠⠁⠐⡀⠄⠐⡀⠡⠡⡑⢀⠂⡁⠄⠂⡈⠌⠌⠐⡀⠐⡈⠠⠐⢀⠐⢀⠡⠀⢂⠀⢂⠡⠀⠄⢁⠐⠀⠄⠁⠄");
            Console.WriteLine("⢕⠐⢈⠠⠐⡈⠄⡁⠂⢌⠪⠨⠨⡈⡂⡂⠅⠢⠐⢈⠀⢂⠠⠈⠠⠀⠄⠂⡁⠄⠁⢂⠀⢂⠁⠄⠨⠨⡂⠂⠄⠐⡀⠁⠄⠅⠅⢂⠀⠡⠀⢂⠈⠄⠐⡀⠐⡈⠠⠈⠠⠐⠀⢂⠠⠀⡁⠄⠁⠄");
            Console.WriteLine("⡣⡈⠄⠐⡀⢂⠐⡀⠅⠢⡡⠡⡁⡂⡂⠄⢅⠡⢁⠠⠐⢀⠐⢈⠀⢂⠠⠁⡀⠂⡁⠄⠐⡀⠐⡈⠄⡑⠄⠅⠂⡁⠐⡈⠠⠡⠡⠀⠌⠠⠈⠠⠐⢈⠠⠀⠡⠀⠂⡁⠄⠡⠈⡀⠄⠂⠠⠀⡁⠄");
            Console.WriteLine("⡪⡀⡂⠁⠄⢂⠐⠠⠈⢌⢂⠅⡂⡂⡂⠅⡂⠌⠄⠐⠀⠂⠐⡀⠐⡀⠐⡀⠐⡀⠄⠂⡁⢀⠡⠀⡂⢜⠨⠀⠅⠐⠠⠐⠈⢌⠂⡁⠐⡈⠠⠁⡈⠄⠐⢈⠠⠈⠠⠐⠠⢈⠠⠀⠐⢈⠀⠂⠠⠀");
            Console.WriteLine("⠏⠮⢪⢣⢳⢱⢕⢳⢹⠢⡂⠅⡂⡂⡂⠅⡂⡑⡈⢀⠁⡈⠠⠀⢂⠀⠂⠐⡀⠄⠂⠁⠄⡀⢂⠐⡀⢢⠡⠁⢂⠁⠄⠁⠌⡂⠅⢀⠂⠄⠂⡁⠄⠂⡁⠄⠂⡈⠄⡈⠄⢐⠀⡈⠄⠀⠂⡁⠐");
            Console.WriteLine("⠌⢀⠂⠄⠂⠄⢂⠐⠠⠨⡂⠅⡂⢂⠂⠅⡂⠔⠠⠀⠄⠐⠀⠌⠀⠄⠁⢂⠀⠂⡁⢈⠠⠀⠄⢂⠠⢑⠌⡐⠀⡂⢈⠐⢈⠂⠅⠠⠐⢀⠁⠄⠂⡁⠄⠂⡁⠄⠂⡀⠂⢐⠀⠄⢀⠡⠐⢀⠈⠄");
            Console.WriteLine("⠂⠄⠂⡈⠐⡈⠄⠨⠀⠅⡂⠅⡂⠅⠌⡂⢂⠅⠅⠐⢀⠁⡈⢀⠡⠀⠡⠀⠂⡁⠄⠠⠐⢀⠡⠀⠂⢅⠅⢂⠁⠄⠂⠐⠠⠡⠁⠄⠁⠄⠂⡈⠄⢀⠂⡁⠄⠂⡁⠄⠈⠄⠐⠀⠄⠐⠀⠄⠐⢀");
            Console.WriteLine("⠠⠈⠠⢀⠡⠐⡈⠄⡁⠢⡈⡂⡂⠅⠅⡂⠢⢈⠂⡁⠄⠠⠐⢀⠐⢈⠠⠈⠠⠀⠂⡐⢈⠠⠐⠈⠄⡑⠌⠄⠂⡈⠄⠁⠌⢌⠐⢈⠠⠈⠠⠀⠂⠄⠂⡀⠂⡁⠄⠂⡁⠨⠀⡁⠄⢁⠈⠄⢈⠠");
            Console.WriteLine("⠐⠈⠄⢂⠠⢁⠐⡀⢂⢁⢂⢂⠂⠅⡊⠄⠅⡂⠅⠀⢂⠐⢈⠠⠐⢀⠐⢈⠠⠈⠠⠀⠄⠂⡈⠄⡁⠪⡨⠀⠅⡀⠂⡁⠌⡂⠌⠠⢐⢈⠠⡈⠐⢈⠠⠐⢀⠐⢀⠁⠄⠨⠀⠄⠂⠠⠐⠀⢂⠠");
            Console.WriteLine("⢀⠁⠂⠄⢂⠐⡀⢂⠐⡀⠆⡂⠌⡂⡂⠅⠌⡐⠡⠈⠠⠐⢀⠐⢈⠠⠐⠀⠄⢁⠂⡁⠄⠁⠄⠂⠄⡱⢐⠡⠐⢀⠡⠀⠌⢀⠡⠈⡐⢀⠁⡀⠅⠂⢂⠁⠂⡁⠁⠅⠂⠌⢀⠂⡁⠐⡈⢀⠂⠐");
            Console.WriteLine("⠄⢈⠐⢈⠀⡂⢐⠀⡂⠄⢕⠠⡁⡂⡂⠅⠡⢈⠂⡁⠐⡈⠠⠐⢀⠐⢈⠠⠈⠄⠠⠐⢈⠠⠁⠌⡀⠪⡐⡀⠅⡀⢂⠈⡐⠠⢀⠡⠀⠄⠂⡀⠂⡁⠄⠈⠄⠠⢁⠈⠄⠁⠄⢂⠀⠅⡀⠂⠄⢁");
            Console.WriteLine("⠄⠂⢐⠀⢂⠐⡀⢂⠐⠨⡐⡐⡐⡐⠠⡁⠅⡂⠅⡀⢂⠀⢂⠈⠠⠐⡀⢐⠈⡐⢀⠡⠀⢂⠈⠄⠠⡑⡐⡀⡂⡐⣀⢢⠰⡰⣐⢲⢨⠠⡡⡐⡀⡂⡈⢄⠁⠂⠄⠂⡈⠄⠁⠄⠂⡐⠠⠈⡐⠀");
            Console.WriteLine("⡈⠐⡀⠌⢀⠂⡐⠠⢈⢐⢐⢐⠠⢂⠅⡂⠅⡂⠅⠠⠀⠂⠄⡈⠐⡀⠂⠄⠂⠄⠂⡐⡨⡠⢢⢨⢢⠪⡢⡣⡱⡑⡅⡇⡣⡱⡸⢰⢑⢕⢅⢇⢣⢣⢱⢑⢕⢍⢎⢖⢔⠜⠔⠁⠀⠀⠀⠀⠀⠁");
            Console.WriteLine("⡐⠠⠐⢈⠀⡂⢐⠈⠄⡐⡐⡐⠨⢐⢐⠠⢁⠂⠅⠂⡁⠂⡁⠄⢁⠐⡈⠠⠁⢂⢕⢜⠔⡕⡱⡡⡣⡣⡱⡸⡨⡊⡎⡜⡌⢎⢪⢪⢸⠰⡱⢸⠰⡡⡣⡣⡣⠃⠃⠁⠀⠀⠀⠀⠀⠀⠀⡀⠀⠀");
            Console.WriteLine("⢐⠠⠈⠄⢂⠐⠠⢈⠐⡀⡂⡂⡑⡐⠠⠨⢐⠨⡈⠄⠐⡀⢂⠈⠄⠐⡀⢂⢁⢆⢇⢎⢎⢪⢪⢸⢰⢱⢸⢰⢡⢣⠪⡢⢣⢣⢱⠸⡰⡑⡕⡱⢱⠱⠑⠁⠀⠀⠀⠀⠀⠀⠀⠀⡀⠂⠁⠀⠀⠀");
            Console.WriteLine("⠂⡐⠈⠄⢂⠨⠐⡀⢂⠐⢔⢐⠐⠄⠅⠅⡂⠌⡂⠄⠡⠀⡂⢐⠈⠄⠂⢄⢪⢪⢪⢪⠪⡪⡪⡪⡪⡪⡢⡣⡣⡱⡱⡱⡱⡑⡕⢕⢕⢱⢑⢕⢕⠑⠀⠀⠀⠀⠀⠀⠀⠀⡐⠀⠀⠐⡀⢂⠐⢀");
            Console.WriteLine("⠄⢂⠡⠈⠄⢂⠡⠐⡐⢈⢂⠂⠌⠌⡂⠅⡂⠅⡂⠨⠀⠅⡐⡀⡂⠅⡊⢔⠡⡃⡃⠇⡇⡇⡇⡎⡎⡎⡎⡪⡪⡪⡪⡪⡪⡪⡪⡪⡪⡪⡪⡪⠊⠀⠀⠀⠀⠀⠀⠀⠀⡐⢀⠀⠀⠠⢀⠀⠈⠀");
            Console.WriteLine("⠌⡀⢂⠡⠈⠄⡂⠅⡐⠐⠠⠡⠡⢁⢂⠅⡂⠅⡢⠡⡡⡱⡐⡐⢌⠌⠆⡑⢌⢂⠪⠨⡂⠪⠨⡊⡊⡪⠪⡪⡪⡪⡪⡪⡪⡪⡪⡪⡪⡪⡪⠊⠀⡀⠄⠀⠄⠀⠠⠀⠄⠂⠄⠀⡀⠌⠄⠂⢈⠀");
            Console.WriteLine("⡂⡐⠠⠈⠄⠡⠀⠅⠠⡁⡌⠄⢕⢂⢃⠅⡢⡁⡢⡑⡐⢄⠢⡈⡢⡊⠌⠌⣶⣬⢌⠪⠨⠪⠨⡂⡊⡢⢑⠰⡐⠅⢅⠕⡑⡑⠕⠕⡕⡕⡅⡀⠠⠀⠀⠂⡐⠈⡀⠐⡀⠅⠌⢀⠠⠨⠀⠅⠠⠀");
            Console.WriteLine("⠄⠂⡄⢅⠌⢆⢑⢑⠡⢑⠨⡨⠰⡐⡐⠅⢅⢑⢐⠨⢈⠢⢑⢈⠢⠨⡨⢐⠸⢛⠐⢌⠪⡘⠨⡂⡊⠌⡢⢑⠌⢌⠢⡑⠌⢌⢜⠨⡂⡢⠡⡑⠢⡨⡀⡁⠄⠂⠠⠀⡐⠠⠁⠄⠐⡈⠂⠡⠐");
            Thread.Sleep(300);
            Console.WriteLine("");
            Console.WriteLine("칠흑같은 어두운 밤, 당신은 어느 침대 위에서 눈을 떴습니다... ");
            Console.WriteLine("");
            Thread.Sleep(1000);
            Console.WriteLine(" <여기... 내 방이 아니잖아...!> ");
            Console.WriteLine("");
            Thread.Sleep(1000);
            Console.WriteLine("움직이기 위험할 정도로 어두운 주변이지만 당신은 예리한 감각으로 이곳이 낮선곳임을 깨닿습니다... ");
            Console.WriteLine("");
            Thread.Sleep(1000);
            Console.WriteLine(" <일단 이곳을 나가야해...> ");
            Console.WriteLine("");
            Thread.Sleep(1000);
            Console.WriteLine("당신은 이 집을 나가기로 마음 먹습니다... ");
            Console.WriteLine("");
            Thread.Sleep(1000);
            Console.WriteLine("그러나 조심하세요... 이 곳은 무엇이 도사리고 있는지 알 수 없는 낮선 공간이니까요...  ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Thread.Sleep(1500);
            Console.WriteLine("[진행을 원하시면 아무 버튼이나 눌러주세요...] ");
            string input2 = Console.ReadLine();
            // Console.Clear();
            Thread.Sleep(1000);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("조금씩 눈이 적응하기 시작하자 방의 사물이 눈에 들어옵니다... ");
            BTWS();
            Console.WriteLine("본래 자신의 방보다 넓은 방에는 침대와 옷장만이 덩그러니 놓여있습니다... ");
            BTWS();
            Console.WriteLine("밖으로 나가기 위한 닫힌 방 문도 보입니다... ");
            BTWS();
            Console.WriteLine("당신은 방을 살필수도, 방 밖으로 향할수도 있습니다... ");
            Console.WriteLine("");
            Thread.Sleep(1000);
            Console.WriteLine("그러나 어둠이 계속될지, 빛이 나올지 알 수 없는 바깥에 ... ");
            BTWS();
            Console.WriteLine("충분히 대비를 하고 나갈 수 있길 ... ");
            BTWS();
            Console.WriteLine("선택은 당신의 몫입니다... ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Thread.Sleep(1000);
            Room1();

        }
        public static void Room1()
        {
        go8:
            Status.Line();
            Console.WriteLine("[1] 침대를 살펴보고 싶으면 1번을 눌러주세요.");
            Thread.Sleep(1000);
            Console.WriteLine("[2] 옷장을 살펴보고 싶으면 2번을 눌러주세요.");
            Thread.Sleep(1000);
            Console.WriteLine("[3] 문 밖으로 나가고 싶으면 3번을 눌러주세요.");
            Thread.Sleep(1000);
            Console.WriteLine("[4] 현재 당신의 인벤토리를 확인하고 싶으면 4번을 눌러주세요.");
            Thread.Sleep(1000);
            string input3 = Console.ReadLine();
            Console.Clear();

            switch (input3)
            {
                case "1":
                    Bed();
                    break;
                case "2":
                    Closet();
                    break;
                case "3":
                    Door();
                    break;
                case "4":
                    ShowInventory();
                    break;
                default:
                    Console.WriteLine("잘못 입력하셨습니다...");
                    Thread.Sleep(1000);
                    Console.Clear();
                    goto go8;
            }
        }
        private static void Bed()
        {
            Random rand = new Random();
            int randValue = rand.Next(0, 101);
            if (randValue <= 100)
            {
                var item = Item.items.Find(i => i.iname == "커터칼");
                if (item != null)
                {
                    Player.Getitem(item);
                    BTWS();
                    Console.WriteLine("⠀⠀⠀⠀⠀⢀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠄⠈⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠐⠈⠀⢀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠂⡀⠀⠘⢖⢄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠫⡦⡀⠈⠱⡕⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⢎⢧⢀⠈⠪⡣⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠳⣕⢦⠀⠈⠊⣇⢄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢳⢝⢬⠀⡀⠣⣣⢀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⣕⢗⢤⠀⠀⠣⣣⢀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠳⡹⣕⣌⢠⡌⠪⣢⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⠼⡜⡮⣄⣞⣞⣾⣢⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠪⣳⡹⡾⣽⡾⣷⣻⣤⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠐⠵⣝⢵⢿⣽⣞⣯⢿⡤⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠑⡳⡝⣞⢷⣻⡽⣯⣗⡆⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠚⣎⡏⡯⣟⣗⣯⣻⣜⡄⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⢼⡹⡪⣇⢧⡳⣗⣟⣖⢄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⣞⡜⡮⡺⡜⣞⣞⣗⡧⣂⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢫⢮⡳⡝⣖⢕⣗⢯⢷⡕⡄⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠑⡳⣝⢼⡱⡵⡝⣗⡯⡯⣕⢄⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠺⣪⡺⢮⡫⡮⣺⢹⢘⠮⣢⠄⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢞⣕⢯⢻⣪⢗⡵⡹⡨⡋⡆⡀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠑⡽⣕⢗⡟⡮⣳⢕⢕⠱⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠪⣗⢽⣹⣪⢇⢇⠇⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠑⠯⡮⣺⢸⢰⠀⠀⠀⠀");
                    Console.WriteLine("당신은 커터칼을 얻었습니다. 이것이 왜 필요한지는 알 수 없지만... ");
                }
            }
            else
            {
                BTWS();
                Console.WriteLine("");
                Console.WriteLine("아무것도 발견하지 못했습니다... ");
            }
            Thread.Sleep(1500);
            Console.Clear();
            Room1();
        }
        private static void Closet()
        {
            Random rand = new Random();
            int randValue = rand.Next(0, 101);
            if (randValue <= 40)
            {
                var item = Item.items.Find(i => i.iname == "야구방망이");
                if (item != null)
                {
                    Player.Getitem(item);
                    BTWS();
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠔⠁⠌⠠⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠐⡁⠌⠠⢁⠅⠂⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⢐⠡⢄⢐⠨⡈⠂⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠄⡡⡢⡫⠪⡑⠐⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠐⢄⢎⠎⠪⠨⠈⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠐⠠⡨⢑⠡⠨⠈⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠠⢂⠨⢘⢐⠠⠁⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠠⠈⠌⡐⠨⡐⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠌⠄⠡⢂⠂⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠐⡀⡂⠅⠅⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⢐⠠⢂⢂⠂⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡐⡐⢐⠨⠐⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡀⡊⡐⡐⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⢂⠐⠄⠂⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠄⡁⡂⠈⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠠⠡⠨⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠄⡂⠌⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡐⠨⠐⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠄⡁⡂⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠄⡁⠢⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠠⡀⠄⡁⡂⠂⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀⠡⢑⠔⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("");
                    Console.WriteLine("당신은 야구방망이를 얻었습니다. 이것이 왜 필요한지는 알 수 없지만...");
                }
            }
            else
            {
                BTWS();
                Console.WriteLine("");
                Console.WriteLine("아무것도 발견하지 못했습니다...");
            }
            Thread.Sleep(1500);
            Console.Clear();
            Room1();
        }
        private static void Door()
        {
            Console.Clear();
            Status.EnterField(player);
            Status.Line();
            Console.WriteLine("⢂⠂⡂⢂⠂⡂⢂⠂⡂⢂⠂⡂⢂⠂⡂⢂⠂⡂⢂⠂⡂⢂⠂⡂⢂⠂⡂⢂⠂⡂⢂⠂⡂⢂⠂⡂⢂⠂⡂⢂⠂⡂⢂⠂⡂⢂⠂⡂⢂⠂");
            Console.WriteLine("⠅⡂⠌⡐⡐⡈⠄⡂⢂⠂⡂⢂⠂⡂⢂⠂⡂⢂⠂⡂⢂⠂⡂⢂⠂⡂⢂⠂⡂⢂⠂⡂⣐⣀⣂⣐⣀⣂⣐⣀⣂⣐⣀⣂⣐⣀⣂⡐⡀⡂");
            Console.WriteLine("⡁⡂⠅⢂⢐⠠⠡⢐⠐⡐⠠⢁⠂⡂⢂⠂⡂⢂⠂⡂⢂⠂⡂⢂⠂⡂⢂⠂⡂⢂⠂⠄⣿⣺⣳⣻⣺⣳⢯⣞⣗⣯⣞⣗⣟⣞⡷⡅⢀⠂");
            Console.WriteLine("⢐⠠⢁⢂⠂⠌⡐⡐⢐⠠⠑⡐⢈⢐⠐⡐⠠⢁⠂⡂⢂⠂⡂⡁⡂⢂⠂⡂⢂⠡⠈⠄⣷⣻⣺⣵⣻⣺⡽⣞⣗⣷⣻⣺⣳⢯⣻⡂⡐⠨");
            Console.WriteLine("⠔⡈⡐⡐⠨⢐⠐⡐⢐⢈⢐⠠⠁⠔⢐⠠⠑⡐⢈⢐⠐⡈⠄⢂⢐⠐⡐⠠⢁⠂⠅⡁⣷⣻⣺⣞⣗⡯⣯⢷⣻⣺⢞⣗⣯⢯⡷⡅⠠⢁");
            Console.WriteLine("⡐⡐⠠⢂⢁⢂⠂⡂⢂⠔⠠⠨⠈⠌⠠⢂⠡⢐⠐⠠⠂⡂⡁⠢⢐⠈⠄⠅⡂⠌⡐⡀⣷⣻⣺⣞⡾⣽⢽⡽⡾⣝⣯⣗⣯⢯⣟⠆⢁⠂");
            Console.WriteLine("⡐⠠⢑⠐⠠⠂⡂⠌⠄⠂⠅⠌⠌⠨⠈⠄⡂⢂⠌⠌⡐⠠⢂⢁⠂⠌⠄⠅⠄⡡⠐⡀⣷⣻⣺⣺⡽⣽⢽⡽⡯⣟⣾⣺⣳⣻⢾⠅⠂⠌");
            Console.WriteLine("⢂⠑⡐⠨⠨⢐⠠⠡⠨⢈⠄⠅⢊⠨⠈⠔⢐⠐⠠⢁⢂⢁⠂⠔⡈⠌⠄⠅⡂⢂⠡⠀⣷⣻⣺⣳⢯⡯⣯⢯⣟⣗⡷⡯⡾⣽⢽⠅⠌⡐");
            Console.WriteLine("⢂⢁⠂⠅⡊⠄⠂⠅⠌⠄⠂⠅⡂⠌⠨⠈⠄⠌⠌⠄⢂⢐⠨⠐⡐⢈⠄⠅⡐⢐⠈⠄⣟⣞⣗⣯⢯⡯⣯⣟⢾⣵⣻⡽⡯⣯⣟⡅⢂⢐");
            Console.WriteLine("⡐⢐⠨⢐⠐⡈⠌⠄⠅⠌⠌⡐⢐⠈⠌⠨⢈⠄⠅⠌⡐⡀⡂⠅⡐⢐⠠⢁⠂⡡⠈⠄⣯⢷⣻⣺⡽⣽⣳⡽⡯⣾⣺⡽⡯⣗⡷⡅⠄⠂");
            Console.WriteLine("⡈⠄⠌⠄⡂⠂⠅⠌⡐⡁⢂⠂⡂⠌⠌⠨⡀⠂⠅⡂⢂⢐⠐⡐⢈⠄⢂⠂⡂⢂⢁⠂⡿⡽⣞⣗⣯⢷⣗⡿⣽⣳⣗⡿⣽⣫⣟⠆⡈⠌");
            Console.WriteLine("⠠⡁⠅⡂⡂⠅⠡⠨⢀⠂⡂⠡⠠⠡⢈⠂⡂⠡⠁⠔⢐⠐⡐⢐⠐⡈⠄⡂⢂⠡⠐⡀⡿⡯⣟⡾⣽⢽⣺⣽⡳⣗⡷⡯⣷⣛⢚⡅⢐⢈");
            Console.WriteLine("⠔⠠⡁⡂⠄⠅⠡⢁⠂⠌⠄⠡⠡⠨⠐⡐⠠⠡⠁⠅⡂⢂⠂⡂⢂⢂⠡⠐⡐⡈⡐⡀⣿⢽⢯⢯⢷⣻⣳⣗⡿⣽⢽⣻⣬⡬⢐⡅⢐⢀");
            Console.WriteLine("⢌⠐⠄⡂⠅⠌⠌⡐⠨⠐⡁⠅⠌⠄⠅⢂⠡⠨⠨⠐⡐⢐⠐⡠⢁⢐⠠⢁⢂⢐⠠⢀⡯⡿⡽⡯⣟⣗⣷⣳⢯⡷⣯⢷⣳⢯⡴⡅⢐⢀");
            Console.WriteLine("⢐⠨⢐⠐⠨⠠⢁⢂⠡⠁⠔⡈⠄⠅⠊⠄⠌⠄⠅⠌⡐⢐⠐⡐⢐⠠⠨⢀⢂⢐⠐⡀⡿⡽⡯⡿⣽⣺⣞⣾⣫⣟⡾⣽⣞⡯⣟⠆⡐⠠");
            Console.WriteLine("⡂⠌⡐⠨⠈⠌⠄⡂⠌⠨⢐⠠⠡⠨⠨⠠⠡⠨⠠⢁⠂⡂⢂⠂⡂⠌⡐⡐⡀⡂⠂⠄⣟⣯⢿⢽⣳⣗⣟⣞⣾⣺⣽⣳⢗⡿⣽⠅⠠⢁");
            Console.WriteLine("⠄⠅⡂⠅⡡⢁⢂⠂⠌⠌⠄⢂⠡⠨⠠⢁⠊⠄⡑⠠⢁⠂⡂⠌⡐⢐⠐⡀⡂⡐⡁⠅⣟⡾⡽⡯⣗⣷⣻⣺⣞⣗⣗⡯⡿⣝⣷⢃⠁⡂");
            Console.WriteLine("⢊⠐⠄⠅⡐⡐⢐⠨⠈⠄⠅⡂⠌⡐⡁⠢⢈⠂⡂⠅⡂⠌⡐⡈⡐⠠⢁⢂⠐⠄⢂⠂⣯⢯⢿⢽⣻⣺⣞⣗⣗⣟⡾⡽⡯⣟⡾⡅⢐⠠");
            Console.WriteLine("⠠⠡⢁⠅⢂⢂⢁⠂⠅⡡⢁⢂⢁⢂⢐⢁⠢⢈⢐⢐⠠⢁⢂⠐⠄⡑⡐⢐⠨⠈⠄⡂⣯⢿⢽⢯⢷⣳⣗⣟⣞⣗⡿⡽⣯⢷⣻⡂⠂⠌");
            Console.WriteLine("⠅⠕⠘⠔⠑⠅⠊⠢⠡⠑⠌⠂⠂⠊⠔⠐⠁⠊⠐⠁⠑⠈⠂⠑⠐⠐⠨⠐⠐⠈⠂⠅⠑⠈⢂⠑⠨⠐⠁⠂⠅⠂⠢⠁⠢⠁⠢⠡⠑⠈");

            Console.WriteLine("당신은 방을 나와 복도에 들어섰습니다...");
            BTWS();
            Console.WriteLine("불이 켜지지 않은 복도는 어둡기만 합니다...");
            BTWS();
            Console.WriteLine("정면에는 또다른 방이 있고 왼편으로는 복도가 이어집니다...");
            BTWS();
            Console.WriteLine("어디로 향하겠습니까...");
            BTWS();
        go2:
            Status.Line();
            Console.WriteLine("[1] 정면의 방으로 들어가고 싶으면 1번을 눌러주세요...");
            Thread.Sleep(300);
            Console.WriteLine("[2] 왼쪽의 복도로 가고싶다면 2번을 눌러주세요...");

            string input = Console.ReadLine();
            Console.Clear();

            switch (input)
            {
                case "1":
                    EnterFrontRoom();
                    break;
                case "2":
                    EnterLeftCorridor();
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    Thread.Sleep(1000);
                    goto go2;
            }
        }

        private static void EnterFrontRoom()
        {
            Console.Clear();
            Status.EnterField(player);
            Status.Line();
            Console.WriteLine("⠄⠂⡐⢀⠂⡂⠠⠀⠄⠠⠀⠄⣀⣄⣀⣄⣀⣄⣤⣤⣦⣤⣤⠠⠀⠄⠠⠀⠄⠠⠀⠄⠠⠀⠄⠐⡀⠠⠀⠠⠀⠠⠀⠠⠀⡀⠄⠀⡀⠄");
            Console.WriteLine("⠐⡀⢂⠐⡈⠄⠂⠐⠀⣿⠛⠛⠛⠙⠉⢉⠉⢉⠉⠊⠀⢑⣿⠀⠐⠀⠂⢁⠐⠀⡁⠐⢀⠁⠄⠁⠄⠀⠂⡀⠂⠐⠀⠂⢀⠠⠀⠄⠀⠄");
            Console.WriteLine("⠂⡐⢀⠂⠄⠅⠠⠁⡈⣿⠐⠀⠂⢀⠁⠀⠄⠀⠄⠈⡀⢐⣿⠀⢈⠀⡁⠄⢀⠁⠠⠈⠀⠄⠂⠁⠌⠀⡁⠀⠄⢁⠀⡁⠀⠄⠀⠂⠐⠀");
            Console.WriteLine("⠡⢀⠐⠠⢁⠊⡀⠂⠀⣿⡈⢀⠈⢀⠀⠂⠐⠀⠂⠠⠀⢐⣿⠀⠠⠀⠄⠐⠀⠄⠁⠄⢁⠐⠈⠠⢁⠐⠀⠂⠐⠀⠄⠠⠈⢀⠈⡀⠁⠄");
            Console.WriteLine("⡂⠄⠨⠐⡐⠠⠐⠈⡀⣿⠠⠀⠐⠀⠠⠈⢀⠈⠠⠐⠈⢐⣿⠀⠐⡀⠂⢁⠐⢨⣦⣶⣴⣴⣸⣴⢶⣶⢷⣷⣳⣓⡾⣶⡾⣶⠆⢀⠂⠀");
            Console.WriteLine("⡀⠂⡁⠂⠄⠅⠂⠁⡀⣿⠐⠈⢀⠁⡀⠂⠠⠐⠀⠐⢀⢐⣿⠀⠂⠀⢂⠠⠀⢕⣿⣞⣷⣯⣷⢿⣻⣽⣟⣾⣽⢯⣿⢯⡿⣯⡃⠠⠀⠁");
            Console.WriteLine("⠄⡁⠄⠡⢈⢂⠈⠄⡀⣿⢁⠈⡀⠄⠀⠂⠐⢀⠁⡈⢀⢐⣿⠀⢈⠀⠂⡀⠂⢹⡷⣟⣷⢿⣾⣛⣛⣓⣛⣳⣟⣿⢯⣿⣟⣿⠄⠂⢈⠀");
            Console.WriteLine("⡂⠄⠨⠐⢐⢀⠂⠐⡀⣿⣆⣤⣤⣢⢥⣬⢴⡤⣦⡴⣤⣴⣟⠀⠄⠠⠁⡀⠄⢵⡿⣯⢿⣽⣾⣻⣟⣿⣻⣽⣾⣻⣽⢷⣯⢿⡂⢈⠀⡀");
            Console.WriteLine("⠄⣿⡾⣯⣗⣵⣻⣽⡾⣯⣿⣳⣝⣽⢽⣟⣿⣻⣯⣿⢽⣕⣯⡿⣿⣻⡿⣷⡂⣺⢿⣽⣟⣷⣯⡷⡿⡽⡯⢿⣾⣻⣽⡿⣾⢿⡂⠠⠀⠄");
            Console.WriteLine("⠨⣿⣽⢿⣽⣯⢿⣞⣿⣻⣞⣯⣿⡽⣟⣷⣯⡷⣿⢾⣟⣯⣷⣟⣯⣿⣽⣿⡐⢼⣟⣷⣯⡷⣿⡽⣟⣯⡿⣟⣾⢯⣷⣟⣯⣿⢂⠐⠀⠂");
            Console.WriteLine("⠡⡿⣾⣟⣷⣯⣭⣭⣵⣿⣽⢿⢾⣻⣟⣷⣻⣽⣟⣟⣝⡿⣾⢯⣷⢿⣾⣻⠄⢽⡿⣞⣷⡿⣯⡿⣻⢽⢟⡿⣽⣟⣷⣻⣾⣻⡂⢀⠁⡐");
            Console.WriteLine("⠐⣿⢷⣻⣗⣿⢾⣯⣷⢿⣾⣻⣟⣯⡷⣿⡽⣷⣻⣽⣯⢿⣻⣯⣟⣯⣿⣯⢃⢽⣟⣯⣷⢿⣯⢿⣞⣯⣷⣟⣯⡿⣾⣻⣞⣿⡐⠀⠄⠠");
            Console.WriteLine("⠂⣿⣻⣯⢿⡮⣯⣵⣽⢿⣾⣻⡾⣯⡿⣯⡿⣯⢯⣷⣟⣿⣻⣾⣯⣿⢾⣿⢐⢼⣿⣺⣽⢿⡾⣿⡽⣯⣷⢿⣽⢿⣽⢷⣻⣽⡂⠐⠀⠂");
            Console.WriteLine("⡁⣿⣳⣟⣯⣿⣻⡾⣯⣿⣳⣯⡿⣯⣟⣷⣟⣿⣻⡷⣿⢾⣯⡷⣟⣾⢿⣻⠔⢼⣯⡿⣽⣟⣿⣳⣽⣵⡽⣽⣽⢿⣽⣟⣿⣽⡂⢈⠀⡁");
            Console.WriteLine("⢂⠂⡁⠂⠄⠡⠐⡀⢅⢂⢔⢠⢠⢀⢂⠄⡡⢈⠐⡈⠈⠄⢉⠉⡉⡘⠩⠈⠌⠚⢛⠛⠛⠚⠛⠳⠻⠻⠝⠟⠞⢟⠾⡯⠿⡟⠆⠐⠈⡀");
            Console.WriteLine("⠐⢀⠂⡡⠨⠔⠕⠜⢌⢪⢊⢆⢆⢕⢔⢅⠣⡡⠱⡨⠫⣊⢆⠣⡒⡔⡱⠸⡰⡑⠔⢌⢔⠡⡡⠡⡨⡐⠨⡠⢡⢐⢀⢂⠡⡨⠀⠅⠂⡐");
            Console.WriteLine("");
            Console.WriteLine("당신은 어떤 방에 들어왔습니다...");
            BTWS();
            Console.WriteLine("이 방은 이전에 있던 방보다는 훨씬 넓어보입니다...");
            BTWS();
            Console.WriteLine("눈이 어둠에 적응이 되자 주변 사물들이 보이기 시작합니다...");
            BTWS();
            Console.WriteLine("특히 당신의 눈에 띄는 것은 옆의 화장대와 엔틱한 장식장입니다...");
            BTWS();
            Console.WriteLine("어떤것을 살펴볼까요...");
        go3:
            BTWS();
            Status.Line();
            Console.WriteLine("[1] 화장대를 살펴보고 싶다면 1번을 눌러주세요...");
            Thread.Sleep(300);
            Console.WriteLine("[2] 장식장을 살펴보고 싶다면 2번을 눌러주세요...");
            Thread.Sleep(300);
            Console.WriteLine("[3] 다시 밖으로 나가고 싶다면 3번을 눌러주세요...");
            Thread.Sleep(300);
            string input9 = Console.ReadLine();
            Console.Clear();

            switch (input9)
            {
                case "1":
                    Random rand = new Random();
                    int randValue = rand.Next(0, 101);
                    if (randValue <= 60)
                    {
                        var item = Item.items.Find(i => i.iname == "집키1");
                        if (item != null)
                        {
                            Player.Getitem(item);
                            BTWS();
                            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀   ⠀⠀⠀⠀⠀⢀⢀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀   ⠀⠀⠀⢀⢦⠯⠻⠻⠻⢿⡾⣦⣀⠀⠀⠀⠀⠀");
                            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀   ⠀⠀⠀⢀⣤⢼⢊⠀⠀⠀⠀⠀⠈⠛⢿⣷⡀⠀⠀⠀");
                            Console.WriteLine("⠀⠀⠀⠀⣺⣿⢿⣻⣟⣟⡿⣝⣟⢻⣛⢏⡟⡟⢏⢋⡋⡙⡕⡃⣣⢊⢮⢒⢒⠒⢒⢲⠲⢾⡞⢜⡎⡢⢀⠀⠀⠀⠻⣿⡀⠀⠀");
                            Console.WriteLine("⠀⠀⠀⠀⣷⡿⣟⣿⣯⡟⠟⠯⠯⠟⠛⠛⠛⠛⠯⠳⠻⠳⠳⠿⠻⠷⠿⠟⠿⠿⠽⠾⠯⣿⣿⡖⢬⠚⠑⠀⠀⠀⢿⠪⠀⠀");
                            Console.WriteLine("⠀⠀⠀⢐⣯⣿⣟⣿⣷⣿⣝⣮⡲⡂⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠻⢿⡐⠀⠀⠀⠀⠀⠀⠀⠀⢀⠟⠀⠀⠀");
                            Console.WriteLine("⠀⠀⠀⠸⣿⡟⣽⣿⢽⣾⣻⠹⣾⡁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠐⢻⣦⣠⡀⠀⡀⡀⡠⡰⡁⠂⠀⠀");
                            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠈⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠙⠛⠟⠛⠋⠊⠀⠀⠀⠀⠀⠀");
                            Console.WriteLine("");
                            Console.WriteLine("당신은 집키1을 얻었습니다. 이것이 왜 필요한지는 알 수 없지만... ");
                        }
                    }
                    else
                    {
                        BTWS();
                        Console.WriteLine("");
                        Console.WriteLine("아무것도 발견하지 못했습니다... ");
                    }
                    goto go3;
                case "2":
                    Status.EnterField(player);
                    goto go3;
                case "3":
                    Corridor();
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    Thread.Sleep(1000);
                    goto go3;
            }
        }
        private static void Corridor()
        {
            Console.Clear();
            Status.EnterField(player);
            Status.Line();
            Console.WriteLine("⢂⢂⠂⡂⢂⠂⡂⢂⠂⡂⢂⠂⡂⢂⠂⡂⢂⠂⡂⢂⠂⡂⢂⠂⡂⢂⠂⡂⢂⠂⡂⢂⠂⡂⢂⠂⡂⢂⠂⡂⢂⠂⡂⢂⠂⡂⢂⠂⡂⠂");
            Console.WriteLine("⠅⠂⡂⢂⠂⡂⣐⣀⣂⣐⣀⣂⣐⣀⣂⣐⣀⣂⣐⣀⣂⡐⡀⡂⠌⡐⡐⡈⠄⡂⢂⠂⡂⢂⠂⡂⢂⠂⡂⢂⠂⡂⢂⠂⡂⢂⠂⡂⢂⡂");
            Console.WriteLine("⡁⠂⡂⢂⠂⠄⣿⣺⣳⣻⣺⣳⢯⣞⣗⣯⣞⣗⣟⣞⡷⡅⢀⡂⠅⢂⢐⠠⠡⢐⠐⡐⠠⢁⠂⡂⢂⠂⡂⢂⠂⡂⢂⠂⡂⢂⠂⡂⢂⠂");
            Console.WriteLine("⢐⡂⢂⠡⠈⠄⣷⣻⣺⣵⣻⣺⡽⣞⣗⣷⣻⣺⣳⢯⣻⡂⡐⠠⢁⢂⠂⠌⡐⡐⢐⠠⠑⡐⢈⢐⠐⡐⠠⢁⠂⡂⢂⠂⡂⡁⡂⢂⠂⠨");
            Console.WriteLine("⠔⠠⢁⠂⠅⡁⣷⣻⣺⣞⣗⡯⣯⢷⣻⣺⢞⣗⣯⢯⡷⡅⠠⡈⡐⡐⠨⢐⠐⡐⢐⢈⢐⠠⠁⠔⢐⠠⠑⡐⢈⢐⠐⡈⠄⢂⢐⠐⡐⢁");
            Console.WriteLine("⡐⠅⡂⠌⡐⡀⣷⣻⣺⣞⡾⣽⢽⡽⡾⣝⣯⣗⣯⢯⣟⠆⢁⡐⠠⢂⢁⢂⠂⡂⢂⠔⠠⠨⠈⠌⠠⢂⠡⢐⠐⠠⠂⡂⡁⠢⢐⠈⠄⠂");
            Console.WriteLine("⡐⠅⠄⡡⠐⡀⣷⣻⣺⣺⡽⣽⢽⡽⡯⣟⣾⣺⣳⣻⢾⠅⠂⠠⢑⠐⠠⠂⡂⠌⠄⠂⠅⠌⠌⠨⠈⠄⡂⢂⠌⠌⡐⠠⢂⢁⠂⠌⠄⠌");
            Console.WriteLine("⢂⠅⡂⢂⠡⠀⣷⣻⣺⣳⢯⡯⣯⢯⣟⣗⡷⡯⡾⣽⢽⠅⠌⠑⡐⠨⠨⢐⠠⠡⠨⢈⠄⠅⢊⠨⠈⠔⢐⠐⠠⢁⢂⢁⠂⠔⡈⠌⠄⡐");
            Console.WriteLine("⢂⠅⡐⢐⠈⠄⣟⣞⣗⣯⢯⡯⣯⣟⢾⣵⣻⡽⡯⣯⣟⡅⢂⢁⠂⠅⡊⠄⠂⠅⠌⠄⠂⠅⡂⠌⠨⠈⠄⠌⠌⠄⢂⢐⠨⠐⡐⢈⠄⢐");
            Console.WriteLine("⡐⢁⠂⡡⠈⠄⣯⢷⣻⣺⡽⣽⣳⡽⡯⣾⣺⡽⡯⣗⡷⡅⠄⢐⠨⢐⠐⡈⠌⠄⠅⠌⠌⡐⢐⠈⠌⠨⢈⠄⠅⠌⡐⡀⡂⠅⡐⢐⠠⠂");
            Console.WriteLine("⡈⠂⡂⢂⢁⠂⡿⡽⣞⣗⣯⢷⣗⡿⣽⣳⣗⡿⣽⣫⣟⠆⡈⠄⠌⠄⡂⠂⠅⠌⡐⡁⢂⠂⡂⠌⠌⠨⡀⠂⠅⡂⢂⢐⠐⡐⢈⠄⢂⠌");
            Console.WriteLine("⠠⡂⢂⠡⠐⡀⡿⡯⣟⡾⣽⢽⣺⣽⡳⣗⡷⡯⣷⣛⢚⡅⢐⡁⠅⡂⡂⠅⠡⠨⢀⠂⡂⠡⠠⠡⢈⠂⡂⠡⠁⠔⢐⠐⡐⢐⠐⡈⠄⢈");
            Console.WriteLine("⠔⠐⡐⡈⡐⡀⣿⢽⢯⢯⢷⣻⣳⣗⡿⣽⢽⣻⣬⡬⢐⡅⢐⠠⡁⡂⠄⠅⠡⢁⠂⠌⠄⠡⠡⠨⠐⡐⠠⠡⠁⠅⡂⢂⠂⡂⢂⢂⠡⢀");
            Console.WriteLine("⢌⢁⢂⢐⠠⢀⡯⡿⡽⡯⣟⣗⣷⣳⢯⡷⣯⢷⣳⢯⡴⡅⢐⠐⠄⡂⠅⠌⠌⡐⠨⠐⡁⠅⠌⠄⠅⢂⠡⠨⠨⠐⡐⢐⠐⡠⢁⢐⠠⢀");
            Console.WriteLine("⢐⢀⢂⢐⠐⡀⡿⡽⡯⡿⣽⣺⣞⣾⣫⣟⡾⣽⣞⡯⣟⠆⡐⠨⢐⠐⠨⠠⢁⢂⠡⠁⠔⡈⠄⠅⠊⠄⠌⠄⠅⠌⡐⢐⠐⡐⢐⠠⠨⠠");
            Console.WriteLine("⡂⡐⡀⡂⠂⠄⣟⣯⢿⢽⣳⣗⣟⣞⣾⣺⣽⣳⢗⡿⣽⠅⠠⠌⡐⠨⠈⠌⠄⡂⠌⠨⢐⠠⠡⠨⠨⠠⠡⠨⠠⢁⠂⡂⢂⠂⡂⠌⡐⢁");
            Console.WriteLine("⠄⡀⡂⡐⡁⠅⣟⡾⡽⡯⣗⣷⣻⣺⣞⣗⣗⡯⡿⣝⣷⢃⠁⠅⡂⠅⡡⢁⢂⠂⠌⠌⠄⢂⠡⠨⠠⢁⠊⠄⡑⠠⢁⠂⡂⠌⡐⢐⠐⡂");
            Console.WriteLine("⢊⢂⠐⠄⢂⠂⣯⢯⢿⢽⣻⣺⣞⣗⣗⣟⡾⡽⡯⣟⡾⡅⢐⠐⠄⠅⡐⡐⢐⠨⠈⠄⠅⡂⠌⡐⡁⠢⢈⠂⡂⠅⡂⠌⡐⡈⡐⠠⢁⠠");
            Console.WriteLine("⠠⢐⠨⠈⠄⡂⣯⢿⢽⢯⢷⣳⣗⣟⣞⣗⡿⡽⣯⢷⣻⡂⠂⠡⢁⠅⢂⢂⢁⠂⠅⡡⢁⢂⢁⢂⢐⢁⠢⢈⢐⢐⠠⢁⢂⠐⠄⡑⡐⠌");
            Console.WriteLine("⠅⠐⠐⠈⠂⠅⠑⠈⢂⠑⠨⠐⠁⠂⠅⠂⠢⠁⠢⠁⠢⠡⠑⠕⠘⠔⠑⠅⠊⠢⠡⠑⠌⠂⠂⠊⠔⠐⠁⠊⠐⠁⠑⠈⠂⠑⠐⠐⠨⠈");

            Console.WriteLine("다시 복도로 나왔습니다...");
            BTWS();
            Console.WriteLine("맞은편으로 당신이 처음 일어났던 방이 보이고...");
            BTWS();
            Console.WriteLine("오른쪽으로는 어두운 복도가 있습니다...");
            BTWS();
            Console.WriteLine("어디로 갈까요...");
            BTWS();
        go4:
            Status.Line();
            Console.WriteLine("[1] 맞은편 방으로 다시 들어간다...");
            Thread.Sleep(300);
            Console.WriteLine("[2] 오른쪽 복도로 향한다...");
            Thread.Sleep(300);
            string input10 = Console.ReadLine();
            Console.Clear();

            switch (input10)
            {
                case "1":
                    Room1();
                    break;
                case "2":
                    EnterLeftCorridor();
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    Thread.Sleep(1000);
                    goto go4;
            }
        }

        private static void EnterLeftCorridor()
        {
            Console.Clear();
            Status.EnterField(player);
            Status.Line();
            Console.WriteLine("⢂⢂⢂⢂⢂⢂⢂⢂⢂⢂⠢⢂⠪⡐⡐⡐⡐⡐⡐⡐⡐⡐⡐⡐⡐⡐⡐⡐⡐⡐⢐⢐⢐⢐⢐⢐⢐⢐⢐⢐⢐⠀⠄⠄⢐⠐⡐⢐⠐⠠");
            Console.WriteLine("⡐⡐⡐⡐⡐⡐⡐⡐⠄⠅⠌⡂⢅⢂⢊⠄⡂⡂⠔⢐⠠⢂⠐⠄⡂⠔⡀⠢⢐⠠⠡⢐⠠⠂⡂⡂⡂⡂⡂⡂⡂⢄⠑⠈⡀⡂⢂⠂⠌⠌");
            Console.WriteLine("⢐⢐⢐⢐⢐⢐⢐⠨⠨⢨⡂⠌⢔⢐⢁⢂⠂⠔⠨⢐⢈⢐⠨⠐⠄⠅⡂⡑⡐⠨⢐⠐⠨⢐⠐⠄⡂⢂⢂⢂⢂⠂⢄⠁⠄⢂⢂⠡⠡⠨");
            Console.WriteLine("⢐⢐⢐⢐⢐⠐⠄⢅⢑⠰⣻⡮⡐⠔⡁⠢⠨⢈⢔⣐⣀⣂⣌⣨⡠⣡⣐⣀⣂⣅⢔⣨⣨⣠⢬⣰⡐⢐⢐⢐⢐⢈⢾⠈⠠⢁⢐⠠⠡⠨");
            Console.WriteLine("⢂⢂⢂⢂⠂⢅⢑⠐⢄⠱⡯⣗⠌⢌⠌⠌⠌⠄⣿⢽⡽⣳⣗⣷⣻⣳⢯⡯⣗⣯⢯⡷⣻⣺⢯⣗⠇⡐⢐⢐⠐⠄⡿⠀⡁⡂⢂⠌⠄⠅");
            Console.WriteLine("⠅⡂⡂⡂⠅⡂⡂⠅⡂⢪⣻⢧⠡⡑⠌⠌⡂⡁⣿⢽⣽⣳⣗⣷⣻⣺⡽⣽⢽⣞⡯⡿⡽⣞⣟⡾⡅⢂⢂⠂⠅⠅⡿⠀⡐⢐⠐⠠⡁⡂");
            Console.WriteLine("⠅⡂⢂⠂⠅⡂⡂⠅⠌⠢⡿⣝⢐⠌⢌⢂⠂⠔⣽⢯⢾⣺⣞⣾⣺⣳⣻⡽⣽⢾⢽⢯⢿⡽⡾⣽⢂⠐⠄⠅⠅⠅⣿⠀⡐⡐⠨⢐⠠⠂");
            Console.WriteLine("⠅⡂⠅⠌⡂⡂⠢⠡⠡⡑⣿⢽⠠⢡⠡⠂⠌⡂⡿⡽⡯⣗⣟⣾⣺⣳⢯⡯⣯⢯⢿⢽⣻⣞⡯⣿⠠⠨⠨⠨⡈⡂⣯⠀⡐⠠⢁⠂⡂⠅");
            Console.WriteLine("⠐⠄⠅⠅⠢⠨⠨⡈⠢⡘⣽⣳⠁⡅⡊⠌⡐⠄⡿⡯⡿⣽⢾⣺⢾⢽⡽⣽⢽⡽⡯⣟⣾⣺⣽⢽⢐⠡⢈⢂⢂⠂⣟⠀⠄⠅⡂⠡⢐⠨");
            Console.WriteLine("⠨⠨⠨⠨⠨⡈⠢⡈⠢⡘⣽⣞⢐⠔⠌⡂⡂⠅⣿⢽⢯⡯⣟⡾⡯⣟⣽⢽⡽⡽⡯⣟⡾⣵⢯⡿⡐⠈⠔⡐⡐⡈⣯⠐⢈⢐⠠⢁⠂⢌");
            Console.WriteLine("⠌⠌⠌⠌⠢⡈⠢⡈⠢⡘⣷⣳⠐⢌⠊⠄⡂⠂⣿⢽⢯⡯⣷⣻⣽⣻⣺⢯⣟⡽⣯⢷⣻⡽⣽⢽⠠⢁⠅⡂⠢⢐⡽⠀⢂⢐⢈⢐⠨⢀");
            Console.WriteLine("⠨⠨⠨⡈⠢⡈⠢⡈⠢⢨⢷⣳⠡⢡⠡⡁⡂⠅⣿⢽⣫⡯⣷⣳⣗⣟⡾⣽⢾⢽⡽⣽⣳⣻⣽⣻⠈⠄⠢⠨⠨⢀⡯⠐⢐⢀⠂⠔⢐⠐");
            Console.WriteLine("⠡⠡⡁⡂⠅⠌⠢⠨⡈⢢⣟⣗⠅⡢⠡⢂⠂⡁⣯⡯⣷⣻⣳⣗⣟⡾⣽⣳⢿⢽⣽⣳⣻⣞⡾⣾⠨⠈⠌⠌⢌⠠⡗⠈⡀⡂⠌⡨⠐⡐");
            Console.WriteLine("⠅⠅⡂⡂⠅⠅⠅⠅⠌⢔⣟⣞⢐⠌⢌⢐⠨⢀⡿⣽⣳⣻⣺⣞⣗⣯⢷⢯⣟⡽⣞⣞⣗⡷⣯⢷⠡⠨⠨⠨⢐⠨⡇⠂⡐⠠⠡⢐⠐⡠");
            Console.WriteLine("⠂⠅⡂⡂⠅⠅⠅⢅⢑⢐⣟⣞⠄⢅⠕⢐⠈⠄⣟⣗⣟⣞⣗⣷⣻⣺⢯⣟⡾⣽⣻⣺⣳⣟⣽⣽⠠⠡⠡⢑⢐⢘⡇⠐⡈⠌⡐⢐⢐⠠");
            Console.WriteLine("⠨⠨⢐⠠⠡⠡⢑⢐⢐⢘⣞⣗⠅⢅⢊⢐⠨⠐⡏⡓⣟⣞⣷⣳⣻⣺⡽⡾⣽⣳⢗⣟⣾⣺⣳⣽⠠⢑⠨⢐⢐⢸⡅⠂⡐⢐⠠⠡⠐⡈");
            Console.WriteLine("⠡⢑⢐⠨⠨⠨⢐⢐⠐⢌⣾⠳⠡⡑⡐⡐⠨⠐⡇⠨⣭⢮⢾⣺⣳⢯⡯⣟⡷⡽⡯⣷⣳⣟⡾⣽⠐⡐⠨⢐⢐⢸⠆⢀⢂⢁⢂⠡⠁⠔");
            Console.WriteLine("⡁⡂⠢⠨⠨⠨⡐⠄⡑⢰⣺⣞⠌⢔⠐⠌⠌⢂⣇⣑⡯⡿⣽⣳⢯⡯⣯⢷⣻⡽⡯⣷⣳⣗⡿⣽⠐⠠⢑⢐⢐⢰⠇⠀⡂⡐⠠⠨⢈⠐");
            Console.WriteLine("⠢⠨⠨⠨⡈⡂⡂⠅⠌⠢⣟⣞⠌⠔⡡⠡⢁⠂⣟⡾⡽⣯⢷⢯⡯⡿⣽⢽⣳⢯⣟⣗⡷⡯⣯⢷⠁⠅⡂⡂⠢⢸⡇⠁⡐⠠⠡⢁⠂⠅");
            Console.WriteLine("⠡⠡⠡⡁⡂⡂⡂⠅⠅⢕⣟⣗⠅⠕⢄⠑⠄⡡⣻⡽⡯⣯⢯⡯⣯⣟⣗⣯⢯⣟⣞⣗⡿⡽⡯⡯⢂⢁⠢⠨⠨⢸⡆⠐⠠⠑⡈⡐⠨⠐");
            Console.WriteLine("⠅⠅⠅⡂⡂⡂⡂⢅⢑⠰⣻⣞⠌⢌⠢⢁⠅⡐⣽⢽⢯⡯⣯⣟⣗⣷⣻⣺⣻⣺⣳⢯⡯⡿⣽⢯⠂⡐⠨⠨⠨⢸⡅⠠⢁⠅⠂⠄⠅⡁");
            Console.WriteLine("⠡⠡⡁⡂⡂⡂⡂⡂⡂⡑⣟⡾⡈⡢⢑⢐⠐⠄⣿⣫⣯⢯⣷⣳⣻⣺⣞⣗⣟⡾⣽⢽⡽⡯⣯⣗⢐⠨⠨⠨⠨⢸⡅⠐⡐⢈⠌⠨⢐⠐");
            Console.WriteLine("⠅⠅⡂⡂⡂⡂⡂⡂⡂⠪⡯⣟⡐⢌⢂⠢⢈⠂⣿⣺⣞⣟⣾⣺⣳⣗⣷⣻⣺⡽⣽⢽⡽⡯⣷⡳⡐⢈⠌⠌⠌⢸⠆⢐⠐⡐⡈⠌⠄⡂");
            Console.WriteLine("⠅⠅⡂⡂⡂⡂⡂⠢⠨⠨⡿⣽⠐⢔⢐⠌⡐⡈⡷⣗⣟⣾⣺⣳⣗⣟⣾⣺⣳⣻⡽⡯⣯⣟⣗⡯⢐⠐⡨⠨⠨⢸⠅⢐⠐⠠⠂⠌⡐⠠");
            Console.WriteLine("⢊⢐⢐⢐⢐⢐⠨⠨⠨⠨⡿⣽⢈⠆⡢⢂⢂⠂⣿⡽⣞⣗⣟⣾⣺⣳⣗⣟⣞⡷⡯⣟⣗⡷⡯⡯⢐⠐⢄⢑⠨⣸⠅⢐⠨⠈⠌⡐⠨⠠");
            Console.WriteLine("⡂⡂⡂⡂⡂⠢⠨⠨⠨⠨⡿⣽⠐⢌⠔⡐⡐⡈⣷⣻⡽⣞⣷⣳⣻⣞⣞⣗⣯⢯⡿⡽⡾⡽⣯⢯⠐⡨⢐⢐⠨⣸⠌⠠⠨⠈⠔⡈⠄⠅");
            Console.WriteLine("⢐⢐⢐⢐⠨⠨⠨⠨⠨⢊⡯⣟⢌⠢⠡⢂⢂⠂⣿⣺⢽⣳⣗⣟⣾⣺⣳⣻⣞⡯⣯⢿⡽⣯⣟⡧⡁⡂⡂⡢⠁⡾⡐⠈⠄⠅⡡⠠⠡⠨");
            Console.WriteLine("⢐⢐⠐⠄⠅⠅⠅⠅⠕⡐⡿⣽⠠⠑⡑⠐⠄⠌⠡⠉⠍⠡⠩⠨⠡⠙⡘⠕⠓⢛⠙⠋⢋⠓⠓⢋⢀⢂⢂⠢⠡⣹⡐⠈⠌⡐⠠⡁⢊⠨");
            Console.WriteLine("⡐⠠⠡⠡⠡⠡⠡⡡⢑⠨⡯⠃⠀⠂⠠⠈⠠⠐⠀⡁⠐⠀⠂⠐⠀⡁⠠⠀⠡⠀⠄⠁⠄⠐⠈⢀⠀⠄⢀⠐⠀⠱⡂⢈⠂⢌⠐⠄⠅⠌");
            Console.WriteLine("⠨⠨⠨⠨⠨⡨⠨⡐⡐⡡⠁⠠⠈⡀⠂⢈⠀⠐⠀⠄⠂⠁⡈⢀⠁⢀⠐⠈⢀⠐⠀⠂⠐⠀⡁⠠⠀⠂⠠⠐⠀⠀⠁⠄⡑⠠⠡⢁⢊⢐");
            Console.WriteLine("");
            Console.WriteLine("당신은 세갈래길에 들어섰습니다...");
            BTWS();
            Console.WriteLine("정면으로 가는 길과 왼쪽으로 가는 길, 오른쪽으로 가는 길이 있습니다...");
            BTWS();
            Console.WriteLine("어디로 향하겠습니까...");
            BTWS();
        go5:
            Status.Line();
            Console.WriteLine("[1] 정면으로 가고싶다면 1번을 눌러주세요...");
            Thread.Sleep(300);
            Console.WriteLine("[2] 왼쪽으로 가고싶다면 2번을 눌러주세요...");
            Thread.Sleep(300);
            Console.WriteLine("[3] 오른쪽으로 가고싶다면 3번을 눌러주세요...");

            string input11 = Console.ReadLine();
            Console.Clear();
            switch (input11)
            {
                case "1":
                    Corridor2();
                    break;
                case "2":
                    Kitchen();
                    break;
                case "3":
                    Livingr();
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    Thread.Sleep(1000);
                    goto go5;
            }
        }
        private static void Corridor2()
        {
            Console.Clear();
            Status.EnterField(player);
            Status.Line();
            Console.WriteLine("⠪⡐⢅⠪⠰⡐⡐⡐⡐⡐⡐⡐⡐⠔⡐⠔⡁⡢⢑⢐⢐⢐⢐⢐⢐⢐⢐⢐⢐⢐⢐⢐⢐⢐⢐⢐⢐⢐⢐⢐⢐⠐⡐⢐⠐⡐⢐⠐⡐⠠");
            Console.WriteLine("⠄⠘⡐⢅⠣⡂⡂⡂⡂⢺⢶⣔⡄⠅⡂⡑⡐⢌⠢⢂⢂⢂⢂⠂⡂⡂⠔⢐⠠⢂⠐⠄⡂⠔⡀⡂⡂⡂⠂⠂⠐⢐⠐⡐⢐⠐⡐⢐⠠⢁");
            Console.WriteLine("⢀⠁⠄⢡⢑⠔⡐⡐⡨⢸⣟⡾⣽⢯⣶⣰⢈⠢⡑⠡⡐⡐⠠⢁⠂⠄⠅⡂⢌⢐⠨⡐⡠⣁⢔⣀⣂⣔⠀⠀⠠⢁⠂⡂⢂⠌⡐⢐⠨⠐");
            Console.WriteLine("⠅⠐⠀⠂⢅⡑⠔⡐⡐⣸⣗⡿⣽⢽⣞⣾⠠⡑⢌⢂⠢⡈⢞⣯⣟⣿⣻⢽⡯⡿⡽⣯⣻⣞⣯⢯⣟⡾⠀⠀⠐⡐⢐⠐⡐⢐⠐⡐⠠⢁");
            Console.WriteLine("⠂⡁⢈⠠⡑⢌⠌⠔⡐⢸⡾⣽⢽⣻⢾⣽⠐⢌⠢⢂⢂⠢⣹⢗⣯⢾⣺⢯⡯⡿⣽⣳⣗⡷⡯⣟⡾⣽⢦⡨⠐⡐⢐⠐⡐⢐⠐⠄⡑⠠");
            Console.WriteLine("⠅⠠⠀⠄⡊⡢⢡⠡⢂⢹⡽⡽⡯⣯⢷⣻⢈⠢⡑⡁⡂⡂⣺⢯⡯⣯⢯⡯⣯⣟⣗⣷⣳⢿⢽⢯⡯⣯⢯⡇⢐⠐⡐⢐⠠⠡⠨⢐⠠⢁");
            Console.WriteLine("⠨⠀⡁⢄⠪⡐⢅⠌⡐⣸⢯⣟⣯⢿⡽⣽⠠⡑⢌⢐⢐⠐⢼⡯⡿⣽⢽⣽⣳⣗⣟⣾⡺⣯⢿⢽⡽⡽⡯⡇⢐⢐⠠⢁⠂⠅⠌⠄⠌⡐");
            Console.WriteLine("⠊⠄⠠⢢⢑⢌⢂⠊⠄⢼⣻⢾⢽⡽⣽⢯⢂⢊⠢⢂⠢⠡⣹⢾⢯⡯⣟⣾⣺⣞⣗⣷⣻⢽⡽⣯⣻⣽⡻⡇⢐⠠⠨⠠⠨⠠⠡⠨⢐⠠");
            Console.WriteLine("⡈⢢⠩⡢⡑⠔⡡⠊⢌⢸⣽⢽⢯⢿⣝⡿⠐⢌⢌⠢⢈⢂⢺⡯⣯⣟⣗⣷⣳⣗⣟⣞⣾⣫⣟⣞⣗⣷⣻⠇⡐⠨⠠⠡⠨⠐⠡⠨⠐⡈");
            Console.WriteLine("⡈⠢⡱⡐⢌⠌⡄⠕⡐⢸⣞⡿⣽⣻⢾⣽⠨⡂⢆⢊⢐⠄⢽⢽⣳⣗⣟⣾⣺⣞⣗⣟⡾⣺⣳⣻⣺⣳⢯⠇⠄⠅⠌⠄⠅⠡⠡⠨⢐⠐");
            Console.WriteLine("⠨⠨⡐⢌⠢⡑⠄⠅⡂⢱⣗⣟⡷⡯⣟⣾⠐⢌⠢⢂⠢⢈⢺⡯⣷⣳⣻⣺⣞⣞⣗⡯⣯⣟⣞⣷⣻⣺⢯⢇⠨⠠⠡⠨⠈⠌⠄⠅⡂⠌");
            Console.WriteLine("⢕⠡⡡⢡⢑⠌⠌⡂⠌⡢⣟⡾⣽⢯⣟⣾⢈⠢⡑⡐⠌⠄⣳⣻⣳⣻⣺⣳⣗⣟⡾⣽⣳⣗⣟⣾⣺⢽⡽⡅⢂⠡⠨⠐⡁⠅⠌⡐⠠⢁");
            Console.WriteLine("⡢⡑⢌⠢⡁⡂⠅⡂⠅⢌⡷⡿⣽⢽⢾⣽⠠⡑⢌⠄⠅⢅⢪⣷⣻⢞⣷⣳⣗⣯⢯⡷⣳⣗⣟⣾⣺⢯⣟⠆⠂⠌⠄⠅⠂⢌⢐⠨⠈⠄");
            Console.WriteLine("⡊⢌⠌⡂⡂⡂⠅⡂⡑⠨⣯⢿⢽⢯⣟⣾⠐⢌⢂⠊⠌⠄⢽⢺⣞⣟⣾⣺⢾⣺⢯⡯⣷⣻⢞⣾⣺⣻⣺⠅⠡⠡⠨⠈⠌⡠⢂⠐⡁⠅");
            Console.WriteLine("⡨⢐⢐⢐⠐⢄⢑⢐⠨⡈⣫⢿⣽⣻⢾⢽⡈⡢⢡⠡⠡⠡⣹⠀⣗⣟⣾⣺⢯⡯⣯⢯⣗⣯⣟⣞⣗⣟⣾⠡⠨⠠⠁⠅⠡⢐⠠⠨⠐⡈");
            Console.WriteLine("⡂⡂⡂⡂⠅⡂⡂⡂⡂⠢⣨⣭⡬⣞⣯⢿⢐⠌⡂⡊⠌⡂⢺⠀⣿⣳⢗⣯⢯⡯⣯⣟⣞⡷⡽⣞⣷⡻⣾⠈⠄⠅⠡⠁⠅⡂⠌⠄⠅⠂");
            Console.WriteLine("⡂⡂⡂⡂⠅⡂⡂⠢⡈⠢⢸⡾⣽⣻⣞⣿⠐⢅⠪⠠⢑⠠⣹⢽⣳⢯⣟⡾⡯⣯⢷⣳⢯⡯⡿⣽⣺⡽⣽⠈⠄⠅⠡⢁⠅⡐⠨⠠⠡⠁");
            Console.WriteLine("⢂⢂⢂⠂⠅⡂⢌⢐⠨⠨⣞⣯⢷⣳⣟⣾⠡⡡⡑⡡⢁⢂⢺⢯⡯⣟⡾⡽⡯⣯⣟⣾⣫⡯⣟⣗⣯⢯⣟⠌⠠⠡⢁⠂⡂⠂⠅⠌⡐⠡");
            Console.WriteLine("⢂⢂⠂⠅⠅⡂⡂⠢⠨⠨⣗⣯⣟⣷⣳⢿⠨⡂⠪⢐⢐⠐⢼⢯⢿⢽⡽⡯⣟⣗⣷⣳⣗⡿⡽⡾⣽⢽⢾⠀⠅⠊⠄⡂⠂⠅⠡⢁⢂⠡");
            Console.WriteLine("⢂⠢⠨⡈⡂⠢⠨⠨⠨⡈⣿⣺⣞⡾⣞⣯⡣⢘⠌⡂⠢⠡⢹⡽⣯⢯⡯⣟⣗⣟⣾⣺⢾⢽⢯⢿⢽⣽⣻⠀⠅⠡⢁⠄⠅⡡⢁⠢⢐⠠");
            Console.WriteLine("⡐⠨⢐⢐⠨⠨⠨⡈⠢⠨⣞⣗⣯⢿⢽⣞⠆⢕⠨⠂⠅⢅⢹⣽⢽⢯⣻⡽⣞⣷⣳⢯⣟⡽⣯⢿⡽⡾⣽⠀⠅⠡⠂⡂⠡⢐⠐⡐⢐⠈");
            Console.WriteLine("⠨⠨⢐⢐⠨⠨⢐⠨⠨⡈⣿⣺⡽⣽⣻⣞⢇⢑⠌⡊⠌⡂⢺⡽⣽⢯⢷⣻⣳⣗⡯⣟⡾⣽⢽⣳⢿⢽⣳⠈⠌⠨⢐⠠⢁⢂⠂⡂⡂⠌");
            Console.WriteLine("⢅⢑⢐⢐⠨⠨⢐⠨⢐⠐⣟⡾⣽⣳⢷⢯⢇⠢⡑⠌⠢⠨⢸⡯⣯⢿⢽⣳⣻⣺⡽⡯⣯⢯⢿⢽⡽⡯⣟⠠⢁⠅⠂⠌⠄⢂⠂⡂⠄⠅");
            Console.WriteLine("⡐⡐⡐⡐⠨⠨⢐⠨⠠⢑⡯⣟⡷⣯⣟⣯⠇⡌⡢⠡⡑⠡⢹⣽⢽⢯⢿⢽⣺⣗⡿⡽⡯⡿⡽⣯⢯⢿⣽⠈⠄⠌⠨⠠⢁⢂⠂⡂⠅⠌");
            Console.WriteLine("⢂⢂⠢⠨⠨⡈⠢⠨⠨⢐⡯⣯⡯⣷⣳⡯⡇⡢⢊⢌⢐⠅⣹⣞⡿⣽⣻⣽⣳⣗⡿⣽⢯⢿⡽⡯⡿⡽⣾⠀⠅⢊⠨⠈⠄⡂⢂⠂⢌⠐");
            Console.WriteLine("⠅⡂⠌⠌⡂⠌⠌⠌⢌⠂⣟⣷⣻⡽⡾⡝⢁⠌⠐⠀⠂⠐⢀⠠⠐⢀⠐⢀⠐⠈⠌⢉⠉⡉⠉⠍⠍⠍⠓⠁⠌⡐⠠⠡⠡⢐⠐⠨⢀⢂");
            Console.WriteLine("⠢⠨⡈⠢⠨⠨⠨⡈⡢⠨⣻⣞⡷⠛⢁⠐⠀⠐⠈⡀⢁⠈⡀⠠⠐⠀⡀⠂⢀⠁⠄⠠⠀⠄⢈⠠⠐⠀⡈⢀⢁⠂⠅⢊⠐⡐⠨⢈⢐⠠");
            Console.WriteLine("");
            Console.WriteLine("당신은 또다른 복도에 들어왔습니다...");
            BTWS();
            Console.WriteLine("정면과 왼쪽에는 각각 방이 있습니다...");
            BTWS();
            Console.WriteLine("어디로 향하겠습니까...");
            BTWS();
        go7:
            Status.Line();
            Console.WriteLine("[1] 정면의 방으로 가고싶다면 1번을 눌러주세요...");
            Thread.Sleep(300);
            Console.WriteLine("[2] 왼쪽의 방으로 가고싶다면 2번을 눌러주세요...");
            Thread.Sleep(300);
            Console.WriteLine("[3] 왔던 길을 되돌아가고싶다면 3번을 눌러주세요...");

            string input12 = Console.ReadLine();
            Console.Clear();
            switch (input12)
            {
                case "1":
                    Laundryr();
                    break;
                case "2":
                    Anotheroom();
                    break;
                case "3":
                    EnterLeftCorridor();
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    goto go7;
            }
        }

        private static void Anotheroom()
        {
            Console.Clear();
            Status.EnterField(player);
            Status.Line();
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣖⢶⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣠⢤⣴⢲⣫⣫⣾⢯⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣠⢤⢴⣺⠽⠓⠋⢉⠈⢿⢱⡐⣎⣿⡠⠤⠤⣤⢄⣀⣀⢀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⡴⣦⢴⢺⣹⢼⢼⡯⡐⡀⡜⢍⢇⣠⡪⠗⠋⢁⣀⠤⠖⣋⡥⠞⠉⠀⡁⢍⢝⢙⠝⢝⠚⠒⢒⠒⠦⢤⣀⠀⠀");
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⢹⢿⣼⢙⠌⢆⢣⢳⣗⡤⣝⣑⢧⣳⡠⠔⣊⣩⠤⠒⠍⠂⢀⢄⢢⠱⡘⢔⠑⡈⢈⠠⢀⢁⢄⠢⡊⣆⡍⢧⠀");
            Console.WriteLine("⠀⠀⠀⡔⣌⢄⠥⡀⠀⢸⣻⣺⣔⠽⠜⠚⠉⣁⣠⡇⡕⢝⡤⠖⠋⠁⠄⢀⠡⡐⢜⢐⠅⡆⠃⠊⠀⢄⠠⡂⡢⡑⡱⣨⠮⠚⢁⠠⢸⠀");
            Console.WriteLine("⠀⠀⢐⠞⡎⠨⠀⢱⢤⢌⣿⡊⠀⠐⢠⠞⢋⠵⢊⣎⢥⠤⡮⠇⡈⢄⢪⠨⡪⡘⠌⢂⠡⠀⡌⠔⡅⡣⣑⣌⡦⠗⠋⢁⠀⡁⣄⡴⡯⠀");
            Console.WriteLine("⠀⠀⣐⠀⡆⠈⠂⢌⢎⢎⠭⣓⢦⢥⢸⠀⡏⠜⠲⠢⡤⣅⣢⣒⣸⡨⣂⢑⠀⡐⠈⢀⢔⣱⠼⠼⠒⡋⠁⠂⡀⠄⣂⡶⡺⡹⡱⡑⡭⠀");
            Console.WriteLine("⢐⡯⣎⡳⡸⢆⢇⣗⡵⢵⣛⡎⡧⡽⣺⣤⣗⣨⣠⣡⣂⣄⣣⣱⠱⡉⠌⠩⠡⠐⡈⢷⢑⢔⠀⣂⣡⡤⡬⡴⡴⡺⡕⡕⣕⡵⠜⠚⠃⠀");
            Console.WriteLine("⢸⢪⢪⣛⢺⣳⢽⢲⢫⣯⢆⣧⢽⡪⡧⣇⣎⣎⢎⢎⢎⢮⢪⢝⢝⡳⡺⡦⡧⡦⣔⣝⢜⡼⡺⡱⡕⡕⡵⣱⣱⠵⠓⠋⠁⠀");
            Console.WriteLine("⢸⢪⢣⢪⢪⡯⣇⣧⢗⡾⡽⡺⣩⣟⠄⠀⠈⠈⠉⠋⠓⠳⠧⢧⣣⣣⡣⡣⡣⡫⣒⢼⡣⡣⡣⣣⣣⠗⠋⠁⠀⠀⠀");
            Console.WriteLine("⢸⢮⡺⣘⢆⡯⣗⢏⢇⣟⢷⡳⠝⡾⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠁⠉⠉⠃⠓⠓⠧⠧⠗⠋⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.WriteLine("⢸⢝⠉⠮⢖⣽⣳⡫⠟⠊⠁⠀⠀⡿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.WriteLine("");
            Console.WriteLine("작은방에 들어왔습니다...");
            BTWS();
            Console.WriteLine("작은 침대와 책상이 놓인 방입니다...");
            BTWS();
            Console.WriteLine("공간이 넓지 않아 크게 둘러볼것은 많지 않네요 ...");
            BTWS();
            Console.WriteLine("어디로 향하겠습니까...");
            BTWS();
        go8:
            Status.Line();
            Console.WriteLine("[1] 책상을 살펴보려면 1번을 눌러주세요...");
            Thread.Sleep(300);
            Console.WriteLine("[2] 침대를 살펴보려면 2번을 눌러주세요...");
            Thread.Sleep(300);
            Console.WriteLine("[3] 밖으로 되돌아가려면 3번을 눌러주세요...");

            string input15 = Console.ReadLine();
            Console.Clear();
            switch (input15)
            {
                case "1":
                    Random rand = new Random();
                    int randValue = rand.Next(0, 101);
                    if (randValue <= 20)
                    {
                        var item = Item.items.Find(i => i.iname == "낡은총");
                        if (item != null)
                        {
                            Player.Getitem(item);
                            BTWS();
                            Console.WriteLine("⠀⠀⠀⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⡀⠀⠀⠀⠀⠀⠀");
                            Console.WriteLine("⠀⢴⡿⡍⡎⡎⣜⢬⢪⢜⢌⢎⢬⢪⢌⢎⢬⢪⡸⣨⢪⢢⡱⡌⣆⢕⢔⢥⡱⡅⡧⡱⣅⢧⢕⢵⡱⣕⢽⣸⡱⡭⡣⡧⡭⣵⠀⠀⠀");
                            Console.WriteLine("⠀⢯⡿⡸⡪⡣⣇⢇⢗⢵⢕⡝⡜⡮⡪⡧⡳⡱⡕⡵⡱⣣⢳⢕⢵⢹⢪⡣⡳⡹⣜⠵⡕⡧⣫⡺⣺⢪⢯⣺⡪⣯⡫⣞⢵⣻⠀");
                            Console.WriteLine("⠀⢱⡿⣱⣹⣸⣜⣜⣕⣕⣕⣵⣹⣸⣪⢪⢎⢧⢫⢮⢾⣘⣊⣣⡳⡹⡜⡮⡝⡮⣪⢏⣮⡫⡮⣺⡪⣏⡗⣗⢽⢺⡪⡗⡗⣽⠀");
                            Console.WriteLine("⠀⢸⣯⢯⣗⣯⣾⢽⣽⢽⣽⣺⣽⢽⣞⣗⡯⣞⣗⣗⣗⣗⡯⡾⣽⢽⣺⢽⣺⢽⣺⢽⣖⣧⣟⣞⣞⣞⢾⢵⢯⣗⣯⢿⠽⠫⠇⠀");
                            Console.WriteLine("⠀⠀⠙⠙⠓⠛⠊⠉⠚⠛⠚⠓⠏⠻⠹⠚⠻⢽⣾⣾⡾⠞⠻⠽⠞⡿⣾⣽⢾⣽⣺⢽⣺⣺⣺⣺⣺⢮⡯⡯⣗⡿⡞⠁⠀⠀");
                            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡳⡇⠀⠀⠀⠀⠀⢨⣞⣞⡽⡿⣾⣻⢮⢗⡟⡮⢯⡳⣫⢯⣟⡿⡇⠀⠀⠀⠀");
                            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢼⡃⠀⠀⠀⠀⢠⣺⠮⠊⠀⣸⣿⣽⢯⣷⣻⢮⡷⣽⣺⢽⣺⣽⣧⠀⠀⠀⠀⠀⠀⠀");
                            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⢯⣻⢤⣀⣀⣀⣛⣉⣀⢤⡲⠯⢾⣻⣽⢿⢽⣳⢯⣗⡯⡯⣗⡷⣿⡆⠀⠀⠀⠀⠀⠀");
                            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠈⠉⠈⠁⠉⠈⠁⠉⠁⠁⠀⠀⠹⣾⣻⣽⣺⣳⣳⢯⣟⡽⣽⣳⣿⠄⠀⠀⠀⠀⠀");
                            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀ ⢹⣷⣳⢷⢽⣺⣽⣺⢽⣳⣳⣟⣿⡀⠀⠀⠀⠀");
                            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢾⡽⣯⣻⢞⣾⣺⣽⣳⣗⣷⣻⢿⡄⠀⠀⠀");
                            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀ ⠀⠈⢾⡽⣯⣻⢞⣾⣺⣽⣳⣗⣷⣻⢿⡄⠀⠀⠀");
                            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀ ⠀⠀⠈⢾⡽⣯⣻⢞⣾⣺⣽⣳⣗⣷⣻⢿⡄⠀⠀⠀");
                            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⣯⡷⡯⣟⡾⡵⣗⣷⡳⣗⣯⣟⣿⡄⠀⠀");
                            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⠽⠳⠳⠳⠳⠳⠳⠳⠟⠆⠀⠀⠀");
                            Console.WriteLine("");
                            Console.WriteLine("당신은 낡은총을 얻었습니다. 이것이 왜 필요한지는 알 수 없지만... ");
                        }
                    }
                    else
                    {
                        BTWS();
                        Console.WriteLine("");
                        Console.WriteLine("아무것도 발견하지 못했습니다... ");
                    }
                    goto go8;
                case "2":
                    Console.WriteLine("아무것도 발견하지 못했습니다... ");
                    goto go8;
                case "3":
                    Corridor2();
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    Thread.Sleep(1000);
                    goto go8;
            }
        }

        private static void Laundryr()
        {
            Console.Clear();
            Status.EnterField(player);
            Status.Line();
            Console.WriteLine("⡇⡎⢮⡪⡯⣪⢗⢗⣝⢮⣫⡺⡱⡱⡱⡱⡑⡕⡅⡇⢄⢑⠡⠡⠘⡈⡂⠌⠅⢂⠡⠑⡁⢂⠑⠡⠠⢁⢊⢐⢐⠨⠈⠔⡈⠅⠡⡈⡑⡀");
            Console.WriteLine("⠘⠘⠘⠊⠋⠊⠓⠙⠜⠊⠒⠙⠊⠊⠂⠃⠃⠑⠑⠑⠑⠀⠂⠁⡈⠄⠂⠈⠄⠁⠂⠁⠐⠀⢁⠡⠈⠀⠂⠐⠀⠂⠁⠁⠐⠈⠐⠀⠂⠘");
            Console.WriteLine("⠄⠄⠄⢂⠠⠁⠄⠄⠄⣔⢤⠡⠄⠢⠐⠄⠢⠰⠠⠰⠠⠢⠰⠠⠄⠤⠠⠤⠄⠢⠄⠢⠰⠠⠤⠠⠄⠌⠤⠐⠄⠢⠰⠠⠢⠰⠠⣢⠔⠀");
            Console.WriteLine("⠀⠁⠈⠀⠀⠁⠈⠀⠁⡯⡅⠀⠀⠀⠀⠀⠀⡀⠄⠀⡀⢀⠀⡀⢀⠀⡀⢀⠀⠠⠀⠄⠀⠠⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢵⡣⠀");
            Console.WriteLine("⠀⠁⠀⠀⠄⠀⠄⠀⠐⡽⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠄⠀⠄⠀⠄⡀⠀⠀⢀⠐⠐⠐⠐⠐⠂⠐⠒⠀⠐⠀⢀⠀⡀⠀⠀⢺⡢⠀");
            Console.WriteLine("⠀⠂⠈⠀⠀⠀⠀⠀⠈⣯⠂⠀⠐⠈⠂⠑⡈⠂⠒⠐⢁⠐⠀⠂⠐⠀⠂⠐⠠⢐⠁⠠⠑⠀⠐⠐⠀⠂⠂⠀⠀⠁⠀⠀⠀⠀⠀⢵⡣");
            Console.WriteLine("⠀⠀⠀⡀⠠⠀⠁⠀⠈⣞⠆⠂⠂⠂⠈⠐⠐⠈⠐⠁⠂⠂⠁⠊⢀⠑⢀⠑⠈⠄⠂⠁⠂⠂⠂⠂⠂⠂⠂⠈⠐⠐⠐⠐⠀⠁⠂⢕⡇⠀");
            Console.WriteLine("⠀⠈⠀⠀⠀⠀⠀⢀⠈⣞⠆⠀⠀⠀⢀⠁⠐⠈⠀⠂⠐⠀⢁⠐⠀⠠⠀⡀⠂⠐⠀⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢕⡇⠀");
            Console.WriteLine("⠈⠠⠀⠄⠂⠠⠈⠀⠠⣻⠄⠀⠀⠐⠀⠠⠈⢀⠈⡀⢈⠠⠀⡀⡂⡐⠄⠄⠂⠅⠄⠄⠄⡀⡀⠀⠀⠀⠀⠀⡀⠄⠀⠀⡀⠄⠀⢵⡣⠀");
            Console.WriteLine("⠀⠄⠀⠀⠀⠀⠀⢀⠠⣳⠅⠀⢀⠁⢈⠀⠐⠀⡀⠄⡠⠐⠈⢀⠀⢀⠠⠀⠂⠠⠐⠀⠄⢀⠈⠐⠠⡀⠁⠀⠀⠀⠀⠀⠀⠀⠀⢺⡢⠀");
            Console.WriteLine("⠀⠀⢀⠀⠂⠀⠈⠀⠀⡷⡁⠀⠄⠐⠀⡀⢁⠠⠐⠀⠄⠐⢈⡠⣔⢖⡮⣮⣫⣞⢮⢮⡲⡤⣀⠁⢔⠨⠢⣀⠀⠀⠀⠀⢣⢳⠁⢜⡆⠀");
            Console.WriteLine("⠁⠀⠀⠀⠀⠀⠄⠀⠐⣝⠆⠀⠐⠀⠁⡀⠄⠂⠁⠐⡠⣪⢞⣞⣾⣫⣟⣞⡷⡽⣯⢯⣟⡾⣵⡫⡦⡑⡑⡐⢅⠄⠀⠂⠀⠀⠀⡱⡇");
            Console.WriteLine("⠠⠐⠀⠐⠈⠀⠀⠀⠈⣞⡂⠀⢁⠀⡁⡐⠀⠂⢁⢮⢽⣺⢯⡷⣗⣟⣞⣗⡿⣽⢽⣽⣺⢽⣳⢿⢵⡪⡢⢡⠑⢌⠄⠀⠀⠀⠀⡪⡇");
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠐⠈⣗⠅⠀⠠⠀⡐⠀⠐⢈⢮⣳⣟⣽⢽⢾⣽⣺⣳⡻⣺⢽⠽⠮⡮⣫⡯⡿⣽⢽⣪⢢⠑⢅⠪⡀⠀⠀⠀⡺⡕⠀");
            Console.WriteLine("⠀⠐⠀⠈⠀⠀⠁⠀⢀⢷⡁⠀⠂⠠⡑⡨⠠⣝⡵⣟⡾⣽⢽⡫⡺⣜⢲⡹⡸⡜⠅⢕⢨⠳⠹⣹⡽⣽⣳⡕⡅⢕⢨⢢⠀⠀⠀⣪⢇⠀");
            Console.WriteLine("⠀⠀⠄⠀⠠⠀⠠⠀⢀⢯⡂⠀⡈⠠⠑⠈⠸⡪⣯⢯⣟⡮⣣⢫⡺⡸⣪⢪⡣⢃⢑⢔⠝⢌⠪⡂⣟⣗⣟⡮⡊⡳⣝⢮⠀⠀⠀⡪⡇⠀");
            Console.WriteLine("⠀⠄⠀⠀⢀⠀⠀⠀⢀⢯⡂⠀⠠⢐⢀⠠⢨⢯⣞⣟⡾⣝⡜⣕⢵⢹⢜⢎⠢⠡⡪⡪⢊⢔⢱⢸⢵⣻⣞⡗⠀⡕⡧⣳⠀⠀⠀⣪⢇");
            Console.WriteLine("⠀⠀⠀⠈⠀⠀⠀⠈⠀⡯⡂⠀⠄⠂⡅⢅⠕⡕⣗⣟⣞⡷⣱⢣⡳⡕⡇⢅⢊⢜⢎⠰⡘⢄⢧⣫⢯⣷⣳⠏⢌⢮⡫⣎⠀⠀⠀⡪⡇⠀");
            Console.WriteLine("⠀⠈⠀⠀⡀⠄⠀⠂⠀⣿⠀⠀⠄⠂⠪⡐⢅⠪⡪⣗⣯⢯⡷⣕⢵⠱⠨⡐⡜⢕⠠⡣⢱⡹⣼⣺⣻⣺⠞⢀⢪⡳⡝⠆⠀⠀⠀⣪⢇⠀");
            Console.WriteLine("⠀⠐⠀⠀⠀⠀⠀⠀⠠⣻⠄⠁⢀⠐⠈⡢⢑⠌⡢⢣⢻⣽⢽⣳⢧⡥⣱⡸⡡⣑⢜⣰⣳⢽⣞⣾⡳⠏⢈⢴⡹⣪⡋⠀⠀⠀⠀⡪⡇");
            Console.WriteLine("⠠⠀⠀⠐⠀⠀⠐⠀⠠⣳⠅⠀⠠⠀⠂⠈⠢⡑⠌⡌⡪⡚⡽⡽⡯⣟⣗⣯⣟⡾⣽⣺⡽⣽⢾⠚⠁⡌⡮⡺⣪⠃⠀⠀⠀⠀⠀⣪⢇");
            Console.WriteLine("⠀⠠⠈⠀⠀⠀⠂⠀⠠⣳⠅⠀⠂⠐⠀⠁⠀⠘⢌⢦⢳⢕⣅⢈⠉⠛⠺⠳⠗⡟⠗⠏⠋⡁⢡⢰⠵⡝⡮⡫⠂⠀⠀⠀⠀⠐⠀⢼⢅⠀");
            Console.WriteLine("⠈⠀⠀⠀⠀⠂⠀⠀⠠⣳⠅⠀⠐⠈⠀⠀⠀⠀⠀⠑⠝⣕⢗⣝⢮⡲⣢⠦⡤⡤⣢⡲⡕⣎⢗⡵⡝⠎⠈⠀⠀⠀⠀⠀⠁⠀⠀⡪⡇");
            Console.WriteLine("⠠⠀⠀⠂⠀⠀⠄⠂⠀⡿⡀⠀⡁⠀⠀⠀⠄⠂⠀⠀⠀⠀⠁⠓⠕⢝⠮⡫⢮⢫⢎⠮⠺⠊⠃⠁⠀⠀⠀⠀⢀⠀⠀⠄⠀⠀⠀⣪⢇⠀");
            Console.WriteLine("⠀⠀⢀⠠⠀⠀⡀⠀⠠⣻⠄⠀⠀⠀⠀⡀⠀⠀⠀⠀⢀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠠⠐⠀⠀⠀⠀⠀⠀⠀⠀⡪⡇⠀");
            Console.WriteLine("⠀⠄⠀⠀⠀⠀⠀⠀⠠⣳⠅⠀⠀⠠⠀⠀⠀⠀⠀⡀⠀⠀⠀⠠⠀⠀⠀⢀⠠⠀⠁⠀⠀⡀⠄⠀⠂⠀⠀⠀⠀⠀⠄⠐⠀⠁⠀⡪⡇");
            Console.WriteLine("⠄⠀⠀⡀⠄⠂⠀⠂⠀⣯⠂⠀⠀⠀⠀⠀⠀⠠⠀⠀⠀⠀⠠⠀⠀⠀⠈⠀⠀⠀⠀⠀⠁⠀⠀⠀⠀⠀⠀⠀⠠⠀⠀⠀⠀⠀⠀⡪⡇⠀");
            Console.WriteLine("⠀⢀⠀⠀⠀⠀⠀⠀⠐⣽⢱⠸⡰⡱⡸⡰⣑⢲⢰⠱⡸⡰⢱⠰⡱⡸⡰⡒⣒⢢⠣⡪⡒⡢⡱⡸⢰⠱⡸⡨⡢⡢⡣⡪⢢⠣⡢⡫⡇");
            Console.WriteLine("⢌⡀⡄⢄⢄⢄⣐⢠⢐⡽⡊⢌⢂⢊⠔⡨⢐⠌⡂⠕⡨⡈⡢⢑⠌⡂⡢⢑⢐⠡⡑⠌⡂⠕⡨⠨⡂⢅⠕⡈⡢⢑⢐⠌⡢⠡⡡⣹⠕⠀");
            Console.WriteLine("⠂⡐⢈⠀⡂⠐⡀⠂⡁⢈⠐⡀⢂⠐⡀⢂⠐⡀⢂⠡⠀⢂⠐⡀⢂⠐⡀⠂⠄⠡⢀⠡⠀⠅⠠⢁⠐⡀⢂⠐⡀⢂⠐⡀⢂⠁⠄⠂⡁⠂");
            Console.WriteLine("");
            Console.WriteLine("사용하지 않은지 오래되어보이는 세탁기가 있는 이곳은...");
            BTWS();
            Console.WriteLine("세탁방으로 보이는군요...");
            BTWS();
            Console.WriteLine("이곳에 있는 물건이라곤 낡은 세탁기 하나 뿐입니다...");
            BTWS();
            Console.WriteLine("어디로 향하겠습니까...");
            BTWS();
        go6:
            Status.Line();
            Console.WriteLine("[1] 세탁기를 살펴보려면 1번을 눌러주세요...");
            Thread.Sleep(300);
            Console.WriteLine("[2] 복도로 돌아가려면 2번을 눌러주세요...");
            string input14 = Console.ReadLine();
            Console.Clear();
            Random rand = new Random();

            switch (input14)
            {
                case "1":
                    int randValue = rand.Next(0, 101);
                    if (randValue <= 50)
                    {
                        var item = Item.items.Find(i => i.iname == "집키2");
                        if (item != null)
                        {
                            Player.Getitem(item);
                            BTWS();
                            Console.WriteLine("");
                            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀   ⠀⠀⠀⠀⠀⢀⢀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀   ⠀⠀⠀⢀⢦⠯⠻⠻⠻⢿⡾⣦⣀⠀⠀⠀⠀⠀");
                            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀   ⠀⠀⠀⢀⣤⢼⢊⠀⠀⠀⠀⠀⠈⠛⢿⣷⡀⠀⠀⠀");
                            Console.WriteLine("⠀⠀⠀⠀⣺⣿⢿⣻⣟⣟⡿⣝⣟⢻⣛⢏⡟⡟⢏⢋⡋⡙⡕⡃⣣⢊⢮⢒⢒⠒⢒⢲⠲⢾⡞⢜⡎⡢⢀⠀⠀⠀⠻⣿⡀⠀⠀");
                            Console.WriteLine("⠀⠀⠀⠀⣷⡿⣟⣿⣯⡟⠟⠯⠯⠟⠛⠛⠛⠛⠯⠳⠻⠳⠳⠿⠻⠷⠿⠟⠿⠿⠽⠾⠯⣿⣿⡖⢬⠚⠑⠀⠀⠀⢿⠪⠀⠀");
                            Console.WriteLine("⠀⠀⠀⢐⣯⣿⣟⣿⣷⣿⣝⣮⡲⡂⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠻⢿⡐⠀⠀⠀⠀⠀⠀⠀⠀⢀⠟⠀⠀⠀");
                            Console.WriteLine("⠀⠀⠀⠸⣿⡟⣽⣿⢽⣾⣻⠹⣾⡁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠐⢻⣦⣠⡀⠀⡀⡀⡠⡰⡁⠂⠀⠀");
                            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠈⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠙⠛⠟⠛⠋⠊⠀⠀⠀⠀⠀⠀");
                            Console.WriteLine("");
                            Console.WriteLine("당신은 집키2를 얻었습니다. 이것이 왜 필요한지는 알 수 없지만... ");
                            BTWS();
                            Console.WriteLine("이것이 당신에게 이로운 일일지 ...알 수 없군요... ");
                            Status.Line();
                        }
                    }
                    else if (randValue > 50 && randValue < 65)
                    {
                        var item = Item.items.Find(i => i.iname == "지하실열쇠");
                        if (item != null)
                        {
                            Player.Getitem(item);
                            BTWS();
                            Console.WriteLine("");
                            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀   ⠀⠀⠀⠀⠀⢀⢀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀   ⠀⠀⠀⢀⢦⠯⠻⠻⠻⢿⡾⣦⣀⠀⠀⠀⠀⠀");
                            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀   ⠀⠀⠀⢀⣤⢼⢊⠀⠀⠀⠀⠀⠈⠛⢿⣷⡀⠀⠀⠀");
                            Console.WriteLine("⠀⠀⠀⠀⣺⣿⢿⣻⣟⣟⡿⣝⣟⢻⣛⢏⡟⡟⢏⢋⡋⡙⡕⡃⣣⢊⢮⢒⢒⠒⢒⢲⠲⢾⡞⢜⡎⡢⢀⠀⠀⠀⠻⣿⡀⠀⠀");
                            Console.WriteLine("⠀⠀⠀⠀⣷⡿⣟⣿⣯⡟⠟⠯⠯⠟⠛⠛⠛⠛⠯⠳⠻⠳⠳⠿⠻⠷⠿⠟⠿⠿⠽⠾⠯⣿⣿⡖⢬⠚⠑⠀⠀⠀⢿⠪⠀⠀");
                            Console.WriteLine("⠀⠀⠀⢐⣯⣿⣟⣿⣷⣿⣝⣮⡲⡂⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠻⢿⡐⠀⠀⠀⠀⠀⠀⠀⠀⢀⠟⠀⠀⠀");
                            Console.WriteLine("⠀⠀⠀⠸⣿⡟⣽⣿⢽⣾⣻⠹⣾⡁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠐⢻⣦⣠⡀⠀⡀⡀⡠⡰⡁⠂⠀⠀");
                            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠈⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠙⠛⠟⠛⠋⠊⠀⠀⠀⠀⠀⠀");
                            Console.WriteLine("");
                            Console.WriteLine("당신은 지하실열쇠를 얻었습니다. 이것이 왜 필요한지는 알 수 없지만... ");
                            Status.Line();
                        }
                    }
                    else
                    {
                        BTWS();
                        Console.WriteLine("");
                        Console.WriteLine("아무것도 발견하지 못했습니다... ");
                        Status.Line();
                    }
                    goto go6;
                case "2":
                    Corridor2();
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    Thread.Sleep(1000);
                    goto go6;
            }
        }

        private static void Kitchen()
        {
            Console.Clear();
            Status.EnterField(player);
            Status.Line();
            Console.WriteLine("⠀⠀⠀⠀⣀⣀⣀⣀⣀⣀⣀⣀⣀⣄⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.WriteLine("⡀⠀⢀⠨⡇⡈⡂⠅⡊⠄⡑⠨⠐⢄⢑⢽⠀⠀⠄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡀");
            Console.WriteLine("⠀⠀⠀⠨⡇⢐⠠⡁⡂⠅⠌⠌⠌⡐⠰⣸⠠⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠀⠂⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡀⠀");
            Console.WriteLine("⠀⢀⠀⠸⡅⢽⠐⡐⠠⠡⡁⠅⠅⠌⢌⢼⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.WriteLine("⠂⠀⠀⢨⠇⠹⢐⠨⢈⢂⠂⠅⡡⢁⠢⣹⠀⠀⠁⠀⠠⠀⠀⡀⠄⢀⠈⠄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠐⠀");
            Console.WriteLine("⠀⠀⠀⢨⢧⢳⢲⢜⣖⣖⡼⣲⢲⢲⢕⢾⠀⠁⠀⢀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠄⠂⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡀⠀");
            Console.WriteLine("⠐⠈⠀⠨⡗⠓⢓⠣⠓⡒⠓⠕⠝⢚⠪⢻⠀⠀⠄⠀⢀⣢⡥⡿⣵⢴⣄⢄⡄⠅⠀⠀⠀⢀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠄⠀⠀⠀");
            Console.WriteLine("⠀⠀⠀⢨⠇⡨⡐⠠⡁⡂⠅⠅⠅⡂⡊⣺⠀⢀⠀⠀⣶⠀⡐⠈⡀⢐⢸⠓⠁⠀⠀⠀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠐⠐⠁⠂⠁⠂⠂⠂");
            Console.WriteLine("⠀⠈⠀⠨⡇⢝⠄⠅⡂⡂⠅⠅⡡⠂⢌⢼⠀⢀⣀⣀⣐⣥⢤⡦⡴⣤⢞⣀⣀⣀⣠⣀⣀⣀⣀⣀⣀⣀⣀⣀⣀⣀⣠⣀⡠⠀⠂⠀⠀⠠");
            Console.WriteLine("⠀⠀⡀⠸⡅⢽⠠⡁⡂⡂⠅⡡⢐⠨⢐⢼⠀⢸⠸⠼⠼⠬⠡⠩⡈⠪⠵⡱⠵⢱⡣⠡⠡⠡⡑⢭⠨⡈⡊⠌⢺⠨⠨⡈⣺⠀⠁⠀⠐⠀");
            Console.WriteLine("⠠⠀⠠⠨⡇⢙⢐⢐⢐⠠⢁⢂⠢⢈⠢⢺⠀⢸⠹⡙⢝⢹⣙⢝⡹⣙⢝⢙⠝⡹⡎⡫⡫⢏⠫⡫⢫⢫⢋⠫⢫⠫⡏⡫⢳⠀⠀⠄⠀⠀");
            Console.WriteLine("⠈⠠⠀⠬⡇⢂⠂⡂⠔⠨⢐⢐⠨⢐⠨⢺⠀⢸⠨⢂⢕⢌⢔⢅⢥⡡⡱⣠⢑⢌⡇⢎⠉⡁⡇⡝⢜⠡⠉⢹⢸⢘⠅⣹⢸⠀⠀⠀⠀⠈");
            Console.WriteLine("⠄⠀⠐⠨⡇⢐⠨⠠⠡⢁⢂⠂⢌⠐⢌⢺⠀⢸⠨⡺⠀⡂⢐⠐⠀⠠⠀⠂⡇⡢⡇⡣⠢⡢⢣⢹⢸⠀⠅⢪⢺⢘⢐⢸⣸⠀⠀⠈⠀⠀");
            Console.WriteLine(" ⠀⠀⠀⢨⠇⡐⠨⡈⠌⡐⠄⡑⠄⡑⡐⣹⠀⢸⠨⢺⠀⢂⠂⠀⠌⠠⠨⠀⡇⢪⡫⡨⡫⣍⠕⣝⢰⠠⢁⢪⢪⢪⠐⢸⢸⠀⠀⠀⠂⠀");
            Console.WriteLine("⠀⠀⠀⠨⡇⠨⠐⠄⠅⡂⠅⡂⠅⡂⢌⢼⠀⢸⠨⠺⡠⣂⢄⡡⣠⢡⡂⣅⠇⢕⡇⡪⠐⡀⡇⢧⢱⢈⢐⢸⢸⢘⠌⢸⢹⠀⠀⠠⠀⠀");
            Console.WriteLine("⣀⣀⣀⢸⣅⡊⣌⢌⣂⣂⢅⣂⢅⣂⡢⣱⣁⢸⣌⣎⣬⣰⣡⣪⣰⣡⣌⣆⣥⡱⣇⣒⣕⣒⣃⣧⣑⣒⣒⡪⣺⣘⢜⣚⢼⣀⣀⣀⠀⠀");
            Console.WriteLine("⠁⠈⠈⠈⠀⠁⠁⠁⠈⠀⠁⠈⠈⠀⠁⠁⠈⠈⠀⠁⠀⠁⠈⠀⠁⠀⠁⠈⠀⠁⠁⠁⠀⠁⠈⠀⠁⠈⠀⠁⠁⠈⠈⠈⠈⠀⠈⠈");
            Console.WriteLine("");
            Console.WriteLine("부엌에 도착했습니다...");
            BTWS();
            Console.WriteLine("당신은 배가 고프지만 먹을 수 있는 것은 찾기 힘들어 보입니다...");
            BTWS();
            Console.WriteLine("바로 앞에 싱크대와 냉장고가 보입니다...");
            BTWS();
            Console.WriteLine("다시 부엌 밖으로 나갈수도 있습니다...");
            BTWS();
            Console.WriteLine("어디로 향하겠습니까...");
            BTWS();
        go9:
            Status.Line();
            Console.WriteLine("[1] 싱크대를 살펴보려면 1번을 눌러주세요...");
            Thread.Sleep(300);
            Console.WriteLine("[2] 냉장고를 살펴보려면 2번을 눌러주세요...");
            Thread.Sleep(300);
            Console.WriteLine("[3] 복도로 돌아가고싶다면 3번을 눌러주세요...");
            string input13 = Console.ReadLine();
            Console.Clear();
            Random rand = new Random();

            switch (input13)
            {
                case "1":
                    int randValue = rand.Next(0, 101);
                    if (randValue <= 30)
                    {
                        var item = Item.items.Find(i => i.iname == "부엌칼");
                        if (item != null)
                        {
                            Player.Getitem(item);
                            BTWS();
                            Console.WriteLine("⠀⠄⠂⠠⠠⠀⠄⠐⡀⠄⠠⠀⠄⠠⠠⠐⠀⠄⠂⡀⢂⠠⠐⢀⠐⡀⠄⠂⡀⠂⠄⠂⠄⠂⠠⠐⢀⠂⠄⠠⠐⠀⠄⠂⡀⠂⠠⠐⢀⠐");
                            Console.WriteLine("⠈⠠⠁⠌⠠⠈⠄⠁⠄⠐⠀⢂⠈⠄⠂⡈⠄⢁⠂⡐⠠⠐⠈⡀⢂⠀⡂⢐⠀⡁⠂⡁⠂⠡⢈⠐⡀⡂⢌⠀⠂⡁⠄⢁⢀⠡⠐⠈⡀⠐");
                            Console.WriteLine("⠁⠌⠐⡈⡀⢂⠈⡐⠈⡀⠡⠀⢂⠈⠄⠠⢈⠠⠠⠐⠀⠌⠠⠐⡀⢐⠠⠐⢀⠂⢁⠠⢈⢔⣔⢮⡺⡭⡳⡽⣝⢮⡳⣲⡢⣔⢄⠁⠄⢁");
                            Console.WriteLine("⠀⠅⠂⠄⠐⡀⢐⠀⢂⠐⡀⠡⠀⢂⠨⠀⡂⠄⠂⠌⠠⠁⢂⠐⡀⠂⠄⡈⠠⢐⢤⢮⡫⣗⢵⣫⢞⡵⣫⢞⢮⡳⣝⢮⡺⡕⠏⢕⠡⡐");
                            Console.WriteLine("⠐⢈⠠⠈⠄⠐⡀⢐⠠⠐⠀⠂⡁⠄⠐⡀⠂⠄⠡⠈⠄⠡⠀⢂⠐⢈⢠⣰⡺⡽⡽⡵⣻⡪⣗⡽⣕⢯⡺⡭⣣⢯⣪⠳⡑⠡⡡⠡⠊⠠");
                            Console.WriteLine("⠂⡐⢀⠡⠈⠄⢐⢀⠐⡈⠈⠄⠄⠂⠁⠄⠡⠈⠄⠡⠈⠄⠡⢐⡠⣖⣗⢗⡽⡽⣺⢽⣪⢯⢞⡮⣳⢝⡮⡯⣺⢪⢊⠢⠨⡨⢂⠡⠈⠄");
                            Console.WriteLine("⠁⠄⠂⡐⠈⠄⢂⠀⡂⠄⠡⠐⡀⠅⠨⠀⠅⠨⠀⠅⠌⣐⣕⣮⣻⣺⡪⣯⣫⢯⢞⣗⢗⡽⣳⢝⣞⡵⣫⢞⢑⠔⡐⡡⠃⠂⠄⠐⡈⠠");
                            Console.WriteLine("⢂⠨⢀⠐⢈⠀⢂⠠⠐⠀⢂⠐⡀⠂⢁⠨⢀⠁⢅⢬⢮⣳⡳⣳⢵⡳⣽⡺⣮⡫⣗⣗⢯⣻⡪⡯⣺⠪⡑⡐⢔⢘⠌⠐⡈⠐⡈⠄⠐⡀");
                            Console.WriteLine("⠄⠂⠄⠂⠐⢈⠀⡐⠈⡀⠂⠄⠂⡈⠠⠐⣠⣪⢾⢝⣵⣳⢽⣝⢗⡯⣗⣟⢮⣻⡺⡮⣯⡺⡮⢋⠢⡑⡰⡘⠌⠄⠂⡁⠄⠂⡐⢀⠁⠄");
                            Console.WriteLine("⠂⡁⠄⠡⠈⠠⠀⢂⠐⠀⠌⠀⡂⡐⣔⢽⡺⣪⢗⣟⣞⡮⣗⣯⣻⣺⢵⣳⣫⣞⣞⢽⠪⡊⢔⠡⡊⡢⢁⠂⠡⠈⠄⠄⠂⢁⠀⢂⠐⡀");
                            Console.WriteLine("⠡⢀⠐⡀⠅⠂⠁⠄⠂⡁⠄⢅⢂⠆⡪⢳⣫⢗⡯⣞⣞⣞⢗⣗⢷⢽⢝⣞⢮⢞⢎⢑⠌⡢⡑⡑⠨⢀⠂⠨⠀⠅⠂⠂⡁⠐⢈⠠⠀⠄");
                            Console.WriteLine("⠁⠄⢐⠀⡂⠡⠈⠄⡡⡐⠅⢕⢡⡪⣮⣳⢽⢵⣫⢗⡗⣗⢯⡺⣵⣫⢗⢗⠝⡐⢔⢡⠪⠨⠐⡈⡈⠄⠠⠁⡂⠈⠌⡀⢂⠡⠠⠐⠈⠠");
                            Console.WriteLine("⠄⡁⢂⠐⠠⠨⡐⣑⠔⢌⡪⣪⣳⢽⡫⢯⢫⢗⣗⢯⡺⡽⣕⣟⢮⠪⡃⢅⠪⡰⡑⠅⠡⢁⠡⠐⠠⠈⠄⠡⠠⠁⡂⢐⠠⠀⡂⡈⠄⢁");
                            Console.WriteLine("⠄⠂⡂⠌⡌⡢⢊⢔⢕⢵⢝⢞⢜⠅⡃⡑⠨⡘⡪⣟⢞⡽⡺⠨⡂⢕⢨⢢⠫⠨⠠⠁⠅⡐⠠⠈⠄⠡⢈⠐⡈⢐⠀⡂⠄⠡⢀⠄⠨⢀");
                            Console.WriteLine("⢄⢅⠪⡨⢢⢪⣪⢮⢯⢫⠪⡑⡐⡁⡂⠌⡐⢐⠐⠌⢏⡣⠡⡃⣊⢆⠇⠅⠅⠡⢁⠅⠡⠐⡈⠄⠡⠈⠄⡂⢂⠂⡐⠠⢈⢐⠠⠨⠐⡀");
                            Console.WriteLine("⡕⢔⢱⢜⣵⡫⣞⢝⢊⠊⠌⡀⢂⢐⢀⠂⡂⠂⠌⡈⡂⡊⠎⡊⡂⠅⢂⠡⠨⡈⠄⠌⠂⠅⡐⠨⠈⠌⡐⢐⠐⡐⠠⢁⠂⡐⠠⠁⠌⡀");
                            Console.WriteLine("");
                            Console.WriteLine("당신은 부엌칼을 얻었습니다. 이것이 왜 필요한지는 알 수 없지만... ");
                            Status.Line();
                        }
                    }
                    else
                    {
                        BTWS();
                        Console.WriteLine("");
                        Console.WriteLine("아무것도 발견하지 못했습니다... ");
                        Status.Line();
                    }
                    goto go9;
                case "2":
                    randValue = rand.Next(0, 101);
                    if (randValue <= 40)
                    {
                        Status.EnterField(player);
                    }
                    else
                    {
                        BTWS();
                        Console.WriteLine("");
                        Console.WriteLine("아무것도 발견하지 못했습니다... ");
                        Status.Line();
                    }
                    goto go9;
                case "3":
                    EnterLeftCorridor();
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    Thread.Sleep(1000);
                    goto go9;
            }
        }
        private static void Corridor3()
        {
            Console.Clear();
            Status.EnterField(player);
            Status.Line();
            Console.WriteLine("⡌⢎⢌⠎⡜⢌⢎⢪⢊⢎⢎⢎⠎⣎⢷⢝⢮⡳⡝⡞⠞⠮⡳⣫⡳⣝⠆⡱⡱⡱⡱⡑⣝⢮⡳⡝⡮⡳⣝⢮⡳⣝⢞⡜⣜⢜⢎⢮⢪⢎");
            Console.WriteLine("⡪⡘⡔⡱⡸⡘⡔⢕⢱⢑⢕⢅⢇⢮⢪⢪⢪⢪⢸⢨⢌⢢⢱⢱⢸⢜⠄⢕⢕⢕⢕⢕⢕⣗⢵⡫⣞⣝⢮⡣⡯⣺⢕⡕⣕⢵⢹⢼⡕⡕");
            Console.WriteLine("⡱⡨⢢⢃⢎⠜⡌⡎⡪⡪⡊⢆⢕⢕⢗⠽⡸⢕⢝⠎⠎⢏⠮⡳⢝⢵⠁⡕⢜⢜⢜⢔⢕⢷⢝⡮⣳⡚⡒⢽⡹⣽⢪⢎⢮⢪⡣⣟⢮⡓");
            Console.WriteLine("⢑⢌⢆⠣⣊⢪⠸⡨⡊⡆⡣⡱⡸⡸⡨⡪⡪⡊⡆⡪⢨⠰⡨⢪⢘⢔⠁⡜⠌⡎⡎⢆⢫⣫⡯⣯⢗⡅⡐⢸⡺⣽⢪⡣⡳⡕⡵⣝⢧⢳");
            Console.WriteLine("⢐⠕⢌⠪⡢⡑⡅⢇⢪⠸⡐⢔⠭⢳⠹⡱⢕⠝⡜⠕⠕⠕⠕⢕⢕⢕⠐⢌⠪⡸⡨⠪⡪⡮⡯⣫⢯⠮⠢⢱⣝⢾⡱⡝⣜⢮⡚⣮⣻⢸");
            Console.WriteLine("⢐⠕⢅⠣⡊⡢⡑⡅⡣⡱⠨⡂⡇⡅⢕⢌⠢⡡⢂⠢⡈⠢⠡⡑⡰⢐⠈⠔⡁⡇⡪⡑⡱⣽⣽⣺⢵⡋⢈⢸⡪⣿⢸⡪⡎⡮⡪⣺⡺⡸");
            Console.WriteLine("⢑⢘⢌⠪⡨⢢⠱⡘⢔⠌⡢⡱⣝⡜⣕⢕⢝⢌⢇⠣⡱⡩⡹⡸⡸⡑⠈⠌⡂⡵⢨⠢⡱⡽⡽⣞⢗⡅⡐⡸⣪⢗⡧⡳⡹⣸⡑⣗⢽⢸");
            Console.WriteLine("⢐⠱⡐⠕⢌⢆⠣⡑⢅⢊⢐⠬⡐⡨⠠⡑⡨⢐⠐⠄⡂⠔⡐⡐⢌⢂⠁⠅⡂⢇⢑⠌⢜⢾⣻⣗⢽⡂⠀⢹⡪⣻⢜⢎⢧⢣⢣⣫⢎⠮");
            Console.WriteLine("⡑⡑⡌⡪⠢⡂⡣⡑⢅⢂⢪⡪⡖⡮⡺⡲⡸⡔⡕⡕⡔⣕⢲⢱⢣⡃⠠⡡⡊⡆⢅⠕⡱⣽⢷⣳⣫⢆⣄⢵⡹⡵⡝⡎⣎⢇⢗⡵⡣⡓");
            Console.WriteLine("⡨⢂⢪⢐⠅⡕⢌⠢⡁⡂⡪⢊⢑⠍⡊⠜⠨⡈⠌⢈⠈⠄⠅⢅⢑⠄⢂⠠⡣⠣⡑⢌⢜⢼⣿⣗⢯⡛⠪⡳⡕⣟⢜⢎⢮⢪⢳⢽⠸⡘");
            Console.WriteLine("⢌⠢⡑⢔⢑⢌⠢⡑⡐⢰⢘⣔⢔⡅⣆⢥⣑⢄⢅⡢⡨⡌⡬⡢⡅⠂⠠⠐⡜⢕⢌⠢⢪⢝⡷⣝⡧⡃⡐⡗⣝⢮⢳⢹⢸⢜⢮⢯⠪⡪");
            Console.WriteLine("⢐⢑⢌⠢⡑⢔⢑⢐⠌⢌⢗⢵⢹⢪⢎⢇⢇⠇⢇⠣⠣⡙⠜⡍⠎⢀⠁⡐⡭⡒⠔⡅⢕⡯⣟⢷⢽⠨⢂⢻⣺⣽⢪⢣⡣⡣⡫⡯⡪⢸");
            Console.WriteLine("⠰⡐⡢⡑⢌⠢⡑⡐⡈⢆⢅⠢⡁⡂⡂⠢⢐⠈⠄⠄⠡⠠⠡⡨⠂⠄⠂⢰⢱⢱⢑⢌⠪⡯⡯⣯⢳⡩⡢⡫⣗⣟⣎⢇⢇⢧⢣⢓⢜⠬");
            Console.WriteLine("⠕⡰⠰⡘⢌⢌⢂⠢⢨⣒⢖⡵⣪⢖⡵⣕⢕⢬⢢⢱⢱⡱⣣⡳⡃⡀⠂⢸⡸⣸⣐⣅⢕⡯⡯⣗⣝⢦⡱⢭⣳⣻⣺⢧⡫⡪⡪⡪⡢⠣");
            Console.WriteLine("⢑⠌⡌⡢⡑⠔⡡⢈⠆⡗⢝⠜⠎⠇⠇⠇⢇⠣⠑⠅⠕⠨⠂⠎⢆⠀⠂⠸⣜⡕⡷⣝⣗⡯⡯⣗⢗⡵⡱⣝⣞⢾⢵⣻⢮⣣⢣⢣⠪⡪");
            Console.WriteLine("⢐⢑⠌⡂⡪⠨⡐⠄⢕⠌⢔⠡⡑⠅⢅⠑⠄⡂⢁⠂⠡⢈⠌⢌⢂⠂⢁⢘⢮⢎⡯⣗⣗⢯⡻⡮⣳⢝⢞⢮⡺⡽⣝⡾⡽⣺⡜⡜⢜⢸");
            Console.WriteLine("⠢⡑⢌⢌⠢⡑⢄⠱⡡⡯⡮⣳⢝⣭⣣⡫⡪⡌⡆⡇⣝⢜⣜⢵⢝⠠⠠⢐⡳⡣⣟⡵⡯⣫⢾⢝⡮⣫⢞⡵⣫⢯⣳⢽⣝⣗⡽⣪⢪⢢");
            Console.WriteLine("⠪⡐⢅⠢⡑⡐⠄⡕⡯⡳⡝⡎⡗⡕⡧⢳⢙⠜⡸⢘⢌⠪⡐⡑⠭⠀⡀⠀⣏⢗⣽⣺⣝⣗⢽⣕⢯⢮⢳⢝⢮⡳⣳⢝⡮⣺⡺⣝⢮⢢");
            Console.WriteLine("⠢⡊⡢⡑⢌⢐⠡⡊⡢⠡⢊⢐⠅⠌⠔⡐⡀⠂⠄⢂⠀⡂⠠⠨⠨⡀⠄⠂⣳⢹⣺⣪⢞⡮⣳⢕⡯⣺⢕⡯⣳⢽⡺⣵⡫⣗⣽⡺⡽⡵");
            Console.WriteLine("⠅⢆⠢⡊⢔⢐⠡⡊⡦⣳⢣⡳⣪⡣⣳⢰⢨⠨⡌⡢⣊⢆⢇⢇⢯⠠⠀⠠⢱⢹⣺⡺⣝⢮⡳⣝⢮⡳⣝⣞⢵⡫⡯⡮⡯⣳⢵⡫⣯⣫");
            Console.WriteLine("⢊⠢⡑⢌⢂⠢⢱⢝⢽⡪⡗⣝⢮⢺⢪⡣⡳⡹⡸⡪⡚⡎⡳⡹⡩⠅⡀⢁⠸⣝⡞⣮⡳⣝⢮⡳⣳⡹⣪⢮⡳⣝⢵⡫⣞⢵⣫⢞⡵⣳");
            Console.WriteLine("⠢⡑⢌⠢⢂⠅⡣⡫⡚⢜⠪⡚⠜⡊⡃⢃⠃⢃⠑⡁⠃⠅⡑⠨⠨⠀⠄⢀⠸⡵⣯⣺⢺⣪⡳⣝⢮⡺⣕⢗⡽⣪⢗⡽⣪⢗⣗⢽⡺⡵");
            Console.WriteLine("⡑⢌⠢⡡⠡⢊⢢⢒⣌⣆⢕⡔⣅⢢⢨⢐⠨⡀⡢⡠⡡⡢⡰⡠⣱⠀⢂⠠⠈⡞⡦⣳⢯⡪⡞⡮⡺⡪⡮⡳⡝⡮⡳⡝⡮⡳⣕⢯⡺⣝");
            Console.WriteLine("⢌⠢⡑⠌⢌⠪⡲⣝⢮⣪⡳⡹⡜⣕⢕⢕⢱⢱⢸⢨⢪⢪⡪⣪⢢⡃⠀⠄⠈⣎⢮⡳⣳⢹⡪⣳⢹⢕⡝⣎⢧⢫⢎⢮⢳⢹⢜⢮⢺⡪");
            Console.WriteLine("⠡⡑⢜⠨⢢⢽⢝⣮⣳⡳⡽⣝⢞⢞⢮⢺⢪⢺⢜⠵⡝⡵⡹⢜⢕⢕⢌⢆⠣⡣⠳⣝⢎⢧⢳⢱⢕⢵⡱⣕⢵⢱⡣⡳⡹⡜⣕⢧⢳⡹");
            Console.WriteLine("⢃⠎⡢⡡⡱⡫⡳⠵⡕⡽⠜⡎⢇⠏⢎⠎⠎⠎⠆⠣⠑⠜⢈⠊⢂⠑⠐⠨⠈⠄⢕⢗⡝⣜⢎⢧⢳⡱⡕⣕⢵⢱⢕⢝⡜⣎⢮⢪⡣⡳");
            Console.WriteLine("⡑⡌⢆⢒⢌⠪⡌⢇⢕⠜⢌⢌⠢⠡⠡⠨⠈⠄⠅⠨⠀⠅⡀⠂⠄⠂⡁⢐⠀⡂⡱⡳⡝⣎⢯⢪⢇⢗⢝⢜⡜⣎⢮⢣⢳⡱⡕⡇⣏⢞");
            Console.WriteLine("");
            Console.WriteLine("정말 넓은 집이로군요...");
            BTWS();
            Console.WriteLine("당신은 또다른 갈림길 앞에 섰습니다...");
            BTWS();
            Console.WriteLine("앞으로는 2층으로 올라가는 계단이 보이고 오른편으로는 복도가 이어집니다...");
            BTWS();
            Console.WriteLine("조용한 집은 힌트를 주지 않습니다...");
            BTWS();
            Console.WriteLine("어디로 향하겠습니까...");
            Thread.Sleep(300);
        go11:
            Status.Line();
            Console.WriteLine("[1] 오른편 복도로 가고싶다면 1번을 눌러주세요...");
            Thread.Sleep(300);
            Console.WriteLine("[2] 2층으로 올라가고 싶다면 2번을 눌러주세요...");
            Thread.Sleep(300);
            Console.WriteLine("[3] 이전 장소로 되돌아가고 싶다면 3번을 눌러주세요...");

            string input17 = Console.ReadLine();
            Console.Clear();
            switch (input17)
            {
                case "1":
                    Entrance();
                    break;
                case "2":
                    Upstair();
                    break;
                case "3":
                    Livingr();
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    Thread.Sleep(1000);
                    goto go11;
            }
        }

        private static void Entrance()
        {
            Console.Clear();
            Status.Line();
            Console.WriteLine("⢌⠆⡑⡈⢂⢑⢈⠂⡑⢈⠂⡊⡐⠡⢂⢑⢈⠂⡑⢐⢁⠢⠑⡐⢁⢂⠑⡐⠌⢂⠊⡐⢁⠊⡐⡈⢂⢑⠨⢂⠑⠌⡂⢃⠊⡂⠕⠨⢂⠣");
            Console.WriteLine("⢢⠡⠐⢐⢀⢂⢐⢐⢐⢐⢐⢀⢂⠡⡐⠠⡐⡐⡐⡐⡀⡂⡡⢐⢀⢂⢐⠠⡈⠄⡂⡐⡐⡐⡀⡂⡂⢄⢂⢂⠌⡐⡐⡠⢁⠄⢅⢑⠐⢨");
            Console.WriteLine("⢸⠈⠌⡐⢨⠣⠓⠕⠝⡘⠕⢍⠣⠫⢙⠙⠜⠱⠙⡊⠫⠙⠜⠩⢃⠫⠋⠝⡘⠝⡙⠜⠩⠩⠩⠊⠍⠣⢙⠜⠙⠍⠝⡘⠍⢏⢂⠂⠌⢔");
            Console.WriteLine("⡎⡎⢐⠠⢱⠡⠨⠠⢁⢐⠈⠄⡂⠌⠠⠨⠠⢁⠂⡂⠡⠈⠄⠅⠂⠄⡁⢂⢐⢀⠂⠌⠄⡁⢂⠡⠈⠌⠠⡡⠡⠨⠐⡐⠈⡎⡂⠅⠡⢂");
            Console.WriteLine("⡘⡔⢐⠐⢸⠠⠡⠈⠄⢂⢈⢂⢐⠨⠠⢁⠂⡂⡐⠠⠁⠌⠄⡡⠁⠅⡐⡀⢂⠐⡈⠄⡁⡂⡐⠠⠁⠅⡁⡂⢂⢁⠂⡂⡁⢎⠂⠅⡡⢑");
            Console.WriteLine("⡸⡐⠡⠨⢸⠈⠄⠅⠡⠂⡂⠢⡰⡐⡌⣄⢢⡐⡄⡅⡅⡅⢌⠔⠨⡐⢄⠂⢆⣂⢆⡅⣔⡠⣂⡅⣅⢅⡢⠨⢀⠂⡂⡐⠄⡣⠡⡁⡂⢕");
            Console.WriteLine("⠢⡅⠅⠅⡪⡅⠅⠅⡡⠡⠠⢑⠌⡒⠪⢒⢑⠒⡑⢚⠒⡎⡐⠌⠌⡐⠠⡁⢲⡘⡚⠚⡒⠓⠓⠓⢓⢓⠨⡨⠐⡈⠄⡂⠅⢕⠅⠂⠌⡧");
            Console.WriteLine("⣑⠢⠡⡁⢎⡆⠅⡁⠢⠨⢈⠢⢨⠠⢑⠠⠂⠌⡐⢐⠨⡪⠠⢈⠂⡂⠅⡂⡱⡕⠠⡁⡂⠅⠅⡑⡐⠄⠕⠄⠅⡂⠅⡂⢅⢣⠊⠌⡂⡕");
            Console.WriteLine("⡱⠡⠡⢂⢳⡃⠅⠌⠌⢌⢐⠨⠢⠨⢐⠠⠡⡁⡂⠅⠌⡎⢌⢐⠨⠠⢁⠢⡘⡎⡐⡐⠄⠅⠅⡂⡂⠅⢕⠡⢑⠠⡁⡂⡂⢇⡃⡑⡐⡕");
            Console.WriteLine("⢣⢃⠅⢅⢽⡣⠡⡑⠅⡂⡢⢈⠎⡌⠔⠨⡐⡐⠄⠅⢅⢗⢐⢐⠨⢐⢁⠢⡘⡇⡂⠢⠡⡡⢑⠐⢄⠣⡑⡌⡐⡐⠔⡐⠌⣎⠆⡊⠔⡕");
            Console.WriteLine("⡕⡕⡨⢂⢽⡃⠕⡈⡂⡢⠂⢅⢣⠢⡡⢑⢐⢐⠡⢑⠰⡱⢐⢐⠨⢐⠠⡁⡪⡇⢌⠜⡐⠔⡁⡊⠔⡨⡘⡂⡢⠊⠌⢔⠡⣇⠣⡘⠌⡎");
            Console.WriteLine("⡕⡕⢌⠢⡹⡪⠨⡂⡊⠔⡡⠡⡣⡃⡢⠡⡂⢅⢊⠔⡡⡇⠕⡠⠡⡡⢂⠢⢊⡇⢅⠌⡢⢑⠨⡐⢅⠪⢌⠢⡂⢕⠡⡑⢌⣎⠪⡨⡊⡎");
            Console.WriteLine("⣕⢝⠔⡡⡋⡇⢕⠰⠨⡊⡐⢅⢳⠡⡊⢌⢌⠢⡂⠪⡐⡕⢅⢊⠌⡢⢑⠨⢸⡅⢕⠨⡐⢔⠡⡊⡐⢍⢆⢕⠨⡐⢅⢊⠢⣇⢇⢒⠌⣎");
            Console.WriteLine("⡎⡧⡱⢨⠪⡣⡡⠣⡑⢌⢌⠢⣫⢪⠨⡂⢆⠕⡨⠨⡂⡏⡂⡢⡑⢔⠡⡊⡢⡇⠕⢌⢌⠢⣱⢐⠅⣕⠕⢔⢑⢌⢢⠡⢣⡳⡡⡱⢅⢇");
            Console.WriteLine("⣎⢧⠣⡑⡕⡇⢕⠥⡑⢅⢢⠱⢵⣑⢑⢌⠢⡑⢜⢨⠸⡸⡐⢔⢌⠢⡑⢔⠱⡝⢌⠆⡕⢌⠢⠢⡱⣸⠸⡨⠢⡊⡢⡑⢕⡕⡕⢌⢎⢎");
            Console.WriteLine("⢮⡣⡣⡱⣘⡎⢆⢕⠜⢌⠆⡕⣽⢢⢱⠨⣊⠪⡢⡑⢌⢗⠌⢆⠢⡃⢎⠢⡹⡕⢅⢊⢢⢡⠱⡑⢔⣪⢣⠪⢪⢘⠔⡅⢇⡗⡅⡇⡪⣣");
            Console.WriteLine("⡕⣇⢇⢎⠢⣏⢪⢂⢇⢣⢱⠸⣼⢱⠡⡃⡎⡪⠢⡪⢪⡪⣊⢪⢘⠌⡆⡣⡱⡏⡌⡪⢢⢡⠱⡘⡔⣺⢜⢜⢸⠰⡑⡕⡱⡝⡜⡌⣎⢮");
            Console.WriteLine("⡪⣇⢇⢎⢎⣗⢅⢇⢕⢜⢔⠭⣺⢕⢱⢑⢌⠎⡞⡪⠲⣕⢆⢣⢱⠱⡘⡔⢜⢧⠱⡘⡌⢆⢣⠱⣑⢽⡪⡢⡱⡑⡕⢜⠬⣇⢇⢎⢮⡺");
            Console.WriteLine("⣝⢮⢪⢪⢪⣞⢜⢌⢆⢇⢎⢮⢺⢕⢅⢇⢕⢅⢇⢎⢕⢧⢱⢡⠣⡃⡇⢎⡪⣇⢇⢣⢱⢑⢕⠱⡌⡿⣜⢔⢕⢱⢸⢸⢸⡪⡪⡪⣪⢞");
            Console.WriteLine("⢮⣳⢹⢸⢪⣞⢎⢎⢎⢎⢎⢎⢯⢇⢇⢇⢕⢜⢔⢕⢕⢵⢱⢱⢱⢱⢱⢱⢸⡣⡣⡣⡣⡱⡱⡱⡱⣽⡪⡪⡪⡪⡪⡪⡪⣳⢱⢱⡱⡯");
            Console.WriteLine("⣟⢮⡣⡳⣱⢽⢜⢜⢜⢜⢜⢜⢽⣱⣱⡱⣱⡱⣱⢱⡱⡝⡕⡕⡕⡕⡕⡕⣕⣏⢎⣎⢎⡎⣎⢎⣎⢾⡪⡪⡪⡪⡪⡪⡪⣗⢕⢵⢱⢯");
            Console.WriteLine("⣞⣗⢵⡹⡼⣽⢕⢵⢱⢣⢣⡫⣓⢖⢕⢕⢕⢎⢮⢪⢪⡪⡺⣚⢮⢺⢚⡺⡒⡜⡎⡎⡎⡎⡎⣎⢎⢖⢽⢸⢜⡜⡼⡸⣪⢷⡱⣣⡫⣗");
            Console.WriteLine("⣺⣺⢕⢵⣹⢾⡕⡧⡳⣱⢣⡫⡪⣎⢎⢧⢳⢱⡱⡕⡵⡱⡹⣸⢸⡸⡜⡼⡸⡜⡎⡮⡣⣫⢪⢎⢮⢪⢮⡣⣷⣟⣿⣪⣺⢧⡫⡮⡺⣝");
            Console.WriteLine("⣗⣽⢕⢧⣳⣻⡺⣜⢕⢧⢳⢭⡣⣳⢹⢜⢎⡇⡧⡳⡱⡝⡎⣇⢧⡣⣣⢳⡱⡕⡵⡱⡝⣜⢎⢧⢳⢕⢧⡫⡳⣟⢟⡖⣽⢵⠵⣝⢽⣕");
            Console.WriteLine("⣗⡿⣝⢵⢵⣻⡪⡮⣳⢹⣪⡺⣪⢮⡳⡹⣕⢝⢮⢎⡗⣝⢮⢺⢜⢮⡪⣣⡣⣳⢱⡣⣏⢮⢮⢳⢕⢗⡵⡝⡞⣎⢗⡝⣾⢵⡻⣪⣳⣳");
            Console.WriteLine("⡮⣟⣮⡳⣝⢾⣕⢯⢎⣗⢵⡹⣪⢧⡫⡞⣎⢗⡳⡵⣝⣜⢮⢳⡹⣪⢞⢮⡺⡼⣱⢕⢧⡳⣕⢏⣗⣝⢮⡫⣞⢮⡳⣝⣞⢷⢝⣞⢮⡯");
            Console.WriteLine("⣯⢿⣪⣞⢵⣻⢮⡳⣝⢎⡧⡯⣺⣕⢯⣝⢮⡳⣝⢮⢮⡺⡼⣕⢯⢮⡳⣣⢗⣝⢮⣫⣣⢗⣗⣝⢮⢮⣳⢝⡮⡳⣝⢮⣺⣽⡽⣪⡯⣯");
            Console.WriteLine("⠢⡅⠅⠅⡪⡅⠅⠅⡡⠡⠠⢑⠌⡒⠪⢒⢑⠒⡑⢚⠒⡎⡐⠌⠌⡐⠠⡁⢲⡘⡚⠚⡒⠓⠓⠓⢓⢓⠨⡨⠐⡈⠄⡂⠅⢕⠅⠂⠌⡧");
            Console.WriteLine("⣑⠢⠡⡁⢎⡆⠅⡁⠢⠨⢈⠢⢨⠠⢑⠠⠂⠌⡐⢐⠨⡪⠠⢈⠂⡂⠅⡂⡱⡕⠠⡁⡂⠅⠅⡑⡐⠄⠕⠄⠅⡂⠅⡂⢅⢣⠊⠌⡂⡕");
            Console.WriteLine("⡱⠡⠡⢂⢳⡃⠅⠌⠌⢌⢐⠨⠢⠨⢐⠠⠡⡁⡂⠅⠌⡎⢌⢐⠨⠠⢁⠢⡘⡎⡐⡐⠄⠅⠅⡂⡂⠅⢕⠡⢑⠠⡁⡂⡂⢇⡃⡑⡐⡕");
            Console.WriteLine("⢣⢃⠅⢅⢽⡣⠡⡑⠅⡂⡢⢈⠎⡌⠔⠨⡐⡐⠄⠅⢅⢗⢐⢐⠨⢐⢁⠢⡘⡇⡂⠢⠡⡡⢑⠐⢄⠣⡑⡌⡐⡐⠔⡐⠌⣎⠆⡊⠔⡕");
            Console.WriteLine("⡕⡕⡨⢂⢽⡃⠕⡈⡂⡢⠂⢅⢣⠢⡡⢑⢐⢐⠡⢑⠰⡱⢐⢐⠨⢐⠠⡁⡪⡇⢌⠜⡐⠔⡁⡊⠔⡨⡘⡂⡢⠊⠌⢔⠡⣇⠣⡘⠌⡎");
            Console.WriteLine("⡕⡕⢌⠢⡹⡪⠨⡂⡊⠔⡡⠡⡣⡃⡢⠡⡂⢅⢊⠔⡡⡇⠕⡠⠡⡡⢂⠢⢊⡇⢅⠌⡢⢑⠨⡐⢅⠪⢌⠢⡂⢕⠡⡑⢌⣎⠪⡨⡊⡎");
            Console.WriteLine("⣕⢝⠔⡡⡋⡇⢕⠰⠨⡊⡐⢅⢳⠡⡊⢌⢌⠢⡂⠪⡐⡕⢅⢊⠌⡢⢑⠨⢸⡅⢕⠨⡐⢔⠡⡊⡐⢍⢆⢕⠨⡐⢅⢊⠢⣇⢇⢒⠌⣎");
            Console.WriteLine("⡎⡧⡱⢨⠪⡣⡡⠣⡑⢌⢌⠢⣫⢪⠨⡂⢆⠕⡨⠨⡂⡏⡂⡢⡑⢔⠡⡊⡢⡇⠕⢌⢌⠢⣱⢐⠅⣕⠕⢔⢑⢌⢢⠡⢣⡳⡡⡱⢅⢇");
            Console.WriteLine("⣎⢧⠣⡑⡕⡇⢕⠥⡑⢅⢢⠱⢵⣑⢑⢌⠢⡑⢜⢨⠸⡸⡐⢔⢌⠢⡑⢔⠱⡝⢌⠆⡕⢌⠢⠢⡱⣸⠸⡨⠢⡊⡢⡑⢕⡕⡕⢌⢎⢎");
            Console.WriteLine("⢮⡣⡣⡱⣘⡎⢆⢕⠜⢌⠆⡕⣽⢢⢱⠨⣊⠪⡢⡑⢌⢗⠌⢆⠢⡃⢎⠢⡹⡕⢅⢊⢢⢡⠱⡑⢔⣪⢣⠪⢪⢘⠔⡅⢇⡗⡅⡇⡪⣣");
            Console.WriteLine("⡕⣇⢇⢎⠢⣏⢪⢂⢇⢣⢱⠸⣼⢱⠡⡃⡎⡪⠢⡪⢪⡪⣊⢪⢘⠌⡆⡣⡱⡏⡌⡪⢢⢡⠱⡘⡔⣺⢜⢜⢸⠰⡑⡕⡱⡝⡜⡌⣎⢮");
            Console.WriteLine("⡪⣇⢇⢎⢎⣗⢅⢇⢕⢜⢔⠭⣺⢕⢱⢑⢌⠎⡞⡪⠲⣕⢆⢣⢱⠱⡘⡔⢜⢧⠱⡘⡌⢆⢣⠱⣑⢽⡪⡢⡱⡑⡕⢜⠬⣇⢇⢎⢮⡺");
            Console.WriteLine("⣝⢮⢪⢪⢪⣞⢜⢌⢆⢇⢎⢮⢺⢕⢅⢇⢕⢅⢇⢎⢕⢧⢱⢡⠣⡃⡇⢎⡪⣇⢇⢣⢱⢑⢕⠱⡌⡿⣜⢔⢕⢱⢸⢸⢸⡪⡪⡪⣪⢞");
            Console.WriteLine("⢮⣳⢹⢸⢪⣞⢎⢎⢎⢎⢎⢎⢯⢇⢇⢇⢕⢜⢔⢕⢕⢵⢱⢱⢱⢱⢱⢱⢸⡣⡣⡣⡣⡱⡱⡱⡱⣽⡪⡪⡪⡪⡪⡪⡪⣳⢱⢱⡱⡯");
            Console.WriteLine("⣟⢮⡣⡳⣱⢽⢜⢜⢜⢜⢜⢜⢽⣱⣱⡱⣱⡱⣱⢱⡱⡝⡕⡕⡕⡕⡕⡕⣕⣏⢎⣎⢎⡎⣎⢎⣎⢾⡪⡪⡪⡪⡪⡪⡪⣗⢕⢵⢱⢯");
            Console.WriteLine("⢟⡾⣻⢯⢿⢽⢾⣻⢯⢿⢽⢾⣻⣻⣻⣻⢽⣻⣻⢞⡯⣟⣟⡷⡿⣟⢿⢽⢷⣻⢷⣻⣻⡻⣟⢿⣳⢿⣟⢿⣻⢷⢟⣿⣻⣻⢯⡷⣟⣷");
            Console.WriteLine("");
            Console.WriteLine("이럴수가...");
            BTWS();
            Console.WriteLine("드디어...");
            BTWS();
            Console.WriteLine("당신의 눈 앞에 대문으로 보이는 문이 보입니다...");
            BTWS();
            Console.WriteLine("조건을 갖춘자만이 문을 통과할 수 있을거라는 예감이 들지만...");
            BTWS();
            Console.WriteLine("어디로 향하겠습니까...");
            Thread.Sleep(1000);
        go12:
            Status.Line();
            Console.WriteLine("[1] 대문으로 나가려면 1번을 눌러주세요...");
            Thread.Sleep(300);
            Console.WriteLine("[2] 이전 공간으로 되돌아가려면 2번을 눌러주세요 ...");

            string input18 = Console.ReadLine();
            Console.Clear();
            switch (input18)
            {
                case "1":
                    Escape();
                    break;
                case "2":
                    Corridor3();
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    Thread.Sleep(1000);
                    goto go12;
            }
        }

        private static void Livingr()
        {
            Console.Clear();
            Status.EnterField(player);
            Status.Line();
            Console.WriteLine("⠀⡀⢀⠀⡀⢀⠀⡀⢀⠀⡀⢀⠀⡀⢀⠀⡀⢀⠀⡀⢀⠀⠠⠀⢀⠀⡀⢀⠀⡀⠀⠄⠀⡀⢀⠀⡀⢀⠀⠠⠀⢀⠀⡀⢀⠠⠀⢀⠀⠠");
            Console.WriteLine("⠠⠀⡀⠄⠀⠄⠀⠄⠀⠄⠀⠄⠀⠄⠀⠄⠀⠄⠀⠄⠀⠐⢀⠐⠀⡀⠄⠀⠄⠀⠂⠀⠂⢀⠠⠀⠠⠀⠐⠀⠂⠀⠄⠀⠄⠀⠄⠠⠐⠀");
            Console.WriteLine("⠀⠄⠀⠠⠐⠀⠂⠀⠂⠀⠂⠀⠂⡀⠂⠐⠀⠐⠀⠄⠁⠈⠀⡀⠄⢀⠠⠐⠀⢈⠀⠁⠈⠀⢀⠀⠂⢀⠁⠠⠈⢀⠐⠀⠐⠀⠐⠀⠠⠈");
            Console.WriteLine("⠐⠀⢈⠀⠠⠐⠀⠁⠈⠀⡁⠈⢀⠀⠐⠀⠁⢈⠀⠐⠈⠀⠁⢀⠀⡀⠀⠄⠐⠀⠠⠈⠀⢁⠀⠠⠈⠀⡀⠐⠀⠠⠀⢈⠀⢁⠀⢁⠀⠂");
            Console.WriteLine("⠂⠈⠀⡀⠄⠀⠂⠁⠈⢀⠀⠐⠀⠠⠈⠀⠁⡀⠀⠂⠁⢀⠁⢀⠠⠀⠐⠀⠂⠈⢀⠀⢁⠀⠄⠂⠀⠂⠀⠄⠁⡀⠂⠀⠄⠀⠄⠠⠀⠂");
            Console.WriteLine("⠐⠈⠀⢀⠠⠈⠀⡈⠀⠄⠀⡁⠐⠀⠄⠁⠠⠀⢈⠀⢈⠀⡾⠀⡀⡾⠈⠀⠂⠁⠀⠄⠀⠄⢀⠐⠈⠀⠐⠀⠄⠀⠄⠁⠀⠂⠀⠂⠀⠂");
            Console.WriteLine("⠂⢀⠁⢀⠀⠄⠂⠀⠐⠀⠂⠀⠐⠀⢸⣺⢞⡾⣲⢗⡷⣺⢞⣞⡶⡷⡷⡷⣷⢷⢷⡷⣷⡁⢀⠠⠀⠁⡈⠀⠐⠀⠐⠀⢁⠀⢁⠀⡁⢀");
            Console.WriteLine("⡀⠄⠀⠄⠀⠄⠐⠈⢀⠈⢀⠈⢀⠁⢰⣻⣽⢽⢽⣝⢾⢽⣝⡮⡯⡾⣝⡿⣽⣻⡽⣯⢿⠠⠀⡀⠄⠁⢀⠀⡁⠈⡀⠈⢀⠠⠀⠠⠀⠀");
            Console.WriteLine("⢀⠠⠐⠀⠂⠀⠂⠐⠀⠠⠀⠐⠀⠠⠨⣷⣻⣽⣻⡮⡯⣗⢷⢽⢽⢽⡺⣝⡮⣷⣻⣯⣿⠡⠀⡀⠠⠐⠀⢀⠠⠀⠠⠈⠀⢀⠀⠂⢀⠁");
            Console.WriteLine("⠀⡀⠄⠐⠈⢀⠈⢀⠈⠀⠄⠁⠐⠀⢸⡽⣗⣯⡷⣟⣿⢽⡽⡽⣝⣗⢯⣗⡯⣗⣗⣗⢿⡂⠠⠀⠠⠀⠂⢀⠠⠐⠀⠐⠈⠀⡀⠈⢀⠠");
            Console.WriteLine("⢀⠀⠠⠐⠀⠠⠀⠄⠀⡁⠠⠈⠀⡁⠰⣟⣯⣷⣟⡿⣞⣿⡽⣯⢷⣝⣗⢷⣝⣗⢷⢽⢽⡂⠀⠂⠐⠀⡈⠀⢀⠠⠀⢁⠀⠂⢀⠈⠀⡀");
            Console.WriteLine("⡀⠄⠂⢀⠈⡀⠄⠂⠁⢀⠠⠀⢁⠀⢸⣯⣿⣞⣷⣿⣯⣷⣿⣫⣿⣳⣯⣷⣷⣽⣽⣽⣽⡂⠈⡀⢈⠀⠠⠈⠀⠀⠄⠠⠐⠈⠀⠀⠂⠀");
            Console.WriteLine("⡀⠠⠀⠄⢀⠀⠄⠀⠂⡀⠄⠐⠀⡀⠂⠉⠉⠉⠉⡁⠉⠌⢈⠁⠅⢁⠁⡁⠁⡁⢁⠁⠡⠀⠂⠀⠄⠐⠀⠄⠁⠐⠀⠄⠀⠂⠈⡀⢈⠀");
            Console.WriteLine("⠠⠀⠂⠠⠀⠄⠂⠈⡀⠀⠄⠂⠁⠀⠄⢁⠈⡀⢁⠀⡂⡈⡀⣀⢂⡠⣀⢄⢂⣀⢄⡐⣀⣂⣁⣐⣀⠂⠁⡀⢈⠀⢁⠀⡁⠈⡀⠠⠀⠠");
            Console.WriteLine("⢀⠐⠀⠂⠐⠀⠄⠁⠠⠐⢠⣞⣟⣟⡿⣝⡯⣟⣽⢽⣳⢯⢯⡯⣟⡾⡽⣽⢽⣺⣳⣻⣳⣳⢯⣞⣗⡧⡀⠄⠠⠐⠀⠠⠀⠂⢀⠐⠀⠂");
            Console.WriteLine("⠀⠐⠈⢀⠁⠐⢀⠁⠄⠂⣻⢮⣳⡳⡯⣗⣯⡻⣮⣻⣺⢽⣽⣺⣳⢽⣽⣺⣽⣺⢵⣗⡷⣽⣳⣳⣳⣟⠄⠐⢀⠐⠈⠀⠄⢁⠠⠀⡁⢈");
            Console.WriteLine("⢀⠁⡈⢀⠀⡁⠄⢀⠂⡀⣗⡯⡾⣝⣗⡤⣼⣺⢵⣳⢽⡽⣺⣺⣺⣻⣺⢞⣞⡾⣽⣺⢽⣺⢾⢵⣗⣷⠐⢈⠀⠠⢈⢀⠂⠠⠀⠄⠄⠄");
            Console.WriteLine("⡀⠄⠄⠄⠂⠄⠂⠄⠂⡀⢾⣝⣽⡺⣮⡨⣱⢗⣟⣞⡽⣞⣟⣞⣗⡯⣞⣯⢷⣻⡳⡯⣯⢯⢯⣟⡮⣷⡁⡐⢈⠐⡀⠂⠨⠀⠅⠂⡁⠈");
            Console.WriteLine("⡀⢂⠐⠈⠄⠁⠌⡀⠅⠠⣻⠺⠮⡻⠮⠯⠯⠻⠺⡪⠯⠳⠓⡓⡓⠏⠟⠪⠛⠪⠋⠛⠚⠙⠓⠓⡙⠑⡁⢀⠂⡀⠂⢈⠀⠡⠀⡁⠄⠈");
            Console.WriteLine("⠠⠀⠂⢁⠈⡐⠠⠐⢀⠁⠄⠌⠐⡀⠄⠂⠄⡁⠡⢀⠐⡀⠁⠄⢂⠈⠄⠨⠀⡁⠌⠠⠁⠡⠈⠄⠂⡐⠀⠄⠐⡀⠡⠀⠌⢀⠁⠄⠂⠡");
            Console.WriteLine("");
            Console.WriteLine("넓게 트인 공간을 보니 이곳은 거실 같군요...");
            BTWS();
            Console.WriteLine("오른쪽과 왼쪽으로 길이 나눠지고...");
            BTWS();
            Console.WriteLine("오른쪽 길은 아마 지하실로 향하는듯한 계단으로 보이는군요...");
            BTWS();
            Console.WriteLine("고장난 티비 아래에는 서랍장이 보입니다....");
            BTWS();
            Console.WriteLine("어디로 향하겠습니까...");
            BTWS();
        go10:
            Status.Line();
            Console.WriteLine("[1] 왼쪽으로 가고싶다면 1번을 눌러주세요...");
            Thread.Sleep(300);
            Console.WriteLine("[2] 오른쪽 지하실로 가고싶다면 2번을 눌러주세요...");
            Thread.Sleep(300);
            Console.WriteLine("[3] 서랍장을 살펴보려면 3번을 눌러주세요...");
            Thread.Sleep(300);
            Console.WriteLine("[4] 이전 공간으로 돌아가고 싶다면 4번을 눌러주세요...");

            string input16 = Console.ReadLine();
            Console.Clear();
            switch (input16)
            {
                case "1":
                    Corridor3();
                    break;
                case "2":
                    Basement();
                    break;
                case "3":
                    Random rand = new Random();
                    int randValue = rand.Next(0, 101);
                    if (randValue <= 80)
                    {
                        var item = Item.items.Find(i => i.iname == "사과");
                        if (item != null)
                        {
                            Player.Getitem(item);
                            BTWS();
                            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⢀⢀⢠⢠⢂⢢⢢⢣⢪⢢⢪⢯⠳⡰⡠⣀⡠⡤⡲⣔⢖⡤⣄⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⡀⡄⣆⢎⢎⢎⢆⢇⢇⢇⢎⢆⣗⢽⣪⢗⡽⡓⣕⢜⠬⡂⢎⠎⡎⡎⡧⡻⢼⢽⢵⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                            Console.WriteLine("⠀⠀⠀⠀⠀⠀⢀⢠⢎⡞⣎⢎⢎⠪⡪⡘⢜⠜⡜⡽⣕⡗⡽⡮⣳⡫⡪⡸⣘⢌⢆⠢⡃⠕⢅⢇⢏⢞⢮⡳⡝⡒⡄⡀⠀⠀⠀⠀⠀⠀");
                            Console.WriteLine("⠀⠀⠀⠀⠀⡠⡮⡳⡵⣝⢜⢎⢆⡳⡸⡸⡠⡡⡑⡑⢜⢜⢝⠵⢯⢪⠪⡊⢆⠣⢊⢌⢮⡺⣤⡣⣏⣎⢧⢣⡣⡳⡨⢪⢨⠀⠀⠀⠀⠀");
                            Console.WriteLine("⠀⠀⠀⠀⣰⢝⡮⡫⡎⡎⢎⠪⡊⢎⢎⢞⢼⣪⢮⢮⣲⡢⣅⢕⢅⢆⢕⢌⡆⣇⢧⣳⢳⠽⡕⡯⡦⣓⢵⣳⡱⣇⢏⡎⡆⢧⠀⠀⠀");
                            Console.WriteLine("⠀⠀⠀⣰⣫⡳⡝⡎⢎⠌⠢⠑⢌⢊⢢⡣⡯⢮⢯⢯⢞⣮⡳⣯⣫⢯⣫⢗⡽⣪⢣⡳⡝⣜⢜⢜⢎⢯⢦⡳⣝⡮⣗⡽⣪⢣⠅⠀⠀⠀");
                            Console.WriteLine("⠀⠀⢠⡳⣕⢗⡝⢌⠢⠨⠨⡈⡢⡪⡮⢮⢯⡳⡯⣯⡻⣮⣻⡺⣮⡻⡮⣻⡺⣪⢧⡳⣹⢸⡸⡸⡘⡜⡼⣝⣮⣫⣗⡯⣗⡽⡥⠀⠀⠀");
                            Console.WriteLine("⠀⠀⡼⣝⡮⣗⠱⡐⠡⠨⡐⡌⡮⡺⡪⣯⡳⣯⡻⣮⣻⣺⣺⢽⣺⣺⢽⣳⣝⣗⢗⣝⢮⡪⣎⢎⢎⢪⢪⢺⣺⡺⡮⡯⣗⣯⢯⢧⡀⠀");
                            Console.WriteLine("⠀⠀⣯⣺⡺⡪⡊⢌⠜⡨⢢⢱⢝⡮⡯⣞⣽⣺⣝⣗⣗⣗⡯⣟⣞⡾⡽⣺⡺⣮⣻⣪⢗⡽⣸⢪⢎⢎⢎⢞⢞⣞⡯⣿⡂⠀⠁⠉⠘⠀");
                            Console.WriteLine("⠀⠀⣗⣗⢽⡸⡘⡔⣑⢌⢎⣞⢽⣺⣝⣗⣷⣳⣻⣞⡾⣵⣻⣳⣳⢯⢯⣗⣟⣞⣞⢮⣻⣪⢗⣕⢇⢇⢇⢗⡽⡮⡯⣷⡃⠀⠀⠀⠀⠀");
                            Console.WriteLine("⠀⠀⣗⡵⡯⣺⢸⡸⡰⡱⣕⡯⡯⣞⣞⣾⣺⣺⣵⢷⣻⣳⣳⣗⡯⣯⣻⣺⣺⡺⣮⣻⡺⡮⡯⡮⡳⣝⢮⣫⢾⢽⢽⣺⠅⠀⠀⠀⠀");
                            Console.WriteLine("⠀⠀⢪⢾⢽⢵⣫⢞⡽⣝⢮⢯⢯⢷⢽⣺⣞⣗⣯⢿⣵⣻⣞⡾⣽⣺⢞⣞⡮⣟⢞⡮⡯⡯⣞⡽⡽⣺⢵⣫⢾⢽⢽⣺⠁⠀⠀");
                            Console.WriteLine("⠀⠀⠈⣗⢯⣳⣳⣫⢯⢾⢽⢽⡽⣽⢽⢾⣺⣳⢯⣻⣺⢞⡾⣽⣺⢞⣽⣺⢽⢽⢽⢽⢽⣝⢮⢯⣫⣞⣗⡽⡽⡽⣽⡺⠀⠀⠀⠀⠀⠀");
                            Console.WriteLine("⠀⠀⠀⢱⢻⣺⡺⣪⡯⡯⡯⣯⢯⡯⣟⡽⣯⣞⡯⣗⡯⣯⢯⣗⡯⣟⣞⢾⢽⢽⡽⣽⡳⡽⡽⡵⣳⢧⢷⢽⢽⢽⣺⠁⠀⠀⠀");
                            Console.WriteLine("⠀⠀⠀⠀⠝⣞⢞⣗⡯⡯⣟⡾⡽⡾⣽⢯⣷⣳⣻⡽⣽⢽⡽⡾⣝⡷⡽⡽⣽⣳⢯⣗⡯⡯⡯⣫⣗⢯⢯⢯⢯⣟⠎⠀⠀⠀");
                            Console.WriteLine("⠀⠀⠀⠀⠈⢪⡳⡵⣫⢯⣗⡯⣟⣽⢽⣻⣞⡷⣯⢯⡿⣽⢯⡿⣽⢽⡽⡯⣗⡯⣟⡮⡯⡯⣯⣳⢽⡽⡽⣽⣻⠊⠀⠀");
                            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠳⣹⡺⡽⡮⡯⣗⡯⣯⢷⢷⣻⡽⣯⢿⡽⣯⢿⡽⣽⡽⣯⢯⡯⣗⡯⣯⣻⣺⣺⢽⣞⡯⣗⠃⠀⠀⠀⠀⠀⠀⠀⠀");
                            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠱⣹⡪⣯⡻⣺⢽⡽⡽⡯⣷⣻⢯⡿⣽⢯⡿⣽⣳⢿⡽⡯⡯⣗⡯⣗⣗⣯⢾⣻⡺⠝⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠫⣺⡪⡯⡯⡯⣟⣯⢷⡯⣯⢿⡽⡯⣯⣷⣻⡯⣟⣯⢿⣽⣺⣻⢾⢽⢽⠎⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡀⠫⡫⣏⡯⣗⣯⢯⡯⣯⡯⣿⢽⣳⣟⣾⣻⣯⢿⡽⣞⣷⣻⡽⡋⠅⠠⠐⠀⠠⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠄⠂⡐⠡⠫⡳⡽⣽⢽⢷⣟⣿⣽⢿⣞⣯⣷⣟⣯⡿⡯⡳⡑⡢⠂⠅⡈⠀⠂⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠁⠁⠂⠕⠑⠝⠫⠻⠫⠟⠟⠟⠟⠝⠝⠕⠑⠅⠊⠀⠂⠈⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                            Console.WriteLine("");
                            Console.WriteLine("당신은 사과를 얻었습니다. 이것이 왜 필요한지는 알 수 없지만... ");
                            Status.Line();
                        }
                    }
                    else
                    {
                        BTWS();
                        Console.WriteLine("");
                        Console.WriteLine("아무것도 발견하지 못했습니다... ");
                        Status.Line();
                    }
                    goto go10;
                case "4":
                    EnterLeftCorridor();
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    Thread.Sleep(1000);
                    goto go10;
            }
        }

        private static void Basement()
        {
            Console.Clear();
            BTWS();
            Status.Line();
            Console.WriteLine("⢐⠔⢐⠐⡄⢂⠢⢐⢐⢐⢸⢐⣜⢎⢎⢐⢐⢐⠔⡱⡀⠄⠠⠀⡀⠀⠄⠀⠄⠠⠠⠠⠀⡂⠄⠂⠄⢂⠐⡀⠂⠄⠂⠄⠂⠄⠂⠄⢂⠐");
            Console.WriteLine("⠠⢑⠐⠨⢐⠠⢑⢐⢌⡆⡪⡷⣳⡙⠄⡂⠅⡂⠌⠔⠨⠨⢈⠢⠨⠪⡘⢌⠌⠌⡂⠡⠈⠐⠈⠈⠊⠐⠈⠐⠁⠊⠄⢅⠪⠠⡡⢨⠠⠨");
            Console.WriteLine("⠌⡒⠅⡁⢇⠨⢐⠅⢔⢇⡮⡯⡒⠄⠅⡂⠅⢂⢁⠊⠨⠐⠀⠐⠨⠨⠨⢐⠨⠐⠀⠐⠀⠀⠀⠀⠀⠀⠀⠀⠀⠁⠐⠀⠌⡐⡈⠢⠀⠅");
            Console.WriteLine("⠡⡘⢔⠨⠰⡈⡢⡣⢑⢯⢞⡝⡈⢌⢂⠂⠅⡂⢐⠈⡀⠂⠈⠀⠌⠌⠐⠀⠠⠐⠈⠀⠀⠐⠀⠀⠀⡀⠀⠀⠁⠀⠁⢈⠀⠄⠂⠁⠀⢂");
            Console.WriteLine("⡐⡈⡂⢂⢑⠔⢨⣪⢮⢯⠳⡐⡨⢐⠄⠅⠅⡂⢂⠐⢀⠀⠂⠀⠱⠀⢂⢐⠀⡀⠀⡀⠀⠀⠀⠀⠀⠀⠀⠐⠈⠀⠈⠀⠀⢀⠂⠀⡈⠀");
            Console.WriteLine("⠔⡐⢌⢂⠢⡣⢅⡷⣝⡕⡑⡐⠌⠔⡨⢈⢂⢂⠂⠌⠀⡀⠂⠁⠨⠈⠀⡇⡏⢮⢹⢸⣘⢆⢗⡒⡖⡔⡤⡢⢤⢄⢄⠀⠄⡐⠀⠠⠀⠌");
            Console.WriteLine("⡕⢐⠨⡂⢅⣟⣗⢟⡞⡐⢌⠢⢑⠡⠂⠅⡂⠔⠐⢈⠀⡀⠄⠈⢌⠈⡀⢇⢎⢎⢢⠱⡐⢅⢅⠕⢍⠪⢪⠪⡣⡓⠁⠀⠄⠐⠀⢂⢁⠂");
            Console.WriteLine("⢕⠡⡘⡵⢡⣺⡺⡕⢅⠌⡂⡪⢐⠡⠡⢑⠠⠡⠈⠄⠠⠀⠐⢈⢐⠀⡐⡕⡕⡅⡇⡕⡅⡣⠢⡣⡑⢕⠅⡇⢎⡊⠀⢂⠁⠄⠐⡀⡂⠅");
            Console.WriteLine("⠡⡊⠔⣝⣗⢧⡫⢊⠔⠡⢊⢐⠄⢅⢑⢐⠨⠀⠅⠂⡐⠈⡐⢀⠢⠐⢨⢪⢪⢪⢪⢒⠜⡌⡕⡅⡕⡕⢕⢕⢕⠐⠈⠠⠀⠄⢂⠐⢄⢑");
            Console.WriteLine("⠮⣇⠣⣳⣯⡳⢑⢐⠅⠕⡁⡂⡊⠔⡐⢐⠈⠌⠠⢁⠀⡂⡐⠄⠕⢈⢸⢜⡜⡜⡜⡜⡜⡜⡌⡆⡇⡝⡜⡜⡌⠠⢈⠐⢀⠐⡀⡊⡐⠄");
            Console.WriteLine("⢝⢮⢟⡯⡾⠨⡂⢅⠪⡈⡢⠨⢐⢁⠂⠅⠌⠄⠅⢂⠐⡀⡂⢌⠊⠄⡺⣜⣜⢎⢞⢜⢜⢜⢜⢜⢜⢜⢜⢜⠔⢀⢂⠈⡀⢐⠠⢂⠂⠅");
            Console.WriteLine("⢕⢯⡯⡯⢃⢑⠌⡢⠡⢂⠢⠡⡁⠢⠨⠨⠠⠡⠈⠄⢂⢂⢂⠢⡡⢁⢯⣪⡲⣝⢜⣕⢵⢱⢱⢱⢕⢵⢹⡘⠠⢐⢀⠂⡐⢐⠨⢐⢈⢂");
            Console.WriteLine("⡾⡝⣞⠅⢕⢐⢅⠢⡡⢑⢈⠢⠨⠨⡈⡂⠅⢊⠨⢈⢐⢐⠄⢕⢐⢌⢾⢜⢮⢮⢳⢕⡵⡹⣪⢣⡳⡕⣇⠇⡁⡂⡂⢂⢐⢐⠨⢐⠐⠄");
            Console.WriteLine("⡯⡯⡃⡊⡢⢑⠄⢕⠠⡑⠄⠅⠅⠅⡂⢄⢑⢐⠨⢐⢐⠔⡡⢱⢐⢸⢽⣝⣝⢮⢗⣝⢼⡪⣇⢗⡵⣽⡜⡀⠢⢂⠂⡂⡂⡂⡊⠄⠅⠅");
            Console.WriteLine("⣯⠣⡊⢔⢌⠢⡑⡐⡡⠂⠅⠅⠅⢅⢂⢂⢂⠢⡈⡂⡢⡑⡌⢆⠕⣜⣷⣳⢽⢝⣗⡽⣕⢷⢕⣗⡵⣝⠆⡊⢌⠢⠨⢐⢐⢐⠌⢌⠪⡈");
            Console.WriteLine("⢇⠪⡨⢂⠢⡑⡐⡡⠂⢅⢑⠡⢑⢐⢐⢐⢐⢐⠔⡨⢂⢪⢨⠪⡂⣷⣳⡯⣯⣟⢾⢽⢝⡽⣝⣞⢮⡳⠡⠨⡂⡊⠌⢔⢐⠅⡪⢐⠅⡂");
            Console.WriteLine("⠅⡕⢌⠢⡑⢌⢂⠢⠡⡑⢄⢑⢐⢐⢐⢐⢐⠔⡁⡪⡘⡌⡆⡇⢕⣽⣾⣻⢷⣻⡯⣟⣯⣟⣞⡾⣽⢊⢌⢪⢴⢴⣕⢧⡳⣯⣞⣖⡵⡬");
            Console.WriteLine("⡑⢌⠢⡑⢌⢂⠢⡡⢑⢐⠔⡐⡐⡁⡢⠂⢅⠢⡑⢔⠱⡘⡰⣘⢌⠿⠾⣟⣿⢷⣟⣯⡷⣯⡷⣿⡝⡐⡌⡪⢱⠑⡕⡏⡝⡎⡞⡮⢯⢟");
            Console.WriteLine("⠪⠢⡑⢌⠢⡑⢌⢐⠡⡂⠌⢔⠐⢌⢐⠅⡑⢌⠌⢆⠣⡱⣘⢆⢇⢫⢑⠕⠬⡍⡫⡓⡟⡯⣿⣳⢣⢑⠔⢌⢪⢘⠔⡍⣺⢜⢸⢨⢣⢣");
            Console.WriteLine("⠪⡨⠨⡂⢕⠐⢅⠢⡑⡐⢅⢑⠌⡂⠢⢑⢈⢂⠅⢥⢱⢸⢸⠸⡘⡌⡆⡝⢌⠎⡜⢜⢌⠪⡒⡜⢔⢡⠨⢊⢢⠡⡃⢎⠢⡱⡘⡌⢆⠣");
            Console.WriteLine("⠅⡂⠕⢌⠢⢑⠡⠊⡐⡈⢄⢂⢂⠢⡑⡰⣐⢢⠣⢣⢑⢅⠕⢕⢅⠣⡣⡊⢆⢣⠪⡢⡑⢕⠱⡱⡱⡑⡨⠨⡂⢕⠨⡂⢕⠨⡂⠎⢜⠨");
            Console.WriteLine("⡘⡌⡊⠄⢌⠔⡈⡢⢂⢊⠔⡰⡢⡱⡘⡜⢔⢅⢍⠆⡣⠢⡑⡡⠢⡑⢔⢘⠌⡢⠣⡪⡊⢎⢎⢎⢎⠆⠪⠨⡐⠡⡊⡐⠔⡡⠨⠨⢂⠑");
            Console.WriteLine("⢊⢆⢊⠌⡢⢌⠢⢪⢸⡪⡎⣎⢪⠱⡱⡘⡔⡌⡢⢃⠪⠢⡊⡄⢕⠨⢂⠢⡑⢌⠪⠰⡘⡜⡸⡸⡘⡌⢘⠌⡂⠕⡐⠌⡢⠨⠨⢊⢐⠡");
            Console.WriteLine("⢆⢇⢢⢕⣕⢏⢯⡪⡎⡎⡎⢎⢎⢎⢎⡲⡸⡨⡊⠜⢌⢪⠰⡨⢂⠣⡡⢱⠨⡢⡑⠕⢅⢪⠢⡣⢪⠨⠐⡨⢐⠡⡨⢂⠌⢌⠊⢔⠠⠡");
            Console.WriteLine("⣝⢽⡸⡸⡨⡓⡇⡧⡳⡱⡱⡱⡱⡸⡨⡪⠺⡰⡱⡩⡪⢢⢑⠜⡰⢑⢌⢢⢑⠬⡘⡜⢜⢔⢱⢑⢅⠕⡁⢂⠕⠨⡐⡐⡡⢁⠪⢐⠨⡈");
            Console.WriteLine("⣳⡣⡣⣣⢣⢣⠣⡢⡃⡣⡣⡣⡣⡣⡣⡪⡪⡒⢜⢌⠪⡪⢪⢪⢊⢎⢆⢕⢅⠣⡣⡣⢕⢌⢎⢜⢸⠨⡐⠐⢌⠊⢔⠐⢌⢐⠡⢂⠅⡂");
            Console.WriteLine("⢧⢣⢣⢣⢣⠕⡕⡱⡨⡒⡌⡆⡣⡹⢸⢸⢰⢱⢱⢘⢜⢌⢆⢕⢑⠱⢱⢱⡸⡸⡰⣸⢨⢪⢪⢪⢪⠪⡂⠡⠡⡊⠔⡡⠡⢂⢑⢐⢐⠄");
            Console.WriteLine("");
            Console.WriteLine("지금까지와는 차원이 다른 어둠으로 앞을 분간하기가 어렵지만...");
            BTWS();
            Console.WriteLine("당신은 용감하게 대담하게도, 지하실로 향하는군요...");
            BTWS();
            Console.WriteLine("조심하지 않으면 금방이라도 발을 헛디딜듯한 계단을 조심히 내려가봅니다....");
            BTWS();
            Console.WriteLine("곧 지하실로 추측되는 굳게 닫힌 문이 보입니다...");
            BTWS();
            Console.WriteLine("문은 자격을 갖춘 이 만을 들여보내줄 듯 합니다...");
            BTWS();
            Console.WriteLine("안에서 불길한 소리가 아주 미세하게 세어나옵니다...");
            BTWS();
            Console.WriteLine("어떻게 하시겠습니까...");
            BTWS();
        go13:
            Status.Line();
            Console.WriteLine("[1] 지하실 문을 열고 싶다면 1번을 눌러주세요...");
            Thread.Sleep(300);
            Console.WriteLine("[2] 왔던 장소로 되돌아가시려면 2번을 눌러주세요...");

            string input19 = Console.ReadLine();
            Console.Clear();
            switch (input19)
            {
                case "1":
                    Base();
                    break;
                case "2":
                    Livingr();
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    Thread.Sleep(1000);
                    goto go13;
            }
        }

        private static void Upstair()
        {
            Console.Clear();
            Status.EnterField(player);
            Status.Line();
            Console.WriteLine("⠀⡂⠢⡡⡃⡇⡗⡽⣯⣯⣟⡾⣝⢮⡳⡕⣗⢕⢧⢳⠹⡜⡎⡞⢮⢪⢳⢹⢪⢳⢝⢮⡳⢽⢕⢯⢳⢝⢽⢝⢯⡫⡯⡯⡪⡂⢂⠂⡂⡐");
            Console.WriteLine("⠂⠌⡂⡢⡱⡹⡜⡿⣿⣷⣯⣯⡳⡱⡱⡑⡆⡇⡣⡢⠣⡒⡌⡪⢢⢣⢱⢱⢕⢧⢳⡳⣹⢕⣏⢗⡽⡹⣝⢽⢵⡫⣗⢽⢱⢁⠂⠌⡀⡂");
            Console.WriteLine("⠈⠔⡐⠔⡱⡸⡱⣻⣷⢿⣻⣳⣽⣺⢼⣪⢮⢮⠮⡮⡺⡼⣪⢞⣞⢞⣞⢾⣺⡳⣗⣯⢷⣻⢾⢽⣞⣯⢷⣻⢗⣝⢮⢳⡱⡡⢈⠂⡂⡐");
            Console.WriteLine("⠁⠌⡢⠑⡌⡪⡪⣻⣺⣻⢮⡪⣖⡕⡗⣜⢜⢔⢕⢕⢕⠕⡕⡕⡪⡣⣣⢳⢕⡽⡺⣪⢯⢮⡳⣝⢮⡺⣝⢮⣻⢜⣕⢗⡕⡅⠂⡂⢂⢐");
            Console.WriteLine("⠄⠅⠌⡌⡢⡣⡫⣞⢮⢺⡣⣏⢮⢎⢧⡣⣇⢧⡣⣣⢣⠣⡣⡕⣕⢭⡪⣎⣗⢝⢮⢗⣗⡵⡯⣮⡳⣝⢮⢳⡳⣣⡳⣕⢕⠅⠌⡐⡐⡀");
            Console.WriteLine("⠂⠅⡑⡐⡸⡰⣱⢳⡱⡣⡯⡺⡸⣪⢳⡹⡸⡱⡱⣱⢑⠕⡕⡝⡜⡕⡝⡎⣞⢜⢵⣫⡺⣪⡫⣎⢯⡺⣪⡳⡽⡪⡮⣪⢣⡃⠡⢐⢐⠠");
            Console.WriteLine("⢂⠡⠨⡂⢎⢪⢪⡣⡣⡱⡣⡫⣪⢺⡸⡸⡸⡨⡢⡣⡣⡑⡕⢕⢕⢱⢱⢹⢜⢕⢧⡳⣝⢲⡱⡕⣯⢺⢜⢮⣫⡳⡹⣜⢎⠆⡁⡂⡐⠄");
            Console.WriteLine("⢐⢈⠢⠸⡸⡰⣱⢝⢌⢪⢣⢫⠪⡪⡪⡪⠢⡃⢎⢜⠔⢌⢪⠪⡊⢆⢣⢣⢫⢪⡪⣞⢜⢵⢱⡹⣪⡳⡹⣪⣺⢪⡫⣪⢺⠨⢀⠂⠄⠅");
            Console.WriteLine("⠐⡠⠊⠄⢕⢝⡜⡕⡅⢕⢕⠕⡕⢕⢕⢕⢑⢅⠕⢜⢌⠢⡑⢕⠜⢌⢪⢪⢪⢣⡚⡮⡝⡎⣇⢗⡗⣝⡜⡮⣺⢕⡝⣜⢽⠨⠐⡈⠄⠡");
            Console.WriteLine("⠐⠄⠅⢅⠅⡇⡯⡣⣊⠪⡪⡊⢎⢜⢔⠕⢌⠢⡡⢣⠑⢌⠪⡘⢌⢊⢢⠣⡣⡣⡣⡯⡺⡸⡜⣜⣞⢼⡸⣕⢽⣪⢺⢸⡺⡨⠐⡠⠁⠅");
            Console.WriteLine("⡁⠅⢊⠄⡣⠪⣚⢗⠔⢅⢇⢎⠪⢢⠱⡡⢡⠑⠔⡱⠡⠡⡱⢘⢌⠢⡱⡑⡝⡜⡜⡮⣣⢫⣚⢦⡳⣕⢵⢕⢽⣪⡣⡳⣝⠄⠅⠄⠡⠈");
            Console.WriteLine("⠄⡑⡐⡐⠌⡎⡎⡎⣊⠢⡣⠢⢍⢢⠣⡊⠔⡡⢑⢸⠨⡈⡢⢱⢐⢑⠌⡎⡪⡪⡪⣫⢪⢎⢮⢲⢝⢮⢪⡳⣝⣖⢵⢹⣎⢊⠄⠡⠁⠅");
            Console.WriteLine("⠡⢐⠀⢇⢑⢜⢜⢜⢄⠣⡣⠩⡊⢔⠱⠨⡨⢐⠡⢸⢀⢂⠪⡂⡪⢐⠅⡇⣣⢣⢣⣻⢸⢪⢺⡸⣝⢎⢧⡳⣕⢧⡳⡱⡧⡡⠂⠡⠁⠅");
            Console.WriteLine("⡁⠢⢈⢢⢱⢸⢘⢎⠔⡡⡣⡑⢅⠕⣑⢑⢐⢁⢊⠬⡐⠄⢕⠌⡢⠡⡑⡕⢜⢜⢔⣗⢝⡜⣕⢕⣗⣝⢵⡱⡽⣱⡣⣫⢗⠄⠅⠡⡈⠂");
            Console.WriteLine("⠐⡁⡂⡱⢘⢜⢜⢜⢐⠌⡆⣊⠢⡱⡐⢅⠢⠡⡂⢪⠠⡑⢔⢑⠌⡌⠆⡇⢇⢇⢇⣗⢵⢱⢕⢕⡗⡮⣪⢺⡪⣗⢝⣼⡣⡑⠨⢐⠠⠡");
            Console.WriteLine("⠐⡐⡐⠨⡢⡝⡮⡇⡢⡑⡕⡐⡱⠰⡘⢔⠡⡑⠌⡸⠐⠄⡕⢌⠢⡊⡪⢊⢎⢎⢆⡷⡱⡳⡱⣳⢹⡺⣜⢵⣹⣪⢳⡱⣇⢊⢐⢀⠂⠡");
            Console.WriteLine("⠂⡂⡂⡑⡜⡕⣕⡇⡪⢂⢇⠪⡨⠪⡓⡱⠙⢌⠣⢙⠨⡈⡊⡃⡫⠪⡩⢍⢝⠜⡜⡪⡫⡫⡫⡫⣫⢫⢮⣪⡺⣜⢵⢝⡎⡢⠐⠠⠨⠠");
            Console.WriteLine("⠐⡐⢐⠨⢪⡺⡰⡕⠜⢌⢎⢜⠨⡊⢔⢨⠨⡂⢌⢂⢂⢂⢊⠔⡨⡨⢢⠱⡘⡜⡜⣜⢕⡝⣜⢵⡱⡳⣕⢵⣹⡪⡳⣝⢜⠔⠈⠌⡠⠡");
            Console.WriteLine("⢐⠨⢐⢈⢢⢫⢪⢪⢊⢪⠪⡢⡑⢍⠪⡊⡪⡘⢌⠪⡨⢊⠢⢃⢕⠨⡸⡸⡱⡝⣺⢪⡳⣝⢮⢗⡯⡫⣎⢮⢺⡪⡯⣺⢸⠨⢈⢐⠐⡈");
            Console.WriteLine("⢀⠊⠄⡂⡪⢪⢪⢪⠢⢱⠱⡂⢎⠢⢣⢑⠔⢌⠢⠡⢂⠅⠪⡐⡅⠪⡸⡨⡊⡎⢎⢎⢎⢎⢎⡇⣯⡺⡜⡮⣳⢝⡞⣎⢇⠕⡀⢂⠂⠌");
            Console.WriteLine("⠂⠅⠅⡂⢎⢎⢎⢎⢪⢨⢣⢑⠅⡕⡱⡐⢅⠢⠡⡑⡐⠌⢌⢂⠎⡌⢜⢌⢎⢜⢜⢜⢜⢕⢕⡕⣗⢵⢹⡪⣺⢵⡹⣪⡣⡑⡀⠂⠌⠠");
            Console.WriteLine("⢈⠌⡐⢌⢢⢳⡹⡸⡐⢜⢜⢔⢱⠨⡢⠪⡰⠨⠌⢔⠐⢅⠪⢐⢕⠨⡸⡌⡆⠧⡱⡱⢕⢵⢱⢕⢯⡪⣣⡫⢮⢇⢯⡪⡎⡢⠠⠡⠈⠌");
            Console.WriteLine("⢃⢂⢂⠪⡸⡸⣜⠮⡘⢌⣗⡿⡜⢜⢒⢓⠪⢚⢘⠢⡃⡣⡚⣒⢕⡱⣘⣚⣎⢗⢏⢞⡓⡗⡳⣓⢗⡻⡜⡼⣕⡏⡧⡫⡎⢆⠂⠡⠈⠄");
            Console.WriteLine("⡐⡐⡐⢨⢘⢞⣜⢎⠜⡰⡕⡹⡘⢌⠢⡂⠕⡐⡡⢂⠢⢊⢟⢝⠽⡹⡫⡳⡻⡏⡎⡆⡇⡇⡇⡇⣇⢇⡏⡮⢮⢮⢳⡹⡍⠆⠌⠄⠡⠈");
            Console.WriteLine("⡈⠄⡂⡑⡌⡧⡳⡱⡑⢔⢕⢌⢌⢪⠪⡪⣑⢱⢘⢸⠠⠡⡪⠸⡸⡸⡸⡱⡹⡘⡜⡼⠵⣝⣝⢮⡳⣝⢮⢹⢕⡗⡵⣹⠭⡊⠌⠨⢈⠈");
            Console.WriteLine("⠂⠅⡂⠢⡱⢵⡹⡱⡨⠢⡣⠢⡑⢌⠪⡂⡢⠡⡂⡪⡈⡂⢎⠜⡨⠨⡨⠢⡣⡣⡊⣞⠭⡲⡱⡱⣝⢮⢪⢇⣗⡝⡞⡮⡫⡂⠅⠌⡀⢂");
            Console.WriteLine("⡈⠢⠨⢨⢸⢸⣪⢳⠨⡊⡎⢪⠨⡘⡌⡢⢂⢑⢐⢸⢀⠢⡑⠌⠔⡡⠨⡪⢸⠰⡘⣜⢎⢎⢎⢎⢞⣎⢧⢳⡱⣝⢎⢯⡣⡊⠄⠡⠐⡀");
            Console.WriteLine("⢈⠌⢌⠢⡣⣓⢮⡣⡑⢌⢎⠢⡑⢜⢌⢂⠢⠡⡂⢪⢐⠠⡃⢕⠡⢂⠕⢌⠎⡎⢜⢜⢎⢎⢎⢎⢧⡳⣱⢣⢏⡮⡳⣽⢪⠂⠅⡁⢂⠐");
            Console.WriteLine("⠠⠡⠡⢊⢜⠼⣕⢧⢑⢅⠇⢕⢘⠔⢜⠄⠅⠕⡨⢘⠄⡂⢕⠰⠨⡐⢌⠢⡣⠣⡑⢽⢸⢸⢸⢸⢪⢞⣜⢕⠧⡯⡪⡾⡕⢌⠂⡐⠠⠨");
            Console.WriteLine("⢨⠨⠨⢂⢕⢝⣞⢧⢑⢸⡘⢌⠢⡩⢢⠃⠅⠕⡠⢱⠐⠄⡣⢊⠔⡐⠔⡑⡜⡅⡣⣻⢸⢸⢸⢸⢪⣳⢱⢭⠳⡝⡎⣯⡇⠕⡐⠀⠅⢂");
            Console.WriteLine("⢐⠨⡈⡂⡪⣺⣪⢧⢑⢔⢕⢡⠱⡘⡔⠅⠕⡁⡢⠱⡈⢂⢕⢐⠔⠨⡈⢆⢣⠕⢔⢺⢸⢘⢌⢎⢞⢮⢺⢸⢕⢯⢪⢷⡣⡑⠄⡁⠅⢐");
            Console.WriteLine("⢐⢐⠐⢌⢢⢳⢵⢧⢑⢌⢆⠕⢌⠪⡘⡌⠌⠔⡠⢱⠠⢁⢆⠢⢊⠐⢌⠢⡣⡣⠡⢽⠸⡘⡜⢜⢼⢕⢇⢗⡕⡯⣪⢯⡇⡪⠐⠠⠈⠄");
            Console.WriteLine("⠅⡢⠡⢑⢌⢮⣫⢧⠱⡘⡆⢕⢡⢑⢕⢐⠡⡁⡢⢑⠌⡐⢔⠑⢄⠑⢄⠣⡱⡊⠜⢼⢑⢕⠱⡑⡵⣹⢸⢱⡱⣫⢪⣻⠜⠄⢅⠌⠄⡁");
            Console.WriteLine("⠨⡐⠌⡰⢸⢸⣺⢇⢇⠪⡪⢐⢅⠪⡢⡑⡐⡐⡐⣑⠐⠄⡣⢑⠄⡑⢄⠣⡱⢅⠣⣹⠂⡇⠕⡅⢽⢜⢜⢕⢕⡗⣕⢯⢇⢃⠕⢀⢂⠐");
            Console.WriteLine("⠑⢄⢑⠐⡕⣝⢾⢕⠢⡱⡡⡑⠔⡱⡰⣘⢔⡱⡰⣰⠡⡁⢎⢆⡕⣅⢇⣕⢝⢔⠡⢺⣸⣨⡣⣝⣜⢮⡪⡪⡪⡞⡼⣝⢎⠔⡐⠠⠐⢐");
            Console.WriteLine("⠌⡂⡂⠕⢌⢎⡯⣗⠑⢌⢆⠪⡨⠢⠨⡐⡐⢌⢐⢐⠐⠄⢅⢂⢂⠢⡁⡂⢅⠢⡊⡂⢆⠢⡊⡢⡊⡪⡸⡸⡘⣎⢮⢗⡕⡑⢄⠡⠈⠄");
            Console.WriteLine("⠕⡐⠌⢌⢢⡳⣽⡣⢡⠱⡅⡪⡂⡇⡕⢌⢢⠡⡢⡑⢌⠪⡐⢔⡐⡅⢆⠪⡢⢱⢨⠸⡐⡕⡌⡆⡇⡕⡅⡇⡇⡇⡗⡯⡪⢨⠂⠄⠅⢂");
            Console.WriteLine("⢌⠢⠡⡁⡇⡽⣺⣪⣢⡱⣧⣷⣵⣵⢾⡼⣮⣮⣶⣵⣵⣵⣵⣵⢮⣮⣮⣮⣮⡶⣵⢧⡷⣵⢾⣼⣼⣮⢾⡾⣾⢧⣫⡗⡕⡑⢬⠠⢁⠂");
            Console.WriteLine("⡐⢅⢑⢐⢱⢹⢵⣳⣗⣕⡻⡚⡞⣝⠻⣙⢏⡛⡞⡞⢞⢳⢓⢏⠟⡝⣺⠹⡞⣛⢛⢝⢟⢟⢫⡛⡞⣏⡻⡻⣝⢝⢻⣟⣆⠎⣸⢀⠂⠌");
            Console.WriteLine("⡜⡐⢌⠢⡡⡳⡽⣾⢾⢿⣽⣟⣾⢾⣽⢮⡷⡷⡷⡯⣷⢷⢷⣟⡾⣾⢾⣮⡿⡾⣷⣻⢾⡽⣷⢿⢿⢷⢿⣻⢿⡕⡆⠪⣳⡕⡨⢀⠂⡁");
            Console.WriteLine("⢌⠢⡑⢌⢜⢼⢇⢇⢝⠸⡐⠔⢌⠢⢂⠕⡨⠨⡨⠨⢂⢃⠇⡂⠣⢊⠢⢂⢃⠣⡂⠕⢅⠕⡌⢜⢌⠪⡢⡪⡱⡽⡸⠨⡈⢗⢸⠀⠂⢌");
            Console.WriteLine("⡢⡑⠌⡌⡢⡯⣗⢕⠔⡱⡘⠌⡂⡊⠔⠨⠐⢅⠊⡌⠢⡂⢅⠊⢌⢂⠅⡑⠄⣵⠨⠨⢂⢑⢌⠢⢢⢑⠡⡣⡪⣗⡕⢕⠐⢅⠸⢀⠑⡐");
            Console.WriteLine("⡢⠊⢌⢂⢇⢯⣳⢬⢢⢱⢨⢂⢆⠪⡨⡨⡊⢔⢡⢊⢆⢌⠪⡊⡪⡢⠪⡐⣅⢺⢌⢪⢰⢢⢢⢣⢣⡢⣱⢱⣪⢗⡕⡑⢌⠂⢭⠐⡀⠂");
            Console.WriteLine("⠇⢅⠕⡐⡕⣝⣾⢿⢯⣿⣽⣽⣮⣯⢾⣞⣾⣳⢷⡷⣷⡯⣟⣾⣵⣟⣾⢽⡮⣟⣷⢯⡷⣯⣯⣯⣷⣻⣾⣻⣟⣗⡕⢕⠐⠅⡊⡠⠀⠅");
            Console.WriteLine("⡑⢅⢊⢔⢣⡳⡽⡩⡋⡓⠝⡪⢓⡙⠝⠪⠓⠝⠝⢝⢑⠛⠝⡪⠚⠕⡋⡫⢋⢛⠚⠝⠫⢛⠪⡓⡻⡙⡚⡓⡝⡝⡎⡆⢅⢑⢨⢂⢁⢂");
            Console.WriteLine("⢌⠢⡱⡂⡇⡯⡎⡇⡪⢐⠡⢂⠂⡂⠅⠡⠡⠡⡁⡂⠂⠅⠅⡂⠅⠅⢂⠂⡂⡂⠡⠡⢑⠠⢁⢂⠊⢔⠨⡂⢇⢽⢕⢜⢐⢐⠸⡐⡀⠅");
            Console.WriteLine("⠢⡡⡣⢂⢟⢮⢣⢊⡂⢅⢪⠠⡡⡐⡨⡈⡄⢅⢂⠌⡌⢌⢂⢔⡨⢐⢐⢐⢐⠄⢅⠅⠅⡌⢔⠠⢃⠕⡘⢌⢎⢮⢇⡣⢂⠢⠨⡢⠐⢀");
            Console.WriteLine("");
            Console.WriteLine("당신은 또한번 몬스터를 물리치고 2층 문 앞에 섰습니다...");
            BTWS();
            Console.WriteLine("열릴지는 알 수 없지만...");
            BTWS();
            Console.WriteLine("안에 무엇이 들어있을지도 알 수 없으니까요....");
            BTWS();
            Console.WriteLine("어떻게 하시겠습니까...");
            BTWS();
        go14:
            Status.Line();
            Console.WriteLine("[1] 2층 문을 열고 싶다면 1번을 눌러주세요...");
            Thread.Sleep(300);
            Console.WriteLine("[2] 왔던 장소로 되돌아가시려면 2번을 눌러주세요...");

            string input20 = Console.ReadLine();
            Console.Clear();
            switch (input20)
            {
                case "1":
                    Random rand = new Random();
                    int randValue = rand.Next(0, 101);
                    if (randValue <= 40)
                    {
                        var item = Item.items.Find(i => i.iname == "집키3");
                        if (item != null)
                        {
                            Player.Getitem(item);
                            BTWS();
                            Console.WriteLine("");
                            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀   ⠀⠀⠀⠀⠀⢀⢀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀   ⠀⠀⠀⢀⢦⠯⠻⠻⠻⢿⡾⣦⣀⠀⠀⠀⠀⠀");
                            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀   ⠀⠀⠀⢀⣤⢼⢊⠀⠀⠀⠀⠀⠈⠛⢿⣷⡀⠀⠀⠀");
                            Console.WriteLine("⠀⠀⠀⠀⣺⣿⢿⣻⣟⣟⡿⣝⣟⢻⣛⢏⡟⡟⢏⢋⡋⡙⡕⡃⣣⢊⢮⢒⢒⠒⢒⢲⠲⢾⡞⢜⡎⡢⢀⠀⠀⠀⠻⣿⡀⠀⠀");
                            Console.WriteLine("⠀⠀⠀⠀⣷⡿⣟⣿⣯⡟⠟⠯⠯⠟⠛⠛⠛⠛⠯⠳⠻⠳⠳⠿⠻⠷⠿⠟⠿⠿⠽⠾⠯⣿⣿⡖⢬⠚⠑⠀⠀⠀⢿⠪⠀⠀");
                            Console.WriteLine("⠀⠀⠀⢐⣯⣿⣟⣿⣷⣿⣝⣮⡲⡂⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠻⢿⡐⠀⠀⠀⠀⠀⠀⠀⠀⢀⠟⠀⠀⠀");
                            Console.WriteLine("⠀⠀⠀⠸⣿⡟⣽⣿⢽⣾⣻⠹⣾⡁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠐⢻⣦⣠⡀⠀⡀⡀⡠⡰⡁⠂⠀⠀");
                            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠈⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠙⠛⠟⠛⠋⠊⠀⠀⠀⠀⠀⠀");
                            Console.WriteLine("");
                            Console.WriteLine("당신은 집키3 을 얻었습니다. 이것이 왜 필요한지는 알 수 없지만... ");
                            Status.Line();
                        }
                    }
                    else
                    {
                        BTWS();
                        Console.WriteLine("");
                        Console.WriteLine("아무것도 발견하지 못했습니다... ");
                        Status.Line();
                    }
                    goto go14;
                case "2":
                    Corridor3();
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    Thread.Sleep(1000);
                    goto go14;
            }
        }

        private static void ShowInventory()
        {
            Console.Clear();
            Item.showInven(Player.inventory, player);
            Thread.Sleep(1500);
        }

        private static void Escape()
        {
            Console.Clear();
            Status.Line();
            Console.WriteLine("⡣⡣⡇⣇⢧⢣⡣⣣⢣⡣⡳⡱⡕⡕⡕⡕⡯⡪⡪⣺⢸⢪⢪⢪⢪⢪⢪⢺⡇⡇⡇⡇⡇⡇⡇⡇⡇⡣⡣⡣⡓⣇⢇⢗⢕⢕⢕⢕⢕⢕");
            Console.WriteLine("⡎⡗⡝⣔⢕⢇⢏⢎⡕⣎⢮⢣⢣⡣⡣⡣⡻⡸⣸⢸⢸⡸⡸⡸⡸⡸⡸⣸⠇⡕⡕⡕⡕⢕⠕⡅⢇⢇⠇⡕⡕⢇⢇⢇⢧⢣⢣⢣⢣⢣");
            Console.WriteLine("⢜⣕⢝⢜⢜⢕⢕⢇⡳⡸⡸⡸⣸⢸⢸⢸⢵⢝⢎⢷⢵⣣⢳⢹⡸⡸⡪⡪⡣⡣⡣⡣⡹⡸⡱⡩⡪⢲⣑⡇⢯⠊⡎⡮⡪⡪⡪⡪⣪⢪");
            Console.WriteLine("⢕⢵⢱⢣⢣⡣⣣⢣⢣⢱⢱⢹⢸⢸⢸⢸⢵⡹⠩⢹⣝⠸⢱⠱⣝⢮⢺⡸⣪⡪⡪⡮⡪⡪⡪⡸⡨⣺⡢⡇⢧⢃⢪⢪⢪⢪⢪⢪⢊⢪");
            Console.WriteLine("⢇⢇⢇⢇⢧⢣⡣⡣⡣⡣⡣⡳⡱⡱⡱⣹⢕⠇⢸⣿⡿⣧⠀⡯⣺⢪⢣⡫⡲⢕⢇⠇⠇⢇⠣⢑⠡⢓⢅⡇⢽⠐⡜⡜⡜⢜⢜⢜⢔⠥");
            Console.WriteLine("⢝⢼⢸⢸⢸⡸⡸⡸⡸⡸⡸⡸⡸⡸⡸⡸⡯⠃⠸⠷⢟⢗⠀⢿⢾⢷⢷⢿⡾⡻⡺⡽⡼⣜⠮⡮⡇⢧⢣⠇⡱⡡⡣⡣⡪⡪⡪⡪⡪⡪");
            Console.WriteLine("⢱⢕⢵⡹⡜⣎⡎⡇⡇⡇⣏⢮⢪⡪⡇⣯⢂⠐⢈⠐⡀⠂⠅⡑⡽⣕⢝⢽⡗⡌⡎⡎⡎⡪⡊⢎⡪⡪⡊⡆⡣⡣⡣⡣⡣⡣⡣⡣⡱⡸");
            Console.WriteLine("⢇⢗⢵⢱⢕⢧⢳⢹⢜⢵⢱⢕⠵⡵⡹⣺⢐⠀⡀⢂⢐⢀⠢⠨⡯⣪⡪⣽⡧⡱⡑⢜⢌⢎⢪⢱⢱⢑⢕⢕⢕⢕⢕⢕⢱⢱⢱⢱⢱⢱");
            Console.WriteLine("⢪⢎⢮⢪⢎⢮⡪⣇⢯⣺⢪⢮⣣⡣⡫⡮⣖⠞⢖⠵⡲⡲⣲⡳⣝⢮⢺⣸⡧⢣⢃⢇⠪⡸⢨⢪⠪⡊⡎⡎⡎⡆⢇⢇⠇⣎⢼⡰⡱⡱");
            Console.WriteLine("⡣⣣⢳⢕⢇⡗⡕⡼⡒⣆⣷⡱⣝⢮⢯⣞⡿⣷⡻⣽⢾⣷⡻⣯⣳⢳⢕⢯⢺⡸⡜⡞⣎⢗⢅⢝⢮⡫⡮⡳⠭⡑⡔⣭⢺⣵⢝⡜⡜");
            Console.WriteLine("⢏⢞⢜⢼⢜⢎⣞⢽⢝⢼⢟⣮⢯⢮⡳⡽⣜⢞⡼⡮⣏⢧⡳⣝⢮⣪⡳⣝⢕⢗⢝⢎⣗⣕⢏⡇⡏⣞⠼⢭⢫⡊⣾⣻⢷⡟⣎⢇⢮⢣");
            Console.WriteLine("⢣⢳⢍⢧⢣⡣⡓⣡⣾⢽⣦⡉⢯⡳⣝⢞⢎⡗⡝⢸⢸⢕⢝⢼⡑⡕⣕⣗⢭⡣⢫⢪⠲⡱⡳⡱⡡⡑⣕⢓⠇⡕⡸⡘⢍⢮⢮⢣⢳⢱");
            Console.WriteLine("⡕⡧⡳⡱⣱⡑⢀⢿⣟⣿⡿⣟⠀⡿⣮⣳⣳⡽⡾⡾⡾⣺⢽⡳⡯⡿⣺⢮⡷⣝⢷⢯⢷⡳⡟⡯⣟⢾⡺⣝⢷⢙⢎⢞⢽⢱⢕⢇⢇⢇");
            Console.WriteLine("⢣⢳⡱⡹⡔⠕⠀⠿⢟⠮⣯⢷⠀⣝⢧⢳⡪⡪⢮⢳⢍⢮⡪⡪⣓⢝⡎⡽⣇⢇⠇⡗⡕⢕⠕⡕⢕⢕⠜⢜⢸⢘⢜⢜⢕⢕⢕⢕⢱⠱");
            Console.WriteLine("⢩⠱⢩⢪⢣⢹⢘⢜⢰⠱⢭⠃⠑⢱⢽⡕⡽⡹⣱⢝⣝⢼⡪⡳⣕⢧⢳⡹⡪⡮⡺⣜⢜⡕⣕⢕⢕⡕⡝⡼⡸⡢⡣⡱⡸⡸⡸⡸⡘⢜");
            Console.WriteLine("⠢⢩⠸⡸⣑⡑⡕⡱⣑⢕⡱⡢⢥⡸⣽⣺⣸⢪⢧⣳⡳⡻⣍⣚⣞⡽⡵⣫⢯⡺⡝⣎⢗⣝⢜⢜⡜⡜⣜⢯⡊⡇⢎⢎⢜⢜⢜⢌⢢⢱");
            Console.WriteLine("⢪⡢⣕⢝⠜⠜⠪⠪⠪⠸⠸⠸⠱⠝⡾⣵⢺⢪⣗⠗⢁⣶⣷⡆⠘⣞⡝⡽⣕⢯⡺⣕⢯⢎⡗⣕⢕⡝⣜⢵⢌⡎⢆⢣⠣⣃⠇⡇⢇⢱");
            Console.WriteLine("⢪⡪⢝⢬⢬⣬⣢⡵⣬⣢⣥⣪⣠⣫⢷⢝⡮⣞⠇⢸⣽⣺⡭⠀⡷⣵⣫⡾⡵⢯⢞⢵⠯⡞⡮⢧⠧⡳⠵⡵⢹⢸⢨⢪⢢⡣⢝⢔⢕");
            Console.WriteLine("⣪⢪⡪⡣⡣⡳⡱⡳⢽⢝⣞⢵⡻⡺⣪⢫⢳⡱⡕⣃⢰⢫⢞⢮⢠⢻⢜⢎⣿⡸⡸⢰⢱⢱⠱⡱⢱⢱⢸⢰⠸⡘⡜⡜⡜⡜⡜⡕⡕⡕");
            Console.WriteLine("⡵⡱⡕⣕⢕⢵⢹⡸⡱⡣⡧⡳⡹⣪⢺⢸⢜⡎⡇⡆⡇⡇⡝⡎⣇⢯⡳⣹⣗⡇⡎⣎⢎⠎⢎⢪⠪⡘⡌⢎⢎⢎⢎⢎⢎⢎⢎⢎⢎⢎");
            Console.WriteLine("⣎⢧⢫⢲⢹⢸⡸⡜⡎⡇⢝⢜⡝⣜⢎⢮⢺⡸⣣⢳⢱⢣⡣⡏⡮⣪⢗⢵⣟⢮⢪⢆⢅⢃⠅⠢⡑⡐⢌⢒⢨⠢⡣⢣⢃⢇⢇⢇⢇⢇");
            Console.WriteLine("⢜⢜⡕⣕⢧⡣⣣⢣⡣⡇⡇⡇⡧⡳⡹⡸⣱⢹⡨⡠⣁⣂⢌⣐⡨⣠⡫⡮⣗⢧⢣⢃⢆⢅⢪⠨⡢⡨⡢⠨⢸⢨⢪⢪⢸⢨⢪⢪⢪⢪");
            Console.WriteLine("⢼⡱⡹⡜⣎⢞⡜⣕⢜⡜⣎⢮⢪⢎⠮⡺⡸⡱⣱⢫⢯⢺⣫⢳⡫⡳⡕⣝⡯⡎⡎⡎⡇⡇⡇⢇⢇⢇⢇⢏⢎⢎⢎⢪⢪⢪⢪⢪⡪⡪");
            Console.WriteLine("⡳⡹⡸⡪⣎⢧⢫⡪⡪⡎⡮⣪⢪⢎⢇⢧⢫⢎⢮⢺⢸⢕⡕⣇⢇⢇⣇⢳⡯⡪⡪⡪⡪⡪⡸⡸⡸⣸⢸⢰⢱⢱⢱⢑⢕⢕⢕⢕⢕⢕");
            Console.WriteLine("");
            Console.WriteLine("고생이 많았습니다...");
            BTWS();
            Console.WriteLine("당신은 드디어 이곳에 도달했군요...");
            BTWS();
            Console.WriteLine("문은 당신의 인벤토리를 열어 당신의 자격을 판단할 것입니다...");
            BTWS();
            Console.WriteLine("아무키를 누르시면 문이 판단을 시작합니다...");
            Status.Line();
            string input19 = Console.ReadLine();

            bool haskey1 = Player.inventory.Any(item => item.iname == "집키1");
            bool haskey2 = Player.inventory.Any(item => item.iname == "집키2");
            bool haskey3 = Player.inventory.Any(item => item.iname == "집키3");
            if (haskey1 && haskey2 && haskey3)
            {
                Program.Playmusic("누구도날.wav");
                Console.WriteLine("⡽⣝⢽⡹⡽⡹⣕⢝⣝⢝⡵⣫⢯⢫⢏⡯⣫⣫⡫⣏⣏⢯⣫⣫⡫⣝⡭⣫⢽⡹⡽⡽⡽⣝⣯⣻⣝⣯⣻⢽⣫⣟⡽⡽⡽⡽⡽⡽⡽⡽⡽⡽⡽⡽⡽⡽⡽⡽⡽⡽⡽⡽⡽⡽⡽⣝⡽⣝⡽⣝⢽⡹⣝⣝⣝⢭⡫⣝⢭⡫⣝⢭⡫⣝⢭⡫⡝⣎⢏⢎⢇⢏⢎⢇⢏⢎⢎⢎⠪⡊");
                Console.WriteLine("⣝⢾⢵⡳⡽⣝⢎⢧⡳⡝⡮⣳⢳⢝⡵⣝⢮⡺⣚⡮⡮⣳⢵⡺⣪⢷⢽⢵⡳⡽⡽⡽⣝⣗⣗⣗⣗⢷⣝⣗⣗⣗⡯⡯⡯⡯⣞⡽⣝⡽⣝⡽⣝⢾⢝⡾⣝⣞⢽⣪⢯⣞⡵⡯⣺⢵⣝⣞⢮⣳⡫⣞⢵⢕⡮⣳⢹⢜⢮⢺⢜⢵⡹⣜⢵⢹⡪⡺⡸⡱⡱⡱⡑⡕⢕⢅⢇⢎⢪⢘");
                Console.WriteLine("⡾⡽⣕⡯⣞⢮⢯⡳⣕⢯⡺⣪⢯⡳⣝⢮⢳⢽⢵⣝⢮⡗⡷⣝⣗⢯⣗⢯⢯⣞⢽⣺⣳⣳⣳⣳⣝⣗⣗⣗⣗⣗⡯⡯⡯⣞⣗⡽⡮⡯⣞⢽⡺⡽⣝⢾⢵⣝⣗⡽⡵⣳⢽⣹⢵⣫⢞⡼⡳⣕⢯⡺⡭⣳⡹⣜⢵⡹⣪⢳⡹⡪⣎⢮⡪⡇⣗⢝⢜⢜⢜⢜⢸⢘⢜⢌⢆⠣⡊⠆");
                Console.WriteLine("⣯⢯⢞⡾⣝⡽⣕⣟⢮⡳⣝⢮⡓⠉⠉⢱⢯⡋⠑⠉⣱⡅⠈⠀⠈⡷⡽⣝⡷⡽⡽⠈⠈⠈⣈⣈⣈⣈⣾⡄⠀⠀⠈⣯⣻⡺⠺⠪⠯⠃⠀⠀⠀⠝⠞⠽⠳⣵⡳⡽⡽⡵⣫⢾⡝⡈⠍⠊⣽⣳⢿⡌⠈⠄⠡⣗⣯⣘⣈⢅⣉⣊⢌⡡⡉⠊⠌⡉⡇⡇⡇⡕⡱⡑⡕⢜⠔⢕⢑⢅");
                Console.WriteLine("⣞⡽⣝⢾⣕⢯⣳⣳⡫⡯⣮⡳⠅⠀⠀⠜⠯⠂⠀⠀⣾⠅⠀⠀⢨⡯⣯⢗⡯⡯⡏⠀⠀⠀⠾⠯⠟⡷⣯⠇⠀⠀⠐⡷⣳⡿⣖⣷⠎⠄⠀⠀⠀⢺⢶⣳⢾⣕⢯⢯⢞⣽⢽⣫⡇⢐⠈⠄⡷⡯⢟⠎⠠⠁⢌⣿⢾⣯⢿⣻⣯⢿⣻⣻⠂⠡⠐⢰⢹⢨⢢⠣⡱⡸⡨⡢⠣⡑⡑⠔");
                Console.WriteLine("⣳⢯⡳⡯⣞⣽⡺⡮⡯⡯⣞⣞⠁⠀⢀⣶⡖⠀⠀⢐⡿⠀⠀⠀⢄⣌⡾⡽⣽⣫⠇⠀⠀⢐⣴⣖⣦⣾⡽⠂⠀⠀⣰⣴⡜⠛⢉⢂⣠⣰⡾⣶⣠⡀⡉⠙⢓⣗⢯⢯⢯⢯⡯⡟⡀⢂⠐⡀⢿⡴⣔⠄⠡⠈⢜⡿⡽⣾⠁⠄⠠⢱⢯⡏⠄⠡⢈⡎⡎⡪⢢⢃⢇⠪⡢⡑⡑⠌⠌⠐");
                Console.WriteLine("⡯⣗⢯⢯⣳⣳⢽⣝⢾⣝⣞⡎⠀⠀⠐⠟⠎⠀⠀⢜⡏⠀⠀⠀⣿⢿⣝⡯⣗⣿⢀⢀⢀⢈⢋⢙⢉⣡⡡⠀⠀⠀⣺⡞⡙⠚⢋⠋⡋⠓⠋⠋⠋⡋⠛⡙⠚⣺⢝⡽⣽⢽⠋⡂⣐⣴⣦⢐⠈⠿⡽⠀⠌⡀⡯⠛⠝⢓⠡⢈⠐⡘⢛⠛⡛⢚⠣⠣⡣⡱⡡⡃⢎⢜⠰⡨⢨⠨⢈⠀");
                Console.WriteLine("⣯⢯⢯⢯⢞⡮⡷⣝⣗⣗⣗⣷⢾⡶⡳⠶⠞⠖⠗⠿⠵⠴⣴⣬⢿⢽⣺⢽⣳⣟⡟⠛⠛⠛⠛⠛⠏⠟⠳⠓⠗⠳⣯⡿⡞⠿⠳⠿⠂⠀⠀⠀⠿⠞⠿⠾⣻⡳⣽⢽⣻⣶⣴⢿⢽⠳⠟⠟⠞⠞⠯⠦⣵⣴⣽⢿⣽⠾⠳⠳⠛⠞⠳⠻⠺⢷⡟⡗⡣⡱⡨⡊⢆⢢⢑⠌⡂⠌⠠⡀");
                Console.WriteLine("⡯⣗⡯⡯⡯⡯⣯⣳⣳⡳⣽⡾⠋⠀⠀⢠⣶⣳⣶⡆⠀⠀⠈⣫⢿⢽⣺⣽⣳⣟⡾⡾⢾⠷⢷⠷⡷⢗⠀⠀⠀⢨⢷⣻⢷⠾⡶⡳⣗⢷⡳⡕⠀⠀⠀⢘⡮⣟⣾⣻⢽⣺⠝⡁⢐⠠⣱⡷⣗⣧⠂⠡⠀⢕⣿⠏⢐⠈⠄⣵⡿⣽⣮⡂⠡⢀⠹⡸⡨⡢⡱⢨⠢⡱⡐⡑⠌⢌⠂⠂");
                Console.WriteLine("⣯⢷⢽⢽⢝⡾⡵⣳⡳⣝⣗⡏⠀⠀⠀⣻⡷⣟⣷⠫⠀⠀⢀⣺⡽⡯⣾⣺⣺⣞⠀⠀⠀⢠⣦⣴⣤⣦⣴⣤⣦⣞⣯⢯⠀⠀⠀⢀⣴⣤⣦⣴⣤⣦⣴⢼⡺⣝⣞⡾⡽⣽⢂⠐⠠⠸⣿⢽⣫⡿⠈⠄⠡⢰⢿⡈⠄⠂⠱⣻⣽⣳⣻⠐⡀⢂⢸⢸⢨⢒⢜⠰⡑⢌⠢⡡⡑⢀⠂⠀");
                Console.WriteLine("⣗⡯⡯⡯⡯⡯⡯⣗⡯⣗⡯⣿⣤⣀⣀⡈⡉⡑⡁⣁⣠⣰⣼⢾⢽⢽⣺⣞⣵⣇⣀⣀⣀⣀⣁⣁⣁⣁⣁⣁⣁⡵⡯⣗⣀⣀⣀⣀⣁⣁⣈⣈⣈⣈⣈⣱⣫⢞⡾⣽⢽⣻⢶⣌⣐⣈⢌⢋⡑⡡⣈⣤⣵⣻⣻⢷⣬⣄⣅⣡⣑⡡⣁⣔⡤⡖⡝⡌⢎⢢⠱⡑⢕⢅⠕⠔⠌⠀⠀");
                Console.WriteLine("⣟⢾⢽⢽⢽⢽⢝⡾⣝⣗⡯⣷⣟⣿⣻⣟⣿⣻⡿⣟⡿⡯⣗⡿⣝⣟⣞⣾⣺⣟⡿⣟⣿⢿⣟⣿⣟⣿⣟⡿⡯⣿⡽⣟⣿⣻⣿⣻⣿⣻⡿⣟⣿⢟⡯⣳⢳⡫⡿⣽⡽⣯⣿⣻⣟⣿⣻⣟⢿⢻⡻⣗⣷⣯⣟⣯⣷⣟⣯⡿⡽⡻⡹⡱⡱⡸⡨⡪⢪⢘⢌⢎⢢⢑⢅⠣⢁⠈");
                Console.WriteLine("⡯⡯⡯⡯⣫⢯⢯⣻⡺⣮⣻⣺⣺⣳⢯⢷⣻⢽⡽⣫⢯⡫⣗⡯⣗⣯⢾⣺⢽⣺⢯⣟⡽⣯⣻⣺⡳⡯⡾⡽⡽⣕⢯⢯⢯⡳⡯⣞⣗⡽⡽⣝⣞⢵⣫⢞⡵⣫⣫⢳⡻⣝⢞⢗⢯⡳⡝⡮⡪⣇⢏⢮⢳⢹⢺⢹⢪⢫⢪⢪⢪⢪⢪⠪⡊⡎⡜⢜⢌⠆⡕⢔⢑⠔⡑⡨⠀⠀");
                Console.WriteLine("⡿⡽⡽⡽⡽⡽⣽⡺⣽⣺⢞⡾⡵⡯⡯⣟⡾⡽⣽⣝⢷⢝⡮⡯⣗⡯⣟⡾⡽⡾⣽⣺⢽⣺⢞⡾⡽⡽⡽⡽⣽⡺⣕⢯⡳⡽⣝⣞⢞⡮⣻⣪⢞⡽⣪⢗⡽⣪⢮⣣⡳⡵⡹⣕⢗⢵⢝⢎⡗⡵⡹⡪⣣⢳⢕⢇⢇⢧⢣⢣⢣⢣⢣⢣⢣⠣⡣⠣⡪⡈⠂⡑⠄⢕⢐⠠⠁⠀⠀⠀");
                Console.WriteLine("⣯⢯⢯⢯⢯⡻⡮⡯⣗⡯⡯⡯⣯⢯⣟⣗⡯⡿⡵⡯⡯⡷⣝⢮⢗⡯⣗⡯⣟⡽⣞⡾⡽⣞⡯⡯⡯⣯⢯⣟⢮⡻⣮⡳⣝⢮⣳⡳⣫⣞⢗⣗⢯⣫⢞⡵⣫⢞⢮⡲⡣⡯⡺⣪⢳⢝⡎⣗⢵⡹⣪⢫⡪⡎⡮⡪⡣⡣⡣⡣⡣⡣⡣⡣⡱⡱⡑⢕⠰⠀⠅⠂⠅⡂⠔⡀⠂");
                Console.WriteLine("⡯⣗⡵⣝⣗⡯⣯⢯⣗⡯⡿⣝⡷⣻⣺⣺⢽⡽⣫⢿⢽⢽⣳⣫⣳⡫⣯⢯⢯⡯⣗⡿⣝⣗⡯⣯⢯⣗⣟⢾⢽⢽⢮⢯⡺⣕⢵⢽⢕⢷⢝⡮⣳⡳⡽⣝⢮⡫⡧⣫⢞⢵⢝⢎⡗⡵⡝⣜⢎⢞⡜⣕⢵⢹⢸⢪⢣⢫⢪⢪⢪⠪⡊⡎⡪⠢⡑⠅⠂⠁⢀⠁⡂⠂⠅⠠⠀⠀⠀⠀");
                Console.WriteLine("⣟⢷⣝⣗⣗⡯⣷⣻⣺⢽⣫⡷⣻⣽⣺⢽⣳⣻⢽⣫⢿⢽⣺⣺⢮⡺⡵⣻⢽⣺⡽⡾⣽⣺⢽⣺⢽⣺⣺⢽⢽⢽⢵⢯⢯⢞⡵⣝⢽⣹⢵⡫⣗⡽⣕⢯⡳⣝⢮⡳⣝⢵⡹⡕⣝⢮⢺⢪⡣⡳⣹⢸⢜⢎⢇⢇⢧⢣⢣⢣⠣⡣⡃⡇⢕⠱⡨⡈⠄⠈⠀⡀⠂⠅⡡⠈⠄⠈⠀⠀");
                Console.WriteLine("");
                Console.WriteLine("드디어 이 어둠뿐인 공간에서 탈출할 수 있겠군요...당신은 자유의 몸입니다...");
                Status.Line();
                Thread.Sleep(1500);
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("⡑⢽⣿⢿⡿⣿⢿⡝⡀⠂⡀⠂⡀⠂⡀⠂⠠⠐⠀⠐⠀⠂⠐⢈⣿⣟⣟⣿⢿⣻⢀⠂⠄⢂⠀⡂⠄⠡⡑⢝⢜⡝⣎⢯⢎⡇⡯⣿⡯⣫⢯⢯⢿⢕⢱⢱⢱⢱⢱⢱⢱⢱⢱⢱⢱⢱⢱⢹⢸⢱⣟");
                Console.WriteLine("⢌⢺⣟⣿⣻⡿⣯⡗⡀⠄⠐⢀⠐⠠⠐⠈⡀⠄⠈⡀⢈⠀⢁⠀⣿⢾⢽⡾⣿⢽⡐⠌⡐⡐⠠⠂⠌⡂⡊⡪⡕⡵⣫⢯⢳⡱⣕⣿⡽⣺⢵⣫⣯⡃⢜⢔⢕⠕⡅⡇⡕⡕⢕⢕⢕⢕⠕⡕⡕⣕⣯");
                Console.WriteLine("⠨⡪⣿⣯⣿⣽⡷⡯⠀⠐⠈⡀⠐⡀⢁⠂⠄⢂⠐⠠⢀⢂⢐⢈⣿⢯⢿⡽⣿⢽⠠⢁⠂⠄⠡⠁⢂⠐⢐⠨⢪⢫⢮⢳⡱⡱⡪⣿⡽⣪⢗⢷⡽⡆⠸⡸⡰⡱⡱⡱⡱⡱⡱⡱⡱⡸⡸⡸⡨⣪⢾");
                Console.WriteLine("⢘⢜⣿⢾⣷⣻⣽⣻⠀⡁⠄⠐⡀⠄⠠⠐⡈⠠⢈⠐⡀⡂⡐⠄⣿⢯⣟⣟⣿⢽⢈⠠⠐⡈⠠⢈⠠⠐⡀⠌⡂⢇⢯⢣⡣⡣⣫⣿⣝⢮⢯⣳⣟⡇⢨⢪⢪⢪⢪⢪⢪⢪⢪⠪⡪⡪⡪⡪⢪⢺⡽");
                Console.WriteLine("⢕⠸⣾⡿⣯⡿⣯⢿⡐⢔⠨⡂⡢⡨⡂⡅⡢⡑⢄⢅⢂⠢⡂⡅⣿⣻⣺⣽⢿⢽⡂⢌⠔⢄⢕⢐⠌⡔⣐⢑⠜⡜⡜⡕⡵⡹⣸⣾⣳⢝⣞⣞⡾⡕⡐⡕⡕⡕⡕⡕⡕⡕⡕⡕⡕⡕⡜⡜⡜⡮⡯");
                Console.WriteLine("⢡⠣⣿⢿⣻⣟⣿⢽⡪⡘⡌⢎⠜⡔⡱⡑⡜⢌⢆⠣⡑⢕⠱⡨⣻⣗⣟⡾⣿⢽⡸⡐⡍⢆⢣⢑⢅⢇⢪⢊⢎⢪⢪⢪⢪⢺⡸⣿⢮⣳⡣⣷⠻⣘⢄⢇⢫⢪⡪⡪⡪⡪⡪⡪⡪⡪⡪⡪⡪⣺⣽");
                Console.WriteLine("⢢⠣⣿⣿⣻⣽⣿⢽⡪⢢⢑⢅⢣⠱⡘⡔⢅⢣⠪⡘⡌⡪⡘⡌⣾⣗⡯⣟⣿⢽⡸⢨⢊⢎⢪⢸⢰⢡⢣⢱⢱⢱⢱⢱⢱⢱⡹⣿⣳⣳⠏⣑⡼⣞⡶⡑⢄⣗⢵⡹⣸⢸⢜⢜⢜⢜⢜⢜⢜⣵⣳");
                Console.WriteLine("⣐⡑⡝⠾⡿⣽⣾⠿⠎⠪⢢⠱⡨⢪⠨⡪⡘⡔⡑⡕⢜⢌⢪⢘⢾⡯⡯⣿⣽⢽⢜⠜⡌⡎⡎⡎⡎⡎⡎⡎⡎⡎⣎⢮⢪⡣⢯⡿⡝⣐⡼⣞⣿⠸⠡⣨⡺⣜⢵⣣⡳⣕⢵⢱⡹⡸⡱⡱⡱⣳⡽");
                Console.WriteLine("⣢⣪⣘⡑⡪⢌⢆⢮⢎⢮⢢⢕⢌⡢⡑⠜⠔⡅⡣⡊⡆⡣⡑⡕⣽⡯⣯⢷⡿⣽⢕⠕⡕⢕⢕⢜⢜⢜⢜⢜⢜⢎⢎⡎⣇⢏⠃⣅⣮⣞⡯⠟⡨⡰⣝⢞⡮⣗⢯⣺⣺⡺⣪⢧⢳⡹⡜⡎⡮⡯⣟");
                Console.WriteLine("⡐⡔⢵⣿⢾⣴⢢⣧⣓⢌⢢⠱⡑⢕⡙⡺⡸⡰⣌⢌⡂⡣⢱⢘⣼⣟⣷⣻⢿⣽⡪⡪⢪⠪⡢⡣⡣⡣⡣⡣⠣⠣⡣⡣⢃⡢⣳⣿⢞⢊⢌⢦⡷⣹⢜⢵⡫⣞⡽⣺⣺⣺⡳⣯⡳⣕⡗⣝⢜⣯⣟");
                Console.WriteLine("⢨⢊⢺⣿⣻⣯⣷⣕⣕⡢⣑⢕⠸⡰⡘⡌⢆⢣⢊⢪⠪⡚⣴⢑⡚⢟⠾⡻⡟⣷⢣⢪⠪⡪⡪⡪⡸⡨⢂⢐⢌⢆⣆⢎⢚⢮⠺⡉⡢⣕⡯⣯⣟⢼⡱⡳⡹⣪⢞⣗⣗⣗⡯⣷⣻⡵⡯⡺⣜⡾⣾");
                Console.WriteLine("⡐⠥⣹⣯⣿⣽⣾⡷⣗⢍⠎⡎⡓⢮⢢⣣⡱⡑⢜⢔⠱⡱⣨⡨⣉⢣⢓⢕⠪⡒⢆⠦⡅⡕⡌⣊⢎⢢⡱⡹⡸⡱⡯⢻⠪⢡⢱⣼⡽⣪⢟⡞⣎⢧⢳⡹⡪⡮⡳⣳⢳⣳⢯⢷⢯⢯⢏⡯⣪⡿⣽");
                Console.WriteLine("⢨⠪⣪⣷⣿⣽⣷⡿⡧⡣⢱⢘⠜⡌⢆⠆⡎⡍⡓⡎⢞⠜⡎⡪⣺⡷⣗⣷⢷⡵⡆⢧⢢⢕⢬⣘⢌⢢⢣⢳⢱⢱⡹⡸⡮⡳⡽⣿⢽⢵⡻⡧⣗⢝⡜⣎⢞⢼⢱⡳⣝⢾⣝⡯⡯⡯⣳⢽⣺⡯⣿");
                Console.WriteLine("⢰⠱⡸⣷⢿⡾⣯⣿⣫⢸⠨⡊⡎⡪⢪⠸⡐⡅⢇⠪⡪⡘⢔⠱⣸⣿⣻⣻⣟⣯⡇⢇⠕⡜⢔⢼⡝⣕⢕⠕⡕⢕⢕⢝⢵⢱⣻⣿⢝⡮⡯⣯⡳⣱⢹⡸⡪⣣⢳⢕⢗⢗⣗⢽⢽⣝⢾⢽⣺⡯⣿");
                Console.WriteLine("⡸⡨⡪⣿⣟⣿⢿⣽⢾⠰⡑⡕⢅⢇⢣⢃⢇⢕⠱⡑⡌⡪⡂⢇⢽⣗⣟⣾⣯⣷⢇⢕⢱⢘⢌⢞⡮⡪⡢⠣⡃⢇⠣⡳⡱⣹⢺⣯⢗⡽⣺⢵⡏⡎⡮⡪⡺⡜⡵⡹⡕⡽⣜⢽⢕⡯⡯⡯⣺⣻⣽");
                Console.WriteLine("⢰⠱⡸⣿⡽⣟⣿⡯⣿⢘⢌⠪⡪⡸⢰⠱⡨⡢⢣⢑⠕⡌⡪⢢⢹⣯⣟⣾⢷⣻⡕⡌⢆⢇⠢⢹⢪⠪⠢⡑⢌⠢⢣⠹⡸⣚⢌⣮⣻⡪⡯⣗⡯⡪⡪⡪⡣⡳⡱⡕⡕⡕⣕⡳⡝⣞⢽⢝⣞⣯⣿");
                Console.WriteLine("⠔⡕⡱⣿⣽⢿⡷⣿⣽⠢⡱⡑⢕⢸⠨⡊⡆⢕⢅⠕⡅⡣⡊⢎⢺⣟⡾⣽⣟⣿⡪⡘⡔⢕⣻⢦⡣⡕⡕⣇⢇⢏⢪⢪⡪⣪⢪⢺⣪⢾⢝⣮⡇⡇⡇⡏⡮⡺⡸⡜⡜⡎⡖⣕⢝⢜⢕⡳⡽⣾⣽");
                Console.WriteLine("⢸⢨⠪⣷⢿⣟⣿⣻⢾⡑⢕⠸⡨⡢⡃⡇⡪⢢⢑⢅⠣⡪⡘⡌⣺⡯⣿⢽⣟⣾⡣⡪⡸⡸⣸⢵⡱⡝⣎⢮⡪⡣⢱⢱⡱⡱⣕⢽⢮⣳⣻⢮⡇⡇⡇⡇⡇⡇⡇⡇⡇⡇⡧⡣⡳⡹⣸⢸⢽⣗⣿");
                Console.WriteLine("⢸⠰⡑⣿⡿⣯⣿⣽⢿⢸⢘⢜⢔⢱⢘⢌⠪⡢⡑⡌⡪⢢⠱⡘⢼⣻⣽⣻⣽⢷⣓⢌⢆⢇⢾⡱⡣⣏⢮⡺⡽⣪⢪⣣⢳⢹⡸⣺⣝⣞⢾⢽⡎⢎⢎⠎⡎⡪⡊⡎⢎⢎⢎⢎⢎⠮⡪⡪⣺⣷⣻");
                Console.WriteLine("⢸⢘⢌⢿⣻⡿⣾⣯⢿⡑⡅⡇⢎⢢⠣⣊⠪⡢⡑⡌⡪⢢⠣⡣⣹⣟⣾⢽⣟⣯⡇⡎⡢⡣⣻⢺⣹⢜⡮⣯⢯⢪⡳⣕⢽⡱⡝⣞⣞⢮⢯⣳⢇⢇⢕⢕⢱⢑⢕⢱⢱⠱⡱⡱⡱⡩⡪⡪⣳⡷⣿");
                Console.WriteLine("⢸⢨⢊⢿⣻⣿⣽⣾⢿⡱⡑⡜⢜⢔⢕⢢⠣⡊⡆⡣⢪⠪⡸⣐⢺⣻⣞⣿⣽⢷⡇⡕⡅⡇⡗⡿⣕⢗⣿⣯⢟⢼⢽⣮⡳⣯⣺⢽⡺⡽⣽⣺⢕⢅⢇⢊⢢⢑⢅⢇⢕⢕⢕⢕⢕⢕⢕⢝⣞⣯⣿");
                Console.WriteLine("⢨⢢⠣⣻⣟⣷⣯⣿⡽⡎⡪⡸⡨⡢⢣⢊⢎⢪⢘⢌⢆⢇⢕⢢⢹⣟⣾⣳⡿⣯⡇⡎⢆⡧⣫⣻⢜⣿⢷⡯⣿⢯⡻⣼⣪⣗⡽⣯⢏⡯⣞⢾⡱⡱⡸⡨⡢⡣⡱⡱⡱⡱⡱⡱⡱⡱⡱⡱⣽⣞⣿");
                Console.WriteLine("⠸⡘⡜⣺⣯⣷⢿⣾⣻⡕⢕⢅⠇⡎⡪⢢⢑⢌⠪⡢⢣⢊⢆⢣⢹⣟⣾⣳⣿⣗⡇⡇⡣⡳⣵⣻⣷⣻⢯⢯⠿⠽⡝⡗⡳⡹⣽⣯⢗⢯⣫⢿⢜⢜⢌⢎⢪⢸⢸⢸⢸⢸⢸⢸⢸⢸⢪⢪⢷⢯⣿");
                Console.WriteLine("⢸⠸⡘⣼⣿⣽⢿⣽⢷⡣⢑⠌⡎⡪⡊⢎⠢⡂⢇⢪⢊⢆⢣⢱⢱⣿⣳⣟⣾⣗⡇⡇⢇⢎⢪⢊⢆⢣⠕⡕⡍⡕⡕⡕⡕⡕⣽⣯⢯⢯⢾⢽⢕⢕⢕⢱⠱⡱⡱⡱⡱⡱⡱⡱⡕⡕⡕⡕⣟⣯⣿");
                Console.WriteLine("⡰⡱⡱⣱⣿⡾⣟⣿⣻⡕⡡⢱⢘⢌⢎⢪⠪⡪⡊⡎⡢⡣⡱⡡⢳⣟⣷⣻⡷⣯⡇⡇⢇⢕⢅⢇⢕⢕⢱⢡⢣⢱⢱⢸⢸⢘⢾⣯⢗⡯⡯⣯⢇⢇⢎⢎⢎⢎⢆⢇⢇⢇⢏⢮⢺⢜⢎⢎⣿⣺⣟");
                Console.WriteLine("⠰⡱⡨⡺⣯⣿⣻⣿⡽⡇⡎⡪⢢⠣⡊⡆⢇⢕⢜⢌⢆⢣⠪⡸⡸⣿⣞⣷⡿⣯⡗⢜⠜⡌⡆⢇⠎⡆⡣⡱⡡⡣⡱⡡⡣⡣⣻⣯⢟⡾⣽⣺⡕⡕⡕⡕⡕⡕⡕⡕⡕⡕⡕⣕⢵⢱⢕⠧⣷⣳⣿");
                Console.WriteLine("⢘⠔⡕⢼⣿⣯⡿⣾⣟⡯⡸⡨⡪⡊⡎⢜⠜⡌⡆⡣⡱⡡⡣⢣⢚⣿⢾⡷⣿⣗⡏⡆⢇⢇⢎⢎⢎⢪⢪⢸⢰⢱⢸⢨⢢⢣⣻⣯⣟⢾⢵⣻⢎⢎⢎⢎⢎⢎⢎⢎⢎⢎⢎⢎⢮⡪⡎⣏⣷⣻⣾");
                Console.WriteLine("");
                Console.WriteLine("나가기 위해서는 키가 있어야 할 것 같습니다...");
                BTWS();
                Console.WriteLine("당신은...아직 다 모으지 못한것 같군요...");
                BTWS();
                Console.WriteLine("원점으로 보내드리겠습니다 필요한 키는 3개입니다...");
                Status.Line();
                Thread.Sleep(300);
                Room1();
            }
        }

        private static void Base()
        {
            Console.Clear();

            bool haskey4 = Player.inventory.Any(item => item.iname == "지하실열쇠");

            if (haskey4)
            {
                Thread.Sleep(300);
                Status.Line();
                Program.Playmusic("종료.wav");
                Console.WriteLine("⠀⠀⠠⠀⠀⠠⣤⣠⡠⡀⠀⠀⠀⠀⠀⠠⠀⠀⠀⠀⠀⠀⠄⠀⠀⠀⠀⠀⠠⠀⠀⠀⠀⠀⢀⠠⠀⠀⠀⠀⠀⡀⠄⠀⠀⠀⠀⠀⠠⠀⠀⠀⠀⠀⠀⠄⠀⠀⠀⠀⠀⠠⠀⠀⠀⠀⠀⠀⠄⠀⠀");
                Console.WriteLine("⠀⠀⠀⠀⠠⠈⣷⣫⢯⠷⠦⡢⡄⠀⠀⠀⠀⠀⠂⢀⠀⠀⠀⠀⠐⠀⡀⠀⠀⠀⠀⠂⢀⢠⣄⠀⠀⠠⠀⠄⠀⠀⠀⠀⠄⠐⠀⠀⠀⠀⠠⠀⠄⠀⠀⠀⠀⠄⠠⠀⠀⠀⠀⠠⠐⠀⠀⠀⠀⠀⠐");
                Console.WriteLine("⠀⡀⠀⡀⠠⠀⢻⣷⣳⣮⡷⣿⡽⣆⡠⣀⠀⠁⠀⠀⢀⠀⢀⠀⠁⠀⠀⢀⠀⢀⠈⠀⢰⣯⣿⣂⠀⠀⠀⠀⡀⠀⠀⠀⠀⠄⠀⡀⠀⡀⠂⠀⠀⡀⠀⡀⠐⠀⠀⢀⠀⢀⠀⠄⠐⠀⢀⠀⡀⠈⠀");
                Console.WriteLine("⠀⠠⠀⠀⠀⠀⠀⢻⣷⢿⡹⡱⡏⡯⡫⡯⣧⠀⠀⠀⠠⠀⡀⠀⠀⠀⠠⠀⠠⠀⠀⢠⣿⣾⣟⣿⡄⠀⠀⠀⠠⠀⠁⠀⠀⠀⠀⠠⠀⠀⠀⠀⠀⠀⠄⠀⠀⠀⠀⠀⠠⠀⠀⠀⠀⠀⠀⡀⠀⠀⠀");
                Console.WriteLine("⠄⠀⠀⠁⢀⠀⡀⠈⠞⠟⣿⣧⣧⡾⣼⡾⣾⣆⣄⠠⠀⠀⠀⠀⠄⠀⠄⠀⠀⠀⢀⣿⣷⡿⣿⡿⣿⡄⠀⠂⠀⠀⠁⠀⠄⢀⠈⠀⠀⠁⢀⠠⠀⠀⠀⠈⠀⠠⠀⠀⠀⠀⠁⢀⠀⡀⠀⠀⠈⠀⠀");
                Console.WriteLine("⠀⠀⠀⠀⢀⠀⠀⠀⠀⠀⠘⣷⡷⣿⡸⡹⡓⡟⣾⡀⠀⠀⠀⠀⠄⠂⠀⠀⠀⡀⣾⢳⣳⣿⢿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠂⠀⠀⠀⠀⠀⠀⡀⠄⠀⠀⠀⠐⠀⠀⠁⠀⠀⠀⡀⠀⠀⠀⠀⠀⠀⠁");
                Console.WriteLine("⠐⠈⠀⠄⠀⠀⠀⠂⠀⠂⠀⠀⠋⢻⡿⣞⣟⡿⣽⣳⡴⠀⠐⠀⠀⠀⠀⠂⠁⠨⣯⣿⣿⣿⣿⣿⣿⣯⡇⠀⠁⠠⠈⠀⠀⠀⠐⠀⠂⠀⠀⠀⠀⢀⠈⢀⠀⠀⠀⠈⢀⠈⠀⠀⠀⠀⠁⡀⠂⠀⠀");
                Console.WriteLine("⡀⠂⠁⠀⠀⢀⠀⠐⠈⠀⠀⡀⠀⠀⠛⠙⢿⣞⣮⣮⣞⡀⠐⠀⠀⢀⠠⣰⢼⣽⣿⣿⣿⣿⣿⣿⣿⣿⢿⡆⠅⠀⠀⡀⠀⡀⠀⠂⠀⠁⠀⡀⠀⠀⠀⠀⠀⡀⠀⠈⠀⠀⠂⠀⢀⠀⠀⠀⠀⠄⠀");
                Console.WriteLine("⠀⠀⠀⠀⠈⠀⡀⠀⠀⠀⠀⠠⠀⠁⠀⠀⠘⠙⠚⢿⣿⢿⣷⠀⠈⢀⢠⣴⣽⣟⣯⣿⣿⣿⣿⣿⣿⣻⢯⣾⣦⣀⠀⠀⠄⠀⠀⠀⠀⠀⠂⠀⠄⠀⠀⠀⠠⠀⠈⠀⠀⠀⠀⠐⠀⡀⠀⠀⠀⠀⠂");
                Console.WriteLine("⠠⠀⠀⠄⠀⠁⠀⠀⠠⠀⠀⠀⠀⠠⠀⠠⠀⠀⠀⠀⠘⠻⣻⣷⣠⡷⣯⢿⣽⣿⣷⣻⣿⣿⣿⣿⣿⢽⣿⣿⣿⢿⣇⠀⠀⠀⠁⠀⠄⠀⠀⠀⠀⠄⠐⠀⠀⠀⠈⠀⡀⠄⠀⠀⠀⠀⠠⠐⠀⠀⠀");
                Console.WriteLine("⠀⠂⠁⠀⠀⠀⠀⠐⠀⠀⠁⠀⠀⠀⠐⠀⠠⠀⠠⣀⢂⠀⡈⣻⣽⡯⣿⣻⣽⣿⡿⣿⣽⣿⣿⣿⢾⣿⣿⣿⣿⣿⣷⠀⠀⠀⠀⠁⠀⠂⠀⠀⠀⠄⠐⠈⠀⠀⠀⠀⢀⠀⠂⠀⠀⠀⠄⠀⠈⠀⠀");
                Console.WriteLine("⠄⠀⠀⠀⠂⠐⠀⠀⠀⠀⠈⢀⠈⠀⠀⠀⠀⠠⠀⠈⠛⠛⠻⠻⣿⣽⣗⣿⣟⣿⣿⣿⣿⡾⣿⣟⣿⣿⣿⢿⣿⡾⣿⠀⠁⡀⠁⠀⠀⠀⠂⠁⠀⠀⠀⠀⠀⠂⠈⠀⠀⠀⠀⢀⠁⢀⠀⠀⠀⠈⠀");
                Console.WriteLine("⠀⡀⠀⡀⠐⠀⠈⠀⢀⠀⠈⠀⠀⢀⠀⡀⢀⠀⠐⠀⢀⠀⡀⡞⢽⣷⣟⣽⣽⣿⣷⣿⣿⣿⣿⣿⣿⣯⣿⣿⣿⢿⣿⡀⢀⢀⢀⣀⡀⠀⠂⠈⠀⢀⠀⢀⠀⠂⠁⠀⠀⡀⠀⠀⠀⠀⢀⠀⢀⠈⠀");
                Console.WriteLine("⠀⡀⠄⠀⠀⠀⠀⠐⠀⠠⠀⠀⠀⠀⢀⠀⠀⠀⠀⠀⢀⠀⠄⠀⢐⣿⣾⣳⣫⡿⣽⢯⢿⢽⣻⣟⣿⣻⣟⣯⣿⡿⣿⣳⢯⣞⣯⠷⢯⠂⠀⠀⠀⢀⠠⠀⠀⠀⠀⠀⠁⠀⠄⠀⠀⠀⠐⡄⠀⠀⠀");
                Console.WriteLine("⠀⠀⠀⠀⠄⠀⠄⠀⠀⠀⠀⠄⠀⠂⠀⠀⠈⠀⠠⠀⠀⠀⠀⠀⠠⣷⣿⢾⣗⣿⣳⣻⣽⡿⣷⣿⣿⣽⣿⡿⣿⣿⣿⡿⠻⠳⢻⣛⠧⠀⡀⠄⠀⠀⠀⠀⠀⠄⢀⠀⠈⠀⠀⠠⠐⠀⠀⢕⠀⠀⠂");
                Console.WriteLine("⠀⠀⠀⠀⠀⠂⠀⠀⠀⠀⠐⠀⠂⠀⠀⠀⠀⠐⠀⠐⠀⠀⠀⠀⣱⡛⣿⣿⣯⣷⣻⣽⣾⣿⣟⣿⣽⣿⣟⣿⣿⣿⡿⣿⣄⠐⠀⠙⠂⠀⠀⠠⠀⠀⠀⠀⠀⠂⠀⠀⠀⠀⠀⠄⠐⠀⠀⢨⠢⠈⠀");
                Console.WriteLine("⠈⠀⠂⠁⠀⠀⠀⠁⡀⠁⠀⠀⠀⠀⠂⠁⡀⠀⠀⠀⠀⠂⠐⣠⠟⠀⢸⣷⣿⣟⣿⣿⣿⣿⣿⣿⣿⡿⣿⣿⣿⣿⣿⣿⣗⠀⠀⠠⠐⠀⠀⠀⠀⠈⡀⠈⠀⠀⠀⠐⠀⠂⠀⠀⠀⠀⠐⢸⢘⠄");
                Console.WriteLine("⠀⠈⠀⠀⡀⢀⠀⠀⠀⠀⠁⠀⡀⠀⠂⠀⠀⢀⠀⠀⠁⢀⠲⠉⠀⠀⢸⣟⣿⣟⣿⣿⣻⣿⡿⣿⣟⣿⣿⣯⣿⢿⣯⣷⣿⣂⠀⠂⠀⠀⡀⢀⠀⠁⠀⠐⠀⠀⡀⠀⠂⠀⠁⠀⢀⠀⠀⢸⢨⠂⠀");
                Console.WriteLine("⠀⠀⠀⠀⢀⠀⠠⠀⠀⠀⢀⠁⢀⠀⠀⠀⠀⢀⠀⠁⠀⠈⠀⠀⡈⠀⣽⣿⣿⣿⣿⣿⣿⢿⣿⣿⣿⣿⣿⣿⣿⣯⣿⣿⣿⣷⠄⠀⠀⠀⢀⠀⡀⠀⠀⠀⠀⠁⢀⠀⠀⠀⠀⠈⢀⠀⠀⣸⢌⠇⠈");
                Console.WriteLine("⠀⠄⠀⠂⠀⠀⠀⠠⠀⠂⠀⠀⠀⠀⠠⠀⠄⠀⠀⠀⠂⠠⠐⠀⠀⢰⣽⢻⣿⣿⣾⣿⣿⣿⣿⣿⣯⣿⣾⣿⡟⣿⣷⡿⣽⣿⣿⡀⠀⠄⠀⠀⠀⠀⠄⠠⠀⠈⠀⠀⠀⠄⠀⠈⠀⠀⠀⣺⢐⠇⠀");
                Console.WriteLine("⠀⠐⠀⠂⠀⠀⠀⠠⠀⠂⠀⠀⠀⠀⠐⠀⠀⠀⠀⠀⠀⠂⠀⠀⢀⣺⠃⢸⣿⣿⣾⣿⣿⣿⣿⣟⣿⣟⣿⣽⠑⢯⠈⠻⣿⡽⣿⣷⣂⠀⠀⠀⠀⠀⠂⠀⠀⠀⠀⠀⠁⠀⠂⠀⠀⠀⠀⣗⢨⢇⠀");
                Console.WriteLine("⡀⠀⠀⠀⡀⠂⠠⠀⠀⠀⠀⡈⠀⠄⠀⠀⠀⠁⡀⠁⠀⠀⠀⠈⠠⠁⣀⣿⣿⣿⣷⣿⣿⣾⣿⣿⣿⣿⣻⣿⣇⠸⡂⠀⠘⢿⣽⢾⣧⡀⠐⠀⠂⠀⠀⠀⠈⢀⠐⠀⠀⠀⠀⠐⠀⠁⢐⠇⣜⡇⠀");
                Console.WriteLine("⠀⠀⡀⠀⠀⠀⠀⡀⠀⢀⠀⠀⠀⢀⠀⢀⠀⠀⠀⠀⠄⠀⡀⠄⠂⣰⡾⣿⣿⣿⣷⣿⣿⡿⣿⣿⣾⣿⢿⣯⣿⡈⡢⠀⠐⢨⢽⣟⣿⡄⠀⠂⠀⢀⠀⡀⠈⠀⠀⠀⡀⢀⠀⠁⠀⠂⡸⢅⢺⡊⠀");
                Console.WriteLine("⠀⠁⢀⠀⠀⠀⠀⢀⠐⠀⠀⠀⠀⠀⠠⠀⠠⠀⠀⠀⡀⠂⠀⣠⠾⠋⢰⣿⣿⣿⣾⣿⣻⣿⣿⣿⢿⣿⣿⣿⣿⣷⠈⠀⠀⠀⠼⢹⠯⣿⣄⠀⠀⢀⠀⡀⠀⠀⠀⠀⡀⢀⠀⠀⠀⠀⣞⢂⣯⡃⠀");
                Console.WriteLine("⡀⠈⠀⠀⠐⠀⠐⠀⠀⠀⠀⠂⠀⠂⠀⠀⠀⠠⠀⠄⠀⠀⠀⠀⠠⢀⢾⣿⣯⣿⣿⣻⣿⣟⣿⣟⣿⣿⣿⣾⡿⣿⣷⠀⢀⠀⠁⠘⠀⠑⣗⣗⡤⡀⠀⠀⠀⠄⠠⠀⠀⠀⠀⠠⠀⢨⡎⡢⣷⠁⠀");
                Console.WriteLine("⠀⠀⠀⠀⠐⠈⠀⠀⠀⠀⠀⠁⠀⠂⠀⠀⠀⠄⠠⠀⠀⠀⠀⠐⢀⢼⣿⣿⣿⣿⣯⢿⣻⣾⣿⣿⣿⣿⣯⣿⣿⣿⢿⡀⠠⠀⠀⠀⠀⠀⠹⡷⣝⣷⡖⣤⡠⠀⠄⠀⠀⠀⠀⠀⠂⣽⠢⡳⡯⠀⠂");
                Console.WriteLine("⠀⠂⠀⠂⠀⠀⠀⠐⠈⢀⠀⠀⠀⠀⠂⠈⠀⠀⠀⠀⠐⠈⠀⢀⣲⣿⣿⣿⣿⣷⢿⣿⡿⣷⣿⣿⣿⣾⣿⣿⣿⣿⣿⡆⠀⠀⠀⢁⠀⠂⠀⠈⢹⣳⣫⡪⣻⡄⣄⠀⠂⠐⠀⠀⢸⡇⣇⢿⡫⠀⠀");
                Console.WriteLine("⠀⠀⠁⠀⡀⠀⡀⠐⠀⠀⠀⡀⠄⠐⠈⠀⠐⠀⠀⡀⠀⣂⣥⣾⢿⣿⣿⣿⣿⣻⣿⣻⣟⣿⣿⣿⣿⣿⣿⣟⣿⣷⣿⡿⡆⠀⠀⠀⠀⢀⠀⠀⠚⢻⡿⣿⣾⡳⢽⡦⣐⡀⠂⢠⢿⣑⢾⣕⣯⠀⠀");
                Console.WriteLine("⠀⠀⠀⠀⠀⠄⠀⠀⠀⠀⢀⠠⠀⠀⠀⠀⠀⠀⠁⠀⠀⠈⠈⢀⣾⣿⡿⣿⣟⣿⣽⣿⣽⣿⣿⣿⣾⣿⣿⣿⣿⣿⣿⣿⣷⡀⠄⠀⠀⠀⠠⠈⠀⠀⢟⣿⣿⣯⣷⢽⣣⣣⡀⣞⡯⣮⢿⡷⣗⠄⠈");
                Console.WriteLine("⠀⠂⠀⠂⠀⠀⠀⠂⠀⠄⠀⠀⠀⠀⠂⠀⠄⠈⠀⠈⠀⡀⣤⢿⡻⠙⢸⣟⣿⡿⣿⣽⣿⣿⣟⣷⣿⣿⣿⣿⣿⣿⣿⣟⣿⣯⠂⠀⠐⠀⠀⠀⠀⠄⠀⡀⠈⢿⢿⣿⣳⣺⣷⣻⣽⢾⣿⣝⠱⡂⠀");
                Console.WriteLine("⠀⠈⠀⠄⠀⠀⠀⠀⠁⠀⠀⠀⠀⠀⠈⠀⠀⠀⠀⠀⠀⠄⠉⠀⠀⢠⣸⣿⣿⢿⣻⣯⡿⣾⣟⣿⣿⣿⣷⣿⣷⣿⣿⢿⣿⡗⠀⠈⠀⠄⠀⠀⠀⠀⠂⠀⠀⠀⠈⠙⣿⣿⣾⣽⢾⡿⣗⡿⢆⠀⠀");
                Console.WriteLine("⠀⠀⠀⠀⡀⠁⠈⠀⠀⠀⠁⢀⠁⠀⠀⠀⠀⢁⠠⠈⠀⠀⠀⠀⠂⢘⣾⣯⣿⣿⣿⣿⣿⣿⣿⣿⣾⣿⣿⣿⡿⣿⣿⣿⣿⣿⡀⠀⠀⠀⡀⠁⠠⠀⠀⠀⠐⠀⢂⣰⣽⣿⣷⣿⢿⣻⡏⢷⠈⠀⠐");
                Console.WriteLine("⠀⠀⠄⠀⠀⠀⠁⠀⡀⢀⠀⠀⠀⠁⢀⠠⠀⠀⠀⠀⢀⠀⠀⣢⡀⢘⣿⣿⣿⣾⣾⣾⣿⣿⣿⣾⣿⣿⣿⣿⣿⣿⣿⣷⣿⣿⡶⠀⠀⡀⠀⠐⠀⠀⡀⢀⢀⣢⣗⣷⣿⣽⢿⣞⡟⠿⣇⠈⠃⠀⠐");
                Console.WriteLine("⠀⠂⠀⠂⠀⠀⠀⠠⠀⢀⠀⠀⠀⠀⠄⠀⠄⠀⠀⠀⠠⠀⣅⣸⣿⣿⣻⣟⣿⣿⣿⣿⣿⣽⣾⣿⣿⣿⣿⣻⣯⣿⣿⣿⣽⣾⣿⡀⠄⠀⠀⠀⠀⠠⠀⢀⢅⣯⣿⢿⣽⢾⡏⢯⡇⠈⠀⠠⠐⠀⠀");
                Console.WriteLine("⠀⠀⠀⠠⠐⠀⠠⠀⠀⠀⠀⠠⠐⠀⠀⠀⠀⡀⢂⠠⠐⡄⠀⠙⣿⣿⣿⣾⢷⣯⣟⣿⣿⣯⣿⣿⣿⡿⣿⣿⣿⣿⣟⣿⣿⣿⣿⣷⡤⠀⠐⠀⡀⡤⣜⡮⣟⣾⣿⣻⡯⡿⠁⠀⠃⠀⠀⠀⠀⠀⠄");
                Console.WriteLine("⠀⡀⠀⠀⠀⠂⠀⠀⠀⠀⠀⢂⢄⠀⠀⠀⠀⢱⣄⣳⣄⠺⣦⣺⣿⣿⣿⣿⣿⣿⣿⣿⣷⣿⣿⣿⣟⣿⣿⣿⣿⣿⡿⣯⣿⣿⣿⣿⣿⢦⣀⢁⢉⠈⡉⠙⠋⡟⣾⣳⣟⠏⠀⠀⠁⠐⡀⠸⠀⠨⢀");
                Console.WriteLine("⠀⢀⠀⠁⠀⠀⠀⠁⡀⠁⠀⠀⠱⣧⣀⠁⡀⠀⢳⣯⡿⣿⣿⣷⣷⣯⣯⣯⣿⣿⢿⣷⣿⣿⣟⣷⣿⣿⣿⣟⣿⣿⣿⣿⣿⣷⣿⣾⡿⣟⠟⠛⠓⠋⠈⠀⠈⠨⡿⡙⣾⠁⠀⠀⠀⠐⠐⠁⠌⠀⡐");
                Console.WriteLine("⠀⠀⠀⠂⠀⡀⠠⠀⠀⠀⠁⠀⡀⠈⠻⢷⣲⡦⣦⣿⣿⣷⣷⣿⣻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⠛⠙⠉⠉⠙⠹⠻⢿⢿⣵⣆⢄⢈⠀⠄⠀⢏⠀⠳⠀⠀⠄⢀⠀⠁⠐⠀⠀⠠");
                Console.WriteLine("⠀⠀⠀⠀⠠⠀⢀⠀⠀⠀⠀⢁⠀⠀⠀⠈⠛⠻⠿⢿⠿⠿⠿⠿⠿⣿⣿⣽⣿⣿⣿⢿⠿⠛⠉⠙⠻⠻⠛⠋⠁⠀⠀⠁⡀⠁⠀⠀⠀⠀⠁⠠⠈⠉⠁⠀⠀⠂⠠⠀⠀⠀⠀⠠⠀⢀⠀⠀⠀⠐⠀");
                Console.WriteLine("");
                Console.WriteLine("쯧쯧쯧...당신...열어서는 안될 공간을 열어버렸군요...");
                BTWS();
                Console.WriteLine("당신은 육체에서 영혼이 분리되어감을 느낍니다...");
                BTWS();
                Console.WriteLine("안타깝지만...당신의 게임은 끝났습니다...");
                Status.Line();
                Thread.Sleep(2000);
                BTWS();
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("⡽⡽⡽⡽⣽⣻⣻⢿⡽⡽⡽⡽⡽⡽⡽⡽⡽⡽⣝⡽⣝⡽⡽⡽⡽⡽⡽⣿⣿⣿⢝⣝⢽⢽⢽⣻⣿⣻⢭⡫⣝⡕⡯⡝⣭⢫⢝⡎⡯⣝⢽⢝⣟⡯⡳⣝⢭⡫⡯⣫⢯⡫⡯⣫⢯⢿⣻⢯⡫⣏⢯");
                Console.WriteLine("⣞⢽⡺⡽⣺⢾⢽⣯⢯⣫⢯⣫⢾⢝⣞⢽⡺⣝⣞⢮⡳⡽⣝⣞⡽⣝⢾⣿⢿⣽⡣⣗⢽⢝⣽⣳⣯⣿⢸⢎⡞⣎⢧⡫⣎⢗⡳⡹⡪⣎⢯⣫⣯⢯⡺⣪⢳⢝⢾⢽⢕⡯⡯⣺⢽⣻⣻⡽⡺⣕⢯");
                Console.WriteLine("⢵⣫⢗⡯⣯⣻⢾⣽⢽⣺⣝⣗⣟⡾⣽⣺⢽⢽⣳⣳⢽⣝⢷⡻⣝⢯⢿⣽⣿⣟⣾⢽⠺⡙⣝⠝⡋⢏⢊⢎⠪⡊⡪⡪⢊⠘⢜⢎⢗⣜⢵⣳⢯⡯⡺⣪⢳⢕⢯⣺⣣⡳⣝⢮⢾⣺⣽⡳⣝⢮⣺");
                Console.WriteLine("⣕⣗⢯⢯⣞⣾⣻⢾⢯⣞⣞⣗⣯⣿⣯⣗⡇⡑⡐⡐⠡⢊⠘⠌⡊⠅⡃⢍⠑⢍⠪⠩⠣⡑⠅⡣⢑⢅⠣⢒⠕⡊⠎⢜⠱⢑⢘⠕⣏⢮⡳⡽⣽⢯⢝⣎⢗⢽⢕⣗⡵⣝⢮⡳⡯⣿⣽⡺⣕⢯⡺");
                Console.WriteLine("⡵⣳⡫⣗⣗⡷⣻⣻⣳⣳⡽⡾⣯⣿⣞⣷⢑⠄⠂⠄⡁⡂⠌⡐⠠⢁⢂⠂⠅⠢⠨⢈⢂⠂⠅⡂⠅⡂⠌⡐⡨⡐⣕⢔⣌⢂⡂⡢⢘⢘⢮⢯⣯⢷⡱⡣⡯⡪⣗⢗⣝⢮⣺⡪⣟⣷⣻⢮⣫⡳⣝");
                Console.WriteLine("⡽⡮⣫⣗⣗⣟⣯⢿⣳⣳⣻⣻⣯⣿⢾⠞⢆⣪⡈⠄⠂⠄⡁⡂⠅⡂⡐⠨⠈⠌⠄⠅⡂⠌⡂⡂⢅⠢⡁⢆⢮⣞⢗⣝⠮⢓⠩⠩⢙⠸⠸⢵⢯⣗⢭⡳⣹⢪⣳⡫⣞⣕⢧⣫⢷⢯⡿⣕⣗⢝⡮");
                Console.WriteLine("⡽⣺⡳⣵⣳⢽⣾⣻⣗⣗⣯⡷⣿⣯⡯⡇⢅⣿⡅⠌⠨⠐⡀⢂⢂⢐⠠⢁⠡⠁⠌⡐⠠⢁⠢⢘⢜⠮⠮⢾⢳⢱⠃⡡⡦⡷⣞⣮⢶⢮⣌⠢⡙⡮⡣⣏⢮⢣⣳⢽⢕⢧⡳⣳⣫⡿⣯⢗⡵⣫⢞");
                Console.WriteLine("⣻⣪⢯⢞⣞⣽⣞⣷⣳⣳⣗⣿⢿⣳⣯⡃⠢⣿⠂⠌⠠⢁⠐⠠⠐⡀⢂⠐⠠⢁⠂⠄⡁⠂⠅⣓⡯⣧⣪⣔⣽⣓⣏⡋⠍⡉⠍⡊⡵⠅⠻⣷⡐⢜⢽⡸⣪⡣⣗⢽⡹⡵⡝⣞⡮⣟⣯⡗⡯⡮⣳");
                Console.WriteLine("⢮⣞⡽⣝⣞⣾⣺⣽⣞⡾⣺⣽⣿⣟⣾⢨⢨⣿⠡⠈⠌⠠⠈⠄⠡⠐⠠⢈⠐⡀⢂⠡⠀⠅⠨⠐⠽⢷⣿⣺⢿⠝⠳⡻⠽⡺⣽⢺⠁⠅⡁⢯⡧⡑⢵⡹⣲⢱⢽⢕⡯⡮⡳⣕⢿⡽⣟⡮⣳⢝⢮");
                Console.WriteLine("⢗⣗⡽⣳⣳⣳⢯⣷⣗⢿⡽⣾⣷⣟⣧⠣⠑⡁⢂⠡⠈⠄⠡⠈⠄⠡⠈⠄⢂⠐⡀⢂⠡⠈⠄⠡⢈⢾⣻⣞⡯⠅⠅⢂⠡⣹⣳⡣⠊⠄⡢⣯⣗⢌⢺⡪⡮⡳⣝⢵⡳⣝⢽⣸⢽⣽⣟⢮⡳⣝⢵");
                Console.WriteLine("⡯⣺⢽⢵⡳⡯⣟⡷⡯⣗⣟⣷⣿⣳⢯⢃⠡⠐⢀⠂⠡⠈⠄⠡⠈⠄⠡⠈⠄⢂⠐⡀⢂⠡⢈⠐⢠⣻⣽⢾⣝⢅⢱⢔⣜⣮⡷⣧⢥⢕⡽⣾⣺⠠⡳⣹⡪⣺⣪⡳⣝⢮⣣⣳⡻⣾⡽⡵⣝⢎⡗");
                Console.WriteLine("⡯⣗⢯⢗⡯⡿⣽⣻⡽⣳⣻⣞⣿⢾⣻⢐⡠⡨⣀⣂⢅⢌⢄⡅⣌⢄⢅⣅⣌⣄⣢⣐⢄⢢⣐⣜⣖⣯⣿⢻⠮⡢⡺⢝⢞⢞⠏⡏⡯⠯⡫⡻⠺⡐⢝⢜⢮⡪⣞⢮⡳⡣⣗⢮⢯⡷⡿⣕⢗⣝⢮");
                Console.WriteLine("⢮⣗⢯⣻⡺⣯⣟⡷⣯⣳⣳⡳⡯⣟⢷⢽⢽⣫⣟⢾⢽⣫⡿⡽⣯⣟⣿⣻⣯⣿⢷⣿⣜⡾⣷⣷⣿⣿⢷⢑⠨⢐⠨⢐⠐⠄⠅⠢⠨⡨⢂⠪⡨⡨⡂⡪⣪⡺⣪⢗⡽⣹⡪⣳⢯⣟⣿⣪⡳⣕⢯");
                Console.WriteLine("⢗⡽⣝⡮⡯⡷⣯⢿⡵⣳⢵⣫⢯⢾⢝⡽⣝⣞⢮⢯⣳⣳⣻⢽⣳⣳⣻⣿⣿⡿⣽⢾⣽⢿⣻⣷⣿⢿⣻⡂⡑⠌⡜⡰⢙⠌⡊⠌⢌⠢⠡⡑⡌⡆⡣⠸⡜⡮⣳⣫⢞⡵⣝⢮⣟⣾⣗⡗⣝⢮⡳");
                Console.WriteLine("⢯⡻⡮⡯⣫⡿⣽⢯⣟⢮⣻⢜⣗⢽⡳⣝⣞⢮⡫⣗⢗⡵⡯⡯⣾⣺⢽⣿⣾⣿⢽⡽⣾⢿⣟⣿⣾⣿⢿⢐⠨⡃⡇⢸⠠⢑⡘⠌⡐⠌⢌⠢⡑⡱⠨⡘⡮⡫⣞⢮⡳⣝⢮⡳⣳⣟⣾⡹⡪⣇⢯");
                Console.WriteLine("⣳⢯⢯⢯⣳⢿⢽⣻⢮⢯⣺⢝⡮⣳⢝⡮⣺⢵⣫⢾⢝⡾⡽⡽⣺⣺⢽⣿⣯⣿⢵⢿⡽⣟⣯⣿⣽⣿⣻⠄⠕⠕⡕⡨⡂⡑⠌⡂⠌⠌⠔⢌⢢⢑⢑⢌⢞⡝⣮⡳⣝⢮⡳⣝⣗⣿⣳⢝⡽⡜⣗");
                Console.WriteLine("⡵⣯⡳⡯⡾⣽⣻⣽⢯⡳⡽⡵⣫⢗⣟⣞⢽⣕⢗⡽⣕⣟⢞⣽⡳⣯⣻⣯⣿⣯⢯⢯⣟⡿⣯⣿⣽⣾⣿⠌⠌⠌⡂⡒⠩⠨⢐⢐⠡⠡⡑⢔⢢⠣⡑⡰⡝⡞⣞⢮⡳⡳⣝⢞⡾⣽⢯⡳⡳⣝⢮");
                Console.WriteLine("⣞⡵⡯⡯⣻⣺⣳⣟⣗⢽⣝⢽⢮⢯⡺⡮⣳⡳⡽⣝⢞⣮⣻⣪⣟⣞⢾⣻⣿⣽⢽⣻⣞⣿⢯⣿⣯⣿⢾⡁⠪⡰⢰⠨⢨⢨⠐⡐⠨⡂⠪⡐⡅⢕⠰⡘⣎⢯⡺⣕⢯⢝⡮⣳⣻⣽⣯⣫⡳⣕⢏");
                Console.WriteLine("⢵⢯⢯⢯⢞⣗⣿⣺⣗⡽⣪⢯⢞⣗⡽⣝⣞⢮⢯⡺⣝⣮⣺⣺⣺⣺⢽⣿⡿⣯⣟⢾⣺⣽⣟⣿⣾⣟⣿⠠⢑⢌⠢⡑⡌⡢⠡⡈⡢⠨⡨⠢⡑⡅⠕⢌⢮⡳⣝⣞⣝⢵⢝⣞⣞⣷⣗⢧⡳⣕⢯");
                Console.WriteLine("⣞⣵⣻⡺⣺⢽⣳⡿⣵⢳⣫⢯⣺⡺⣕⢷⢝⣞⡵⣳⢽⢵⣻⡪⡯⣻⣺⢿⣿⣗⣗⢽⡺⣯⢷⣿⣟⡿⡾⡐⡄⡑⣐⢨⢐⡐⣐⢔⡐⡌⣢⢢⣪⣰⣰⢸⢕⣗⢧⡳⣝⢮⢳⢽⢽⣻⣗⣝⢮⡫⡮");
                Console.WriteLine("⣗⡵⣳⢽⢽⢽⣳⣟⣗⢯⣺⢵⡳⣽⡪⣯⣳⡳⣝⢮⢗⡯⣺⣪⢯⢷⢽⣿⣟⣷⡳⣝⡽⣞⣯⣷⡿⣯⡫⣗⢽⢝⡮⣳⡳⣝⢞⢮⡺⣝⣞⣯⣿⢮⢮⢳⢝⣮⡳⡯⡮⡳⣝⢮⢟⣷⣟⡼⣕⡝⣎");
                Console.WriteLine("⢵⣫⢗⡯⣳⣟⣷⣻⣳⣫⢾⢵⡻⣪⢾⢕⣗⢽⣪⢯⣳⣫⡳⣳⣫⢯⢯⣷⣿⣟⣞⡺⣺⣳⣻⡾⣿⣳⢹⣪⡳⡳⡝⣞⢮⡳⣝⢵⢝⣞⡮⣷⣿⡳⣝⢵⣫⣺⡪⣗⢽⡹⣜⢞⣽⢷⡷⣝⢖⡽⣸");
                Console.WriteLine("");
                Console.WriteLine("이곳을 들어가기 위한 조건에 맞지 않습니다...");
                BTWS();
                Console.WriteLine("그러나 굳이 이곳을...들어가야 할지...알 수 없군요...");
                BTWS();
                Console.WriteLine("세탁실로 보내드리겠습니다...다시 한번 고민해보시길...");
                Status.Line();
                Thread.Sleep(2000);
                Laundryr();
            }
            Thread.Sleep(300);
        }
    }
}