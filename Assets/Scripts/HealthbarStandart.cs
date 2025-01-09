using UnityEngine;
using UnityEngine.UI;

public class HealthbarStandart : MonoBehaviour
{
    private Slider _healthSlider;
    private float _maxHealth;

    private void Awake()
    {
        _healthSlider = GetComponent<Slider>();
    }

    public void SetStartParameters(float maxHealth)
    {
        _maxHealth = maxHealth;
    }

    public void SetHealth(float currenHealth)
    {
        _healthSlider.value = currenHealth / _maxHealth;
    }
}
