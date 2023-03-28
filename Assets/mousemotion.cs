using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousemotion : MonoBehaviour
{
    [SerializeField] GameObject hand;
    float difference;
    Vector3 mouseposition;
    Vector3 savemousepos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseDrag()
    {
        //Debug.Log("here in mouse drag");

        //difference=Camera.main.
        //if ()
        //{

        //}
        mouseposition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y,Camera.main.nearClipPlane));
        if(savemousepos!=mouseposition)
        {
            //Vector3 newpos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane);
          // if (Input.mousePosition.x>savemousepos.


          //      transform.position.x)
          //{


          //  }
        }


    }
}





//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class mousemotion : MonoBehaviour
//{
//    [SerializeField] GameObject hand;
//    float difference;
//    public Vector3 mouseposition;
//    public Vector3 savemousepos;
//    public Vector3 testmousepos;
//    float zaddition;
//    public bool frotate;
//    public bool brotate;
//    public float z;
//    // Start is called before the first frame update
//    void Start()
//    {

//    }

//    // Update is called once per frame
//    void Update()
//    {

//        if (frotate)
//        {
//            brotate = false;
//            z = hand.transform.eulerAngles.z;
//            z += 60f * Time.deltaTime;

//            hand.transform.rotation = Quaternion.Euler(0, 0, z);
//        }
//        if (brotate)
//        {
//            frotate = false;
//            z = hand.transform.eulerAngles.z;
//            z -= 60f * Time.deltaTime;

//            hand.transform.rotation = Quaternion.Euler(0, 0, z);
//        }
//    }
//    public void OnMouseDrag()
//    {

//        mouseposition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));
//        testmousepos = mouseposition;
//        if (savemousepos != mouseposition)
//        {
//            Debug.Log("not equal");
//            if (Mathf.Abs(mouseposition.x) >= Mathf.Abs(savemousepos.x))
//            {
//                frotate = true;
//                brotate = false;

//                /*z = hand.transform.eulerAngles.z;
//                z += 40f * Time.deltaTime;

//                hand.transform.rotation = Quaternion.Euler(0, 0, z);*/




//            }
//            else
//            {
//                brotate = true;
//                frotate = false;
//                Debug.Log("here ");
//                /*Debug.Log("second");
              
//                z = hand.transform.eulerAngles.z;
//                z -= 40f * Time.deltaTime;

//                hand.transform.rotation = Quaternion.Euler(0, 0, z); */

//            }
//            savemousepos = mouseposition;


//        }

//    }
//    private void OnMouseUp()
//    {
//        z = 0f;
//        if (brotate == true)
//        {
//            brotate = false;
//        }
//        else
//        if (frotate == true)
//        {
//            Debug.Log("here");
//            frotate = false;
//        }
//        /* rotate = false;*/
//        /* Debug.Log("up");*/
//    }
//}