using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float Speed;
    Vector3 Target;

    void Update()
    {
        Target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Target.z = transform.position.z;

        transform.position = Vector3.MoveTowards(transform.position, Target, Speed * Time.deltaTime);
    }
}
