using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject player;
    private Vector3 offset ;


    void Start()
    {
    	player =  GameObject.FindWithTag("Player");

        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;       
    }
}
