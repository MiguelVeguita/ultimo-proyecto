using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAMRADENIV1 : MonoBehaviour
{
    public float camaraY;
    public GameObject player;
    public BoxCollider2D playeee;
    public SpriteRenderer sprit;
    private Vector3 targplayer;
    public float direci;
    public float suavisado;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        targplayer = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);

        if (sprit.flipX == true)
        {
            targplayer = new Vector3(player.transform.position.x - direci, player.transform.position.y, transform.position.z);
        }
        if (sprit.flipX == false)
        {
            targplayer = new Vector3(player.transform.position.x + direci, player.transform.position.y, transform.position.z);
        }
        transform.position = Vector3.Lerp(transform.position, targplayer, suavisado * Time.deltaTime);
       
    }
    
}
