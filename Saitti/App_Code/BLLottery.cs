using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BLLottery
/// </summary>

namespace JAMK.ICT.BL
{
    public class BLLottery
    {
        List<int> numbers;
        public BLLottery()
        {
            numbers = new List<int>();
        }

        public List<int> randomLottery()
        {
            var rnd = new Random();
            numbers = Enumerable.Range(1, 39).OrderBy(x => rnd.Next()).Take(7).ToList();
            return numbers;
        }


        public List<int> randomVikingLottery()
        {
            var rnd = new Random();
            numbers = Enumerable.Range(1, 48).OrderBy(x => rnd.Next()).Take(6).ToList();
            return numbers;
        }
    }
}