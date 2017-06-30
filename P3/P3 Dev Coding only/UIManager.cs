using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {

    private GameObject conversation;
    private ConversationManager conv;

    public void Awake() {
        conversation = GameObject.Find("ConversationManager");
        conv = conversation.GetComponent<ConversationManager>();
    }

    //Laat de correcte text zien dat af hangt van welke state de Enum is
    public void Update() {
        if(conv.personTalkingTo == ConversationManager.state.person1) {
        conv.currentVisibleLine.text = conv.conversationFiles[0].npcText[conv.currentLineNpcOne];
        }

        if (conv.personTalkingTo == ConversationManager.state.person2) {
            conv.currentVisibleLine.text = conv.conversationFiles[0].npcText[conv.currentLineNpcTwo];

        }
    }

    //Spreekt de "AnswerYes void in de ConvversationManager Class aan.
    public void Yes() {
        if(conv.canMakeChoices == true && conv.personTalkingTo == ConversationManager.state.person2) {
            Debug.Log("[You have responded with: YES]");
            conv.AnswerYes();

        }
    }

    //Spreekt de AwnserNo void in de ConvManager Class aan
    public void No() {
        if (conv.canMakeChoices == true && conv.personTalkingTo == ConversationManager.state.person2) {
            Debug.Log("[You have responded with: NO]");
            conv.AnswerNo();
        }
    }

    
    public void PersonOne() {
            conv.personTalkingTo = ConversationManager.state.person1;

    }
    
    public void PersonTwo() {
        conv.personTalkingTo = ConversationManager.state.person2;

    }
}
