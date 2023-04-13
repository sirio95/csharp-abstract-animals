using System.Diagnostics.Contracts;

namespace csharp_abstract_animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Esercizio1();
            Esercizio2();
        }
        public static void Esercizio1() 
        {

            List <Animale> listAnimali = new List <Animale>();
            Aquila AquilaDiBonelli = new Aquila();
            Cane Bassotto = new Cane();
            Delfino StenellaMaculata = new Delfino();
            Passerotto Testagrigia = new Passerotto();

            listAnimali.Add(AquilaDiBonelli);
            listAnimali.Add (Bassotto);
            listAnimali.Add(StenellaMaculata);
            listAnimali.Add(Testagrigia);

            foreach(Animale a in listAnimali)
            {
                a.Dormi();
                a.Verso();
                a.Mangia();
            }
            
        }
        public static void Esercizio2()
        {
            Console.WriteLine("Crea un animale: digita 1 per un'aquila, 2 per un cane, 3 per un delfino e 4 per un passero");
            int numAnimale;
            while((!int.TryParse(Console.ReadLine(), out numAnimale)) || !(numAnimale > 0 && numAnimale < 5))
                Console.WriteLine("il numero inserito non è valido");

            switch (numAnimale)
            {
                case 1:
                    {
                        Aquila aquilaUtente = new Aquila();
                        FaiVolare(aquilaUtente);
                        break;
                    }
                case 2:
                    {
                        Cane caneUtente = new Cane();
                        FaiCamminare(caneUtente);
                        break;
                    }
                case 3:
                    {
                        Delfino delfinoUtente = new Delfino();
                        FaiNuotare(delfinoUtente);
                        break;
                    }
                case 4:
                    {
                        Passerotto passeroUtente = new Passerotto();
                        FaiVolare(passeroUtente);
                        break;
                    }

            }   

            void FaiVolare(IVolante animal)
            {
                animal.Vola();
            }
            void FaiNuotare(INuotante animal)
            {
                animal.Nuota();
            }
            void FaiCamminare(ICamminante animal)
            {
                animal.Cammina();
            }

            

        }

        public abstract class Animale
        {
            public void Dormi()
            {
                Console.WriteLine("Zzzzz");
            }
            public abstract void Verso();

            public abstract void Mangia();            
        }
        public class Aquila : Animale, IVolante, ICamminante
        {
            public override void Verso()
            {
                Console.WriteLine("strido");
            }
            public override void Mangia()
            {
                Console.WriteLine("pesci, piccoli e medi vertebrati");
            }
            public void Vola()
            {
                Console.WriteLine("Sto Volando!");
            }
            public void Cammina()
            {
                Console.WriteLine("Posso anche camminare");
            }
        }
        public class Cane: Animale, ICamminante
        {
            public override void Verso()
            {
                Console.WriteLine("abbaìo");
            }
            public override void Mangia()
            {
                Console.WriteLine("Onnivoro. Dieta al 50% composto da proteine animali");
            }
            public void Cammina()
            {
                Console.WriteLine("Sto camminando!");
            }
        }
        public class Delfino: Animale, INuotante
        {
            public override void Verso()
            {
                Console.WriteLine("clicks, burst pulsed sound e fischi");
            }
            public override void Mangia()
            {
                Console.WriteLine("pesci");
            }
            public void Nuota()
            {
                Console.WriteLine("Sto nuotando");
            }
        }
        public class Passerotto: Animale, IVolante, ICamminante
        {
            public override void Verso()
            {
                Console.WriteLine("cinghuettio");
            }
            public override void Mangia()
            {
                Console.WriteLine("Onnivoro. Insetti e semi");
            }
            public void Vola()
            {
                Console.WriteLine("Sto volando!");
            }
            public void Cammina()
            {
                Console.WriteLine("Posso anche camminare!");
            }
        }

        public interface IVolante
        {
            public void Vola();
            
        }
        public interface INuotante
        {
            public void Nuota();
            
        }
        public interface ICamminante
        {
            public void Cammina();
            
        }

        

        
        
    }
    
    
}