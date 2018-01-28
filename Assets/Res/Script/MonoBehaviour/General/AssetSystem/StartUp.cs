using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.IO;

public class StartUp : MonoBehaviour
{
    

	public void StartUpAction ()
	{
		DontDestroyOnLoad (gameObject);
		StartCoroutine (AssetBundleManager.RequestScene (true, false, "ClientOffline", null, onLoaded => {
			Destroy (gameObject);	
		}));
	}
}
