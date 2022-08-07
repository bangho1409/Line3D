using UnityEngine;
using System.Collections;

public class TargetMove : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

       


    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hitInfo = new RaycastHit();
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo) && hitInfo.transform.tag == "Ball")
            {

                print("It's working");
            }
        }
    }

}