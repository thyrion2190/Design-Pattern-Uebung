using System;
using System.Collections.Generic;
using System.Text;

namespace AdaptaPatternExample
{
    public class Adapter : IEnemyObject
    {
        private Wizard wizard;

        public Adapter(Wizard wizard)
        {
            this.wizard = wizard;
        }
        public void Attack()
        {
            wizard.AttackPlayer();
        }

        public void SayHello()
        {
            wizard.Communicate();
        }

        public void Sleep()
        {
            wizard.Rest();
        }
    }
}
