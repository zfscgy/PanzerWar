using System.Collections.Generic;

public enum GameYearEnum {
    WW1,
    WW2Early,
    WW2Middle,
    WW2Late,
    ColdWar
}

public class GameYear {
    public static List<string> GetVehicleListFromYear(GameYearEnum currentYearEnum){
        List<string> WW1VehicleList = new List<string>() {
            "A7V_SturmpanzerWagen","Mark_IV","FT_17"
        };

        List<string> WW2EarlyVehicleList = new List<string>(){
         
        };

        List<string> WW2MiddleVehicleList = new List<string>(){
            "KV2","KV"
        };

        List<string> WW2LateVehicleList = new List<string>() {
            "T-54","T-44","IS-3"
        };

        List<string> ColdWarVehicleList = new List<string>() {
            "T-62A","Bat_Chatillon155_58","T-34-3"
        };
        switch(currentYearEnum){
            case GameYearEnum.WW1:
                return WW1VehicleList;
            case GameYearEnum.WW2Early:
                return WW2EarlyVehicleList;
            case GameYearEnum.WW2Middle:
                return WW2MiddleVehicleList;
            case GameYearEnum.WW2Late:
                return WW2LateVehicleList;
            case GameYearEnum.ColdWar:
                return ColdWarVehicleList;
            default:
                return null;
        }
    }
}