using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealthbarSmooth : MonoBehaviour
{
    [SerializeField] private float _recoveryRate = 0.5f;

    private Slider _healthSlider;
    private float _currentHealth;
    private float _maxHealth;

    private void Awake()
    {
        _healthSlider = GetComponent<Slider>();
    }

    private IEnumerator HealthDisplayingRoutine()
    {
        while (_healthSlider.value != _currentHealth / _maxHealth)
        {
            _healthSlider.value = Mathf.MoveTowards(_healthSlider.value, _currentHealth / _maxHealth, _recoveryRate * Time.deltaTime);

            yield return null;
        }
    }

    public void SetStartParameters(float maxHealth)
    {
        _maxHealth = maxHealth;
    }

    public void SetHealth(float currenHealth)
    {
        _currentHealth = currenHealth;
        StopCoroutine(HealthDisplayingRoutine());
        StartCoroutine(HealthDisplayingRoutine());
    }
}
