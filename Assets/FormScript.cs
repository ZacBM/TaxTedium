using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FormScript : MonoBehaviour
{
    List<Transform> children;
    public List<GameObject> filledText;
    [SerializeField] List<string> textList;
    public float amountRisk;
    public string typeRisk;
    public float percentRisk;
    public float submittedPercentFloat;
    public float submittedAmountFloat;


    // Start is called before the first frame update
    void Start()
    {
        children = GetChildren(transform);

        foreach(Transform child in children)
        {
            Debug.Log(child.name);
        }
    }

    List<Transform> GetChildren(Transform parent)
    {
        List <Transform> children = new List<Transform>();
        foreach (Transform child in parent)
        {
            if(child.tag == "TextSlot")
            {
                children.Add(child);
            }
            
        }
        return children;
    }

    private void Update()
    {
        
    }

    public void FormChecker()
    {
        filledText.Clear();

        foreach (Transform child in children)
        {
            if (child.transform.childCount > 0)
            {
                filledText.Add(child.gameObject.transform.GetChild(0).gameObject);
            }
        }

        foreach (GameObject gameObject in filledText)
        {
            Debug.Log (gameObject.name);
        }

        List <string> textList = new List<string>();
        foreach (GameObject gameObject in filledText)
        {
            string newText = gameObject.GetComponentInChildren<TMP_Text>().text;
            textList.Add(newText);
        }

        foreach (var obj in textList)
        {
            Debug.Log(obj);
        }
        
    }

    public void RiskReward()
    {
        submittedAmountFloat = float.Parse(textList[0]);
        submittedPercentFloat = float.Parse(textList[2]);
        Debug.Log(submittedPercentFloat + submittedAmountFloat);
    }
}
