using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PickItem : MonoBehaviour
{
    public AudioSource key;
    


    private int score = 0;
    public Text scoreText;

    public GameObject bonus;
    private int limit = 12;

    int itemCount;
    // Start is called before the first frame update
    void Start()
    {
         itemCount = GameObject.FindGameObjectsWithTag("Item").Length;
         scoreText.text = "Item x  " + score.ToString()+"/"+itemCount.ToString();
        bonus.SetActive(true);

        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider target)
    {
        if (target.gameObject.tag.Equals("Item"))
        {
            Destroy(target.gameObject);
            limit--;
            if (limit == 0)
            {
                bonus.SetActive(false);
            }
            score += 1;
            scoreText.text = "Item x  " + score.ToString() + "/" + itemCount.ToString();

            key.Play();
            
        }
        
    }
   
}
