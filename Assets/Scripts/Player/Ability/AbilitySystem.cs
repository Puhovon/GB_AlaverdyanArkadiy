using DG.Tweening;
using General.GamePlay;
using UnityEngine;
using UnityEngine.Events;

public class AbilitySystem : MonoBehaviour
{
    [SerializeField] private GameObject abilityPanel;
    [SerializeField] private Level level;

    public UnityEvent onAbilitySelect = new UnityEvent();
    private void Start()
    {
        transform.gameObject.SetActive(false);
        level.onLevelComplete.AddListener(OpenWindowWithAbilities);
        onAbilitySelect.AddListener(CloseWindowWithAbilities);
    }

    private void OpenWindowWithAbilities()
    {
        transform.gameObject.SetActive(true);
        transform.DOScale(new Vector3(0.5f, 0.5f, 1), 1f);
    }

    private void CloseWindowWithAbilities()
    {
        transform.DOScale(new Vector3(0, 0, 1), 1f);
        transform.gameObject.SetActive(false);
    }
}
