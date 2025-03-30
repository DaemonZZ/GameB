using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets._Game.Scripts.ObjectControl.Enemies
{
    internal class CommonCarController : MonoBehaviour, IEnemyController
    {
        private float moveSpeed = 5f;
        private Rigidbody2D rb;
        public void OnDestroyEnemy()
        {
            Debug.Log("onDestroy");
        }

        public void OnSpawnEnemy()
        {
            Debug.Log("onSpawn");
        }

        void Start()
        {

        }
        void Update()
        {
        
        }
    }
}
