using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
        // Start is called before the first frame update
        public float Speed = 2f;
        private Rigidbody2D rb2D;
        public bool grounded;
        public float MaxSpeed = 5f;
        private Animator anim;
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("Speed", Mathf.Abs(rb2D.velocity.x));
        anim.SetBool("Grounded",grounded);
    }
    void FixedUpdate() {
     float h = Input.GetAxis("Horizontal");

    rb2D.AddForce(Vector2.right * Speed * h);

        float limitedSpeed = Mathf.Clamp(rb2D.velocity.x, -MaxSpeed,MaxSpeed );
        rb2D.velocity = new Vector2(limitedSpeed, rb2D.velocity.y);
        Debug.Log(rb2D.velocity.x);

            //De esta manera puedo cambiar la localizacion el la que el player se encuentra caminando   
        if(h>0.1f){
            transform.localScale = new Vector3(1f,1f,1f);
        }
        if (h<-0.1f)
        {
            transform.localScale = new Vector3(-1f,1f,1f);
        }
    }
    
}
