using UnityEngine;
using TMPro;
using Microlight.MicroBar;


public class car_second_script1 : MonoBehaviour
{
    //***for car***

    private float score;

    //***Weapon Selection***

    public TextMeshProUGUI Text;
    public GameObject endgame;
    private GameObject randomPower;
    public GameObject[] powers;
    [SerializeField] MicroBar health_Bar;
    public float time = 0f;
    

    
    [Header("icon_animation")]
    public Animator shield_ani;
    public Animator heal_ani;
    public Animator Gun_ani;
    public Animator speed_ani;
    public Animator ring_ani;

    private bool isPowerActive = false;
    
    
   
    void Update()
    {
        //*************Timer For Shield************************
        if (isPowerActive == true)
        {
            
            time += Time.deltaTime;
            if (time >= 5f)
            {
                
                randomPower.GetComponent<Collider>().enabled = false;
                randomPower.GetComponent<MeshRenderer>().enabled = false;
                
                isPowerActive = false;
                time = 0F;
            }

        }
        else 
        {
            time = 0f;
        }

        if (HP == 0)
        {
            endgame.SetActive(true);
            gameObject.GetComponentInChildren<Renderer>().enabled = false;
            gameObject.GetComponent<PrometeoCarController>().enabled = false;
            Time.timeScale = 0f;
            
        }

        shield_ani.SetBool("shield_off", true);
        heal_ani.SetBool("heal_off", true);
        Gun_ani.SetBool("gun_off", true);
        speed_ani.SetBool("speed_off", true);
        ring_ani.SetBool("ring_off", true);
       

    }
    private void OnCollisionEnter(Collision collision)
    {
        switch(collision.gameObject.tag)
        {
            case "crate":
                generatePower();
            break;

            case "empty":
                
                endgame.SetActive(true);
            break;

            case "enemy":
                print("boom");
                damage();
            break;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "Coin":
                score += 1;
                print(score);
                Text.text = score.ToString();
                Destroy(other.gameObject);
                
                break;
        }
    }

    void generatePower()
    {
        randomPower = powers[Random.Range(0, powers.Length - 1)];
        
        //randomPower.GetComponent<gun>().enabled = true;
        print(randomPower.ToString());
        switch(randomPower.tag)
        {
            case "shield":
                randomPower.GetComponent<Collider>().enabled = true;
                randomPower.GetComponent<MeshRenderer>().enabled = true;
                shield_ani.SetTrigger("shield_on");
                isPowerActive = true;               
            break;


            case "heal":
                heal();
                heal_ani.SetTrigger("heal_on");
            break;


            case "gun":
                randomPower.GetComponent<gun>().enabled = true;
                Gun_ani.SetTrigger("gun_on");
            break;

            case "ring":
                randomPower.GetComponentInChildren<Collider>().enabled = true;
                randomPower.GetComponentInChildren<MeshRenderer>().enabled = true;
                ring_ani.SetTrigger("ring_on");
                isPowerActive = true;
            break;


            case "speed":
                GetComponent<Rigidbody>().velocity *= 1.4f;
                speed_ani.SetTrigger("speed_on");
            break;

            
        }
    }

    //*********************************************HEALTH***************************************************

    
    const float Max_Hp = 100f;
    float _hp = Max_Hp;
    float HP
    {
        get => _hp;
        set
        {
            bool isHeal = value > _hp;
            _hp = Mathf.Clamp(value, 0f, Max_Hp);
            if (isHeal)
            {
                health_Bar.UpdateBar(_hp, UpdateAnim.Heal);
            }

            else 
            {
                health_Bar.UpdateBar(_hp, UpdateAnim.Damage);
            }
            
        }
    }

    void Start()
    {
        health_Bar.Initialize(Max_Hp);
        Time.timeScale = 1.0f;
    }


    public void damage()
    {
        HP -= 20f;
    }

    public void heal()
    {
        HP += 70f;
    }

    //**********************************************************************************************************



    
}