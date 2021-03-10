using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System.IO;
using System;


public class cheapMentality : MonoBehaviour
{
    
public TMPro.TMP_Text rackNme;
  public GameObject block1;

  public GameObject boxes;
  private float worldHeight;
  public float worldWidth;
  public float gap;
  private int rackNumber;
  private int count;
  private string rackJson;
  private string cellJson;
  List < string > rName = new List < string > ();
    List < string > cellList = new List < string > ();
    List < string > rackList = new List < string > ();
   void Start() {
    rackJson = File.ReadAllText(Application.dataPath + "/json/rack.json");
      cellJson = File.ReadAllText(Application.dataPath + "/json/cells.json");
    //CreateBox();

    // Debug.Log(rName);

    CreateWorld(rackJson,cellJson);

  }

  void CreateWorld(string rackJson,string cellJson) {
  boxes.GetComponent<boxTable1>().CreateBox(cellJson);
    for (int i = 0; i >= 0; i++) {
      try {
        PlayerInfo[] PInfo = JsonHelper.getJsonArray < PlayerInfo > (rackJson);
        string s = PInfo[i].rack_name;
        rName.Add(s);
        rackNumber = i;
        // Debug.Log(rackNumber);
        // Debug.Log(s);

      }
      catch(System.Exception excp) {

        //                        Debug.Log("sexy");
        break;
      }
    }
     for (int i = 0; i >=0 ;i++) {
      try {
        PlayerInfo[] PInfo = JsonHelper.getJsonArray < PlayerInfo > (cellJson);
        string cell = PInfo[i].rack_id;
        cellList.Add(cell);
        int values =cellList.Count;
       Debug.Log(values);
      //  Debug.Log(cell);
        //  Debug.Log(i);


      }
      catch(System.Exception excp) {

        //                        Debug.Log("sexy");
        break;
      }
    }
    for (int i = 0; i >= 0; i++) {
      try {
        PlayerInfo[] PInfo = JsonHelper.getJsonArray < PlayerInfo > (rackJson);
        string rack = PInfo[i].id;
        rackList.Add(rack);
      //  Debug.Log(rack);

        // Debug.Log(s);

      }
      catch(System.Exception excp) {

        //                        Debug.Log("sexy");
        break;
      }
    }
    //  var fib = new List<int>{0,1,2};
    // foreach( object elem in PInfo){
    //  string s = PInfo[elem].rack_name;
    //         Debug.Log(s);

    // }

    count = 1;
    worldHeight = rackNumber / 2;
    rackNumber++;
    rackNme.text = rName[0];

    int cellCount = cellList.Count;
    int rackCount = rackList.Count;
    for (float x = 0f; x < worldHeight; x++) {
      //  boxes.GetComponent<boxTable1>().CreateBox(cellJson);

      //    Debug.Log( "firstLoop:"+x);
      for (float z = 0f; z < worldWidth; z=z+2) {
       
        // Debug.Log("secodn Loop:" +z);
        if (count <= rackNumber) {
        //   GameObject block = Instantiate(block1, Vector3.zero, block1.transform.rotation) as GameObject;
        //   block.transform.parent = transform;
        //   block.transform.localPosition = new Vector3(z + z * gap, 0, x + x * gap);
          //                     float myFloat = count;
          // int myInt = Convert.ToInt32(myFloat);

          rackNme.text = rName[count];
          // string s = PInfo[i].rack_name;
          // rackNme.text= s;
          // Debug.Log(s);

          // Debug.Log(block);
          count++;
        
          int a =0;
            if(rackList[(int)Math.Round(x)]==cellList[a]){
              a++;
               
          
           

        }
         

          //  Debug.Log("Inside IF Condition :" + z);
        }
      }
    }
    
  }}

  






//void CreateBox()
//{
//    for (float p = 0f; p < boxHeight; p++)
//    {

//        for (float q = 0f; q < boxWidth; q++)
//        {

//            GameObject box1 = Instantiate(box, Vector3.zero, box.transform.rotation) as GameObject;
//            box1.transform.parent = transform;
//            box1.transform.localPosition = new Vector3(q + q * gapHeight, p + p * gapWidth, 0);
//        }
//    }
//}

