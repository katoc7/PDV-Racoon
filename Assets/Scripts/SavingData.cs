using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class SavingData : MonoBehaviour
{
    
    private string DATA_PATH = "/MyGame.dat";
    private Player raccon;

    // Start is called before the first frame update
    void Start()
    {
        // SaveData();
        //print("DATA PHAT IS" + Application.persistentDataPath + DATA_PATH);
        LoadData();
        if(raccon != null)
        {
            print("Paints" + raccon.Paints);
            print("Health" + raccon.Health);
            print("xPos" + raccon.XPos);
            print("yPos" + raccon.YPos);
        }
    }

    // Update is called once per frame
    void SaveData()
    {
        FileStream file = null;

        try
        {
            BinaryFormatter bf = new BinaryFormatter();

            file = File.Create(Application.persistentDataPath + DATA_PATH);
            Player p = new Player(3,60,50,50);

            bf.Serialize(file, p); //encript and saving

        }catch(Exception e)
        {
            if (e != null)
            {

            }
        }
        finally
        {
            if(file != null)
            {
                file.Close();
            }
        }
    }

    void LoadData()
    {
        FileStream file = null;

        try
        {
            BinaryFormatter bf = new BinaryFormatter();

            file = File.Open(Application.persistentDataPath + DATA_PATH, FileMode.Open);
            raccon = bf.Deserialize(file) as Player;
            //decrepting and loading

        }catch(Exception e)
        {

        }
        finally
        {
            if (file != null)
            {
                file.Close();
            }
        }

    }
}
