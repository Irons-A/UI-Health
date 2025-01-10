using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthbarCore : MonoBehaviour
{
    [SerializeField] private Health _health;

    private void OnEnable()
    {
        _health.ValueChanged += DisplayHealth;
    }

    private void OnDisable()
    {
        _health.ValueChanged -= DisplayHealth;
    }

    public virtual void DisplayHealth(float currenHealth, float maxHealth)
    {

    }
}
