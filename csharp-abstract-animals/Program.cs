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
            Aquila AquilaDiBonelli = new Aquila();
            AquilaDiBonelli.Dormi();
            AquilaDiBonelli.Verso();
            AquilaDiBonelli.Mangia();


            Cane Bassotto = new Cane();
            Bassotto.Dormi();
            Bassotto.Verso();
            Bassotto.Mangia();



            Delfino StenellaMaculata = new Delfino();
            StenellaMaculata.Dormi();
            StenellaMaculata.Verso();
            StenellaMaculata.Mangia();


            Passerotto Testagrigia = new Passerotto();
            Testagrigia.Dormi();
            Testagrigia.Verso();
            Testagrigia.Mangia();
        }
        public static void Esercizio2()
        {
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

            for(int i = 0; i < 3; i++) 
            {
                Aquila aquila = new Aquila();
                FaiVolare(aquila);
                Passerotto Passero = new Passerotto();
                FaiVolare(Passero);
                Delfino delfino = new Delfino();
                FaiNuotare(delfino);
                Cane cane = new Cane();
                FaiCamminare(cane);

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