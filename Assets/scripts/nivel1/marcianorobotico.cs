using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class marcianorobotico : herencias
{
    public SpriteRenderer _spri;
    public float vell;
    private Rigidbody2D _rig;
    
    public GameObject player;
   
    private AudioSource ss;
    public bool n;
    public float nn;
    private BoxCollider2D _box;
    public Animator anima;
    // Start is called before the first frame update
    private void Awake()
    {
         _spri = GetComponent<SpriteRenderer>();
        _rig = GetComponent<Rigidbody2D>();
        _box = GetComponent<BoxCollider2D>(); 
        ss = GetComponent<AudioSource>();
        anima = GetComponent<Animator>();


    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if (this.transform.position.x <= 120)
        {
            vell = 1;
            _spri.flipX = false;
        }
        if (this.transform.position.x >= 138)
        {
            vell = -1;
            _spri.flipX = true;

        }
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
        _rig.velocity = new Vector2(veloci * vell, transform.position.y);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            vell = 1;
            _spri.flipX = false;
        }
        if (collision.gameObject.tag == "balita")
        {
            vida = vida - 1;
           
            if (vida < 0)
            {
                ss.Play();
                anima.SetBool("f", false);
                _box.isTrigger = true;
                vell = 0;
                n = true;
            }
           
        }

    }
}
