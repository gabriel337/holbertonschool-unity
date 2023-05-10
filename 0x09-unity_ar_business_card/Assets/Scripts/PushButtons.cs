using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushButtons : MonoBehaviour
{
    
    public Animator PinterestB;
    public Animator GitHubB;
    public Animator TwitterB;
    public Animator LinkednB;
    public Animator NameB;
    public Animator TitleB;

    private bool animPlayed = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    //Add Button Component to any GameObject you used as the button icon. 
    //Once this script is added into each button as a coponent as well, it
    //will communicate the methods according to the button components available
    //methods. Add Audio source in each button and quickly access the component
    //in each button.
    public void Pinterest()
    { /*None of it works*/
        if (!animPlayed)
        {
            PinterestB.SetBool("trigger", true);
            animPlayed = true;
        }
        Application.OpenURL("https://www.pinterest.com/solymar227/");
    }

    public void GitHub()
    {
        if (!animPlayed)
        {
            GitHubB.SetBool("trigger", true);
            animPlayed = true;
        }
        Application.OpenURL("https://github.com/Soly-M-27");
    }

    public void Twitter()
    {
        if (!animPlayed)
        {
            TwitterB.SetBool("trigger", true);
            animPlayed = true;
        }
        Application.OpenURL("https://twitter.com/Michi_or_Skully");
    }

    public void Linkdn()
    {
        if (!animPlayed)
        {
            LinkednB.SetBool("trigger", true);
            animPlayed = true;
        }
        Application.OpenURL("https://www.linkedin.com/in/solymar-sánchez-molina-094572220/");
    }

    public void Update() {
        /*Nope*/
        if (!animPlayed)
        {
            NameB.SetBool("trigger", true);
            TitleB.SetBool("trigger", true);
            animPlayed = true;
        }
        NameB.SetBool("trigger", false);
        TitleB.SetBool("trigger", false);
    }
}
