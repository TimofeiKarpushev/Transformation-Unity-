using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    void Update()
    {
        transform.localScale = new Vector4(Mathf.PingPong(Time.time,1) + 1, transform.localScale.x, transform.localScale.y, transform.localScale.z);
    }
}
