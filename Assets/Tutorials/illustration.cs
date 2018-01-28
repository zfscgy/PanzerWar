using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class illustration : MonoBehaviour {
	void Start () {
        GameObject newVehicle = new GameObject("Vehicle");
        GameDataManager.OfflineMode = true;
        TankInitSystem initSystem = newVehicle.AddComponent<TankInitSystem>();
        initSystem.VehicleName = "FT_17";
        initSystem._InstanceNetType = InstanceNetType.GameNetWorkOffline;
        initSystem.BulletCountList = new int[3]{
            35,15,5
        };
        initSystem.InitTankInitSystem();
	}

}
