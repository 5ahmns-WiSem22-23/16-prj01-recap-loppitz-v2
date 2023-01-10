
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CollectablesManager : MonoBehaviour
{
    [SerializeField]
    private CollectablesSpawn collectablesSpawn;

    private bool pickedUp;

    private int pickupCollect;
    [SerializeField]
    private Text counter;

    public bool plate1 = false;
    public bool plate2 = false;
    public bool plate3 = false;
    private bool plate4 = false;

    

    [SerializeField]
    private GameObject firstPlate;
    [SerializeField]
    private GameObject secondPlate;
    [SerializeField]
    private GameObject thirdPlate;
    [SerializeField]
    private GameObject finalPlate;


    
    void Start()
    {
        pickupCollect = 0;
        pickedUp = false;
        

        firstPlate.SetActive(false);
        secondPlate.SetActive(false);
        thirdPlate.SetActive(false);
        finalPlate.SetActive(false);
    }

    
    void Update()
    {
        counter.text = pickupCollect.ToString();
    }

   

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "plate_1" && !pickedUp)
        {
            
            pickedUp = true;
            plate1 = true;
           
            
        }

        if (other.name == "plate_2" && !pickedUp)
        {
            Destroy(collectablesSpawn.plates[1]);
            pickedUp = true;
            plate2 = true;
            
        }


        if (other.name == "plate_3" && !pickedUp)
        {
            Destroy(collectablesSpawn.plates[2]);
            pickedUp = true;
            plate3 = true;
            
        }

        if (other.name == "plate_4" && !pickedUp)
        {
            Destroy(collectablesSpawn.plates[3]);
            pickedUp = true;
            plate4 = true;
            
        }

        if (other.name == "goal" && pickedUp)
        {
            pickedUp = false;
           
            pickupCollect ++;

            if (plate1)
            {
                firstPlate.SetActive(true);
                plate1 = false;
            }
            if (plate2)
            {
                secondPlate.SetActive(true);
                plate2 = false;
            }
            if (plate3)
            {
                thirdPlate.SetActive(true);
                plate3 = false;
            }
            if (plate4)
            {
                finalPlate.SetActive(true);
                plate4 = false;
            }

            if (other.name == "goal" && pickupCollect > 3)
            {
                SceneManager.LoadScene("YouWon");
            }
        }

        
    }
}
