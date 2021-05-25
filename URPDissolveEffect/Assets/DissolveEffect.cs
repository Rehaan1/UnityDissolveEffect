using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveEffect : MonoBehaviour
{
    [SerializeField] Material dissolveMat;
    [SerializeField] float appearanceValue;
    [SerializeField] float maxAppearanceValue;
    [SerializeField] float appearanceSpeed=10f;
    [SerializeField] string dissolveVal;
    bool initiateAppearanceSequence = false;
    bool initiateDisappearanceSequence = false;

    void Start()
    {
        dissolveMat.SetFloat(dissolveVal, appearanceValue/maxAppearanceValue);
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
            if(appearanceValue<=maxAppearanceValue)
            {
                appearanceValue +=5 * Time.deltaTime * appearanceSpeed;
                dissolveMat.SetFloat(dissolveVal, appearanceValue/maxAppearanceValue);
            }
            else
            {
                initiateAppearanceSequence = false;
            }
    }

    void Disappear()
    {
            if(appearanceValue>=0)
            {
                appearanceValue -=5 * Time.deltaTime * appearanceSpeed;
                dissolveMat.SetFloat(dissolveVal, appearanceValue/maxAppearanceValue);
            }
            else
            {
                initiateDisappearanceSequence = false;
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
