using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Genetic
{
    class Population
    {
        public List<Chromosome> chromosomes = new List<Chromosome>();
        public int porC;
        public int porM;

        public Population(int porC,int porM)
        {
            this.porC = porC;
            this.porM = porM;
        }
        public void crossover()
        {

        }

        public void mutate()
        {

        }
        public void roulette()
        {

        }
    }
}
