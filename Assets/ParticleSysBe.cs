using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSysBe : MonoBehaviour
{

   public ParticleSystem[] partsys;
      public float incr;

      Vector3 red = new Vector3(255,0,0);
    // Start is called before the first frame update
    void Start()
    {
       var mainps = partsys[0].main;
       var mainps2 = partsys[1].main;
       //initialize color
       mainps.startColor = new Color(1f,1f,1f,1f);
       mainps2.startColor = new Color(1f,1f,1f,1f);
       incr = 1.5f;
    }

    // Update is called once per frame
    void Update()
    {
       var mainps = partsys[0].main;
       var mainps2 = partsys[1].main;


       //on key down: GetKeyDown
       //on key release: GetKeyUp
       //on key pressed and held: GetKey

        if(Input.GetKeyDown(KeyCode.Space)){
           partsys[0].Play();
           partsys[1].Play();
        }

        //while space key pressed
        if(Input.GetKey(KeyCode.Space)){
           //decrement
            if(incr > 0f){
               incr-=0.001f;
            }
            //set color
            mainps.startColor = new Color(1f,incr,incr,1f);
            mainps2.startColor = new Color(1f,incr,incr,1f);
            
         }

        if(Input.GetKeyUp(KeyCode.Space)){
           partsys[0].Stop();
           partsys[1].Stop();
            //reset color
           incr = 1.5f;
        }
    }
}
