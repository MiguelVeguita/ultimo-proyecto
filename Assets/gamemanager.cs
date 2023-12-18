using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    public Text vidsa;
    public GameObject prota;
    public int vida;


    // Start is called before the first frame update
    void Start()
    {
        upvida(8);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void upvida(int vida)
    {
        
        
        vidsa.text = "x"+vida;
        if (vida<=0)
        {
            derrota();
        }
    }
    public void derrota()
    {

        SceneManager.LoadScene("perder");
    }
}
