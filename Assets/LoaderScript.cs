using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class LoaderScript : MonoBehaviour
{
    [SerializeField] AssetReference addressableScene;

    public void LoadAddressableScene()
    {
        Addressables.LoadSceneAsync(addressableScene);
    }
}
