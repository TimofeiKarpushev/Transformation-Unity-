using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _speed;

    private float _xAngel = 0;
    private float _yAngel = 0;
    private float _zAngel = -1;

    void Update()
    {
        transform.Rotate(_xAngel, _yAngel, _speed * _zAngel);
    }
}
