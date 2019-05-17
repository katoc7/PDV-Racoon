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
    private static bool isSaved;
    private static Player raccon;

    public Text countPaint;
    public Text lv;
    public Slider life; //listo
    public Rigidbody2D rb2d;
    private static string DATA_PATH = "/MyGamef.dat";

    public static Player Raccon { get => raccon; set => raccon = value; }
    public static bool IsSaved { get => isSaved; set => isSaved = value; }


    // Update is called once per frame
    public void SaveData()
    {
        health = life.value;
        paints = Int32.Parse(countPaint.text);
        level = Int32.Parse(lv.text);
        position = rb2d.position;
        SavingData.IsSaved = true;
        Debug.Log(isSaved);

        FileStream file = null;

        try
        {
            BinaryFormatter bf = new BinaryFormatter();

            file = File.Create(Application.persistentDataPath + DATA_PATH);
            Player p = new Player(paints,health,position,level);
            //Debug.Log(p.Paints);
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

    public static void LoadData()
    {
        FileStream file = null;

        try
        {
            BinaryFormatter bf = new BinaryFormatter();

            file = File.Open(Application.persistentDataPath + DATA_PATH, FileMode.Open);
            SavingData.raccon = bf.Deserialize(file) as Player;
            //decrepting and loading

        }
        catch (Exception e)
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
