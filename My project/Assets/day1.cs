using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    
    string heroname = "  CAPTAIN MARVEL  ";
        float herohight = 185.7f;
        int heroage = 44;
        string herosuperpower = " Speed and Flight ";

        string villainName = " JOKER ";
        float villainhight = 175.8f;
        int villainage = 38;
        string villainsuperpower = " Deception ";
        int agedifference = 44 - 38;

    // Start is called before the first frame update
    void Start()
    {

       

        print(" my name is " + heroname);
        print("  and im " + heroage);
        print("  my hight is " + herohight);
        print(" my super power is " + herosuperpower);


        print(" my name is " + villainName);
        print(" and im " + villainage);
        print("my hight is " + villainhight);
        print(" my super power is " + villainsuperpower);
        print(agedifference);

        print(heroage + 5);

    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
