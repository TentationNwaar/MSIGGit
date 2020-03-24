using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace HelloCar
{
    class Program
    {
        static void Main(string[] args)
        {
            SoundPlayer carSound = new System.Media.SoundPlayer("CarSound.wav");
            carSound.Play();

            Console.WriteLine("Hello 00");
            
            Car car1 = new Car("Ferrari");
            Car car2 = new Car("Mazerati");
            Car car3 = new Car("Citroen");

            Console.WriteLine("\r\nNom de la première voiture : " + car1.name);
            Console.WriteLine("\r\nNom de la deuxième voiture : " + car2.name);
            Console.WriteLine("\r\nNom de la troisième voiture : " + car3.name);

            Console.ReadLine();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Bienvenue dans SelectMyCar");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("\r\nCombien de voitures voulez-vous ? : ");
            int numberCar = Convert.ToInt32(Console.ReadLine());
            Car[] cars = new Car[numberCar];

            for (int i = 0; i < cars.Length; i++)
            {
                Console.Write("Quels noms voulez-vous donner ? : ");
                string carName = Console.ReadLine();
                Car carUser1 = new Car(carName);
                cars[i] = carUser1;

                Console.WriteLine("Nom de la voiture : " +(i+1+" ") + carUser1.name)


            }

            Console.WriteLine("\r\nAppuyer sur enter pour fermer");
            Console.ReadLine();

            
        }
    }
}
