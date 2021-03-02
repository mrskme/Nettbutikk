using System;
using System.Collections.Generic;
using System.Text;

namespace Nettbutikk
{
    class Members
    {
        public List<Member> LedZeppelin, Daftpunk;
        public Instruments Instruments; 

        public Members()
        {
            Instruments = new Instruments();
            LedZeppelin = new List<Member>
            {
                new Member("James Patrick", "Jimmy Page", Instruments.Guitar),
                new Member("John Henry Bonham", "John Bonham", Instruments.Drumset),
            };
            Daftpunk = new List<Member>
            {
                new Member("Thomas Bangalter","Brain Mann", Instruments.KeyBoard),
                new Member("Guy-Manuel de Homem-Christo", "Rocket Mann", Instruments.DJ),
            };
        }
    }
}
