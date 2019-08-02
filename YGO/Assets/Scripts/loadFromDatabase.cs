using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;
using System.IO;

//https://github.com/rizasif/sqlite-unity-plugin
public class loadFromDatabase : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        try
        {
            string app_path = Application.dataPath;//Application.persistentDataPath;
            Debug.Log(app_path);
            string connection = "URI=file:" + app_path + "/" + "Database/card_list.sqlite";
            IDbConnection dbcon = new SqliteConnection(connection);
            dbcon.Open();
            // do something
            dbcon.Close();
        }
        catch (System.Exception e)
        {
            //Debug.Log("Naslo bazu!");
            Debug.Log(e);
        };
    }
}
