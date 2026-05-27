using UnityEngine;
using TMPro;
using System.Linq.Expressions;
using Unity.VisualScripting;

public class UIcontroller : MonoBehaviour
{
    public static UIcontroller instance;
    public GameObject menuPanel;
    public TMP_InputField inputField;
    public TMP_Text headlineText;
    private GameObject currentTarget;
    private int lvl;
    private string Code;

    void Awake()
    {
        instance = this;
    }

    public void MinigameStart(GameObject target)
    {
        currentTarget = target;
        lvl = currentTarget.GetComponent<HackableObject>().HackLevel;
        
        
        switch (lvl)
        {
            case 1:
                PlayerAbilities.instance.canAttack = false;
                PlayerMovement.instance.canMove = false;
                inputField.text = "";
                string characters = "0123456789";
                for (int i = 0; i < 5; i++)
                {
                    char randomChar = characters[UnityEngine.Random.Range(0, characters.Length)];
                    Code += randomChar;
                }
                menuPanel.SetActive(true);
                inputField.Select();
                inputField.ActivateInputField();
                headlineText.text = "Type this code: " + Code;
                break;

            case 2:
                MinigameLvl2();
                break;

            case 3:
                MinigameLvl3();
                break;
        }
    }

 

    private void MinigameLvl2()
    {

    }

    private void MinigameLvl3()
    {

    }
    public void MinigameStop()
    {
        menuPanel.SetActive(false);
    }

    public void CheckInput()
    {
        PlayerMovement.instance.canMove = true;
        PlayerAbilities.instance.canAttack = true;

        string typed = inputField.text;
        if (typed == Code)
        {
            Destroy(currentTarget);
            Code = string.Empty;
            MinigameStop();



        }
        else
        {
            Code = string.Empty;
            MinigameStop();


        }
    }
}
