using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public static Stack<Vector3> pos = new Stack<Vector3>();
    public static Stack<Quaternion> Rotation = new Stack<Quaternion>();
    public static Stack<int> lastnum = new Stack<int>();
    public static bool turnOver = false;
    GameObject play;
    GameObject GameManager;

    private void Awake()
    {
        play = GameObject.Find("Play");
        GameManager = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        backwardMov();
        StartCoroutine(movPlayerForward());
    }



    IEnumerator movPlayerForward() //Movimiento de jugador SaveInputs.Inputs es de la lista y SaveInputs.InputsFunc es dela function
    {
        if (Play.play && SaveInputs.Inputs.Count > 0)
        {
            //desactivate During Runtime
            var buttons = GameObject.FindGameObjectsWithTag("Buttons");
            foreach (var button in buttons)
            {
                button.SetActive(false);
            }
            var cross = GameObject.Find("Cross");
            cross.SetActive(false);
            play.SetActive(false);
            var movs = GameObject.Find("ListOfMovs").GetComponentsInChildren<Image>();

            for (int i = 0; i < SaveInputs.Inputs.Count; i++)
            {
                if (SaveInputs.Inputs[i] == 1)
                {
                    lastnum.Push(1);
                    //saveLastPos
                    pos.Push(new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z));
                    Rotation.Push(Quaternion.Euler(gameObject.transform.rotation.eulerAngles.x, gameObject.transform.rotation.eulerAngles.y, gameObject.transform.rotation.eulerAngles.z));

                    gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z - 1);
                    gameObject.transform.Rotate(gameObject.transform.localRotation.x - 90, gameObject.transform.localRotation.y, gameObject.transform.localRotation.z, Space.World);
                    movs[i].sprite = null;
                    movs[i].color = new Color(0, 0, 0, 0);
                    AudioManager.Play = true;
                    AudioManager.playerMov = true;
                    AudioManager.pressButton = false;
                    yield return new WaitForSeconds(0.5f);
                }
                else if (SaveInputs.Inputs[i] == 2)
                {
                    //saveLastPos
                    lastnum.Push(2);
                    pos.Push(new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z));
                    Rotation.Push(Quaternion.Euler(gameObject.transform.rotation.eulerAngles.x, gameObject.transform.rotation.eulerAngles.y, gameObject.transform.rotation.eulerAngles.z));

                    gameObject.transform.position = new Vector3(gameObject.transform.position.x + 1, gameObject.transform.position.y, gameObject.transform.position.z);
                    gameObject.transform.Rotate(gameObject.transform.localRotation.x, gameObject.transform.localRotation.y, gameObject.transform.localRotation.z - 90, Space.World);
                    movs[i].sprite = null;
                    movs[i].color = new Color(0, 0, 0, 0);
                    AudioManager.Play = true;
                    AudioManager.playerMov = true;
                    AudioManager.pressButton = false;
                    yield return new WaitForSeconds(0.5f);
                }
                else if (SaveInputs.Inputs[i] == 3)
                {
                    //saveLastPos
                    lastnum.Push(4);
                    pos.Push(new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z));
                    Rotation.Push(Quaternion.Euler(gameObject.transform.rotation.eulerAngles.x, gameObject.transform.rotation.eulerAngles.y, gameObject.transform.rotation.eulerAngles.z));

                    gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z + 1);
                    gameObject.transform.Rotate(gameObject.transform.localRotation.x + 90, gameObject.transform.localRotation.y, gameObject.transform.localRotation.z, Space.World);
                    movs[i].sprite = null;
                    movs[i].color = new Color(0, 0, 0, 0);
                    AudioManager.Play = true;
                    AudioManager.playerMov = true;
                    AudioManager.pressButton = false;
                    yield return new WaitForSeconds(0.5f);
                }

                else if (SaveInputs.Inputs[i] == 4)
                {
                    //saveLastPos
                    lastnum.Push(3);
                    pos.Push(new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z));
                    Rotation.Push(Quaternion.Euler(gameObject.transform.rotation.eulerAngles.x, gameObject.transform.rotation.eulerAngles.y, gameObject.transform.rotation.eulerAngles.z));

                    gameObject.transform.position = new Vector3(gameObject.transform.position.x - 1, gameObject.transform.position.y, gameObject.transform.position.z);
                    gameObject.transform.Rotate(gameObject.transform.localRotation.x, gameObject.transform.localRotation.y, gameObject.transform.localRotation.z + 90, Space.World);
                    movs[i].sprite = null;
                    movs[i].color = new Color(0, 0, 0, 0);
                    AudioManager.Play = true;
                    AudioManager.playerMov = true;
                    AudioManager.pressButton = false;
                    yield return new WaitForSeconds(0.5f);
                }
                else if (SaveInputs.Inputs[i] == 5)
                {
                    if(SaveInputs.InputsFunc.Count != 0) {
                        for (int j = 0; j < SaveInputs.InputsFunc.Count; j++)
                        {
                            if (SaveInputs.InputsFunc[j] == 1)
                            {
                                lastnum.Push(1);
                                //saveLastPos
                                pos.Push(new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z));
                                Rotation.Push(Quaternion.Euler(gameObject.transform.rotation.eulerAngles.x, gameObject.transform.rotation.eulerAngles.y, gameObject.transform.rotation.eulerAngles.z));

                                gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z - 1);
                                gameObject.transform.Rotate(gameObject.transform.localRotation.x - 90, gameObject.transform.localRotation.y, gameObject.transform.localRotation.z, Space.World);
                                AudioManager.Play = true;
                                AudioManager.playerMov = true;
                                AudioManager.pressButton = false;
                                yield return new WaitForSeconds(0.5f);
                            }
                            else if (SaveInputs.InputsFunc[j] == 2)
                            {
                                //saveLastPos
                                lastnum.Push(2);
                                pos.Push(new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z));
                                Rotation.Push(Quaternion.Euler(gameObject.transform.rotation.eulerAngles.x, gameObject.transform.rotation.eulerAngles.y, gameObject.transform.rotation.eulerAngles.z));

                                gameObject.transform.position = new Vector3(gameObject.transform.position.x + 1, gameObject.transform.position.y, gameObject.transform.position.z);
                                gameObject.transform.Rotate(gameObject.transform.localRotation.x, gameObject.transform.localRotation.y, gameObject.transform.localRotation.z - 90, Space.World);
                                AudioManager.Play = true;
                                AudioManager.playerMov = true;
                                AudioManager.pressButton = false;
                                yield return new WaitForSeconds(0.5f);
                            }
                            else if (SaveInputs.InputsFunc[j] == 3)
                            {
                                //saveLastPos
                                lastnum.Push(4);
                                pos.Push(new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z));
                                Rotation.Push(Quaternion.Euler(gameObject.transform.rotation.eulerAngles.x, gameObject.transform.rotation.eulerAngles.y, gameObject.transform.rotation.eulerAngles.z));

                                gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z + 1);
                                gameObject.transform.Rotate(gameObject.transform.localRotation.x + 90, gameObject.transform.localRotation.y, gameObject.transform.localRotation.z, Space.World);
                                AudioManager.Play = true;
                                AudioManager.playerMov = true;
                                AudioManager.pressButton = false;
                                yield return new WaitForSeconds(0.5f);
                            }

                            else if (SaveInputs.InputsFunc[j] == 4)
                            {
                                //saveLastPos
                                lastnum.Push(3);
                                pos.Push(new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z));
                                Rotation.Push(Quaternion.Euler(gameObject.transform.rotation.eulerAngles.x, gameObject.transform.rotation.eulerAngles.y, gameObject.transform.rotation.eulerAngles.z));

                                gameObject.transform.position = new Vector3(gameObject.transform.position.x - 1, gameObject.transform.position.y, gameObject.transform.position.z);
                                gameObject.transform.Rotate(gameObject.transform.localRotation.x, gameObject.transform.localRotation.y, gameObject.transform.localRotation.z + 90, Space.World);
                                AudioManager.Play = true;
                                AudioManager.playerMov = true;
                                AudioManager.pressButton = false;
                                yield return new WaitForSeconds(0.5f);
                            }
                            movs[i].sprite = null;
                            movs[i].color = new Color(0, 0, 0, 0);
                        }
                    }
                    else
                    {
                        yield return new WaitForSeconds(0.5f);
                        movs[i].sprite = null;
                        movs[i].color = new Color(0, 0, 0, 0);
                    }

                }
                //limpiar de a 1 los movimientos
                movs[i].tag = "Texts";
            }
            Play.play = false;
            play.SetActive(true);
            cross.SetActive(true);
            foreach (var button in buttons)
            {
                button.SetActive(true);
            }
            lastnum.Clear();
            pos.Clear();
            Rotation.Clear();
            SaveInputs.Inputs.Clear();
            StopAllCoroutines();
            turnOver = true;
            GameManager.GetComponent<GameManager>().endTurn(turnOver); //si pierde reinicio el turno
        }

    }
    void backwardMov()
    {
        if (SaveInputs.deleteMovs)
        {
            if (pos.Count > 0 && Rotation.Count > 0)
            {
                gameObject.transform.position = pos.Pop();
                gameObject.transform.rotation = Rotation.Pop();
            }

            SaveInputs.deleteMovs = false;
        }
    }

}
