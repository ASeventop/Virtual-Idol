using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;
using System.Linq;

public class UI_Manager
{
    static UI_Manager instance;
    public static UI_Manager Instance{
        get{
            if(instance == null){}
                Initialize();
            return instance;
        }
    }
    static void Initialize(){
        instance = new UI_Manager();
        instance.ui_dictionary = new Dictionary<string, UI_Display>();
    }
    public Dictionary<string,UI_Display> ui_dictionary;
    public static void RegisterUI(UI_Display displayUI){
        if(!Instance.ui_dictionary.ContainsKey(displayUI.id))
            Instance.ui_dictionary.Add(displayUI.id,displayUI);
    }
    public static void UnregisterUI(UI_Display displayUI){
        if(Instance.ui_dictionary.ContainsKey(displayUI.id))
            Instance.ui_dictionary.Remove(displayUI.id);
    }

}
