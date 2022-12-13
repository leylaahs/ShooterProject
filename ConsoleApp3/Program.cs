using ConsoleApp3.Models;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weapon weapon = new Weapon(20, 47, 67, true);
            CreateMenu();

            Console.Write("Reqem secim: ");
            int acarsoz = int.Parse(Console.ReadLine().Trim());

            switch (acarsoz)
            {
                case 1:
                    weapon.Shoot();
                    break;
                case 2:
                    weapon.Fire();
                    break;
                case 3:
                    weapon.GetRemainBulletCount();
                    break;
                case 4:
                    weapon.Reload();
                    break;
                case 5:
                    weapon.ChangeFireMode();
                    break;
            }

        }
        private static bool CreateMenu()
        {
            Console.Clear();

            Console.WriteLine("0) İnformasiya almaq üçün");
            Console.WriteLine("1) Shoot metodu üçün");
            Console.WriteLine("2) Fire metodu üçün");
            Console.WriteLine("3) GetRemainBulletCount metodu üçün");
            Console.WriteLine("4) - Reload metodu üçün");
            Console.WriteLine("5)ChangeFireMode metodu üçün");
            Console.WriteLine("6)  Proqramdan dayandırmaq üçün\r\nqısayoldur.");

            return true;

        }
    }
}