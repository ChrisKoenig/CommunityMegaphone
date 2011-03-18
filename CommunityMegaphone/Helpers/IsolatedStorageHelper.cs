using System;
using System.IO;
using System.IO.IsolatedStorage;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Newtonsoft.Json;

namespace CommunityMegaphone.Helpers
{
    public class IsolatedStorageHelper
    {
        public static void SaveObjectToIsolatedStorage<T>(T theObject, string key)
        {
            using (var file = IsolatedStorageFile.GetUserStoreForApplication())
            {
                if (!file.FileExists(key))
                    file.DeleteFile(key);
                using (var stream = file.CreateFile(key))
                {
                    string data = JsonConvert.SerializeObject(theObject);
                    using (var writer = new StreamWriter(stream))
                    {
                        writer.Write(data);
                    }
                }
            }
        }

        public static T LoadObjectFromIsolatedStorage<T>(string key)
        {
            using (var file = IsolatedStorageFile.GetUserStoreForApplication())
            {
                if (!file.FileExists(key))
                    return default(T);
                using (var stream = file.OpenFile(key, System.IO.FileMode.Open))
                {
                    string data;
                    using (var reader = new StreamReader(stream))
                    {
                        data = reader.ReadToEnd();
                    }
                    T deserializedObject = JsonConvert.DeserializeObject<T>(data);
                    return deserializedObject;
                }
            }
        }
    }
}