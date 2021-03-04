using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public static class Utils{
        public static string GetTextFromFile(string filePath){
            var streamReader = new StreamReader(filePath);
            return streamReader.ReadToEnd();
        }

        public static void ClearContent(Transform content){
            for (var i = 0; i < content.childCount; i++)
            {
                if(content.GetChild(0) != null)
                    Object.Destroy(content.GetChild(0).gameObject);
            }
        }
}
