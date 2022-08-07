using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreventOverlap4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        void OnCollisionEnter(Collision col)
        {
            if(col.gameObject.tag == "Ball4")
                Destroy(this.gameObject);
            if (col.gameObject.tag == "Ball2")
                Destroy(col.gameObject);
            if (col.gameObject.tag == "Ball3")
                Destroy(col.gameObject);
            if (col.gameObject.tag == "Ball")
                Destroy(col.gameObject);
            if (col.gameObject.tag == "Ball5")
                Destroy(col.gameObject);
        }
    }
}
