using UnityEngine;
using System.Diagnostics;

public class ScriptOpener : MonoBehaviour
{
    [SerializeField] private string filePath = "C:/path/to/your/script.py"; // Set the correct path

    public void OpenScript()
    {
        Process.Start("code", filePath); // "code" is the command line command to open VS Code
    }
}
