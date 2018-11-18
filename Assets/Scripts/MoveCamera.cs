using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {

    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    float tempo = 0;
    float tempoDash = 1;
    float tempoAux = 0;
    char ultimaTecla=' ';
    float speedX = 3.0f;
    float speedY = 3.0f;
    float yaw = 0.0f;
    float pitch = 0.0f;
    float speed = 0.05f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var up = new Vector3(0, 1, 0);
        var down = new Vector3(1, 0, 0);
        var k = new Vector3(transform.worldToLocalMatrix.m20,0,transform.worldToLocalMatrix.m22);
        k.Normalize();
        var i = new Vector3(transform.worldToLocalMatrix.m00,transform.worldToLocalMatrix.m01,transform.worldToLocalMatrix.m02);

        tempo += Time.deltaTime;

        yaw += speedX * Input.GetAxis("Mouse X");
        pitch -= speedY * Input.GetAxis("Mouse Y");
        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);

        if (Input.GetButtonDown("Fire1")) 
        {
            Fire();
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += k * speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += -k * speed;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            if (tempoAux != 0 && tempo - tempoAux <= tempoDash && ultimaTecla == 'a')
            {
                transform.position += -i * (speed * 30);
                tempoAux = 0;
                ultimaTecla = ' ';
            }
            else
            {
                tempoAux = tempo;
                ultimaTecla = 'a';
            }

        }


        if (Input.GetKey(KeyCode.A))
        {
            transform.position += -i * speed;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (tempoAux != 0 && tempo - tempoAux <= tempoDash && ultimaTecla=='d')
            {
                transform.position += i * (speed * 30);
                tempoAux = 0;
                ultimaTecla = ' ';
            }
            else
            {
                tempoAux = tempo;
                ultimaTecla = 'd';
            }

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += i * (speed);
        }

        
        if (Input.GetKey(KeyCode.LeftArrow)) transform.Rotate(up, -1, Space.World);
        if (Input.GetKey(KeyCode.RightArrow)) transform.Rotate(up, 1, Space.World);
        if (Input.GetKey(KeyCode.UpArrow)) transform.Rotate(down, -1, Space.Self);
        if (Input.GetKey(KeyCode.DownArrow)) transform.Rotate(down, 1, Space.Self);
      
    }
    void Fire()
    {
        var bullet = (GameObject)Instantiate(
            bulletPrefab,
            bulletSpawn.position,
            bulletSpawn.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 10;

        Destroy(bullet, 3.0f);
    }
    //implementando
    /*Preciso descobrir os keyCode, foi retornado os valores da tabela ASCII quando fiz um mapeamento 
     * mas não estão sendo aceito quando passo o código como parametro no Input.GetKey(até faz sentido
     * não aceitar, já que é esperado uma ação do teclado e estou passando um parametro que não é do Event).  
    */
    void dash()
    {

    }
}
