using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NiceJson;


public class testJson : MonoBehaviour {







	void Start () 
	{


		string url = "http://192.168.1.2:8080/api/getrestaurantcategories/1";
		WWW www = new WWW(url);
		StartCoroutine(WaitForRequest(www));
	}
	IEnumerator WaitForRequest(WWW www)
	{
		yield return www;

		// check for errors
		if (www.error == null){
			Debug.Log("WWW Ok!: " + www.data);
		} else {
			Debug.Log("WWW Error: "+ www.error);
		}

		JsonArray arrayExample = (JsonArray) JsonNode.ParseJsonString(www.data);
		Debug.Log (arrayExample [0] ["name"]+"--------"+ arrayExample.Count);

		//meal = JsonUtility.FromJson<Meal>(www.data);
		//meal = (Meal)JsonUtility.FromJson(www.data, typeof(Meal));
		//Debug.Log("---------------"+meal.id_restaurant);
	}

	// Update is called once per frame
	void Update () {

	}
}
