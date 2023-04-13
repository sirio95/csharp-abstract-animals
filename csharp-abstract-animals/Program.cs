namespace csharp_abstract_animals
{
    internal class Program
    {
        static void Main(string[] args)
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

        public abstract class Animale
        {
            public void Dormi()
            {
                Console.WriteLine("Zzzzz");
            }
            public abstract void Verso();

            public abstract void Mangia();
            
        }
        public class Aquila : Animale
        {
            public override void Verso()
            {
                Console.WriteLine("strido");
            }
            public override void Mangia()
            {
                Console.WriteLine("pesci, piccoli e medi vertebrati");
            }
        }
        public class Cane: Animale
        {
            public override void Verso()
            {
                Console.WriteLine("abbaìo");
            }
            public override void Mangia()
            {
                Console.WriteLine("Onnivoro. Dieta al 50% composto da proteine animali");
            }
        }
        public class Delfino: Animale
        {
            public override void Verso()
            {
                Console.WriteLine("clicks, burst pulsed sound e fischi");
            }
            public override void Mangia()
            {
                Console.WriteLine("pesci");
            }
        }
        public class Passerotto: Animale
        {
            public override void Verso()
            {
                Console.WriteLine("cinghuettio");
            }
            public override void Mangia()
            {
                Console.WriteLine("Onnivoro. Insetti e semi");
            }
        }
    }
}