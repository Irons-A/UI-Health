using TMPro;
using UnityEngine;

public class HealthbarText : MonoBehaviour
{
    private TMP_Text _healthText;
    private float _maxHealth;

    private void Awake()
    {
        _healthText = GetComponent<TMP_Text>();
    }

    public void SetMaxHealth(float maxHealth)
    {
        _maxHealth = maxHealth;
    }

    public void SetHealth(float health)
    {
        _healthText.text = ($"{health} / {_maxHealth}");
    }
}
