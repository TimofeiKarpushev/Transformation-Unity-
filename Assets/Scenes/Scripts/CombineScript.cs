using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombineScript : MonoBehaviour
{
    [SerializeField] private Transform _endPoint;
    [SerializeField] private float _speed;
    [SerializeField] private float _speedRotation;

    void Update()
    {
        transform.Rotate(0, 0, _speedRotation * -1);

        transform.localScale = new Vector4(Mathf.PingPong(Time.time, 1) + 1, transform.localScale.x, transform.localScale.y, transform.localScale.z);

        transform.position = Vector3.MoveTowards(transform.position, _endPoint.position, _speed * Time.deltaTime);
    }
}
