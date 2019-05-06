using System;
using System.Collections.Generic;
using System.Text;

namespace DecorationPattern
{
    public class TShirt : DecoratePerson
    {
        public override void Show()
        {
            Console.Write("TShirt ");
            base.Show();
        }
    }

    public class BigTrouser: DecoratePerson
    {
        public override void Show()
        {
            Console.Write("BigTrouser ");
            base.Show();
        }
    }
}
