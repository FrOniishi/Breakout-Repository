using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public abstract class PersistentScore : ScriptableObject
{
    public void Save(string FileName = null)
    {
        var bf = new BinaryFormatter();
        var file = File.Create(GetPath(FileName));
        var json = JsonUtility.ToJson(this);

        bf.Serialize(file, json);
        file.Close();
    }

    public virtual void Load(string fileName = null)
    {
        if (File.Exists(GetPath(fileName)))
        {
            var bf = new BinaryFormatter();
            var file = File.Open(GetPath(fileName), FileMode.Open);
            JsonUtility.FromJsonOverwrite((string)bf.Deserialize(file), this);
            file.Close();
        }
    }

    public string GetPath(string fileName = null)
    {
        var fileNameComplete = string.IsNullOrEmpty(fileName) ? name : fileName;
        return string.Format("{0}/{1}.ebac", Application.persistentDataPath, fileNameComplete);
    }
}
