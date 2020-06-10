using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSysBe : MonoBehaviour
{

   public ParticleSystem[] partsys;
      private float incr;
      private float emisRate;

    // Start is called before the first frame update
    void Start()
    {
       var mainps = partsys[0].main;
       var mainps2 = partsys[1].main;
       //initialize color
       mainps.startColor = new Color(1f,1f,1f,1f);
       mainps2.startColor = new Color(1f,1f,1f,1f);
       //initialize counters
       incr = 1.5f;
       emisRate = 0;

       Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
       var mainps = partsys[0].main;
       var mainps2 = partsys[1].main;
       var emissps = partsys[0].emission;
       var emissps2 = partsys[1].emission;
       var emissps3 = partsys[2].emission;
       var emissps4 = partsys[3].emission;


       //on key down: GetKeyDown
       //on key release: GetKeyUp
       //on key pressed and held: GetKey

        if(Input.GetKeyDown(KeyCode.Space)){
           partsys[0].Play();
           partsys[1].Play();
           partsys[2].Play();
           partsys[3].Play();
        }

        if(Input.GetKey(KeyCode.Space)){
           //-crement counters
            if(incr > 0f){
               incr-=0.001f;
            }
            if(emisRate < 1000){
               emisRate += 0.7f;
            }

            //update emission rate
            emissps.rateOverTime = emisRate;
            emissps2.rateOverTime = emisRate;
            emissps3.rateOverTime = emisRate;
            emissps4.rateOverTime = emisRate;

            //update color
            //mainps.startColor = new Color(1f,incr,incr,1f);
            //mainps2.startColor = new Color(1f,incr,incr,1f);
            
         }

        if(Input.GetKeyUp(KeyCode.Space)){
            partsys[0].Stop();
            partsys[1].Stop();
            partsys[2].Stop();
            partsys[3].Stop();

            //reset -crements
           incr = 1.5f;
           emisRate = 0;
           Time.timeScale = 1f;
        }


    }

}
