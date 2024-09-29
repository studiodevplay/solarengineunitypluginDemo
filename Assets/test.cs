// using System.Collections;
// using System.Collections.Generic;
// using Newtonsoft.Json;
// using Newtonsoft.Json.Serialization;
// using SolarEngine;
// using SolarEngine.MiniGames;
// using StarkSDKSpace;
// using UnityEngine;
// using SolarEngine;
// using SolarEngine.MiniGames.info;
// using SolarEngine.MiniGames.Track;
// using SolarEngine.Request;
//
// public  class test:MonoBehaviour
// {
//     // Start is called before the first frame update
//     void Start()
//     {
//   
//        // string mUUID = System.Guid.NewGuid().ToString();
//        // Debug.LogWarning(mUUID);
//        // int log =SETool. getEventLogCount();
//        // //SEUUIDGenerator.updateStorageLogCount(log);
//        // Debug.Log(log);
//      MockSetting.OpenAllMockModule();
//        string appkey = "8444a29b7211d849";
//       
//        MiniGameInitParams initParams = new MiniGameInitParams();
//      
//     
//        InitConfig initConfig = new InitConfig();
//     
//        initConfig.logEnabled = true;
//
//
//        RemoteConfig remoteConfig = new RemoteConfig();
//        remoteConfig.pollingInterval = 30;
//        remoteConfig.enable = true;
//        remoteConfig.mergeType = 1;
//        remoteConfig.customIDProperties = new Dictionary<string, object> { { "a", 1 } };
//        remoteConfig.customIDEventProperties = new Dictionary<string, object> { { "e", 1 } };
//        remoteConfig.customIDUserProperties = new Dictionary<string, object> { { "u", 1 } };
//        remoteConfig.requestTimeout = 5000;
//
//        initConfig.remoteConfig = remoteConfig;
//        initParams.config = initConfig;
//        SolarEngineSDK4MiniGames.prevInit(appkey);
//        SolarEngineSDK4MiniGames.init(initParams);
//        
//       
//
//      //   SESDKInfo._openid = "test111";
//      // Distinct distinct=  SolarEngineSDK.getDistinctId();
//      // Debug.Log(distinct.distinct_id +"    "+ distinct.distinct_id_type);
//     }
//
//     // Update is called once per frame
//     void Update()
//     {
//         
//     }
//     
//     
//     public static void testevent()
//     {
//         List<Dictionary<string, object>> postParams = new List<Dictionary<string, object>>();
//         SEEventData data = new SEEventData("_mpInstall",1,SESDKTool4MiniGames.UUID.GenerateUUID());
//         var reportdata = data.ToDictionary();
//         string reportdatas= JsonConvert.SerializeObject( reportdata);
//         Debug.Log(reportdatas);
//         string _si = SESDKTool4MiniGames.CreateSign(reportdata);
//         
//         reportdata.Add(SESDKConstant.EventString._si,_si);
//         postParams.Add(reportdata);
//         string test= JsonConvert.SerializeObject( postParams);
//         
//         
//         string url = "http://api-receiver.detailroi.com/datareceiver/receive/v1/debugApi";
//         
//         string url2 = "http://api-receiver.detailroi.com/datareceiver/receive/v3/api";
//         
//         SEUnityWebRequest.Instance.Post(url,test,null,null);
//
//     }
//
// }
