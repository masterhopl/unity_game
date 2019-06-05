using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
 	  float z;
    float x;
    float y;
    Rigidbody rb;
    Rigidbody rbClone;
    public GameObject bullet;
    public Text hpText;
    GameObject bulletClone;
    int hp;
    float moveSpeed = 0.06f;
    float turnSpeed = 1.2f;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        hp = 100;

        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
     if(Input.GetKey(KeyCode.W)){
          transform.Translate(Vector3.forward * moveSpeed);
        
        }
        if(Input.GetKey(KeyCode.S)){
          transform.Translate(-Vector3.forward * moveSpeed);
        }
        if(Input.GetKey(KeyCode.A)){
            transform.Rotate(-Vector3.up * turnSpeed);
        }
        if(Input.GetKey(KeyCode.D)){
            transform.Rotate(Vector3.up * turnSpeed);
        }
       if (Input.GetKeyDown("space"))
       {
          bulletClone = Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z+1f), Quaternion.identity);
          rbClone = bulletClone.GetComponent<Rigidbody>();
          rbClone.AddForce(transform.forward * 1000f);

       }
    }
    void OnCollisionEnter(Collision collision)
    {  
        if(collision.gameObject.CompareTag("enemy"))
        {
            
        }

    }

}
