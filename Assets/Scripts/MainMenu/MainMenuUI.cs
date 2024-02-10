using DG.Tweening;
using General;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace MainMenu
{
    public class MainMenuUI : MonoBehaviour
    {
        [SerializeField] private Button about;
        [SerializeField] private GameObject aboutPanel;
        [SerializeField] private Button closeAboutPanel;
        [SerializeField] private Button start;
        [SerializeField] private Button howToPlay;
        [SerializeField] private Button howToPlayClose;
        [SerializeField] private GameObject howToPlayPanel;


        private void Start()
        {
            start.onClick.AddListener(StartGame);
            about.onClick.AddListener(AboutOpen);
            closeAboutPanel.onClick.AddListener(AboutClose);
            howToPlay.onClick.AddListener(HowToPlayOpen);
            howToPlayClose.onClick.AddListener(HowToPlayClose);
            aboutPanel.SetActive(false);
            howToPlayPanel.SetActive(false);
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

        private void HowToPlayOpen()
        {
            howToPlayPanel.SetActive(true);
            howToPlayPanel.transform.DOScale(new Vector3(0.5f, 0.5f, 1), 1);
        }

        private void HowToPlayClose()
        {
            howToPlayPanel.transform.DOScale(new Vector3(0, 0, 0), 1).onComplete = () => howToPlayPanel.SetActive(false);
        }
    }
}