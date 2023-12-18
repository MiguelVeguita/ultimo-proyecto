using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class misi : MonoBehaviour
{
    public int ve;
    private BoxCollider2D _box;
    private AudioSource ss;
    private Animator anima;
    public bool m;
    public float nn;
    private void Awake()
    {
        _box = GetComponent<BoxCollider2D>();
        ss = GetComponent<AudioSource>();
        anima = GetComponent<Animator>();
      

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (m == true)
        {
            nn = nn + Time.deltaTime;
            if (nn >= 3)
            {
                Destroy(this.gameObject);

            }
        }
        transform.position = new Vector3(transform.position.x,transform.position.y+ve*Time.deltaTime,transform.position.z);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="piso")
        {
            anima.SetBool("explotion", false);
            ss.Play();
            _box.isTrigger=true;
            m = true;

        }
        if (collision.gameObject.tag == "Player")
        {
            anima.SetBool("explotion", false);
            ss.Play();
            _box.isTrigger = true;
            m = true;

        }
    }
}
