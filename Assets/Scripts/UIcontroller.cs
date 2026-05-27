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
        HackableObject hackable = target.GetComponentInParent<HackableObject>();

        if (hackable == null)
        {
            Debug.LogError("No HackableObject found on " + target.name);
            return;
        }

        currentTarget = hackable.gameObject;
        lvl = hackable.HackLevel;
        
        
        switch (lvl)
        {
            case 1:
                //PlayerAbilities.instance.canAttack = false;
                //PlayerMovement.instance.canMove = false;
                //inputField.text = "";
                //string characters = "0123456789";
                //for (int i = 0; i < 5; i++)
                //{
                //    char randomChar = characters[UnityEngine.Random.Range(0, characters.Length)];
                //    Code += randomChar;
                //}
                //menuPanel.SetActive(true);
                //inputField.Select();
                //inputField.ActivateInputField();
                //headlineText.text = "Type this code: " + Code;
                Debug.Log("1");
                Destroy(currentTarget);
                break;

            case 2:
                //PlayerAbilities.instance.canAttack = false;
                //PlayerMovement.instance.canMove = false;
                //inputField.text = "";
                //string PurePainAndAgoni = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                //for (int i = 0; i < 5; i++)
                //{
                //    char randomChar = PurePainAndAgoni[UnityEngine.Random.Range(0, PurePainAndAgoni.Length)];
                //    Code += randomChar;
                //}
                //menuPanel.SetActive(true);
                //inputField.Select();
                //inputField.ActivateInputField();
                //headlineText.text = "Type this code: " + Code;
                Debug.Log("2");
                Destroy(currentTarget);
                break;

            case 3:
                //PlayerAbilities.instance.canAttack = false;
                //PlayerMovement.instance.canMove = false;
                //inputField.text = "";
                //string RapeAndGrape = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                //for (int i = 0; i < 50; i++)
                //{
                //    char randomChar = RapeAndGrape[UnityEngine.Random.Range(0, RapeAndGrape.Length)];
                //    Code += randomChar;
                //}
                //menuPanel.SetActive(true);
                //inputField.Select();
                //inputField.ActivateInputField();
                //headlineText.text = "Type this code: " + Code;
                Debug.Log("3");
                Destroy(currentTarget);
                break;
        }
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
