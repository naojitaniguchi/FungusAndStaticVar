using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetGlobalVarToFungus : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setHP()
    {
        gameObject.GetComponent<Fungus.Flowchart>().SetIntegerVariable("HP", GlobalVar.hp);
    }

    public void setMP()
    {
        gameObject.GetComponent<Fungus.Flowchart>().SetIntegerVariable("MP", GlobalVar.mp);
    }

    // Fungus -> Global
    public void setPumpkinFromFungusToGLobal()
    {
        GlobalVar.pumpkin = gameObject.GetComponent<Fungus.Flowchart>().GetBooleanVariable("Pumpkin");
    }

    // Global -> Fungus
    public void setPumpkinFromGlobalToFungus()
    {
        gameObject.GetComponent<Fungus.Flowchart>().SetBooleanVariable("Pumpkin", GlobalVar.pumpkin);
    }
}
