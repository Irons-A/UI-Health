using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthbarSmooth : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private float _recoveryRate = 0.5f;

    private Slider _healthSlider;
    private Coroutine _healthDisplayingRoutine;

    private void Awake()
    {
        _healthSlider = GetComponent<Slider>();
    }

    private void OnEnable()
    {
        _health.ValueChanged += DisplayHealth;
    }

    private void OnDisable()
    {
        _health.ValueChanged -= DisplayHealth;
    }

    private IEnumerator HealthDisplayingRoutine(float health, float maxHealth)
    {
        while (_healthSlider.value != health / maxHealth)
        {
            _healthSlider.value = Mathf.MoveTowards(_healthSlider.value, health / maxHealth, _recoveryRate * Time.deltaTime);

            yield return null;
        }
    }

    public void DisplayHealth(float health, float maxHealth)
    {
        if (_healthDisplayingRoutine != null)
        {
            StopCoroutine(_healthDisplayingRoutine);
        }

        _healthDisplayingRoutine = StartCoroutine(HealthDisplayingRoutine(health, maxHealth));
    }
}
