using DG.Tweening;
using General;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
    [SerializeField] private Button about;
    [SerializeField] private GameObject aboutPanel;
    [SerializeField] private Button closeAboutPanel;
    [SerializeField] private Button start;


    private void Start()
    {
        start.onClick.AddListener(StartGame);
        about.onClick.AddListener(AboutOpen);
        closeAboutPanel.onClick.AddListener(AboutClose);
        aboutPanel.SetActive(false);
    }

    private void StartGame()
    {
        SceneManager.LoadScene(ScenesIndex.GameScene);
    }

    private void AboutOpen()
    {
        aboutPanel.SetActive(true);
        aboutPanel.transform.DOScale(new Vector3(0.5f, 0.5f, 1), 1);
    }

    private void AboutClose()
    {
        aboutPanel.transform.DOScale(new Vector3(0, 0, 0), 1).onComplete = () => aboutPanel.SetActive(false);
    }

}
