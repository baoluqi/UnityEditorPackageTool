using UnityEngine;
using System.Collections;
using UnityEditor;
using System.Collections.Generic;

public class ExportAssets : Editor {

    [MenuItem("Tools/Export Assets")]
    static void Build() {

        if (Selection.objects == null) return;
        List<string> paths = new List<string>();
        foreach (UnityEngine.Object o in Selection.objects)
        {
            paths.Add(AssetDatabase.GetAssetPath(o));
        }

        AssetDatabase.ExportPackage(paths.ToArray(), "Assets/UnityPackage/" + Selection.objects[0].name + "add.unitypackage", ExportPackageOptions.IncludeDependencies);
        AssetDatabase.Refresh();
    }
}
