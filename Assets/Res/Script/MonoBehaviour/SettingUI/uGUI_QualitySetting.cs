using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[System.Serializable]
public class GraphicSetting{
    public bool isFullResoultion;

    public bool isSunRays;

    public bool isHighTextureQuality;
}

public class uGUI_QualitySetting : MonoBehaviour {
	public static GameObject Panel;

	public GameObject Settings_Panel;

    public Toggle ToggleFullResoultion, ToggleSunRays, ToggleHighTextureQuality;

	public static Rect PhysicsScreen = new Rect();

	public static uGUI_QualitySetting _Instance;

    public static GraphicSetting currentGraphicSetting = new GraphicSetting();

	public static void Init (){
		Open();
		_Instance = Panel.GetComponentInChildren<uGUI_QualitySetting>();
		Panel.transform.GetChild(0).GetChild(0).gameObject.SetActive (false);
	}

	public static void Open(){
		if (Panel != null) {
			Panel.transform.GetChild(0).GetChild(0).gameObject.SetActive (true);
		} else {
			Panel = Instantiate(Resources.Load ("UI/Settings")) as GameObject;
			DontDestroyOnLoad (Panel);
			Open ();
		}
	}
	void Start(){
        ReadSetting();

        ToggleFullResoultion.onValueChanged.AddListener((condition)=>{
            currentGraphicSetting.isFullResoultion = condition;
            SaveSetting();
        });

        ToggleSunRays.onValueChanged.AddListener((condition) => {
            currentGraphicSetting.isSunRays = condition;
            SaveSetting();
        });

        ToggleHighTextureQuality.onValueChanged.AddListener((condition) => {
            currentGraphicSetting.isHighTextureQuality = condition;
            SaveSetting();
        });
	}

    void ReadSetting(){
        JsonUtility.FromJsonOverwrite(PlayerPrefs.GetString("Graphic"), currentGraphicSetting);

        ToggleFullResoultion.isOn = currentGraphicSetting.isFullResoultion;
        ToggleSunRays.isOn = currentGraphicSetting.isSunRays;
        ToggleHighTextureQuality.isOn = currentGraphicSetting.isHighTextureQuality;

        if(currentGraphicSetting.isFullResoultion){
            
        }
        else {
            Screen.SetResolution(Mathf.RoundToInt(Screen.width * 0.8f),Mathf.RoundToInt(Screen.height * 0.8f),true,30);
        }

        if(currentGraphicSetting.isHighTextureQuality){
            QualitySettings.masterTextureLimit = 0;
        }
        else {
            QualitySettings.masterTextureLimit = 1;
        }
    }

    void SaveSetting(){
        PlayerPrefs.SetString("Graphic",JsonUtility.ToJson(currentGraphicSetting));
    }

}
