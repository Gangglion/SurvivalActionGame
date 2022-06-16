using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// 작성자 - 한승협
public class Player : MonoBehaviour
{
    Animator playerAnim;
    Rigidbody rigidbody;
    public Slider hpBar;
    public Scrollbar expBar;
    public Text level;
    float turnSpeed = 4.0f;
    private float xRotate = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        playerAnim = this.GetComponent<Animator>();
        rigidbody = this.GetComponent<Rigidbody>();
        transform.rotation = Quaternion.identity;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerStatusSet();
        PlayerMove();
        PlayerSight();
    }
    // 플레이어 이동
    public void PlayerMove()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(Vector3.forward * Time.deltaTime * PlayerStatus._PSpeed);
            playerAnim.SetBool("isForWRun", true);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(Vector3.back * Time.deltaTime * PlayerStatus._PSpeed);
            playerAnim.SetBool("isBackRun", true);
        }
        else
        {
            playerAnim.SetBool("isForWRun", false);
            playerAnim.SetBool("isBackRun", false);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(Vector3.left * Time.deltaTime * PlayerStatus._PSpeed);
            playerAnim.SetBool("isLeftRun", true);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(Vector3.right * Time.deltaTime * PlayerStatus._PSpeed);
            playerAnim.SetBool("isRightRun", true);
        }
        else
        {
            playerAnim.SetBool("isLeftRun", false);
            playerAnim.SetBool("isRightRun", false);
        }
    }
    //마우스 이동에 따른 플레이어 시야
    public void PlayerSight()
    {
        float yRotateSize = Input.GetAxis("Mouse X") * turnSpeed;
        float yRotate = transform.eulerAngles.y + yRotateSize;

        transform.eulerAngles = new Vector3(0, yRotate, 0);
    }
    // 플레이어 스텟 세팅
    public void PlayerStatusSet()
    {
        hpBar.value = PlayerStatus.PHp;
        level.text = PlayerStatus.PLevel.ToString();
        //Debug.Log("플레이어 공격력 : "+PlayerStatus.PAttack);
    }
    // 플레이어 피격
    public void PlayerHit(float eAttack)
    {
        if(PlayerStatus.PHp <=0)
        {
            SceneManager.LoadScene("03.GameOver");
        }
        else
        {
            PlayerStatus.PHp -= eAttack;
            hpBar.value = PlayerStatus.PHp;
            // hp bar size에 -10처리
        }
    }
    // 플레이어 경험치 증가
    public void ExpUp(float eExp)
    {
        PlayerStatus.PExp += eExp;
        expBar.size = PlayerStatus.PExp/100;
        if (PlayerStatus.PExp >= 100)
        {
            LevelUp();
        }
    }
    // 플레이어 레벨업
    public void LevelUp()
    {
        expBar.size = 0;
        PlayerStatus.PLevel += 1;
        PlayerStatus.PHp = 100;
        PlayerStatus._PSpeed *= 1.2f;
        PlayerStatus.PExp = 0;
        PlayerStatus.PAttack *= 1.5f;

        PlayerStatusSet();
    }
}
