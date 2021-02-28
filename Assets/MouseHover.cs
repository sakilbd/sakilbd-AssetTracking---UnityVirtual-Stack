using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseHover : MonoBehaviour
{


private Color basicColor = Color.gray;
 private Color hoverColor = Color.red;
 public Renderer renderer;

// public Text text;
public Text PN;
public Text PId;
public Text SAd;

public GameObject tilePrefab;
    public int x,z;

    public bool randomColor;
    public Color[] colorChoices;

    public void Start () {
//   GameObject plane  = GameObject.CreatePrimitive(PrimitiveType.Plane);
//           GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
//           cube.transform.position = new Vector3(0, 0.5f, 0);
//           GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
//           sphere.transform.position = new Vector3(0, 2.5f, 0);
//           GameObject capsule = GameObject.CreatePrimitive(PrimitiveType.Capsule);
//           capsule.transform.position = new Vector3(2, 1, 0);
//           GameObject cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
//           cylinder.transform.position = new Vector3(-2, 1, 0);
   PN.text="";
   PId.text="";
   SAd.text="";


        for (int a = 0; a < x; a++) {
            for (int b = 1; b < z; b++) {
                GameObject cube1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
                if (randomColor) {
                    cube1.GetComponent<Renderer>().material.color = colorChoices[Random.Range(0, (colorChoices.Length)) ];
                }
                cube1.transform.position = new Vector3(a, b, b);
            }
        }
        }

   void OnMouseOver()
       {

                    PN.text="Computer";
                    PId.text="152";
                    SAd.text="MirPur";
          renderer.material.color = hoverColor;

           //If your mouse hovers over the GameObject with the script attached, output this message
           Debug.Log("Mouse is over GameObject.");
       }

       void OnMouseExit()
       {
PN.text="";
PId.text="";
SAd.text="";
       renderer.material.color = basicColor;
           //The mouse is no longer hovering over the GameObject so output this message each frame
           Debug.Log("Mouse is no longer on GameObject.");
       }
}
