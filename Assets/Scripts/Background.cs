using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float speed = 6f;
    public float loopWidth = 20f;
    private float StartX;

    // Start is called before the first frame update
    void Start()
    {
        StartX = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x <= StartX - loopWidth)
        {
            transform.position = new Vector3(
                StartX,
                transform.position.y,
                transform.position.z
            );
        }
    }
}
