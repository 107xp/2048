using UnityEngine;
using UnityEngine.UI;

public class NavigationButtonsController : MonoBehaviour
{
    public GameObject mainMenu_GO, inGame_GO, playStyle_GO;

    public Button rememberChoice_BT;

    public Sprite rememberChoiceSelected, rememberChoiceUnselected;

    public void googleLogin()
    {
        Debug.Log("Google login");
    }

    public void facebookLogin()
    {
        Debug.Log("Facebook login");
    }

    public void play()
    {
        if (PlayerPrefs.GetInt(Constants.MY_CHOISE_OF_GAME, 0) == 0)
        {
            //selecionar playstyle
            playStyle_GO.SetActive(true);
            setRememberChoiceSpriteButton(0);
        }
        else
        {
            //pular direto pra ingame
            inGame_GO.SetActive(true);
        }

        mainMenu_GO.SetActive(false);
    }

    public void createAMatch()
    {
        Debug.Log("Create a match");
    }

    public void settingsButton()
    {
        Debug.Log("Settings");
    }

    public void returnToMainMenu()
    {
        mainMenu_GO.SetActive(true);
        playStyle_GO.SetActive(false);
    }

    public void chooseSwipeMode()
    {
        inGame_GO.SetActive(true);
        playStyle_GO.SetActive(false);
    }

    public void chooseKeysMode()
    {
        inGame_GO.SetActive(true);
        playStyle_GO.SetActive(false);
    }

    public void exitGameplay()
    {
        inGame_GO.SetActive(false);
        mainMenu_GO.SetActive(true);
    }

    public void rememberMyChoice()
    {
        if (PlayerPrefs.GetInt(Constants.MY_CHOISE_OF_GAME, 0) == 0)
        {
            //selecionar para lembrar
            PlayerPrefs.SetInt(Constants.MY_CHOISE_OF_GAME, 1);
            setRememberChoiceSpriteButton(1);
        }
        else
        {
            //selecionar para não lembrar
            PlayerPrefs.SetInt(Constants.MY_CHOISE_OF_GAME, 0);
            setRememberChoiceSpriteButton(0);
        }
    }

    public void setRememberChoiceSpriteButton(int choice)
    {
        if (choice == 0)
        {
            //selecionar para lembrar
            rememberChoice_BT.GetComponent<Image>().sprite = rememberChoiceUnselected;
        }
        else
        {
            //selecionar para não lembrar
            rememberChoice_BT.GetComponent<Image>().sprite = rememberChoiceSelected;
        }
    }

    public void clearCache()
    {
        PlayerPrefs.DeleteAll();
    }
}
