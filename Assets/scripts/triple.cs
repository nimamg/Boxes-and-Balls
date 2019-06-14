using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triple : MonoBehaviour
{

    Rigidbody2D EnBody;
    [SerializeField]
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        EnBody = GetComponent<Rigidbody2D>();
        speed = 10;
        EnBody.velocity = new Vector2(-1 * speed / 4, -1 * speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
