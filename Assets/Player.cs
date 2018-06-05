using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

  public float Speed;

  // Use this for initialization
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    bool moveUp = Input.GetKey(KeyCode.W);
    bool moveDown = Input.GetKey(KeyCode.S);
    bool moveLeft = Input.GetKey(KeyCode.A);
    bool moveRight = Input.GetKey(KeyCode.D);

    if (moveUp)
      transform.position += new Vector3(0, Speed * Time.deltaTime, 0);

    if (moveDown)
      transform.position += new Vector3(0, -Speed * Time.deltaTime, 0);

    if (moveLeft)
      transform.position += new Vector3(-Speed * Time.deltaTime, 0, 0);

    if (moveRight)
      transform.position += new Vector3(Speed * Time.deltaTime, 0, 0);
  }
}
