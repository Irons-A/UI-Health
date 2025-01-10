using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    public event Action<float, float> ValueChanged;

    [SerializeField] private float _minHealth = 0;
    [SerializeField] private float _currentHealth = 100;
    [SerializeField] private float _maxHealth = 100;

    private void Start()
    {
        ValueChanged?.Invoke(_currentHealth, _maxHealth);
    }

    public void TakeDamage(float damageAmount)
    {
        if (damageAmount > 0)
        {
            _currentHealth -= damageAmount;

            _currentHealth = Mathf.Clamp(_currentHealth, _minHealth, _maxHealth);

            ValueChanged?.Invoke(_currentHealth, _maxHealth);
        }
    }

    public void Heal(float healingAmount)
    {
        if (healingAmount > 0)
        {
            _currentHealth += healingAmount;

            _currentHealth = Mathf.Clamp(_currentHealth, _minHealth, _maxHealth);

            ValueChanged?.Invoke(_currentHealth, _maxHealth);
        }
    }
}
