    using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System.IO;


[System.Serializable]
public class boxTable : MonoBehaviour
{


    private string jsonD;
    List<float> list1 = new List<float>();
    List<GameObject> list2 = new List<GameObject>();
    private string info;
    public GameObject id;
    public GameObject name;
    public GameObject destination;
    public GameObject rf;
        public GameObject idS;
        public GameObject nameS;
        public GameObject destinationS;
        public GameObject rfS;




    private int score;
    public GameObject box;
     public GameObject box1;
    public float boxHeight;
    public float boxWidth;
    public float gapHeight;
    public float gapWidth;

    void Start()
    {
 //Application.ExternalEval("OnAppReady()");

        jsonD = File.ReadAllText(Application.dataPath + "/data.json");

        //PlayerInfo LoadInfo = JsonUtility.FromJson<PlayerInfo>(jsonD);
       // Debug.Log("" + LoadInfo.product_name);

        //CreateBox(list1);

        PlayerInfo[] PlayerInfo = JsonHelper.getJsonArray<PlayerInfo>(jsonD);
        //Debug.Log(PlayerInfo[1].product_name);


  CreateBox(jsonD);
    }





   public void CreateBox(string jsonD)
    {

        PlayerInfo[] PInfo = JsonHelper.getJsonArray<PlayerInfo>(jsonD);




        for (float p = 0; p <= boxHeight; p++)
        {


            for (float q = 0; q <= boxWidth; q++)
            { int count = 1;
                for (int i = 0; i >= 0; i++)
                {
                    float height = gapHeight-.3f;

                    try
                    {
                        //                        Debug.Log(PInfo[i].id);
                        string s = PInfo[i].cell_position;
                        string ax = PInfo[i].status;
                        string bx = PInfo[i].product_name;
                        string c = PInfo[i].rf_card_number;
                         string qx = PInfo[i].destination;
                        var results = s.Split('_');
                        string a = results[0];
                        string b = results[1];

                        //                        Debug.Log("cell" + i + a);
                        //                        Debug.Log("cell" + i + b);

                        if (p == float.Parse(a) && q == float.Parse(b))
                        {
                            //    case float n when (n <= 2f):
                            //int c = (int)q;

                            //list1.Add(q);

                            //Debug.Log(list1[c]);



                            Text d = id.GetComponent<Text>();
                            Text e = name.GetComponent<Text>();
                            Text f = destination.GetComponent<Text>();
                            Text g = rf.GetComponent<Text>();
                            Text h = idS.GetComponent<Text>();
                            Text z = nameS.GetComponent<Text>();
                            Text j = destinationS.GetComponent<Text>();
                            Text k = rfS.GetComponent<Text>();



                            if (int.Parse(ax) == 3 || int.Parse(ax) == 1) {
                              
                                

                                    for (int pk = 0; pk >= 0; pk++)
                                        try
                                        {
                                            string cellNo = PInfo[pk].cell_position;
                                            string rfNo = PInfo[pk].rf_card_number;
                                            if (cellNo == s && rfNo!=c)
                                            {

                                                

                                                    info = "Product Name :" + bx;
                                                    h.text = info;
                                                    z.text = "RFID :" + c;
                                                    j.text = "Destination :" + qx;
                                                    k.text = "Cell Number :" + s;
                                                    Vector3 Vec = new Vector3(1, 0, 0);

                                                    GameObject laura;
                                                    laura = Instantiate(box1, Vec, box.transform.rotation) as GameObject;
                                                    laura.transform.parent = transform;
                                                    laura.transform.localPosition = new Vector3((q + q * 2.3f), -(p + p * gapWidth), 0);
                                                Debug.Log("boxAA");
                                            break;
                                                

                                            }
                                            else if (cellNo == s && rfNo == c)
                                        {
                                                info = "Product Name:" + bx;
                                                h.text = info;
                                                z.text = "RFID :" + c;
                                                j.text = "Destination :" + qx;
                                                k.text = "Cell Number :" + s;
                                                Vector3 Vec = new Vector3(1, 0, 0);

                                                GameObject laura;
                                                laura = Instantiate(box1, Vec, box.transform.rotation) as GameObject;
                                                laura.transform.parent = transform;
                                                laura.transform.localPosition = new Vector3((q + q * gapHeight - .3f), -(p + p * gapWidth), 0);
                                                Debug.Log("boxBB");
                                            break;
                                           
                                                

                                            }

                                        }
                                        catch (System.Exception ex)
                                        {
                                            break;
                                        }
                                


                               


                                                            }
                                                    else{

                            //info = PInfo[i].product_name;
                            info = "Cell Number:" + s;
                            d.text = info;
                            e.text = "Destination :"+qx;
                            f.text = "Product Name :"+bx;
                            g.text ="RFID :"+c;
                            Vector3 Vec = new Vector3(1, 0, 0);
                            //thisText.GetComponent<UnityEngine.UI.Text>().text = "Sakil";
                              GameObject laura;
                            laura = Instantiate(box, Vec, box.transform.rotation) as GameObject;
                            laura.transform.parent = transform;
                            laura.transform.localPosition = new Vector3((q + q * gapHeight), -(p + p * gapWidth), 0);
                            //break;
                            //}
                            }
                        }

                    }
                    catch (System.Exception excp)
                    {

//                        Debug.Log("sexy");
                        break;
                    }

                }

                //switch(q){

            }
        }
    }


}
[System.Serializable]
public class PlayerInfo
{
    public string id;
    public string product_name;
    public string order_id;
    public string cell_position;
    public string rf_card_number;
    public string destination;
     public string status;

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

//[System.Serializable]
//public struct PlayerInfo
//{
//    [System.Serializable]
//    public struct ArrayEntry
//    {
//        public string id;
//        public string product_name;
//        public string order_id;
//    }

//    public ArrayEntry[] fuck;
//}
