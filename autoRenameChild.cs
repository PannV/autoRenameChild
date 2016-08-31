using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class autoRenameChild : MonoBehaviour {
	
	Transform child;
	GameObject parent;
	public string mount = "Mount" ;


	void Awake(){
		string parentName = this.gameObject.name;
		var colorNameOnly = parentName.Remove (parentName.Length - 4);

		//find child that has string "mount"
		child = transform.FindChild(mount);

		if (child.name != "_" + colorNameOnly + child.name) {
			//combine parent's name with child's
			child.name = "_" + colorNameOnly + "Mount"; 
			mount = child.name; 
			Debug.Log (parentName + " +mount");
		} else {
			Debug.Log ("Already Done:" + parentName + " +mount");
		}



	}
}