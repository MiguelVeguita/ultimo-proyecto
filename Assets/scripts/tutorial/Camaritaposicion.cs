using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camaritaposicion : MonoBehaviour
{
    public GameObject player;
    public SpriteRenderer sprit;
    private Vector3 targplayer;
    public float direci;
    public float suavisado;

    
    // Start is called before the first frame update
    private void Awake()
    {
        //sprit = GetComponent<SpriteRenderer>();
    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        targplayer = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);
       
        if (sprit.flipX == true)
        {
            targplayer = new Vector3(player.transform.position.x-direci, 1.92f, transform.position.z);
        }
        if (sprit.flipX == false)
        {
            targplayer = new Vector3(player.transform.position.x + direci, 1.92f, transform.position.z);
        }
        transform.position = Vector3.Lerp(transform.position,targplayer,suavisado*Time.deltaTime);
    }
}
