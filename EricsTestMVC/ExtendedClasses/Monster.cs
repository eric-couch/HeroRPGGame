using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EricsTestMVC.Models
{
    public class Monster
    {
        public int Health { get; set; }
        public int LVL { get; set; }
        public int AttackPower { get; set; }
        public Nullable<int> EXP { get; set; }
        public string Name { get; set; }
        public Nullable<byte> Alive { get; set; }
        //public Nullable<int> Weapon { get; set; }

        public virtual Weapon Weapon1 { get; set; }
    }
}
