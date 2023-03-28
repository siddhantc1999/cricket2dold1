using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movewithmouse : MonoBehaviour
{
    [SerializeField] GameObject hand;
    float difference;
    public Vector3 mouseposition;
    public Vector3 savemousepos;
    public Vector3 testmousepos;
    float zaddition;
    public bool frotate;
    public bool brotate;
    public float z;
    public float zspeed;
    public float zeulerangles;
    public float addpower;
    public float mainaddpower;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //    if (frotate)
        //    {
        //        brotate = false;
        //        z = hand.transform.eulerAngles.z;
        //        z += 60f * Time.deltaTime;

        //        hand.transform.rotation = Quaternion.Euler(0, 0, z);
        //    }
        //    if (brotate)
        //    {
        //        frotate = false;
        //        z = hand.transform.eulerAngles.z;
        //        z -= 60f * Time.deltaTime;

        //        hand.transform.rotation = Quaternion.Euler(0, 0, z);
        //    }
        //}
        if (frotate)
        {
            if (z >= -90f)
            {

             
                z += 10f * zspeed * Time.deltaTime;
                zeulerangles = hand.transform.rotation.z;
                var rotation = Quaternion.Euler(0f, 0f, z);
                hand.transform.rotation = rotation;
                addpower += Time.deltaTime*200f;
            }
            else
            {
                frotate = false;
            }
        }
    }
    public void OnMouseDrag()
    {
        frotate = true;


        //mouseposition = Camera.main.ScreenToWorldPoint(new
        //Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f));
        //hand.transform.position = mouseposition;
        //z = hand.transform.eulerAngles.z;
        //z -= 60f * Time.deltaTime;

        //hand.transform.rotation = Quaternion.Euler(0, 0, z);
    }

    //testmousepos = mouseposition;
    //if (savemousepos != mouseposition)
    //{

    //    if (Mathf.Abs(mouseposition.x) >= Mathf.Abs(savemousepos.x))
    //    {
    //        frotate = true;
    //        brotate = false;

    //        /*z = hand.transform.eulerAngles.z;
    //        z += 40f * Time.deltaTime;

    //        hand.transform.rotation = Quaternion.Euler(0, 0, z);*/




    //    }
    //    else
    //    {
    //        brotate = true;
    //        frotate = false;
    //        Debug.Log("here ");
    //        /*Debug.Log("second");

    //        z = hand.transform.eulerAngles.z;
    //        z -= 40f * Time.deltaTime;

    //        hand.transform.rotation = Quaternion.Euler(0, 0, z); */

    //    }
    //    savemousepos = mouseposition;


    //}
    private void OnMouseDown()
    {
        addpower = 0f;
    }
    private void OnMouseUp()
    {
        frotate = false;
        z = 0f;
        mainaddpower = addpower;
        if (addpower > 0f)
        {
            StartCoroutine(addpowerzero());
        }
        //z = 0f;
        //if (brotate == true)
        //{
        //    brotate = false;
        //}
        //else
        //if (frotate == true)
        //{
        //    Debug.Log("here");
        //    frotate = false;
        //}


    }

  IEnumerator addpowerzero()
    {
        yield return new WaitForSeconds(1f);
        addpower = 0f;
        mainaddpower = 0;
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    Debug.Log("in collision 2d");
    //}
}
//private void OnMouseUp()
//{
//    z = 0f;
//    if (brotate == true)
//    {
//        brotate = false;
//    }
//    else
//    if (frotate == true)
//    {
//        Debug.Log("here");
//        frotate = false;
//    }

//}
//}
