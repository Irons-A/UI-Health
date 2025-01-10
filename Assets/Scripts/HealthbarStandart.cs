using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthbarStandart : MonoBehaviour
{
    [SerializeField] private Health _health;

    private Slider _healthSlider;

    private void Awake()
    {
        _healthSlider = GetComponent<Slider>();
    }

    private void OnEnable()
    {
        _health.ValueChanged += SetHealth;
    }

    private void OnDisable()
    {
        _health.ValueChanged -= SetHealth;
    }

    public void SetHealth(float currenHealth, float maxHealth)
    {
        _healthSlider.value = currenHealth / maxHealth;
    }
}
