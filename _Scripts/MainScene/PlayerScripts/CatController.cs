using UnityEngine;
using System.Collections;

public class CatController : MonoBehaviour {

    private TouchHandler touchHandler;
    private float speed = 2f;
    private Vector2 pos;
    private Rigidbody2D rb2d;

    // Use this for initialization
    void Start ()
    {
        touchHandler = FindObjectOfType<TouchHandler>();
        rb2d = GetComponent<Rigidbody2D>();
        //speed *= Time.deltaTime;
	}

    void Update()
    {
        // Currently clamping based on screen size for set resolution
        //Will this be affected by more adaptive screen sizes?
        pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -3.1f, 3.2f);
        pos.y = Mathf.Clamp(pos.y, -2.4f, 4.0f);
        transform.position = pos;


        if (touchHandler.leftTouch)
        {
            var newX = new Vector3(-1, 0, 0);
            rb2d.MovePosition(transform.position + newX * (speed* Time.deltaTime));
        }
        
        else if (touchHandler.rightTouch)
        {
            var newX = new Vector3(1, 0, 0);
            rb2d.MovePosition(transform.position + newX * (speed * Time.deltaTime));
        }
        else if (touchHandler.upTouch)
        {
            var newY = new Vector3(0, 1, 0);
            rb2d.MovePosition(transform.position + newY * (speed * Time.deltaTime));
        }
        else if (touchHandler.downTouch)
        {
            var newY = new Vector3(0, -1, 0);
            rb2d.MovePosition(transform.position + newY * (speed * Time.deltaTime));
        }

    }

    public void SpeedAdjust()
    {
        speed += 1.25f;
    }

}
