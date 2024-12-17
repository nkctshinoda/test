using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class No04 : MonoBehaviour
{
    // ‰ñ“]‘¬“x (“x/•b)
    public float rotationSpeed = 100f;

    void Update()
    {
        // Z²‚ğ’†S‚É‰ñ“]‚³‚¹‚é
        transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
    }
}