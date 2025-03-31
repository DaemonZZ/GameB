using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor.Tilemaps;
using UnityEngine;

namespace Assets._Game.Scripts.ObjectControl.Enemies
{
    internal class CommonCarController : MonoBehaviour, IEnemyController
    {
        private float moveSpeed = 10f;
        private Rigidbody2D rb;

        void Start()
        {
            Debug.Log("Start");
            rb = GetComponent<Rigidbody2D>();
        }
        void Update()
        {
            MoveEnemy();
        }
        void OnDestroy()
        {
            Debug.Log("OnDestroy");
        }
        void OnBecameInvisible()
        {
            Destroy(gameObject);
        }

        public void MoveEnemy()
        {
            transform.Translate(0, 0.01f, 0);
        }
    }
}
