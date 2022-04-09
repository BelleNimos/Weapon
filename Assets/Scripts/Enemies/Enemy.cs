using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private int _reward;

    private Player _target;

    public Player Target => _target;
    public int Reward => _reward;

    public event UnityAction<Enemy> Dying;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Arrow>(out Arrow arrow))
        {
            TakeDamage(arrow.Damage);
            Destroy(collision.gameObject);
        }
    }

    public void InitTarget(Player target)
    {
        _target = target;
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;

        if (_health <= 0)
        {
            Dying?.Invoke(this);
            Destroy(gameObject);
        }
    }
}