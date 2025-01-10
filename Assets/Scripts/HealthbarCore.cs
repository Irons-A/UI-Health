using UnityEngine;

public abstract class HealthbarCore : MonoBehaviour
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

    public abstract void DisplayHealth(float currenHealth, float maxHealth);
}
