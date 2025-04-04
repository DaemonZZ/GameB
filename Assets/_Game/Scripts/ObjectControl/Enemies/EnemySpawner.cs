using System.Xml.Serialization;
using UnityEngine;

namespace Assets._Game.Scripts.ObjectControl.Enemies
{
    public class EnemySpawner : MonoBehaviour
    {
        [SerializeField]
        private GameObject _enemyPrefab;
        private float timeSpawn;

        private void SetTimeSpawn()
        {
            timeSpawn = Random.Range(1, 7);
        }
        private void Awake()
        {
            SetTimeSpawn();
        }
        private void Update()
        {
            timeSpawn -= Time.deltaTime;
            if (timeSpawn < 0)
            {
                GameObject enemy = Instantiate(_enemyPrefab);
                enemy.transform.position = this.transform.position;
                enemy.SetActive(true);
                SetTimeSpawn() ;
            }
        }
    }
}
