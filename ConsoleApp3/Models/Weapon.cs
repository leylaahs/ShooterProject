using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Models
{
    internal class Weapon
    {
        int BulletCapacity;
        int BulletCount;
        int DischargeSeconds;
        bool ShootingMode;
       


        public void Shoot()
        {
            if (ShootingMode==true)
            {
                if (BulletCapacity > 0)
                {
                    Console.WriteLine("1 gülle atır");
                }
            }
            else
            {
                BulletCapacity = BulletCapacity - 1;
                Console.WriteLine(" ");
            }
        }
        public void Fire()
        {
             int str=(BulletCapacity/DischargeSeconds)*BulletCount;
            Console.WriteLine("hamısı atəşlənir ");
        }
        public void GetRemainBulletCount()
        {
            Console.WriteLine(BulletCapacity-BulletCount);
        }
       public void Reload()
        {
            if (BulletCount== BulletCapacity)
            {
                Console.WriteLine(" darağı yenidən doldurur.");
            }
        }
        public void ChangeFireMode()
        {
            if (ShootingMode == false)
            {
                Console.WriteLine("Atış modunu dəyişir.");
            }
        }
        public Weapon(int bulletCapacity,int bulletCount,int dischargeSeconds,bool shootingMode)
        {
            BulletCapacity = bulletCapacity;
            BulletCount = bulletCount;
            DischargeSeconds=dischargeSeconds;
            ShootingMode = shootingMode;

        }

    }
}
