using System;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public event Action<float, float> ValueChanged;

    [SerializeField] private float _minHealth = 0;

    [field: SerializeField] public float CurrentHealth = 100;
    [field: SerializeField] public float MaxHealth = 100;

    private void Start()
    {
        ValueChanged?.Invoke(CurrentHealth, MaxHealth);
    }

    public void TakeDamage(float damageAmount)
    {
        CurrentHealth -= damageAmount;

        if (CurrentHealth < _minHealth)
        {
            CurrentHealth = _minHealth;
        }

        ValueChanged?.Invoke(CurrentHealth, MaxHealth);
    }

    public void Heal(float healingAmount)
    {
        CurrentHealth += healingAmount;

        if (CurrentHealth > MaxHealth)
        {
            CurrentHealth = MaxHealth;
        }

        ValueChanged?.Invoke(CurrentHealth, MaxHealth);
    }
}
