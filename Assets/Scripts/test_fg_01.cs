﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using ProgressBar;

public class Constants{
	public const int SCREEN_DIVISION_FIVE = 5;
	public const int MOVE_AWAY_DISTANCE = 20;
}
public class test_fg_01 : MonoBehaviour {

	public GameObject circle;
	public int testPaperCounter;

	ProgressBarBehaviour BarBehaviour;
    //float UpdateDelay = 2f;

	// Use this for initialization
	void Start () {
		testPaperCounter = 0;

		//BarBehaviour = GetComponent<ProgressBarBehaviour>();
		//BarBehaviour.Value = 80f;

        Debug.Log("Start for test_fg_01.cs");
		BarBehaviour = GameObject.Find("ProgressBarLabelInside").GetComponent<ProgressBarBehaviour>();
		//BarBehaviour.Value = 100f;
         BarBehaviour.IncrementValue(100f);
		//BarBehaviour.Value = 100f;
		//BarBehaviour.isDone = false;

        //while (true)
        //{
        //    yield return new WaitForSeconds(UpdateDelay);
		//	Debug.Log("START after yield");
        //    BarBehaviour.Value = Random.value * 100;
        //    print("new value: " + BarBehaviour.Value);
       // }
	}
	
	// Update is called once per frame
	void Update () {

		//Debug.Log("is Done = " + BarBehaviour.isDone);
		//Debug.Log("is TriggerOnComplete = " + BarBehaviour.TriggerOnComplete);

		if(BarBehaviour.isPaused){
			//Debug.Log("is TriggerOnComplete = " + BarBehaviour.TriggerOnComplete);
			moveProblem();
			//BarBehaviour.Value = 0f;
			//BarBehaviour.SetFillerSizeAsPercentage(0);
			BarBehaviour.SetFillerSize(0f); // SKC on160718 it makes progress 0%
			BarBehaviour.SetFillerSizeAsPercentage(100f);

	    }else{
			//moveProblem();
		}

		for (var i = 0; i < Input.touchCount; ++i) {
			Touch touch = Input.GetTouch(i);
		
			if (touch.phase == TouchPhase.Began) {

				Vector3 tPosition;
				Debug.Log("touch ~~!");

				tPosition.x = 0.1f;
				tPosition.y = -0.1f;
				tPosition.z = 2f;

				if(touch.position.y < (Screen.height/2 - 60))
				{
			        if((touch.position.x > 0) && (touch.position.x < (Screen.width/Constants.SCREEN_DIVISION_FIVE))){
						tPosition.x = -5.4f;
					 	tPosition.y = -1.8f;
					 	tPosition.z = -1f;
					}else if((touch.position.x > ((Screen.width/Constants.SCREEN_DIVISION_FIVE))) && (touch.position.x < ((Screen.width/Constants.SCREEN_DIVISION_FIVE)*2))){
						tPosition.x = -2.6f;
					 	tPosition.y = -1.8f;
					 	tPosition.z = -1f;
					}else if((touch.position.x > ((Screen.width/Constants.SCREEN_DIVISION_FIVE)*2)) && (touch.position.x < ((Screen.width/Constants.SCREEN_DIVISION_FIVE)*3))){
						tPosition.x = 0.1f;
					 	tPosition.y = -1.8f;
					 	tPosition.z = -1f;
					}else if((touch.position.x > ((Screen.width/Constants.SCREEN_DIVISION_FIVE)*3)) && (touch.position.x < ((Screen.width/Constants.SCREEN_DIVISION_FIVE)*4))){
						tPosition.x = 2.8f;
					 	tPosition.y = -1.8f;
					 	tPosition.z = -1f;
					}else if((touch.position.x > ((Screen.width/Constants.SCREEN_DIVISION_FIVE)*4)) && (touch.position.x < (Screen.width))){
						tPosition.x = 5.6f;
					 	tPosition.y = -1.8f;
					 	tPosition.z = -1f;
					}
					
					Destroy(Instantiate(circle, tPosition, transform.rotation), 2.0f);
					
					moveProblem();
				}
			}
		}
	}

    void moveProblem(){
		Invoke("invokeTransform", 2);
	}

	void invokeTransform(){
		Transform transformTarget ;
		transformTarget = GameObject.Find("test_fg_" + testPaperCounter).transform;
		transformTarget.Translate(Vector3.right*Constants.MOVE_AWAY_DISTANCE);

		testPaperCounter++;
	}
}
