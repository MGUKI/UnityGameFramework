using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.Plastic.Antlr3.Runtime.Misc;
using UnityEditor;
using UnityEngine;

/// <summary>
/// 创建AssetBuild
/// </summary>
public class TestAssetBundle
{
    [MenuItem("AssetBundle/Build Windows")]
    static void BuildAssetBundle()
    {
        // Bundle路径
        string outputPath = Application.streamingAssetsPath;
        if (!Directory.Exists(outputPath))
        {
            Directory.CreateDirectory(outputPath);
            createBuild(outputPath);
        }
    }

    static void createBuild(string outputPath)
    {
        // Build列表
        List<AssetBundleBuild> builds = new ListStack<AssetBundleBuild>();
        
        // 场景包不能个资源包放在同一个包
        
        // ArtsBuild
        AssetBundleBuild ArtsBuild = new AssetBundleBuild();
        ArtsBuild.assetBundleName = "UI";
        ArtsBuild.assetBundleVariant = "unity3d";
        ArtsBuild.assetNames = new[] {"Assets/AssetBundle/AssetTest/Image.prefab"};
        // ScenenBuild
        AssetBundleBuild ScenenBuild = new AssetBundleBuild();
        ScenenBuild.assetBundleName = "Scenens";
        ScenenBuild.assetBundleVariant = "unity3d";
        ScenenBuild.assetNames = new[] {"Assets/AssetBundle/Scenens/BundleTest02.unity"};
        
        builds.Add(ArtsBuild);
        builds.Add(ScenenBuild);
        
        // 创建Build
        BuildPipeline.BuildAssetBundles(outputPath, builds.ToArray(),BuildAssetBundleOptions.ChunkBasedCompression, BuildTarget.StandaloneWindows);
    }
}
