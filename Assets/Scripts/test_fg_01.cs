using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class Constants{
	public const int SCREEN_DIVISION_FIVE = 5;
}
public class test_fg_01 : MonoBehaviour {

	public Vector2 touchPos;
	public Transform touchTrans;
	public GameObject circle;
	public Text debugText;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

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
					}

					Destroy(Instantiate(circle, tPosition, transform.rotation), 2.0f);
					
					moveProblem();
				}
		}
	}

    void moveProblem(){
		Invoke("invokeTransform", 2);
	}

	void invokeTransform(){
		Transform transformTarget ;
		transformTarget = GameObject.Find("test_fg_01").transform;
		transformTarget.Translate(Vector3.right*20);
	}
}
