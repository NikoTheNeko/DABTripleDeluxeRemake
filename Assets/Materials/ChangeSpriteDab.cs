using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSpriteDab : MonoBehaviour
{
   public SpriteRenderer spriteRenderer;
   public Sprite[] spritef;


    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer.sprite = spritef[0];
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space)){
           spriteRenderer.sprite = spritef[1];
        }
        else{
           spriteRenderer.sprite = spritef[0];
        }
    }
}
