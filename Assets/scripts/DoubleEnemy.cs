using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleEnemy : MonoBehaviour
{
    

    Rigidbody2D EnBody;
    [SerializeField]
    private float speed;
    public Vector2 moveVector;
    // Start is called before the first frame update
    void Start()
    {
        EnBody = GetComponent<Rigidbody2D>();
        speed = 15;
        moveVector += new Vector2(-1/4, 1);
        EnBody.velocity = moveVector * speed;
    }
    void Awake()
    {
        EnBody = GetComponent<Rigidbody2D>();

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
