using System;
using System.Collections.Generic;
using System.Text;

namespace DecorationPattern
{
    public class DecoratePerson : Person
    {
        private Person _decorator;

        public void SetDecorator(Person decorator)
        {
            this._decorator = decorator;
        }

        public override void Show()
        {
            if(_decorator != null)
            {
                this._decorator.Show();
            }            
        }
    }
}
