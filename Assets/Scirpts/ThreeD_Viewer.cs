using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ThreeD_Viewer : MonoBehaviour
{
    public Camera mainCam;
    // Start is called before the first frame update
    void Start()
    {
        var loadedPrefabResource = LoadPrefabFromFile("3d_assets/" + NotDestroyGameObj.path);
        GameObject model = (GameObject) Instantiate(loadedPrefabResource, Vector3.zero, Quaternion.identity);

        if(mainCam)
            mainCam.GetComponent<MouseOrbit>().target = model.transform;
        
    }


    private UnityEngine.Object LoadPrefabFromFile(string filename)
    {
        Debug.Log("Trying to load LevelPrefab from file (" + filename + ")...");
        var loadedObject = Resources.Load(filename);
        if (loadedObject == null)
        {
            throw new System.IO.FileNotFoundException("...no file found - please check the configuration");
        }
        return loadedObject;
    }

    public void AR_Mode()
    {
        SceneManager.LoadScene(0);
    }

}
