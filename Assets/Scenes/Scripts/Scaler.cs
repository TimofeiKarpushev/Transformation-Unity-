using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed;
    [SerializeField] private float _scaleSize;

    private Vector3 _defaultScale;
    private bool _isScalingUp = true;

    void Start()
    {
        _defaultScale = transform.localScale;
    }

    void Update()
    {
        if (_isScalingUp)
        {
            transform.localScale += new Vector3(_scaleSpeed, _scaleSpeed, _scaleSpeed) * Time.deltaTime;

            if (transform.localScale.x >= _defaultScale.x + _scaleSize)
            {
                _isScalingUp = false;
            }
        }
        else
        {
            transform.localScale -= new Vector3(_scaleSpeed, _scaleSpeed, _scaleSpeed) * Time.deltaTime;

            if (transform.localScale.x <= _defaultScale.x)
            {
                _isScalingUp = true;
            }
        }
    }
}
