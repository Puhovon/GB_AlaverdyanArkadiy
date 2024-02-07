using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class UIController : MonoBehaviour
{
    [SerializeField] private Health playerHealth;

    [Header("UI Components")]
    [SerializeField] private TMP_Text healthCount;
    [SerializeField] private TMP_Text scoreCount;

    public UnityEvent<int> onScoreChanged = new UnityEvent<int>();
    
    private int score = 0;
    
    private void Start()
    {
        playerHealth.onHealPointChanged.AddListener(OnHealthChanged);
        onScoreChanged.AddListener(OnScoreChanged);
        OnHealthChanged(playerHealth.CurrentHealth);
        OnScoreChanged(0);
    }

    private void OnHealthChanged(int health)
    {
        healthCount.text = $"HP: {health}";
    }

    private void OnScoreChanged(int scorePerUnit)
    {
        score += scorePerUnit;
        scoreCount.text = $"Score: {score}";
    }
}
