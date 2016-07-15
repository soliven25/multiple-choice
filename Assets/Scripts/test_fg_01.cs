using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class test_fg_01 : MonoBehaviour {

	public Vector2 touchPos;
	public Transform touchTrans;
	public GameObject circle;
	public Text debugText;

	// Use this for initialization
	void Start () {
		//debugText = GameObject.FindGameObjectWithTag("DebugText").GetComponent<Text>();

		//debugText.text += Screen.width + transform.position.x + " " + transform.position.y +" "+ transform.position.z;
	}
	
	
	// Update is called once per frame
	void Update () {

		// Debug.Log("TEST");
		// Instantiate(circle, transform.position, transform.rotation);
		// debugText.text += "test test test";
		//Instantiate(circle, Input.GetTouch(0).position, transform.rotation);

		for (var i = 0; i < Input.touchCount; ++i) {
			Touch touch = Input.GetTouch(i);
		
			if (touch.phase == TouchPhase.Began) {
				// Need to put .x
				//if (touch.position.x > (Screen.width/2)) {
					//do something

					Vector3 tPosition;
					//tPosition = Camera.main.ScreenToWorldPoint( new Vector3( touch.position.x, touch.position.y ) );
					// tPosition.x = touch.position.x;
					// tPosition.y = touch.position.x;
					// tPosition.z = -1;
					Debug.Log("touch ~~!");

					// Destroy(GameObject.Find("redCircle(clone)"));

					tPosition.x = 0.1f;
					tPosition.y = -0.1f;
					tPosition.z = 2f;

					if(touch.position.y < (Screen.height/2 - 60))
					{
			            if((touch.position.x > 0) && (touch.position.x < (Screen.width/5))){
							tPosition.x = -5.4f;
					 		tPosition.y = -1.8f;
					 		tPosition.z = -1f;
						}else if((touch.position.x > ((Screen.width/5))) && (touch.position.x < ((Screen.width/5)*2))){
						    tPosition.x = -2.6f;
					 		tPosition.y = -1.8f;
					 		tPosition.z = -1f;

						}else if((touch.position.x > ((Screen.width/5)*2)) && (touch.position.x < ((Screen.width/5)*3))){
							tPosition.x = 0.1f;
					 		tPosition.y = -1.8f;
					 		tPosition.z = -1f;

						}else if((touch.position.x > ((Screen.width/5)*3)) && (touch.position.x < ((Screen.width/5)*4))){
							tPosition.x = 2.8f;
					 		tPosition.y = -1.8f;
					 		tPosition.z = -1f;

						}else if((touch.position.x > ((Screen.width/5)*4)) && (touch.position.x < ((Screen.width/5)*5))){
						    tPosition.x = 5.6f;
					 		tPosition.y = -1.8f;
					 		tPosition.z = -1f;

						}
					}
					//debugText.text += touch.position.x + "," + touch.position.y;
					Destroy(Instantiate(circle, tPosition, transform.rotation), 2.0f);
					
					//float timeLeft = 2.0f;
					//timeLeft -= Time.deltaTime;
					//if(timeLeft < 0)
					    //transform.Translate(Vector3.right*20);

					//Invoke("moveProblem",2);

					moveProblem();
				//}
				}
		}
	    //Debug.Log("input Count" + Input.touchCount);
	    //if(Input.touchCount > 0)
		//{
		//	touchPos = Input.GetTouch(0).position;

		//	Debug.Log("touchPos = " + touchPos.x + "and " + touchPos.y);

		//	Instantiate(circle, touchTrans.position, touchTrans.rotation);
			

		//}
	}

    void moveProblem(){
		Invoke("invokeTransform", 2);
	}

	void invokeTransform(){
		Transform transformTarget ;
		transformTarget = GameObject.Find("test_fg_01").transform;
		transformTarget.Translate(Vector3.right*20);

		//transform.Translate(Vector3.right*20);
	}
}
