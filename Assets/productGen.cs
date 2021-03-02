    using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System.IO;

public class productGen : MonoBehaviour
{
     public GameObject block1;

       public GameObject boxes;
    public float worldHeight ;
     public float worldWidth;
     public float gap ;
      public float rackNumber;
private float count;
  private string jsonD;
    //public GameObject box;
    //public float boxHeight;
    //public float boxWidth;
    //public float gapHeight;
    //public float gapWidth;

    void  Start () {
   jsonD = File.ReadAllText(Application.dataPath + "/data.json");
        //CreateBox();
        CreateWorld(jsonD);

    }

    void CreateWorld (string jsonD) {

         count=1f;
        //  worldHeight = rackNumber/2 ;

         for(float x = 0f; x < worldHeight; x++) {
            //    Debug.Log( "firstLoop:"+x);
            for (float z = 0f; z < worldWidth; z++) {
                //   boxes.GetComponent<boxTable>().CreateBox(jsonD);
                // Debug.Log("secodn Loop:" +z);
                // if(count<=rackNumber){
                    GameObject block = Instantiate(block1, Vector3.zero , block1.transform.rotation) as GameObject;
                    block.transform.parent = transform;
                    block.transform.localPosition = new Vector3( z + z * gap ,0, x + x * gap);
                    // Debug.Log(block);
                    count++;
                    
                  
               Debug.Log("Inside IF Condition :" + z);
    // }
                }
             }
         }
}
