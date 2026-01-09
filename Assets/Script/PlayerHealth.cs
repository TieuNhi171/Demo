using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Script
{
    public class PlayerHealth : Health
    {
        protected override void Die()
        {
            base.Die();
            Debug.WriteLine("Player die");
        }
    }
}
