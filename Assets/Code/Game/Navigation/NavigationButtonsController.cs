using UnityEngine;

public class NavigationButtonsController : MonoBehaviour
{
    public GameObject mainMenu_GO, inGame_GO, playStyle_GO;

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
}
