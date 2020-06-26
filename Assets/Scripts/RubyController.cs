using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement2();
    }

    void movement1() // wersja 1 MOJA AUTORSKA KURWAs
    {
        float horizontal = Input.GetAxis("Horizontal");
        Vector2 position = transform.position;
        position.x = position.x + 0.1f * horizontal;
        transform.position = position;
        
        float vertical = Input.GetAxis("Vertical");
        position = transform.position;
        position.y = position.y + 0.1f * vertical;
        transform.position = position;
    }

    void movement2() // wersja 2
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector2 position = transform.position;
        position.x = position.x + 3.0f * horizontal * Time.deltaTime;
        position.y = position.y + 3.0f * vertical * Time.deltaTime;
        transform.position = position;
    }
}
