using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using UnityEditor.SceneManagement;

[CustomEditor(typeof(Button360))]
public class Button360Editor : Editor {

	public override void OnInspectorGUI()
	{
		Button360 targ = (Button360)target;
		//var rooms = Rooms.Instance.GetComponent<Rooms>();

		EditorGUILayout.LabelField("Vertical");
		targ.xAngle = EditorGUILayout.Slider(targ.xAngle, -90, 90);

		EditorGUILayout.LabelField("Horizontal");
		targ.yAngle = EditorGUILayout.Slider(targ.yAngle, -1, 361);

		if(targ.yAngle >= 361) targ.yAngle = 0;
		else if(targ.yAngle <= -1) targ.yAngle = 360;

		targ.SetXPositionByAngle();
        
		//targ.selected = EditorGUILayout.Popup("Go to", targ.selected, rooms.roomID.ToArray());

		if (GUI.changed)
		
		{
			SceneView.RepaintAll();
			EditorSceneManager.MarkSceneDirty(SceneManager.GetActiveScene());
		}
	}
}