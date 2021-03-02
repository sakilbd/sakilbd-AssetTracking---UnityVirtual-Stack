    using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System.IO;
 using System;
[System.Serializable]
 public class table : MonoBehaviour {



   public TMPro.TMP_Text rackNme;
     public GameObject block1;

       public GameObject boxes;
    private float worldHeight ;
     public float worldWidth;
     public float gap ;
      private int rackNumber;
private int count;
  private string jsonD;
  List<string> rName = new List<string>();
    //public GameObject box;
    //public float boxHeight;
    //public float boxWidth;
    //public float gapHeight;
    //public float gapWidth;

    void  Start () {
   jsonD = File.ReadAllText(Application.dataPath + "/json/rack.json");
        //CreateBox();


 rackNumber=0;
  for (int i = 0; i >= 0; i++)
          {
            try
                                        {
        PlayerInfo[] PInfo = JsonHelper.getJsonArray<PlayerInfo>(jsonD);                                
        string s = PInfo[i].rack_name;
        rName.Add(s);
       rackNumber = i;
       Debug.Log(rackNumber);
        // Debug.Log(s);

                                        }
 catch (System.Exception excp)
                    {

//                        Debug.Log("sexy");
                        break;
                    }
          }
// Debug.Log(rName);
 for (int q = 0; q <2;q++){

 
 }
 
        CreateWorld(jsonD,rackNumber);

    }

    void CreateWorld (string jsonD,int rackNumber) {
 

//  var fib = new List<int>{0,1,2};
// foreach( object elem in PInfo){
//  string s = PInfo[elem].rack_name;
//         Debug.Log(s);

// }

         count=1;
         worldHeight = rackNumber/2 ;
        rackNumber++;
         rackNme.text= rName[0];
         for(float x = 0f; x < worldHeight; x++) {
            //    Debug.Log( "firstLoop:"+x);
            for (float z = 0f; z < worldWidth; z++) {
                  // boxes.GetComponent<boxTable>().CreateBox(jsonD);
                // Debug.Log("secodn Loop:" +z);
                if(count<=rackNumber){
                    GameObject block = Instantiate(block1, Vector3.zero , block1.transform.rotation) as GameObject;
                    block.transform.parent = transform;
                    block.transform.localPosition = new Vector3( z + z * gap ,0, x + x * gap);


//                     float myFloat = count;
// int myInt = Convert.ToInt32(myFloat);

                       rackNme.text= rName[count];
                    // string s = PInfo[i].rack_name;
        // rackNme.text= s;
        // Debug.Log(s);

                    // Debug.Log(block);
                    count++;
                    
                  
              //  Debug.Log("Inside IF Condition :" + z);
    }
                }
             }
         }

     }





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
[System.Serializable]
public class PlayerInfo
{
    // public string id;
    // public string product_name;
    // public string order_id;
    // public string cell_position;
    // public string rf_card_number;
    // public string destination;
     public string rack_name;

}
[System.Serializable]
public class JsonHelper
{
    public static T[] getJsonArray<T>(string json)
    {
        string newJson = "{ \"array\": " + json + "}";
        Wrapper<T> wrapper = JsonUtility.FromJson<Wrapper<T>>(newJson);
        return wrapper.array;
    }

    [System.Serializable]
    private class Wrapper<T>
    {
        public T[] array;
    }
}



