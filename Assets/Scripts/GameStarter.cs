using Asteroids.ObjectsPool;
using UnityEngine;

namespace Asteroids
{
    public sealed class GameStarter : MonoBehaviour
    {
        private void Start()
        {
            EnemyPool _enemyPool = new EnemyPool(5);
            var enemy = _enemyPool.GetEnemy("Asteroid");
            enemy.transform.position = Vector3.one;
            enemy.gameObject.SetActive(true);
            Rigidbody2D rb = enemy.GetComponent<Rigidbody2D>();
            rb.AddForce(enemy.transform.forward * 10.0f);
        }
    }
}
