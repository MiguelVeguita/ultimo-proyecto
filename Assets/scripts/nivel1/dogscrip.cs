using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dogscrip : herencias
{
    private Rigidbody2D _rigg;
    private Animator anima;
    private AudioSource ss;
    public bool n;
    public float nn;
    private BoxCollider2D _box;

    void Awake()
    {
        
       _rigg = GetComponent<Rigidbody2D>();
        anima = GetComponent<Animator>();
        ss = GetComponent<AudioSource>();
        _box = GetComponent<BoxCollider2D>();
        
    }
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (n == true)
        {
            nn = nn + Time.deltaTime;
            if (nn >= 3)
            {
                Destroy(this.gameObject);

            }
        }
    }
    private void FixedUpdate()
    {
        _rigg.velocity = new Vector2(veloci, _rigg.velocity. y);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "balita")
        {
            vida = vida - 1;
            if (vida <= 0)
            {
                ss.Play();
                anima.SetBool("muerte", false);
                _box.isTrigger = true;
                n = true;
                veloci = 0;
            }
        }
        if (collision.gameObject.tag == "Player")
        {
            ss.Play();
            anima.SetBool("muerte", false);
            _box.isTrigger = true;
            veloci = 0;
            n = true;
        }
    }
  
}
