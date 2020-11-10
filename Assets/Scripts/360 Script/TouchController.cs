using UnityEngine;

public class TouchController : MonoBehaviour
{
    public float sensitivityX = 3F;
    public float sensitivityY = 3F;

    public float minimumX = -360F;
    public float maximumX = 360F;

    public float minimumY = -90F;
    public float maximumY = 90F;

    public float smoothSpeed = 20F;

    float rotationX = 0F;
    float smoothRotationX = 0F;
    float rotationY = 0F;
    float smoothRotationY = 0F;
    Vector3 vMousePos;
    public float Speed = 100f;

    public float zoomMin = 60;
    public float zoomMax = 20;
    float zoom;

    bool enableAuto;

    void Start()
    {
        rotationY = -Camera.main.transform.localEulerAngles.x;
        rotationX = Camera.main.transform.localEulerAngles.y;
        smoothRotationX = Camera.main.transform.localEulerAngles.y;
        smoothRotationY = -Camera.main.transform.localEulerAngles.x;
        zoom = 60.0f;
    }

    void TouchForRotate()
    {
        Touch touch = Input.GetTouch(0);
        Vector2 fingerDeltaPosition = touch.deltaPosition;
        float touchDeltaTime = touch.deltaTime;
        if (touchDeltaTime == 0.0f) return;
        rotationX += fingerDeltaPosition.x / (touchDeltaTime * 1000) * sensitivityX;
        rotationY += fingerDeltaPosition.y / (touchDeltaTime * 1000) * sensitivityY;
        rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);
    }

    void Update()
    {
#if (UNITY_ANDROID || UNITY_IPHONE || UNITY_IOS) && !UNITY_EDITOR
		if(Input.touchCount == 1 && Input.GetTouch(0).deltaTime != 0.0f && Input.GetTouch(0).phase == TouchPhase.Moved && !enableAuto)
		{
			TouchForRotate();
		}
#else
            if (Input.GetMouseButton(0) && !enableAuto)
            {
                rotationX += Input.GetAxis("Mouse X") * sensitivityX;
                rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
                rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);
            }
#endif
        if (enableAuto)
            rotationX += 1.5f * sensitivityX * Time.smoothDeltaTime;

#if (UNITY_ANDROID || UNITY_IPHONE || UNITY_IOS) && !UNITY_EDITOR
		if(Input.touchCount == 2 && zoomMax < zoom && zoom < zoomMin)
		{
			Touch touch0 = Input.GetTouch(0);
			Touch touch1 = Input.GetTouch(1);
			Vector2 touch0PrevPos = touch0.position - touch0.deltaPosition;
			Vector2 touch1PrevPos = touch1.position - touch1.deltaPosition;
			float prevTouchDeltaMag = (touch0PrevPos - touch1PrevPos).magnitude;
			float touchDeltaMag = (touch0.position - touch1.position).magnitude;
			float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;
			zoom += deltaMagnitudeDiff;
		}
#else
        if (Input.GetAxis("Mouse ScrollWheel") != 0 && zoomMax < zoom && zoom < zoomMin)
        {
            zoom -= Input.GetAxis("Mouse ScrollWheel") * 10;
            Debug.Log(Input.GetAxis("Mouse ScrollWheel") * 10);
        }
#endif
        if (zoom <= zoomMax) zoom = zoomMax + 0.5f;
        if (zoom >= zoomMin) zoom = zoomMin - 0.5f;
        Camera.main.fieldOfView = zoom;
        smoothRotationX += (rotationX - smoothRotationX) * smoothSpeed * Time.smoothDeltaTime;
        smoothRotationY += (rotationY - smoothRotationY) * smoothSpeed * Time.smoothDeltaTime;
        Camera.main.transform.localEulerAngles = new Vector3(-smoothRotationY, smoothRotationX, 0);
    }


    public void GoToStartRotation()
    {
        rotationX = 0;
        rotationY = 0;
    }

    public void ZoomPlus()
    {
        zoom -= 3.5f;
    }

    public void ZoomMinus()
    {
        zoom += 3.5f;
    }

    public void RotateRight()
    {
        rotationX += 5.0f * sensitivityX;

    }

    public void RotateLeft()
    {
        rotationX += -5.0f * sensitivityX;
    }

    public void RotateUp()
    {
        rotationY += 3.0f * sensitivityY;
    }

    public void RotateDown()
    {
        rotationY += -3.0f * sensitivityY;
    }

    public void AutoRotate()
    {
        enableAuto = !enableAuto;
    }
}
