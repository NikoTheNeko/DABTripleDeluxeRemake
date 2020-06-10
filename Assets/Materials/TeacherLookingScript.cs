using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeacherLookingScript : MonoBehaviour
{

    public GameObject[] postProcessingFX;
    //Has 3 states, 0 = not looking, 1 = About to look, 2 = looking
    private int teacherState = 0;
    //For moving the FX
    private bool moving = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            //If they're looking don't look
            if (teacherState >= 2){
                teacherState = 0;
            }
            else if (teacherState < 2){
                teacherState++;
            }
        }
        Debug.Log(teacherState);

        if(teacherState == 0)
        {
            if(transform.position.y > -1)
                transform.Translate(new Vector3(0, -4, 0) * Time.deltaTime);
            if(postProcessingFX[0].transform.position.z < 3)
                postProcessingFX[0].transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime);
        }

        if (teacherState == 1)
        {
            if (transform.position.y < 0)
                transform.Translate(new Vector3(0, 4, 0) * Time.deltaTime);
            if (postProcessingFX[0].transform.position.z > -0.65)
                postProcessingFX[0].transform.Translate(new Vector3(0, 0, -2) * Time.deltaTime);
        }

        if (teacherState == 2)
        {
            if (transform.position.y < 2)
                transform.Translate(new Vector3(0, 4, 0) * Time.deltaTime);
            if (postProcessingFX[0].transform.position.z > -2)
                postProcessingFX[0].transform.Translate(new Vector3(0, 0, -2) * Time.deltaTime);
        }

        Debug.Log(teacherState);

    }
}
