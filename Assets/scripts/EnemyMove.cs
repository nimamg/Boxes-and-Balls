using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
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
        moveVector += new Vector2(0, 1);
        EnBody.velocity = moveVector * speed;
    }

    void Awake()
    {
        EnBody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
