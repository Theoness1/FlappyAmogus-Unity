using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmogusTracker : MonoBehaviour
{
    [SerializeField] private Amogus _amogus;
    [SerializeField] private float _xOffset;

    private void Update()
    {
        transform.position = new Vector3(_amogus.transform.position.x - _xOffset, transform.position.y, transform.position.z);
    }
}
