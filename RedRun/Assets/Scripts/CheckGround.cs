using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{
    // Start is called before the first frame update
    private Player_Controller player;
    void Start()
    {
        player =GetComponentInParent<Player_Controller>();
    }

   void OnCollisionStay2D(Collision2D col) {
       if (col.gameObject.tag == "Ground")
       {
           player.grounded = true;
       }
       player.grounded = true;
   }

   void  OnCollisionExit2D(Collision2D col) {
       if (col.gameObject.tag == "Ground")
       {
           player.grounded = false;
       }
       player.grounded = false;
   }

}
