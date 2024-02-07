using General.GamePlay;
using UnityEngine;

namespace Enemy
{
    public class EnemyDie : MonoBehaviour
    {
        [SerializeField] private Health health;
        [SerializeField] private int score;

        private UIController ui;
        private Level level;

        
        public void Initialize(UIController ui, Level level)
        {
            this.ui = ui;
            this.level = level;
            health.onDie.AddListener(Die);
        }

        private void Die()
        {
            print("Kill");
            ui.onScoreChanged.Invoke(score);
            level.onEnemyDie.Invoke();
            Destroy(gameObject);
        }
    }
}