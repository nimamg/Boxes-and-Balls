using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{

    [SerializeField]
    private GameObject enemy;
    [SerializeField]
    private GameObject douben;

    Rigidbody2D bulletBody;
    void Awake()
    {
        bulletBody = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "double")
        {
            GameObject en1 = Instantiate(enemy);
            en1.transform.position = new Vector2(transform.position.x, transform.position.y + 0.5f);
            en1.GetComponent<EnemyMove>().moveVector = new Vector2(10,10).normalized;
            GameObject en2 = Instantiate(enemy);
            en2.transform.position = new Vector2(transform.position.x, transform.position.y - 0.5f);
            en2.GetComponent<EnemyMove>().moveVector = new Vector2(10, -10).normalized;
            Destroy(collision.gameObject);
            GameObject en3 = Instantiate(enemy);
            en3.transform.position = new Vector2(transform.position.x, transform.position.y + 0.5f);
            en3.GetComponent<EnemyMove>().moveVector = new Vector2(10, 10).normalized;
            GameObject en4 = Instantiate(enemy);
            en4.transform.position = new Vector2(transform.position.x, transform.position.y - 0.5f);
            en4.GetComponent<EnemyMove>().moveVector = new Vector2(10, -10).normalized;
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "triple")
        {
            GameObject en1 = Instantiate(douben);
            en1.transform.position = new Vector2(transform.position.x, transform.position.y + 0.5f);
            en1.GetComponent<DoubleEnemy>().moveVector = new Vector2(10, 10).normalized;
            GameObject en2 = Instantiate(douben);
            en2.transform.position = new Vector2(transform.position.x, transform.position.y - 0.5f);
            en2.GetComponent<DoubleEnemy>().moveVector = new Vector2(10, -10).normalized;
            GameObject en3 = Instantiate(douben);
            en3.transform.position = new Vector2(transform.position.x, transform.position.y - 0.5f);
            en3.GetComponent<DoubleEnemy>().moveVector = new Vector2(10, -10).normalized;
            GameObject en4 = Instantiate(douben);
            en4.transform.position = new Vector2(transform.position.x, transform.position.y - 0.5f);
            en4.GetComponent<DoubleEnemy>().moveVector = new Vector2(10, -10).normalized;
            Destroy(collision.gameObject);
        }
        Destroy(gameObject);
    }
    public void shoot()
    {
        bulletBody.velocity = new Vector2(25, 0);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
