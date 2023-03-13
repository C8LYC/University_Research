using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Mirror the attached Camera 
/// </summary>
public class CamMirror : MonoBehaviour
{
    void Start()
    {
        Camera cam = GetComponent<Camera>();
        if(cam != null)
		{
            Debug.Log("Have Cam to Mirror");
            MirrorFlipCamera(cam);
        }
    }

	#region function

    void MirrorFlipCamera(Camera cam)
	{
        Matrix4x4 CamProjectMat = cam.projectionMatrix;
        CamProjectMat *= Matrix4x4.Scale(new Vector3(-1, 1, 1));
        cam.projectionMatrix = CamProjectMat;
	}

	#endregion
}
