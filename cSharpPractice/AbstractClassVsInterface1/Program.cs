using System;

namespace AbstractClassVsInterface1
{
    class Program
    {
        static void Main(string[] args)
        {
            // var missile = new Missile();
            // var machineGun = new MachineGun();
            // missile.Fire();
            // machineGun.Fire();
            Weapon[] weapons= new Weapon[2];
            weapons[0] = new Missile();
            weapons[1] = new MachineGun();
            //for (int i = 0; i < weapons.Length; i++)
            //{
            //    weapons[i].Fire();
            //}

            foreach (var weapon in weapons)
            {
                weapon.Fire();
            }
        }
    }
    public interface IWeapon
    {

    }
    public abstract class Weapon
    {
        protected int DamagePower;
        public abstract void Fire();
    }
    public class Missile : Weapon
    {
        public Missile()
        {
            DamagePower = 200;
        }
        public override void Fire()
        {
            Console.WriteLine("Missile was fired with damage amount: {0}", DamagePower);
        }
    }
    public class MachineGun : Weapon
    {
        public MachineGun()
        {
            DamagePower = 100;
        }
        public override void Fire()
        {
            Console.WriteLine("MachineGun was fired with damage amount: {0}", DamagePower);
        }
    }


}
