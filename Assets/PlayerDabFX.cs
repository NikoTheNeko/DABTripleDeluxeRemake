using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDabFX : MonoBehaviour
{
   public SpriteRenderer spriteRenderer;
   public Sprite[] spritef;
   void Start()
   {
      spriteRenderer.sprite = spritef[0];
   }
   void Update()
   {
      if(Input.GetKey(KeyCode.Space)){
         spriteRenderer.sprite = spritef[1];
      }
      else
      {
         spriteRenderer.sprite = spritef[0];
      }
   }

}