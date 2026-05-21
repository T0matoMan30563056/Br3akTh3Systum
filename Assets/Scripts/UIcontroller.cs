using UnityEngine;
using TMPro;
using NUnit.Framework.Internal.Commands;
public class UIcontroller : MonoBehaviour
{
    public static UIcontroller instance;
    public GameObject menuPanel;
    public TMP_InputField inputField;

    void Awake()
    {
        instance = this;
    }

    public void MinigameStart(TargetObject)
    {
        menuPanel.SetActive(true);
        inputField.text = "";
        inputField.Select();
        inputField.ActivateInputField();
    }
    public void MinigameStop()
    {
        menuPanel.SetActive(false);
    }

    public void CheckInput()
    {
        string typed = inputField.text;


        if (typed == "67")
        {
            MinigameStop();

        }
        else
        {
            Destroy(PlayerMovement.instance.gameObject);
           MinigameStop();

        }
    }
}
