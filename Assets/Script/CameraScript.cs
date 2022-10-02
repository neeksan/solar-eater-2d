using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    private GameObject player;

    void Start()
    {
        player = GameObject.Find("Player");
    }
    void Update()
    {
        if (player.transform.localScale.x > 2)
        {
            GetComponent<Camera>().orthographicSize = 10.0f;
        }
        else
        {
            GetComponent<Camera>().orthographicSize = 5.0f;
        }
    }
}
 