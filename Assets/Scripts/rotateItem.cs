using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateItem : MonoBehaviour
{
    int _rotationSpeed = 20;

    void Update()
    {

        // Rotation on y axis
        // be sure to capitalize Rotate or you'll get errors
        transform.Rotate(0, _rotationSpeed * Time.deltaTime, 0);
    }
}
