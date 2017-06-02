using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    class TabuSearch
    {

        public Random rnd = new Random();

        public int MAX_ITER = 8000;
        public int TABU_SIZE = 10;
        public int NEIGHBORHOOD_SIZE = 50;
        public int COMBINATION_QUANTITY = 100;

        public int needed_piedra = 0;
        public int needed_ceramico = 0;
        public int needed_retablo = 0;

        public TabuSearch()
        {

        }

        private double fitness(List<ProductLineAssignment> solution, List<Tuple<int, Product>> product_quantities) // REFINAR
        {
            if (solution == null) return -1;

            double total_break = 0;
            double total_time = 0;

            foreach (ProductLineAssignment set in solution)
            {
                double partial_break = 0;
                double partial_time = 0;
                double product_quantity = 0;
                foreach (Assignment assignment in set.assignments)
                {
                    foreach (Ratio r in assignment.assigned_worker.ratios)
                    {
                        if (r.workstation.Equals(assignment.assigned_workstation) && (r.type == "Efficiency"))
                        {
                            foreach (Tuple<int, Product> tuple in product_quantities)
                            {
                                if (tuple.Item2.Equals(assignment.assigned_workstation.product))
                                {
                                    partial_break = partial_break + (1 - r.value) * assignment.assigned_workstation.break_cost;
                                    if (tuple.Item2.name == "Retablo") product_quantity = tuple.Item1 / needed_retablo;
                                    else if (tuple.Item2.name == "Ceramico") product_quantity = tuple.Item1 / needed_ceramico;
                                    else if (tuple.Item2.name == "Piedra") product_quantity = tuple.Item1 / needed_piedra;
                                    break;
                                }
                            }
                            break;
                        }
                    }
                }
                total_break = total_break + (partial_break / set.assignments.Count()) * product_quantity;                
            }
            return 1 / total_break;
        }



    }
}
