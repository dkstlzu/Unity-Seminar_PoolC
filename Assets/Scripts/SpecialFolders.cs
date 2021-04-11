using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SpecialFolders : MonoBehaviour
{
    [Header("Resource Root")]
    public string ResourceFolderPath = "TestSound1";
    public Object ResourceObj;
    Rect ResourceFolderRect = new Rect(10, 10, 100, 50);

    [Header("Resource Sub Path")]
    public string ResourceSubFolderPath = "SubDirectory/TestSound2";
    public Object ResourceSubDirectoryObj;
    Rect ResourceSubFolderRect = new Rect(120, 10, 100, 50);

    [Header("StreamingAssets Root")]
    public string StreamingAssetsFolderPath = "TestSound3";
    public Object StreamingAssetsDirectoryObj;
    Rect StreamingAssetsFolderRect = new Rect(230, 10, 100, 50);

    [Header("StreamingAssets Root")]
    public string StreamingAssetsSubFolderPath = "SubDirectory/TestSound4";
    public Object StreamingAssetsSubDirectoryObj;
    Rect StreamingAssetsSubFolderRect = new Rect(340, 10, 100, 50);


    void OnGUI()
    {
        if (GUI.Button(ResourceFolderRect, ResourceFolderPath))
        {
            ResourceObj = Resources.Load(ResourceFolderPath);
        }

        if (GUI.Button(ResourceSubFolderRect, ResourceSubFolderPath))
        {
            ResourceSubDirectoryObj = Resources.Load(ResourceSubFolderPath);
        }

        if (GUI.Button(StreamingAssetsFolderRect, StreamingAssetsFolderPath))
        {
            StreamingAssetsDirectoryObj = Resources.Load(StreamingAssetsFolderPath);
        }

        if (GUI.Button(StreamingAssetsSubFolderRect, StreamingAssetsSubFolderPath))
        {
            StreamingAssetsSubDirectoryObj = Resources.Load(StreamingAssetsSubFolderPath);
        }
    }
}
