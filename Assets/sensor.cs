using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sensor : MonoBehaviour
{


	private Rigidbody rb;
	private GameObject obstacle;
	private bool coll;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame


    void OnCollisionEnter(Collision other){
    	if(other.gameObject.CompareTag("cylindre"))
    		Debug.Log("Touch pared");
    		coll = true;
    		//other.gameObject.SetActive(false);
    	}

    void OnCollisionStay(Collision other){
        if(other.gameObject.CompareTag("cylindre")){
            Debug.Log("Touch");
            coll = true;
            //other.gameObject.SetActive(false);
            Vector3 hit = other.contact
        }

    }

    void OnCollisionExit(Collision other){
        coll =false;
        Debug.Log("exit");

    }

    public bool getCollision(){
    	return coll;
    }




        void Update()
    {
        
    }
}




/*


coodrinadas
altura
proximidad


*/