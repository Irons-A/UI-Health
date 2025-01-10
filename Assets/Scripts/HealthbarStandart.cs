using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthbarStandart : HealthbarCore
{
    public Slider _healthSlider;

    private void Awake()
    {
        _healthSlider = GetComponent<Slider>();
    }

    public override void DisplayHealth(float currenHealth, float maxHealth)
    {
        _healthSlider.value = currenHealth / maxHealth;
    }
}
