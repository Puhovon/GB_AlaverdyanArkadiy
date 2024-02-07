using Enemy;
using UnityEngine;
using UnityEngine.Events;

namespace General.GamePlay
{
    public class Level : MonoBehaviour
    {
        [Header("Enemy Settings")]
        [SerializeField] private int maxCountOfEnemies = 0;
        [SerializeField] private int multiplyerOfEnemiesCount;

        [SerializeField] private Transform[] spawnPoints;

        [Header("Links")]
        [SerializeField] private GameObject Enemy;
        [SerializeField] private Transform Player;
        [SerializeField] private UIController ui;
        
        [HideInInspector] public UnityEvent onEnemyDie = new UnityEvent();

        private int enemiesCount;

        private void Start()
        {
            NextLevel();
            onEnemyDie.AddListener(EnemyDie);
            enemiesCount = maxCountOfEnemies;
        }

        private void EnemyDie()
        {
            enemiesCount -= 1;
            print(enemiesCount);

            if (enemiesCount <= 0) NextLevel();
        }

        private void NextLevel()
        {
            
            print("NextLevel");
            maxCountOfEnemies += multiplyerOfEnemiesCount;
            enemiesCount = maxCountOfEnemies;
            print(maxCountOfEnemies);            
            for (int i = 0; i < maxCountOfEnemies; i++)
            {

                int spawnPoint = Random.Range(0, 4);
                var g = Instantiate(Enemy, spawnPoints[spawnPoint]);
                g.GetComponent<Health>().Initialize();
                g.GetComponent<EnemyMovement>().Initialize(Player);
                g.GetComponent<EnemyDie>().Initialize(ui, this);
            }

        }
    }
}