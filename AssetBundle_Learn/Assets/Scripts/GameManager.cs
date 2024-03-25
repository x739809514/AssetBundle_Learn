using System.IO;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void Start()
    {
        var myLoaderAssetBundle =
            AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath + "/AssetBundles"));
        if (myLoaderAssetBundle==null)
        {
            Debug.Log("Failed to load AssetBundle");
        }

        var prefab = myLoaderAssetBundle.LoadAsset<GameObject>("prefabs/player");
        Instantiate(prefab);
    }
}
