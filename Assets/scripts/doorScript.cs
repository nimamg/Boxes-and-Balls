using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorScript : MonoBehaviour
{
    private bool flag = false;
    private bool flagflag = false;
    private float prev;
    [SerializeField]
    GameObject cam;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player" && !flagflag)
        {
            flag = true;
            flagflag = true;
            prev = 0;
            collision.gameObject.transform.position = new Vector2(collision.gameObject.transform.position.x + 1.5f, collision.gameObject.transform.position.y);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (flag && prev < 17)
        {

            Camera.main.transform.position += new Vector3(0.5f, 0, 0);
            prev += 0.5f;
            if( Camera.main.orthographicSize < 5.352307f)
	            Camera.main.orthographicSize += 0.05f;
        }
        else if (prev >= 17)
        {
            Camera.main.orthographicSize = 5.352307f;
        }
    }
}