using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatataCaliente : MonoBehaviour
{
    private int counter;

    // Start is called before the first frame update
    void Start()
    {
        counter = Random.Range(5, 11);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        counter -= 1;
        if (counter <= 0)
        {
            Destroy(gameObject);
        }

        transform.localScale += 2 * Vector3.one;
    }

}
