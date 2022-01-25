using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// 从AssetBundle加载资源
/// </summary>
public class TestBundleLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AssetBundle assetBundle = AssetBundle.LoadFromFile(Application.streamingAssetsPath+"/UI.unity3d");
        AssetBundle scenenBundle = AssetBundle.LoadFromFile(Application.streamingAssetsPath+"/Scenens.unity3d");
        // 加载美术资源
        if (assetBundle != null)
        {
            // 加载资源
            GameObject objectPrefab = assetBundle.LoadAsset<GameObject>("Image");
            // 加载子资源
            //Sprite[] sprites = assetBundle.LoadAssetWithSubAssets<Sprite>("XXX");
            // 加载所有的资源
            Object[] allObj = assetBundle.LoadAllAssets();
            for (int i = 0; i < allObj.Length; i++)
            {
                Debug.Log(allObj[i].name);
            }
            // 实例化到场景
            //GameObject.Instantiate(objectPrefab, transform);
        }
        // 加载场景
        if (scenenBundle!=null)
        {
            // 和其他的资源不一样，场景加载Bundle后，就可以直接SceneManager.LoadScene加载了场景
            SceneManager.LoadScene("BundleTest02");
        }
    }
    
}
