using System;
using Galaxy.Core.Actors;
using Galaxy.Core.Environment;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy.Environments.Actors
{
    class ShipCool : Ship
    {
        public ShipCool(ILevelInfo info)  : base(info)
        {
          Width = 30;
          Height = Height + 25;
          ActorType = ActorType.Enemy;
        }
        public override void Load()
        {
            InitTimer();
            Load(@"Assets\ship4.png");
        }
    }
}
