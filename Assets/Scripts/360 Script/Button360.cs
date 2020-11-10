using UnityEngine;

[ExecuteInEditMode]
public class Button360 : MonoBehaviour {

	public float xAngle;
	public float yAngle = 0;
	//public InterfaceManager interfaceManager;

	float radius = 4.8f;

	[HideInInspector]
	public int selected = 0;

	//bool isOK;
	//int lastID;
	//bool f;

	void Update()
	{
		transform.rotation = Quaternion.LookRotation(transform.position - transform.parent.transform.position);
	
		//if(Application.isPlaying && !isOK)
		//{

			//SetListener();
			//isOK = true;
		//}
	}

	public void SetXPositionByAngle()
	{
		float xRadians = (xAngle - 90) * Mathf.PI / 180;
		float yRadians = (yAngle + 270) * Mathf.PI / 180;		

		float xPos = radius * Mathf.Sin(xRadians) * Mathf.Cos(yRadians);
		float zPos = radius * Mathf.Sin(xRadians) * Mathf.Sin(yRadians);
		float yPos = radius * Mathf.Cos(xRadians);	

		transform.localPosition = new Vector3(-xPos, yPos, zPos);
	}
	
	/*
	public void SetListener() {
	    //var rooms = Rooms.Instance;               
        //if (selected > rooms.roomName.Count - 1) return;   

		//var interfaceManager = Rooms.Instance.GetComponent<InterfaceManager>();

		Button buttonBu = GetComponent<Button>();

		#if !UNITY_ANDROID && !(UNITY_IOS || UNITY_IPHONE)
        int index = rooms.RealIndex(rooms.roomName[selected]);  
		buttonBu.onClick.RemoveAllListeners();
	
       // buttonBu.onClick.AddListener( () => {  
			          
            //InterfaceManager.finishInt = index;
            //interfaceManager.NextRoom();
			//Debug.Log("Go");
			//Debug.Log("Clicked");
			 
		} );

		EventTrigger trigger = GetComponent<EventTrigger>();

	    EventTrigger.Entry entry = new EventTrigger.Entry {eventID = EventTriggerType.PointerEnter};

	    entry.callback.AddListener( (eventData) => {
			interfaceManager.ButtonHighlitedOn(selected, transform);
		} );
		trigger.triggers.Add(entry);

		EventTrigger.Entry exit = new EventTrigger.Entry();
		exit.eventID = EventTriggerType.PointerExit;
		exit.callback.AddListener( (eventData) => {
			interfaceManager.ButtonHighlitedOff();
		} );
		trigger.triggers.Add(exit);
		#endif

		#if UNITY_ANDROID || UNITY_IPHONE || UNITY_IOS
		buttonBu.onClick.RemoveAllListeners();
        buttonBu.onClick.AddListener(() =>
        { 
			
			//var newCamPos = rooms.roomTrans[finishInt].position;
			//Camera.main.transform.position = newCamPos;
			//uiCam.position = newCamPos;
			if(interfaceManager.isWindowOpened)
				interfaceManager.ButtonHighlitedOff();
			else
			{
				Debug.Log("Clicked");
				Camera.main.transform.position = newCamPos;
				//interfaceManager.ButtonHighlitedOn(selected, transform);
			}
			
		});

	    if (Data.viewMode == 0) {
	        var vrControlWatch = GetComponent<VRControlWatch>();
	        if (vrControlWatch != null) {
	            var eventTrigger = GetComponent<EventTrigger>();
	            var pEnterEntry = new EventTrigger.Entry {eventID = EventTriggerType.PointerEnter};
	            var pExitEntry = new EventTrigger.Entry {eventID = EventTriggerType.PointerExit};
	            pEnterEntry.callback.AddListener(evt => { vrControlWatch.OnWatch(); });
	            pExitEntry.callback.AddListener(evt => { vrControlWatch.OnExitWatch(); });

	            eventTrigger.triggers.Add(pEnterEntry);
	            eventTrigger.triggers.Add(pExitEntry);
	        }
	    }
	#endif
    }
	 */
}