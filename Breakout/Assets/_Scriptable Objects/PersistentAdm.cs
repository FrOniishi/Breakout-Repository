using System.Collections.Generic;
using UnityEngine;

public class PersistentAdm : MonoBehaviour
{
    public List<PersistentScore> saveObjects;
   
    public void OnEnable()
    {
        for (int i = 0; i < saveObjects.Count; i++)
        {
            var so = saveObjects[i];
            so.Load();
        }
    }
    
    public void OnDisable()
    {
        for (int i = 0; i < saveObjects.Count; i++)
        {
            var so = saveObjects[i];
            so.Save();
        }
    }
}
