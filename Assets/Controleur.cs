using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// etude unity

public class Controleur : MonoBehaviour
{
    // Start is called before the first frame update
	private actuador act;

    void Start()
    {
     	   act = GetComponent<actuador>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
        

       // act.moveLeft();
        //act.moveForward();


    	if(Input.GetKey(KeyCode.RightArrow))
    		act.moveRight();
        if(Input.GetKey(KeyCode.LeftArrow))
    		act.moveLeft();
		if(Input.GetKey(KeyCode.UpArrow))
			act.moveForward();
		if(Input.GetKey(KeyCode.DownArrow))
			act.moveBackward();
    	if(Input.GetKey(KeyCode.C))
    		act.flyUpper();
    	if(Input.GetKey(KeyCode.V))
    		act.flyDown();
    }

    
}
