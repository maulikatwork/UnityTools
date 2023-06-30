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

}
