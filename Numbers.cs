using System;
using System.Collections.Generic;

namespace UniqeNumbers {
    public class Numbers {

        public Random a = new Random ();
        public List<int> randomUniqeNumbers = new List<int> ();
        int number = 0;

        private void MakeUniqeNumbers () {
            number = a.Next (0, 1000);
            if (!randomUniqeNumbers.Contains (number))
                randomUniqeNumbers.Add (number);
        }

        public bool Test () {

            bool isDublicate = NumberTests.HasDuplicate (randomUniqeNumbers, out int dublicate);
            return isDublicate;
        }
    }

}
