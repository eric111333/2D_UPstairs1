using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    Rigidbody2D playerRigidbody2D;
    [Header("移動速度"), Range(0, 100)]
    public float speed;
    private SpriteRenderer sprPlayer;
    private Animator ani;
    private bool grounded, isjump;
    public AudioClip fly;
    private float yForcemin = 1;
    private float yForcemax = 10;
    private float yForcecrt = 1;
    private bool jumped;
    private float speedpower = 10;
    public Slider Jumpslider;

    [Header("偵測地板的射線起點")]
    public Transform groundCheck;
    [Header("地面圖層")]
    public LayerMask groundLayer;
    //private bool grounded, isjump;


    void Start()
    {
        sprPlayer = GetComponent<SpriteRenderer>();
        ani = GetComponent<Animator>();
        playerRigidbody2D = GetComponent<Rigidbody2D>();

    }
    private void Move()
    {
        //float y = Mathf.Sin(Time.time) * Random.Range(-15, 15) * Time.deltaTime;
        //transform.Translate(0, y, 0);
        if (sprPlayer.flipX == false)
            transform.Translate(speed * 1 * Time.deltaTime, 0, 0);
        if (gameObject.transform.position.x >= 4)
            sprPlayer.flipX = true;
        if (sprPlayer.flipX == true)
            transform.Translate(speed * -1 * Time.deltaTime, 0, 0);
        if (gameObject.transform.position.x <= -4)
            sprPlayer.flipX = false;


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "left")
        {
            sprPlayer.flipX = false;
            transform.Translate(speed * 1 * Time.deltaTime, 0, 0);
        }
        if (collision.tag == "right")
        {
            sprPlayer.flipX = true;
            transform.Translate(speed * -1 * Time.deltaTime, 0, 0);
        }
        //if(collision.tag == "ground")
        //{
        //    Jumpslider.value = yForcemin;
        //    yForcecrt = yForcemin;
        //}
    }

    public void OnMouseDown()
    {
        //Jumpslider.value = yForcemin;
        if (yForcecrt > 5f)
            yForcecrt -= 5f;
        /*
        if (grounded)
        {
            Jumpslider.value = yForcemin;
            yForcecrt = yForcemin;
            //isjump = false;
        }
        else
            yForcecrt--;
        //jumped = false;
        //isjump = true;
        //playerRigidbody2D.velocity = new Vector2(playerRigidbody2D.velocity.x, yForce);
        */
    }
    public void OnMouseDrag()
    {
        if (yForcecrt <= yForcemax)
            yForcecrt += speedpower * Time.deltaTime;

    }


    public void OnMouseUp()
    {
        if (grounded)
        {

            playerRigidbody2D.velocity = new Vector2(playerRigidbody2D.velocity.x, yForcecrt);
            ani.SetTrigger("Jump");
        }
       

        //jumped = true;
    }




    // Start is called before the first frame update
    private void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, 0.05f, groundLayer);
    }

    // Update is called once per frame
    void Update()
    {

        Move();
        Jumpslider.value = yForcecrt;
    }
}
