using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[System.Serializable]
public class StoryBlock {
    [TextArea]
    public string story;
    [Header("Button 1")]
    public string option1Text;
    public int option1BlockId;
    [Header("Button 2")]
    public string option2Text;
    public int option2BlockId;
    [Header("Button 3")]
    public string option3Text;
    public int option3BlockId;

    public StoryBlock(string story, string option1Text = "", string option2Text = "", string option3Text = "", int option1BlockId = -1, int option2BlockId = -1, int option3BlockId = -1) {

        this.story = story;
        this.option1Text = option1Text;
        this.option2Text = option2Text;
        this.option3Text = option3Text;
        this.option1BlockId = option1BlockId;
        this.option2BlockId = option2BlockId;
        this.option3BlockId = option3BlockId;
    }
}

public class GameManager : MonoBehaviour {

    [Header("UI elements")]
    public TMP_Text mainText;
    public Button option1;
    public Button option2;
    public Button option3;

    public StoryBlock[] storyBlocks = {
        new StoryBlock("So you think you can dance?", "Hell nah", "Yep", "Fight me", 1, 2, 3),
        new StoryBlock("Why not?", "I never learned", "Dancing is for babies", "Fight me", 0, 0, 0),
        new StoryBlock("Let's dance battle", "Ok", "Sure!", "Fight me", 0, 0, 0),
        new StoryBlock("You wanna fight? Me?", "Yes, king", "No just kidding", "Fight me", 0, 0, 0),
        };

    StoryBlock currentBlock;

    void Start()
    {
       currentBlock = storyBlocks[0];
        DisplayBlock(currentBlock);
    }

    void DisplayBlock(StoryBlock block) {
        mainText.text = block.story;
        option1.GetComponentInChildren<TMP_Text>().text = block.option1Text;
        option2.GetComponentInChildren<TMP_Text>().text = block.option2Text;
        option3.GetComponentInChildren<TMP_Text>().text = block.option3Text;

        currentBlock = block;
    }

public void Button1Clicked() {
    if (currentBlock.option1BlockId != -1)
    {
        DisplayBlock(storyBlocks[currentBlock.option1BlockId]);
    }
}

public void Button2Clicked() {
    if (currentBlock.option2BlockId != -1)
    {
        DisplayBlock(storyBlocks[currentBlock.option2BlockId]);
    }
}

public void Button3Clicked() {
    if (currentBlock.option3BlockId != -1)
    {
        DisplayBlock(storyBlocks[currentBlock.option3BlockId]);
    }
}

}
