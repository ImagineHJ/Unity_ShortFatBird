using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
           transform.Translate((float)1.5 * Time.deltaTime, 0, 0);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.name == "wall")
        {
            gameObject.SetActive(false);
        }
    }
}
