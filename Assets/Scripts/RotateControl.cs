using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateControl : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(1f, 0f, 1f));
    }
}
