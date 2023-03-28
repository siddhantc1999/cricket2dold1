using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballcollisiontest : MonoBehaviour
{
    movewithmouse mymovewithmouse;
    public Vector3 destinedpoint;
    // Start is called before the first frame update
    void Start()
    {
        mymovewithmouse = FindObjectOfType<movewithmouse>();
    }

    // Update is called once per frame
    void Update()
    {


        Debug.DrawLine(transform.position, new Vector3(50f,50f,0f),Color.red);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //add power according to backward force

        //Vector3 worldpoint = Camera.main.ViewportToWorldPoint(new Vector3(randomviewpoint.x - 0.1f, randomviewpoint.y, 10f));

         destinedpoint = new Vector2(50f + 10f * mymovewithmouse.mainaddpower, 50f * (mymovewithmouse.mainaddpower / 4) + 50f);

        collision.collider.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(50f + 10f* mymovewithmouse.mainaddpower, 50f * (mymovewithmouse.mainaddpower / 4)+ transform.position.y));
    }
}
