using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static void SaveGame(SaveStructure saveStructure)
    {
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        string filePath = Application.persistentDataPath + "/dashingparkour.save";
        FileStream fileStream = new FileStream(filePath, FileMode.Create);
        binaryFormatter.Serialize(fileStream, saveStructure);
        fileStream.Close();
    }
    public static SaveStructure LoadGame()
    {
        string filePath = Application.persistentDataPath + "/dashingparkour.save";
        if (File.Exists(filePath))
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream  fileStream = new FileStream(filePath, FileMode.Open);
            SaveStructure save = binaryFormatter.Deserialize(fileStream) as SaveStructure;
            fileStream.Close();
            return save;
        }
        else
        {
            Debug.Log("Tried to load from a non existent file.");
            return null;
        }
    }
}
