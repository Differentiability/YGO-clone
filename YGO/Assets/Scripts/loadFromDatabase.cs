using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;
using System.IO;

//https://github.com/rizasif/sqlite-unity-plugin
public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string connection = "URI=file:" + Application.persistentDataPath + "/" + "My_Database";
        //IDbConnection dbcon = new SqliteConnection(connection);
        //dbcon.Open();
        // do something
        //dbcon.Close();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
