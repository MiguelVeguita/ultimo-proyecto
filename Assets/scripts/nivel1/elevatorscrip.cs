using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevatorscrip : MonoBehaviour
{
    public GameObject pla;
    public float velocity;
    public GameObject respw;
    private AudioSource aa;
    private void Awake()
    {
        aa = GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + velocity*Time.deltaTime, transform.position.z);

        if (transform.position.y>=-3)
        {
            velocity = 0f;
            aa.Pause();
            respw.SetActive(false);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (transform.position.y<= -3)
        {
            if (collision.gameObject.tag == "Player")
            {
                aa.Play();
                velocity = 0.8f;
                respw.SetActive(true);
            }
        }
        
    }
}
