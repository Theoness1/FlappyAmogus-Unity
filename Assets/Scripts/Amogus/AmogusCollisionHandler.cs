using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Amogus))]
public class AmogusCollisionHandler : MonoBehaviour
{
    private Amogus _amogus;

    private void Start()
    {
        _amogus = GetComponent<Amogus>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out ScoreZone scoreZone))
        {
            _amogus.IncreaseScore();
        }
        else
            _amogus.Die();
    }
}
