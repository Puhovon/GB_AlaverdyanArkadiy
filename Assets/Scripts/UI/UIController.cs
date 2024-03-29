using DG.Tweening;
using General;
using General.Entities;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] private Health playerHealth;

    [Header("UI Components")]
    [SerializeField] private TMP_Text healthCount;
    [SerializeField] private TMP_Text scoreCount;
    
    [Space]
    
    [Header("UI Pause")]
    [SerializeField] private Button pause;
    [SerializeField] private Button mainMenu;
    [SerializeField] private Button returnToGame;
    [SerializeField] private GameObject pausePanel;

    [Space]
    
    [Header("UI Lose")]
    [SerializeField] private Button mainMenuAfterLose;
    [SerializeField] private GameObject losePanel;
    
    [HideInInspector] public UnityEvent<int> onScoreChanged = new UnityEvent<int>();
    
    private int score = 0;
    
    public void Initialize()
    {
        playerHealth.onHealPointChanged.AddListener(OnHealthChanged);
        playerHealth.onDie.AddListener(Lose);
        onScoreChanged.AddListener(OnScoreChanged);
        pause.onClick.AddListener(OnPauseClicked);
        returnToGame.onClick.AddListener(OnReturnToGameClicked);
        mainMenu.onClick.AddListener(OnMainMenuClicked);
        mainMenuAfterLose.onClick.AddListener(OnMainMenuClicked);

        
        OnHealthChanged(playerHealth.CurrentHealth);
        OnScoreChanged(0);
        
        pausePanel.SetActive(false);
        losePanel.SetActive(false);
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

    private void OnPauseClicked()
    {
        pausePanel.SetActive(true);
        pausePanel.transform.DOScale(new Vector3(0.5f, 0.5f, 1), 1).onComplete = (() => Time.timeScale = 0);
        pause.enabled = false;
    }

    private void OnReturnToGameClicked()
    {
        Time.timeScale = 1;
        pausePanel.transform.DOScale(new Vector3(0, 0, 0), 1).onComplete = () => pausePanel.SetActive(false);
        pause.enabled = true;
    }

    private void OnMainMenuClicked()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(ScenesIndex.MainMenu);
    }

    private void Lose()
    {
        losePanel.SetActive(true);
        losePanel.transform.DOScale(new Vector3(0.5f, 0.5f, 1), 1).onComplete = (() => Time.timeScale = 0);
    }
}
