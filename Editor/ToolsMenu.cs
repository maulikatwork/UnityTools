using System.IO;
using UnityEditor;
using UnityEngine;

using static System.IO.Directory;
using static System.IO.Path;
using static UnityEditor.AssetDatabase;
using static UnityEngine.Application;

public static class ToolsMenu
{
    [MenuItem("Maulik/Setup/Create Default Folders")]
    public static void CreateDefaultFolder()
    {
        CreateDirectories("_project","Art", "Prefabs", "Scripts", "Audio", "Scenes");
        Refresh();
    }   

    public static void CreateDirectories(string root, params string[] dir)
    {
        string fullpath = Combine(dataPath, root);
        foreach (var newDirectory in dir)
            CreateDirectory(Combine(fullpath, newDirectory));
    
    }

    [UnityEditor.MenuItem("Maulik/Scripts/Singleton Templet")]
    public  static void CreateSingleton()
    {
        string templetPath = "Packages/com.maulik.tools/Editor/SingletonTemplate.cs";
        string destPath = Path.Combine("_project", "Scripts", "Template");
        string fileName = Path.GetFileName(templetPath);
        string destFilePath = Path.Combine(destPath, fileName);
        CreateDirectory(Combine(dataPath,destPath));
        CopyAsset(templetPath, destPath);
        ImportAsset(destFilePath);
        Refresh();

    }

}
