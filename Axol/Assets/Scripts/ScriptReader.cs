using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ink.Runtime;
using TMPro;
using UnityEngine.SceneManagement;

public class ScriptReader : MonoBehaviour
{
    //Ink scripts loads
    [SerializeField] private TextAsset _Tutorial1;
    [SerializeField] private TextAsset _Tutorial2;
    [SerializeField] private TextAsset _Tutorial3;
    [SerializeField] private TextAsset _Tutorial4;
    [SerializeField] private TextAsset _Tutorial5;

    private Story _SciptHistory;
    private bool DialogPlaying;

    public Canvas DialogUI;
    public TMP_Text DialogBox;
    public TMP_Text NameBox;
    public Image SpriteRenderer1;
    public Image SpriteRenderer2;
    private int ItemCounter;
    [SerializeField]
    private GridLayoutGroup ChoiceGrid;
    [SerializeField]
    private Button Choicebtn;

    void Start()
    {
        ItemCounter = 0;
        LoadStory();
        if (_SciptHistory.canContinue)
        {
            DialogBox.text = _SciptHistory.Continue();
        }
        else
        {
            EndingDialog();
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))    //Checks if space is pushed so it can move on
        {
            DisplayNext();
        }
    }
    public void DialogTrigger(Collider other)//Displays dialog when picking up an item
    {
        if (other.tag == "Candle") {
            ItemCounter++;
            LoadStory();
        }
    }
    void LoadStory()    //Loads story and assigns extra functions to change name and images from the InkJson file
    {
        switch (ItemCounter)
        {
            case 0:
                _SciptHistory = new Story(_Tutorial1.text);
                PlayingDialog();
                break;
            case 1:
                _SciptHistory = new Story(_Tutorial2.text);
                PlayingDialog();
                break;
            case 2:
                _SciptHistory = new Story(_Tutorial3.text);
                PlayingDialog();
                break;
            case 3:
                _SciptHistory = new Story(_Tutorial4.text);
                PlayingDialog();
                break;
            case 4:
                _SciptHistory = new Story(_Tutorial5.text);
                PlayingDialog();
                break;
            case 5: //No segura si se queda
                break;
            default:
                DialogBox.text = "Error loading story";
                break;
        }
        _SciptHistory.BindExternalFunction("Name", (string charName) => ChangeName(charName));
        _SciptHistory.BindExternalFunction("Img", (string nameImg) => ChangeSprite(nameImg));
        _SciptHistory.BindExternalFunction("ImgR", (string nameImgR) => ChangeSprite2(nameImgR));
        _SciptHistory.BindExternalFunction("GameOver", (string gameOver) => GameOver(gameOver));
    }

    public void GameOver(string gameOver) //Loads a scene in unity with the game over message
    {
        Debug.Log(gameOver);
        if (gameOver == "GAME OVER")
        {
            SceneManager.LoadScene("GameOver", LoadSceneMode.Additive);//Needs scene called "GameOVer",will display it
        }
    }

    void PlayingDialog() //Notifies that a dialog is running, and enables the dialog panel
    {
        DialogPlaying = true;
        DialogUI.enabled = true;
    }
    void EndingDialog()//Notifies end of story and hides all;
    {
        DialogPlaying = false;
        DialogUI.enabled = false;//Disables all of the canvas
    }
    public void ChangeSprite(string nameImg) //Changes the left image according to the name in ink file
    {
        if (nameImg == "") { SpriteRenderer1.enabled = false; }//Disables img if theres nothing written
        else
        {
            SpriteRenderer1.enabled = true;
            SpriteRenderer1.sprite = Resources.Load<Sprite>(nameImg);
            Debug.Log($"Characters/{nameImg}.png");
        }
    }
    public void ChangeSprite2(string nameImgR) //Changes the right image according to the name in ink file
    {
        if (nameImgR == "") { SpriteRenderer2.enabled = false; }
        else
        {
            SpriteRenderer2.enabled = true;
            SpriteRenderer2.sprite = Resources.Load<Sprite>(nameImgR);
        }
    }
    public void DisplayNext()//Shows either next dialog line or the buttons with choices
    {
        if (_SciptHistory.canContinue)//Checks if more dialog lines are aviable
        {
            string Text = _SciptHistory.Continue();   //Gets next dialog
            Text = Text?.Trim();  //Delete unnecesary space
            DialogBox.text = Text; //Show dialog in the Dialog Box
        }
        else if (_SciptHistory.currentChoices.Count > 0) //Checks if the next line is a choice
        {
            DisplayChoices();
        }
        else
        {
            //End of the entire story written in ink file
            EndingDialog();
            Debug.Log("History Finished"); 
        }
    }
    private void DisplayChoices()
    {
        if (ChoiceGrid.GetComponentsInChildren<Button>().Length > 0) { return; } //Checks if a button is in the grid

        for (int i = 0; i < _SciptHistory.currentChoices.Count; i++) //Creates a button for each choice and writes the text on them
        {
            var choice = _SciptHistory.currentChoices[i];
            var btn = Createchoicebtn(choice.text); 

            btn.onClick.AddListener(() => ClickBtnOpcion(choice));
        }
    }
    Button Createchoicebtn(string choice)
    {
        //Creates a clone of the prefab button
        var choicebtn = Instantiate(Choicebtn);
        choicebtn.transform.SetParent(ChoiceGrid.transform, false);

        //Changes the text on the button
        var btntxt = choicebtn.GetComponentInChildren<TMP_Text>();
        btntxt.text = choice;

        return choicebtn;
    }
    void ClickBtnOpcion(Choice choice) //When a button gets clicked the button gets removed and the story continues
    {
        _SciptHistory.ChooseChoiceIndex(choice.index);
        RefreshGrid();
        DisplayNext();
    }
    void RefreshGrid()//Deletes buttons
    {
        if (ChoiceGrid != null)
        {
            foreach (var btn in ChoiceGrid.GetComponentsInChildren<Button>())
            {
                Destroy(btn.gameObject);
            }
        }
    }
    public void ChangeName(string name)//Changes the name according to the ink file
    {
        string Speaker = name;  
        NameBox.text = Speaker;
    }
}
