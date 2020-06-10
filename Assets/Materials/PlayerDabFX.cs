using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.XR.WSA.Input;

public class PlayerDabFX : MonoBehaviour
{
    public UnityEngine.Vector3 initiateVector;
    public UnityEngine.Vector3 deactivateVector;
    public int start;
    public int end;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //Moves the Post Processing Forward
        if(Input.GetKey(KeyCode.Space) && transform.position.z < end)
        {
            Debug.Log("Moving towards Camera");
            transform.Translate(initiateVector  * Time.deltaTime);
        }

        if(!Input.GetKey(KeyCode.Space) && transform.position.z > start)
        {
            Debug.Log("Moving away from camera");
            transform.Translate(deactivateVector * Time.deltaTime);
        }

        //Debug.Log(transform.position.z);

    }
}
