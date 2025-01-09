using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] private float _minHealth = 0;
    [SerializeField] private float _maxHealth = 100;
    [SerializeField] private float _currentHealth = 100;
    [SerializeField] private float _damageAmount = 10;
    [SerializeField] private float _healingAmount = 10;

    [SerializeField] private HealthbarText _healthText;
    [SerializeField] private HealthbarStandart _healthbarStandart;
    [SerializeField] private HealthbarSmooth _healthbarSmooth;

    [SerializeField] private Button _damageButton;
    [SerializeField] private Button _healButton;

    private void Awake()
    {
        _damageButton.onClick.AddListener(TakeDamage);
        _healButton.onClick.AddListener(Heal);
    }

    private void Start()
    {
        _healthText.SetMaxHealth(_maxHealth);
        _healthbarStandart.SetStartParameters(_maxHealth);
        _healthbarSmooth.SetStartParameters(_maxHealth);

        DisplayHealth();
    }

    private void DisplayHealth()
    {
        _currentHealth = Mathf.Clamp(_currentHealth, _minHealth, _maxHealth);

        _healthText.SetHealth(_currentHealth);
        _healthbarStandart.SetHealth(_currentHealth);
        _healthbarSmooth.SetHealth(_currentHealth);
    }

    public void TakeDamage()
    {
        _currentHealth -= _damageAmount;

        DisplayHealth();
        Debug.Log(_currentHealth / _maxHealth);
    }

    public void Heal()
    {
        _currentHealth += _healingAmount;

        DisplayHealth();
    }
}
