using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//etude unity

public class actuador : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    private float intensity = 0.1f;


    void Start()
    {
    	rb =  GameObject.FindWithTag("Player").GetComponent<Rigidbody>();
    //	rb = (RigidbodyGameObject.FindGameObjectsWithTag("Player") as Rigidbody;
    }

    // Update is called once per frame
    public void moveRight()
    {   
    	rb.transform.position = rb.transform.position +intensity*Vector3.right;
    	//rb.AddForce(Vector3.right*intensity);
    }

    public void moveLeft()
    {   
    	rb.transform.position = rb.transform.position + intensity*Vector3.left;

    	//rb.AddForce(Vector3.left*intensity);
    }
    public void moveForward()
    {   
    	rb.transform.position = rb.transform.position +intensity*Vector3.forward;

    } 
    public void moveBackward()
    {   
    	rb.transform.position = rb.transform.position +intensity*Vector3.back;
    }

    public void flyUpper()
    {   
    	rb.transform.position = rb.transform.position +intensity*Vector3.up;
    }

    public void flyDown()
    {   
    	rb.transform.position = rb.transform.position +intensity*Vector3.down;
    }




}
