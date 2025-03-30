using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets._Game.Scripts
{
    internal interface IEnemyController
    {
        public void OnSpawnEnemy();
        public void OnDestroyEnemy();

    }
}
