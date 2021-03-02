using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System.IO;



public class boxTable1 : MonoBehaviour
{


    private string info;
    // public GameObject dp;




    private int score;
    public GameObject box;
    public float boxHeight;
    public float boxWidth;
    public float gapHeight;
    public float gapWidth;

    void Start()
    {


// box.transform.localScale += new Vector3(-.2f,0, 0);
// box.transform.localPosition += new Vector3(2,0, 0);
//dp.transform.localScale += new Vector3(0,0, .1f);


        // CreateBox();
    }





    public void CreateBox(string jsonD)
    {





        for (float p = 1; p <= boxHeight; p++)
        {


            for (float q = 1; q <= boxWidth; q++)
            {


                GameObject laura;
                // Text t = dp.GetComponent<Text>();

                // info = "" + p + q;
                // t.text = info;
                Vector3 Vec = new Vector3(1, 0, 0);

                laura = Instantiate(box, Vec, box.transform.rotation) as GameObject;
                laura.transform.parent = transform;
                laura.transform.localPosition = new Vector3((q + q * gapHeight), -(p + p * gapWidth), 0);
                // Debug.Log("p:"+p+"Q:"+q);
             





            }
        }
    }

}

