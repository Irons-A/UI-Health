using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthbarStandart : HealthbarCore
{
    [field: SerializeField] public Slider HealthSlider { get; private set; }

    private void Awake()
    {
        HealthSlider = GetComponent<Slider>();
    }

    protected override void DisplayHealth(float currenHealth, float maxHealth)
    {
        HealthSlider.value = currenHealth / maxHealth;
    }
}
