using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace DCSL.RPNFinder
{
    public class RPNEngine
    {
        private List<int> _rpnList;

        public RPNEngine()
        {
            _rpnList = new List<int>();
        }

        public int GetRPNByIndex(int index)
        {
            return _rpnList[index - 1];
        }

        public void LoadRPNPrimes(int totalOfRPNs)
        {
            _rpnList.Add(2);

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            int nextPrime = 3;

            while (_rpnList.Count < totalOfRPNs)
            {
                if (IsRPN(nextPrime))
                {
                    _rpnList.Add(nextPrime);
                    Console.Write($"\r Robustly Prime Numbers loaded: {_rpnList.Count}; Progress: {(_rpnList.Count * 100) / totalOfRPNs}%; Time elapsed: {stopWatch.Elapsed}");
                }

                nextPrime += 2;
            }

            stopWatch.Stop();
        }

        private bool IsRPN(int primeNumber)
        {
            var number = primeNumber.ToString();

            if (number.Contains("0"))
            {
                return false;
            }

            var isRPN = true;

            for (int i = 0; i < number.Length; i++)
            {
                var newNumber = Convert.ToInt32(number.Remove(0, i));

                if (!IsPrime(newNumber))
                {
                    isRPN = false;
                    break;
                }
            }

            return isRPN;
        }

        private bool IsPrime(int number)
        {
            if (number < 2) return false;
            if (number % 2 == 0) return (number == 2);
            int root = (int)Math.Sqrt((double)number);
            for (int i = 3; i <= root; i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
