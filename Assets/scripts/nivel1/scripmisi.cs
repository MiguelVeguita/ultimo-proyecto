using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scripmisi : MonoBehaviour
{
    public float xnega, xposi;
    public GameObject _misil;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("crr", 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void crr()
    {
        Invoke("crr", 1.5f);
        Vector2 posi = new Vector2(Random.Range( xnega, xposi),13);
        Instantiate(_misil,posi,transform.rotation);
    }
}
