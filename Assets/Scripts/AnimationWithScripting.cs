using UnityEngine;
using System.Collections;
public class AnimationWithScripting : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite[] walk;
    public Sprite[] idle;
    // public Sprite[] kick;
    public Sprite[] jump;
    public Sprite[] damage;
    public Sprite[] playerAttack;
    
    public Sprite[] ilikeLights;
    
    public bool isGreen;
    public bool isDamaged;
    void Start()
    {
        StartCoroutine(Idle());
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            StopAllCoroutines();
            StartCoroutine(Idle());
        }

        // if (Input.GetKeyDown(KeyCode.K))
        // {
        //     StopAllCoroutines();
        //     StartCoroutine(Kick());
        // }
        
        //walk
        if (Input.GetKeyDown(KeyCode.A))
        {
            StopAllCoroutines();
            StartCoroutine(Walk());
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            StopAllCoroutines();
            StartCoroutine(Walk());
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StopAllCoroutines();
            StartCoroutine(Jump());
        }
        if (isDamaged == true)
        {
            StopAllCoroutines();
            StartCoroutine(Damage());
        }
        if (isGreen == true)
        {
            StopAllCoroutines();
            StartCoroutine(IlikeLights());
        }

        if (Input.GetButtonDown("Fire1"))
        {
            StopAllCoroutines();
            StartCoroutine(PlayerAttack());
        }

    }
    IEnumerator Idle()
    {
        int i;
        i = 0;
        while (i < idle.Length)
        {
            spriteRenderer.sprite = idle[i];
            i++;
            yield return new WaitForSeconds(0.07f);
            yield return 0;
                
        }
        StartCoroutine(Idle());
    }
    IEnumerator Walk()
    {
        int i;
        i = 0;
        while (i < walk.Length)
        {
            spriteRenderer.sprite = walk[i];
            i++;
            yield return new WaitForSeconds(0.1f);
            yield return 0;
        }
        StartCoroutine(Idle());
        
    }

        IEnumerator Jump()
    {
        int i;
        i = 0;
        while (i < walk.Length)
        {
            spriteRenderer.sprite = jump[i];
            i++;
            yield return new WaitForSeconds(0.05f);
            yield return 0;
        }
        StartCoroutine(Idle());
        
    }

    // IEnumerator Kick()
    // {
    //     int i;
    //     i = 0;
    //     while (i < kick.Length)
    //     {
    //         spriteRenderer.sprite = kick[i];
    //         i++;
    //         yield return new WaitForSeconds(0.07f);
    //         yield return 0;

    //     }
    //     StartCoroutine(Kick());
    // }

            IEnumerator Damage()
    {
        int i;
        i = 0;
        while (i < damage.Length)
        {
            spriteRenderer.sprite = damage[i];
            i++;
            yield return new WaitForSeconds(0.05f);
            yield return 0;
        }
        StartCoroutine(Idle());
        
    }
    IEnumerator IlikeLights()
    {
        int i;
        i = 0;
        while (i < ilikeLights.Length)
        {
            spriteRenderer.sprite = ilikeLights[i];
            i++;
            yield return new WaitForSeconds(0.1f);
            yield return 0;
        }
        StartCoroutine(Idle());
        
    }

    
    IEnumerator PlayerAttack()
    {
        int i;
        i = 0;
        while (i < playerAttack.Length)
        {
            spriteRenderer.sprite = playerAttack[i];
            i++;
            yield return new WaitForSeconds(0.03f);
            yield return 0;
        }
        StartCoroutine(Idle());
        
    }



        private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "GreenLight")
        {  
            isGreen = true;
            StopAllCoroutines();
            StartCoroutine(IlikeLights());
            
        }

        if (collision.gameObject.tag == "enemy")
        {
            isDamaged = true;
            StopAllCoroutines();
            StartCoroutine(Damage());
            
        }

    }
        void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "enemy")
        {
            isDamaged = true;
            Debug.Log("damaged");
        }

    }

    void OnTriggerExit2D(Collider2D colission)
    {
        isGreen = false;
        
    }


    void OnCollisionExit2D(Collision2D col)
    {
        isDamaged = false;
    }

}


