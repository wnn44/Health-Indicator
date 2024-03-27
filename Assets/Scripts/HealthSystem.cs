using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    [SerializeField] private int _maxHealth;
    [SerializeField] private int _curentHealth;

    public int MaxHealth { get { return _maxHealth; } }
    public int CurentHealth { get { return _curentHealth; } }

    public void Damage(int damageValue)
    {
        _curentHealth -= damageValue;

        if (_curentHealth < 0)
        {
            _curentHealth = 0;
        }
    }

    public void Heal(int healValue)
    {
        _curentHealth += healValue;

        if (_curentHealth > _maxHealth)
        {
            _curentHealth = _maxHealth;
        }
    }
}
