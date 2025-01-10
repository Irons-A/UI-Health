using TMPro;
using UnityEngine;

[RequireComponent(typeof(TMP_Text))]
public class HealthbarText : MonoBehaviour
{
    [SerializeField] private Health _health;

    private TMP_Text _healthText;

    private void Awake()
    {
        _healthText = GetComponent<TMP_Text>();
    }

    private void OnEnable()
    {
        _health.ValueChanged += SetHealth;
    }

    private void OnDisable()
    {
        _health.ValueChanged -= SetHealth;
    }

    private void SetHealth(float health, float maxHealth)
    {
        _healthText.text = ($"{health} / {maxHealth}");
    }
}
