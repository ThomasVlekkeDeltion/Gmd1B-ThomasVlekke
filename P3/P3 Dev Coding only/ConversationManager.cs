using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ConversationManager : MonoBehaviour {

    public List<Conversation> conversationFiles = new List<Conversation>();
    public List<string> npcYouAreTalkingTo = new List<string>();
    public List<int> questionNumbers = new List<int>();

    public state personTalkingTo;

    public enum state {person1, person2}

    public int addUp;
    public int dontAddUp;
    public int doAddUp;
    public int currentLineNpcOne;
    public int currentLineNpcTwo;

    public bool canMakeAChoices;
    public bool questionArrived;
    public bool npcTwoNoSkip;
  

    public Text currentVisibleLine;

    public void Update() {
        
        
       if (personTalkingTo == state.person1) {
            currentVisibleLine.text = conversationFiles[0].npcText[currentLineNpcOne];
        }

        if (personTalkingTo == state.person2) {
            currentVisibleLine.text = conversationFiles[1].npcText[currentLineNpcTwo];
        }

        QuestionsCheck();

    }

    //Zet de "currentline" op een heel nieuwe Array route.
    public void AnswerNo() {
        currentLineNpcOne = currentLineNpcTwo;
        currentLineNpcOne += dontAddUp;
        currentLineNpcTwo += dontAddUp;
        npcTwoNoSkip = true;

    }

    public void AnswerYes() {
        currentLineNpcOne = currentLineNpcTwo;
        currentLineNpcOne += doAddUp;
        currentLineNpcTwo += doAddUp;
        npcTwoNoSkip = true;

    }

    //Skips naar de volgende lines in de string list
    public void Next() {
        if(questionArrived == false) {
        if (personTalkingTo == state.person1) {
            currentLineNpcOne = currentLineNpcOne + addUp;
        }

            if (personTalkingTo == state.person2 && npcTwoNoSkip == false) {
                currentLineNpcTwo = currentLineNpcTwo + addUp;
            }
        }
    }

    //Checks welke lines vragen zijn
    public void QuestionsCheck() {
        switch (currentLineNpcTwo) {
            case 2:
            case 10:
                canMakeAChoices = true;
                npcTwoNoSkip = true;
                questionArrived = true;
                break;

            default:
                questionArrived = false;
                npcTwoNoSkip = false;
                canMakeAChoices = false;
                break;
        }
    }
}
