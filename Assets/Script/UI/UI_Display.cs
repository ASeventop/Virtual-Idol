using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
public class UI_Display : MonoBehaviour
{
    public static Subject<string> OnUIOpened = new Subject<string>();
    public static Subject<string> OnUIClosed = new Subject<string>();
    public GameObject root;
    public string id;
    public virtual void Open(){
        root.gameObject.SetActive(true);
        OnUIOpened.OnNext(id);
    }
    public virtual void Close(){
        root.gameObject.SetActive(false);
        OnUIClosed.OnNext(id);
    }
}
