using System;
using System.Collections.Generic;
using System.Text;

namespace Nettbutikk
{
    class Members
    {
        public List<Member> LedZeppelin;
        public Instruments Instruments; 

        public Members()
        {
            Instruments = new Instruments();
            LedZeppelin = new List<Member>
            {
                new Member("James Patrick", "Jimmy Page", Instruments.Guitar),
            };
        }
    }
}
