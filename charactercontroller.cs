using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charactercontroller : MonoBehaviour
{
    public float speed = 1.00f; // 1.
    private Rigidbody2D r2d; // 3.
    private Animator animator; //4.
    private Vector3 charPosmkbl;
    private SpriteRenderer spriteRendererMkbl;
    [SerializeField] private GameObject _cameramkbl;
    private int sayi;


     void Start() //2. oyunun baslangicinda.  SAhip oldugu fiziksel haller. 
    {
        spriteRendererMkbl = GetComponent<SpriteRenderer>();
        r2d = GetComponent<Rigidbody2D>(); // 5 caching r2d
        animator = GetComponent<Animator>(); // 6. caching
        charPosmkbl = transform.position;
        sayi = 1;
  
    }

    private void FixedUpdate()
    {
        //r2d.velocity = new Vector2(x: speed, y: 0f); // x de hizi kadar hareket edebilmesi için. y de hareket yok
        sayi = 2;
    }

    private void Update() // 7.oyun surerken
    {
        

        charPosmkbl = new Vector3(x:charPosmkbl.x + (Input.GetAxis("Horizontal") * speed * Time.deltaTime), charPosmkbl.y);
        transform.position = charPosmkbl;
        
        if (Input.GetAxis("Horizontal") == 0.00f)
        {
            animator.SetFloat(name: "speed", value: 0.00f);
        }

        else
        {
            animator.SetFloat(name: "speed", value: 1.00f);
        }

        if (Input.GetAxis("Horizontal") > 0.01f)
        {
            spriteRendererMkbl.flipX = false;
        }else if(Input.GetAxis("Horizontal") < -0.01f)
        {
            spriteRendererMkbl.flipX = true ;
        }
    }

    private void LateUpdate()
    {
        //_cameramkbl.transform.position = new Vector3(charPosmkbl.x, charPosmkbl.y, charPosmkbl.z - 1.0f);
        sayi = 4;
    }
}