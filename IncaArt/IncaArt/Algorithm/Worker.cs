using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Algorithm
{
    public class Worker : Person
    {
        public int shift_id { get; set; }
        public List<Ratio> ratios { get; set; }

    public Worker()
    {

    }

    public Worker(string name, string last_name) :base(name,last_name)
        {
        this.ratios = new List<Ratio>();
    }


}
class WorkerComparer : IComparer<Worker>
{
    public int Compare(Worker w1, Worker w2)
    {
        double average1 = 0;
        double average2 = 0;

        for (int i = 0; i < w1.ratios.Count(); i++)
        {
            if (w1.ratios.ElementAt(i).type == "Efficiency")
                average1 = average1 + w1.ratios.ElementAt(i).value;
        }
        average1 = average1 / w1.ratios.Count();

        for (int j = 0; j < w2.ratios.Count(); j++)
        {
            if (w2.ratios.ElementAt(j).type == "Efficiency")
                average2 = average2 + w2.ratios.ElementAt(j).value;
        }
        average2 = average2 / w2.ratios.Count();

        if (average1 == average2)
            return 0;
        if (average1 < average2)
            return -1;
        return 1;
    }
}
}
