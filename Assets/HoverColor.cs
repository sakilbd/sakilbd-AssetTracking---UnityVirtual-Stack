using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HoverColor : MonoBehaviour
{

	private Color basicColor = Color.cyan;
	private Color hoverColor = Color.red;
private Renderer renderer;
	public GameObject obj;


	void Start()
	{


	int count = transform.childCount;
     for(int i = 0; i < 4; i++)
     {
obj.transform.GetChild(i).gameObject.SetActive(false
);
}
		renderer = GetComponent<Renderer>();
		renderer.material.color = basicColor;
	
	}

	void OnMouseEnter()
	{

		renderer.material.color = hoverColor;
		  for(int i = 0; i < 4; i++)
             {
        obj.transform.GetChild(i).gameObject.SetActive(true);
        }

		
	}

	void OnMouseExit()
	{
		renderer.material.color = basicColor;
		  for(int i = 0; i < 4; i++)
             {
        obj.transform.GetChild(i).gameObject.SetActive(false);
        }

		
	}

}
