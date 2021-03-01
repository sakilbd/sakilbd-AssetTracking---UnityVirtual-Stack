 using UnityEngine;
 using System.Collections;

 public class table : MonoBehaviour {




     public GameObject block1;

       public GameObject boxes;
    public float worldHeight ;
     public float worldWidth;
     public float gap ;
      public float rackNumber;
private float count;

    //public GameObject box;
    //public float boxHeight;
    //public float boxWidth;
    //public float gapHeight;
    //public float gapWidth;

    void  Start () {

        //CreateBox();
        CreateWorld();

    }

    void CreateWorld () {

         count=1f;
         worldHeight = rackNumber/2;

         for(float x = 0f; x < worldHeight; x++) {
            for (float z = 0f; z < worldWidth; z++) {
                
                if(count<=rackNumber){
                    GameObject block = Instantiate(block1, Vector3.zero , block1.transform.rotation) as GameObject;
                    block.transform.parent = transform;
                    block.transform.localPosition = new Vector3( z + z * gap ,0, x + x * gap);
                    Debug.Log(block);
                    count++;
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




}