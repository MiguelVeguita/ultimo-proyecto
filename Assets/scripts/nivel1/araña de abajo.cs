using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class arañadeabajo : MonoBehaviour
{
    private SpriteRenderer _spri;
    public int vell;
    private Rigidbody2D _rig;
    public int direccc;
    public int vida;
    public bool m;
    public float nn;
    private BoxCollider2D _box;
    private AudioSource ss;
    private Animator anima;
    // Start is called before the first frame update
    private void Awake()
    {
        _spri = GetComponent<SpriteRenderer>();
        _rig = GetComponent<Rigidbody2D>();
        _box = GetComponent<BoxCollider2D>();
        anima = GetComponent<Animator>();
        _box = GetComponent<BoxCollider2D>();




    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if (this.transform.position.x <= 71)
        {
            vell = 1;
            _spri.flipX = true;
        }
        if (this.transform.position.x >= 111)
        {
            vell = -1;
            _spri.flipX = false;

        }
        if (m == true)
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
        _rig.velocity = new Vector2(direccc * vell, transform.position.y);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "balita")
        {
            vida = vida - 1;
            if (vida <= 0)
            {
                ss.Play();
                anima.SetBool("muerte de araña", false);
                _box.isTrigger = true;
                m = true;
                direccc = 0;
            }
        }
        if (collision.gameObject.tag == "Player")
        {
            ss.Play();
            anima.SetBool("muerte de araña", false);
            _box.isTrigger = true;
            m = true;
            direccc = 0;
        }
    }
    
}
