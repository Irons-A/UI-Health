using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthbarSlider : MonoBehaviour
{
    [SerializeField] private bool _isSmooth = false;
    [SerializeField] private float _recoveryRate = 1;

    private Slider _healthSlider;
    private float _currentHealth;

    private void Awake()
    {
        _healthSlider = GetComponent<Slider>();
    }

    private void Update()
    {
        if (_isSmooth)
        {
            _healthSlider.value = Mathf.MoveTowards(_healthSlider.value, _currentHealth, _recoveryRate * Time.deltaTime);
        }
        else
        {
            _healthSlider.value = _currentHealth;
        }
    }

    public void SetStartParameters(float minHealth, float maxHealth)
    {
        _healthSlider.minValue = minHealth;
        _healthSlider.maxValue = maxHealth;
    }

    public void SetHealth(float currenHealth)
    {
        _currentHealth = currenHealth;
    }
}
