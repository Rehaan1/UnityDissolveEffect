using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveEffect : MonoBehaviour
{
    [SerializeField] Material[] dissolveMat;
    [SerializeField] float appearanceValue;
    [SerializeField] float appearanceSpeed=10f;
    [SerializeField] float appearanceLimit=100f;
    [SerializeField] string dissolveVal;
    float minApperanceValue;
    float maxAppearanceValue=100f;
    bool initiateAppearanceSequence = false;
    bool initiateDisappearanceSequence = false;


    void Start()
    {
        foreach (Material mat in dissolveMat)
        {
            mat.SetFloat(dissolveVal, appearanceValue/maxAppearanceValue);
        }
        minApperanceValue = appearanceValue;
    }
    
    void Update()
    {
        
        if(initiateAppearanceSequence)
        {
            Appear();
        }

        if(initiateDisappearanceSequence)
        {
            Disappear();
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            InitiateAppearence();
        }     
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            InitiateDisappearence();
        }     
    }

    void Appear()
    {
        foreach(Material mat in dissolveMat)
        {
            if(appearanceValue<=maxAppearanceValue && appearanceValue<=appearanceLimit)
            {
                appearanceValue +=5 * Time.deltaTime * appearanceSpeed;
                mat.SetFloat(dissolveVal, appearanceValue/maxAppearanceValue);
            }
            else
            {
                initiateAppearanceSequence = false;
            }
        } 
    }

    void Disappear()
    {
        foreach (Material mat in dissolveMat)
        {
             if(appearanceValue>=minApperanceValue)
            {
                appearanceValue -=5 * Time.deltaTime * appearanceSpeed;
                mat.SetFloat(dissolveVal, appearanceValue/maxAppearanceValue);
            }
            else
            {
                initiateDisappearanceSequence = false;
            }
        }  
    }

    public void InitiateAppearence()
    {
        initiateAppearanceSequence = true;
    }

    public void InitiateDisappearence()
    {
        initiateDisappearanceSequence = true;
    }
}
