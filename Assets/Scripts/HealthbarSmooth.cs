using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthbarSmooth : HealthbarStandart
{
    [SerializeField] private float _recoveryRate = 0.5f;

    private Coroutine _healthDisplayingRoutine;

    private IEnumerator HealthDisplayingRoutine(float health, float maxHealth)
    {
        while (HealthSlider.value != health / maxHealth)
        {
            HealthSlider.value = Mathf.MoveTowards(HealthSlider.value, health / maxHealth, _recoveryRate * Time.deltaTime);

            yield return null;
        }
    }

    protected override void DisplayHealth(float health, float maxHealth)
    {
        if (_healthDisplayingRoutine != null)
        {
            StopCoroutine(_healthDisplayingRoutine);
        }

        _healthDisplayingRoutine = StartCoroutine(HealthDisplayingRoutine(health, maxHealth));
    }
}
