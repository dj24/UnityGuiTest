using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newItem : MonoBehaviour {


    public GameObject itemBox;
    
    public class Weapon
    {
        public string type, dps;
        public int level, modifier, rarity;

        public Weapon()
        {
            float roll = Random.Range(0f, 1f);
            if (roll < 0.6f)
                rarity = 0;
            else if (roll < 0.9f)
                rarity = 1;
            else
                rarity = 2;
            type = null;
            dps = null;
        }
        
        

        public string getRarity()
        {
            string[] rarityName = new string[] { "Common", "Rare", "Epic" };
            return rarityName[rarity];
        }

        public string getDps()
        {
            return (level * modifier * (1 + (rarity * 0.2f)) * Random.Range(0.75f, 1.3f)).ToString();
        }
    }

    public class Axe : Weapon
    {
        public Axe(int axeLevel)
        {
            level = axeLevel;
            modifier = 10;
            type = "Axe " + getRarity();
            dps = getDps();
        }
    }

    public class Sword : Weapon
    {
        public Sword(int swordLevel)
        {
            level = swordLevel;
            modifier = 8;
            type = "Sword " + getRarity();
            dps = getDps();
        }
    }


    void setText(string objName, string txt)
    {
        GameObject obj;
        obj = GameObject.Find(objName);
        obj.GetComponent<UnityEngine.UI.Text>().text = txt;
    }

    void createItem(string type, string dps)
    {
        setText("DPS", dps);
        setText("Type", type);
    }

    public void inst()
    {

        GameObject ui = GameObject.FindGameObjectWithTag("UI");
        GameObject childObject = Instantiate(itemBox) as GameObject;
        childObject.transform.parent = ui.transform;


        int rand = Random.Range(0, 2);

        if (rand == 0)
        {
            Weapon newWeapon = new Axe(10);
            createItem(newWeapon.type, newWeapon.dps);
        }
        if (rand == 1)
        {
            Weapon newWeapon = new Sword(10);
            createItem(newWeapon.type, newWeapon.dps);
        }
    }

    public void destroy()
    {
        Destroy(GameObject.Find("NewItem(Clone)"));
    }

    void Start()
    {

    }

    void Update () {
		
	}
}
