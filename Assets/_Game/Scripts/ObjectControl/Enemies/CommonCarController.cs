using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEditor.Tilemaps;
using UnityEngine;

namespace Assets._Game.Scripts.ObjectControl.Enemies
{
    internal class CommonCarController : MonoBehaviour, IEnemyController
    {
        private float moveSpeed = 3f;
        private Rigidbody2D rb;
        public Vector2 target;
        public float duration = 2f;
        private float time = 0f;

        void Start()
        {
            Debug.Log("Start: " + transform.position.x);
            rb = GetComponent<Rigidbody2D>();
            target = new Vector2(transform.position.x, transform.position.y + 10);
        }
        void Update()
        {
            MoveEnemy();
        }
        void OnDestroy()
        {
            
        }
        void OnBecameInvisible()
        {
            Destroy(gameObject);
        }

        public void MoveEnemy()
        {
            if (time < 1f)
            {
                time += Time.deltaTime / duration;
                transform.position = Vector3.Lerp(transform.position, target, time);
            }
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            Destroy(gameObject);
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            Destroy(gameObject);
        }
        private void OnTriggerExit2D(Collider2D collision)
        {
            //Debug.Log("OnTriggerExit2D");

        }
    }
}
