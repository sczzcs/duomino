
using UnityEngine;
using System.Collections;

public class creat : MonoBehaviour {
	public GameObject scz;
	public Camera cam;
	float zpoint=0;
	// We need to actually hit an object
	
	RaycastHit hitt = new RaycastHit();
	// Use this for initialization
	
	void Start()
		
	{
	}
	// Update is called once per frame
	
	void Update()
		
	{
		
		Ray ray = cam.ScreenPointToRay(Input.mousePosition);
		
		Physics.Raycast(ray, out hitt, 100);
		
		// Debug.DrawLine(cam.transform.position, ray.direction,Color.red);
		Vector3 y = new Vector3(0,1,0);
		Vector3 z = new Vector3(0,0,zpoint);

			if (Input.GetMouseButtonDown (0)) {
				if (null != hitt.transform)
					
				{
				GameObject abc = Instantiate (scz) as GameObject;
				abc.transform.position = hitt.point+y+z;
				zpoint=zpoint+0.7f;

	
		}
		
	}
		if(Input.GetKey ("space")){
			zpoint=0;
		}

		
	}
}