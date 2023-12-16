using System;

namespace Ex7Lab.POS
{
    public class Register
    {
        private Pos pos;
        public void AddPos(Pos pos)
        {
            this.pos = pos;
        }

        public void PlataCash(double suma)
        {
            Console.WriteLine($"S-a efectuat plata in valoare de {suma} cash");
        }

        public Pos PlataCuCardul(double suma)
        {
            pos.IntroduSumaDePlata(suma);
            return pos;
        }
    }
}