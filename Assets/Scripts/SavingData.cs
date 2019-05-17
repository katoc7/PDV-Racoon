using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

using UnityEngine.UI;

public class SavingData : MonoBehaviour
{
    public int paints;
    public float health;
    public Vector3 position;
    public int level;

    public Text countPaint;
    public Text lv;
    public Slider life; //listo
    public Rigidbody2D rb2d;
    private string DATA_PATH = "/MyGame.dat";
    private Player raccon;


    // Update is called once per frame
    public void SaveData(Player p)
    {
      
        FileStream file = null;
        raccon = p;
        try
        {
            BinaryFormatter bf = new BinaryFormatter();

            file = File.Create(Application.persistentDataPath + DATA_PATH);
            bf.Serialize(file, p); //encript and saving
            Debug.Log("SAVED");

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

   public void LoadData()
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
