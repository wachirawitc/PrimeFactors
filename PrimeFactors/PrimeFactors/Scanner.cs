using System.Collections.Generic;

namespace PrimeFactors
{
    public class Scanner<T>
    {
        private readonly List<T> sources;
        private int pointer;

        public Scanner(List<T> sources)
        {
            this.sources = sources;
            pointer = 0;
        }

        public T Value => sources[pointer];

        public void Next()
        {
            pointer += 1;
        }

        public bool HasNext()
        {
            return pointer < sources.Count;
        }
    }
}