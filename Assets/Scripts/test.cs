using UnityEngine;
using System.Collections;
using UnityEngine.Analytics;
using System.Collections.Generic;

public class test : MonoBehaviour {
	void Start () {
		Analytics.CustomEvent("test", new Dictionary<string, object> {
			{"succes", true}
		});

		Analytics.SetUserId ("xam4lor");
		Analytics.SetUserGender (Gender.Male);
		Analytics.SetUserBirthYear (2001);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
