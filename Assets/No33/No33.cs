using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class No33 : MonoBehaviour
{
    [SerializeField]
    float speed = 10.0f;
    Vector2 targetPosition;

    // Start is called before the first frame update
    void Start()
    {
        targetPosition = new Vector3(5, transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        if (transform.position.x == targetPosition.x)
        {
            if (targetPosition.x == 5)
            {
                targetPosition = new Vector3(-5, transform.position.y);
            }
            else
            {
                targetPosition = new Vector3(5, transform.position.y);
            }
        }
    }
}
