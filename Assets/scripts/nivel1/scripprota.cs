using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class scripprota : MonoBehaviour
{
    private Rigidbody2D _comporig;
    public int velocidad;
    private float hori, verti;
    private Animator _anim;
    private SpriteRenderer _sprit;
    public GameObject disparo;
    public float salto;
    public bool detector;
    public bool jum;
    public Transform graudetector;
    public float raydistancia;
    public LayerMask condi;
    public int vidaplayer;
    private AudioSource soun;
    public gamemanager gama;


    private void Awake()
    {
        _comporig = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
        _sprit = GetComponent<SpriteRenderer>();
        soun = GetComponent<AudioSource>();
      
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        caminata();
        verti = Input.GetAxis("Vertical");
        // RaycastHit hit;
        detector = Physics2D.Raycast(graudetector.position, new Vector2(0, -1), raydistancia,condi);
        Debug.DrawRay(graudetector.position, new Vector2(0, -1) * raydistancia, Color.yellow);
        
       

    }
    private void FixedUpdate()
    {
        _comporig.velocity = new Vector2(hori * velocidad, _comporig.velocity.y );
        if (verti>0&&detector==true)
        {
            _comporig.AddForce(Vector2.up*salto ,ForceMode2D.Impulse) ;
        }
       
       
    }
    public void caminata()
    {
        hori = Input.GetAxis("Horizontal");

        if (hori < 0)
        {
            _sprit.flipX = true;
            _anim.SetBool("run", false);
            if (Input.GetKeyDown("space") == true)
            {
                Instantiate(disparo, transform.position, transform.rotation);
            }
        }
        else if (hori > 0)
        {
            _sprit.flipX = false;
            _anim.SetBool("run", false);
            if (Input.GetKeyDown("space") == true)
            {
                Instantiate(disparo, transform.position, transform.rotation);
            }
        }
        else
        {
            _anim.SetBool("run", true);

        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "perro")
        {
           
            soun.Play();
            vidaplayer = vidaplayer - 1;
            gama.upvida(vidaplayer);
            if (vidaplayer <= 0)
            {
                Destroy(this.gameObject);
            }

        }
        if (collision.gameObject.tag == "arabot")
        {

            soun.Play();

            vidaplayer = vidaplayer - 1;
            gama.upvida(vidaplayer);
            if (vidaplayer <= 0)
            {
                this.gameObject.SetActive(false);
            }

        }
        if (collision.gameObject.tag == "caracol")
        {
            soun.Play();

            vidaplayer = vidaplayer - 2;
            gama.upvida(vidaplayer);
            if (vidaplayer <= 0)
            {
                this.gameObject.SetActive(false);
            }

        }
        if (collision.gameObject.tag == "superarabot")
        {
            soun.Play();

            vidaplayer = vidaplayer - 2;
            gama.upvida(vidaplayer);
            if (vidaplayer <= 0)
            {
                this.gameObject.SetActive(false);
            }

        }
        if (collision.gameObject.tag == "misil")
        {
            soun.Play();

            vidaplayer = vidaplayer - 1;
            gama.upvida(vidaplayer);
            if (vidaplayer <= 0)
            {
                this.gameObject.SetActive(false);
            }

        }
        if (collision.gameObject.tag == "coso")
        {
            soun.Play();

            vidaplayer = vidaplayer - 3;
            gama.upvida(vidaplayer);

            if (vidaplayer <= 0)
            {
                this.gameObject.SetActive(false);
            }

        }



    }
    public int vid()
    {
       
        return vidaplayer;
    }
}
