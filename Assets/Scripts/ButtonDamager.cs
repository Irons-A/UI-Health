using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ButtonDamager : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private float _damage = 10;

    private Button _button;

    private void Awake()
    {
        _button = GetComponent<Button>();
    }

    private void OnEnable()
    {
        _button.onClick.AddListener(Damage);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(Damage);
    }

    private void Damage()
    {
        _health.TakeDamage(_damage);
    }
}
