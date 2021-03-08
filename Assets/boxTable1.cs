using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System.IO;



public class boxTable1 : MonoBehaviour
{


    private string info;
    // public GameObject dp;

  private string cellJson;


    private int score;
    public GameObject box;
    public float boxHeight;
    public float boxWidth;
    public float gapHeight;
    public float gapWidth;

    void Start()
    {

 cellJson = File.ReadAllText(Application.dataPath + "/json/cells.json");
// box.transform.localScale += new Vector3(-.2f,0, 0);
// box.transform.localPosition += new Vector3(2,0, 0);
//dp.transform.localScale += new Vector3(0,0, .1f);


        CreateBox(cellJson);
    }





    public void CreateBox(string cellJson)
    {



 PlayerInfo[] PInfo = JsonHelper.getJsonArray<PlayerInfo>(cellJson);

        for (float p = 1; p <= boxHeight; p++)
        {


            for (float q = 1; q <= boxWidth; q++)
            {



                 for (int i = 0; i >= 0; i++)
                {
                   

                    try{
string pos = PInfo[i].position;
string rfid = PInfo[i].rfid;
    string s = PInfo[i].name;
     var results = pos.Split('_');
                        string posA = results[0];
                        string posB = results[1];
    // Debug.Log(s);
    //  Debug.Log(pos);
    //     Debug.Log(rfid);

             
if (p == float.Parse(posA) && q == float.Parse(posB))
                        {
                          

                GameObject cellBox;
                // Text t = dp.GetComponent<Text>();

                // info = "" + p + q;
                // t.text = info;
                Vector3 Vec = new Vector3(1, 0, 0);

                cellBox = Instantiate(box, Vec, box.transform.rotation) as GameObject;
                cellBox.transform.parent = transform;
                cellBox.transform.localPosition = new Vector3((q + q * gapHeight), -(p + p * gapWidth), 0);
                // Debug.Log("p:"+p+"Q:"+q);
             


       }
                    }
                
                    catch (System.Exception excp)
                    {

//                        Debug.Log("sexy");
                        break;
                    }
   
                }



            }
        }
    }

}

