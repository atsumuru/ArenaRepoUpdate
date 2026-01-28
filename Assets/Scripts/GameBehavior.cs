using UnityEngine;
using TMPro; 
using UnityEngine.UI;

public class GameBehavior : MonoBehaviour
{
    public Button WinButton;
    public int ItemsCollected

    {
        get { return _itemsCollected; }
        set
        {
            _itemsCollected = value;
            ItemText.text = "Items: " + Items;
 
            if (_itemsCollected >= MaxItems)
            {
                ProgressText.text = "You've found all the items!";
          
                // 3
                WinButton.gameObject.SetActive(true);
            }
            else
            {
                ProgressText.text = "Item found, only " + 
                    (MaxItems - _itemsCollected) + " more to go!";
            }
        }
    }

    public int MaxItems = 4;
    // 3
    public TMP_Text HealthText;     
    public TMP_Text ItemText;
    public TMP_Text ProgressText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ItemText.text += _itemsCollected;
        HealthText.text += _playerHP;
    }

    private int _itemsCollected = 0;
    public int Items
    {
        // 2
        get { return _itemsCollected; }
        // 3
        set { 
                _itemsCollected = value; 
                Debug.LogFormat("Items: {0}", _itemsCollected);
        }
    }
    // 4

    private int _playerHP = 10;
    public int HP 
    {
        get { return _playerHP; }
        set { 
                _playerHP = value; 
                Debug.LogFormat("Lives: {0}", _playerHP);
         }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
