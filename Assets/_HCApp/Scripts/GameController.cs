using UnityEngine;

public class GameController : MonoBehaviour
{
    // public GameObject DestroyBaseBlue;
    // public GameObject DestroyBaseRed;
    //
    // public GameObject WinUIBlue;
    // public GameObject WinUIRed;
    //
    // public Transform Parent;
    // public GameObject EndGameSound;
    // public PlayerScores PlayerOne;
    // public PlayerScores PlayerTwo;
    //
    // // [Inject] 
    // // private IPrefabFactory prefabFactory;
    //
    // public enum GameStates { Idle, Start, FirstRound, SecondRound, ThirdRound, FirstPlayerWin, SecondPlayerWin, Draw, MessageForPlayers}
    //
    // private int firstPlayerScore = 0;
    // private int secondPlayerScore = 0;
    //
    // public AudioSource EndRound;
    //
    // public GameObject Ball;
    //
    // public GameObject FirstPlayerBlocks;
    // public GameObject SecondPlayerBlocks;
    //
    // private Vector3 firstPlayerPosition = new Vector3(0f, 0f, -8.95f);
    // private Vector3 secondPlayerPosition = new Vector3(0f, 0f, 8.95f);
    //
    // public GameStates currentState;
    //
    // private List<GameObject> spawners = new List<GameObject>();
    // private List<GameObject> balls = new List<GameObject>();
    // public UIController uiController;
    //
    // public float RoundTime = 30f;
    // private float timer;
    //
    // private int buttonPressedToStart = 0;
    // private bool roundStart = false;
    //
    // private bool firstPlayerReady = false;
    // private bool secondPlayerReady = false;
    //
    // private int roundWinsBlue = 0;
    // private int roundWinsRed = 0;
    //
    // private void Start()
    // {
    //     WinUIBlue.SetActive(false);
    //     WinUIRed.SetActive(false);
    //     
    //     timer = RoundTime;
    //     currentState = GameStates.Idle;
    //     uiController.FirstActivateButtonPressed += FirstPlayerActivateGame;
    //     uiController.SecondActivateButtonPressed += SecondPlayerActivateGame;
    // }
    //
    // private void Update()
    // {
    //     switch (currentState)
    //     {
    //         case GameStates.Idle:
    //             break;
    //         case GameStates.Start:
    //             roundWinsBlue = 0;
    //             roundWinsRed = 0;
    //             PlayerOne.ResetUI();
    //             PlayerTwo.ResetUI();
    //             WinUIBlue.SetActive(false);
    //             WinUIRed.SetActive(false);
    //             break;
    //         case GameStates.FirstRound:
    //             break;
    //         case  GameStates.FirstPlayerWin:
    //             WinUIBlue.SetActive(true);
    //             EnterIdle();
    //             break;
    //         case GameStates.SecondPlayerWin:
    //             WinUIRed.SetActive(true);
    //             EnterIdle();
    //             break;
    //     }
    //
    //     if (currentState == GameStates.Start)
    //     {
    //         StartCoroutine(nameof(StartGame));
    //     }
    //
    //     if (roundStart == true)
    //     {
    //         timer -= Time.deltaTime;
    //
    //         if (timer <= 3)
    //         {
    //             if(!EndRound.isPlaying)
    //                 EndRound.Play();
    //         }
    //         if (timer <= 0)
    //         {
    //             NextRound();
    //             timer = RoundTime;
    //         }
    //     }
    // }
    //
    // public void NextRound()
    // {
    //     timer = RoundTime;
    //     if (currentState == GameStates.FirstRound)
    //     {
    //         if (PlayerOne.GetScores() > PlayerTwo.GetScores())
    //             roundWinsBlue++;
    //         else if (PlayerOne.GetScores() < PlayerTwo.GetScores())
    //             roundWinsRed++;
    //         else
    //         {
    //             roundWinsBlue++;
    //             roundWinsRed++;
    //         }
    //             
    //         RestartGame();
    //         print("Round 2");
    //         currentState = GameStates.SecondRound;
    //     }
    //         
    //     else if (currentState == GameStates.SecondRound)
    //     {
    //         if (PlayerOne.GetScores() > PlayerTwo.GetScores())
    //             roundWinsBlue++;
    //         else if (PlayerOne.GetScores() < PlayerTwo.GetScores())
    //             roundWinsRed++;
    //         else
    //         {
    //             roundWinsBlue++;
    //             roundWinsRed++;
    //         }
    //
    //         if (roundWinsBlue == 2)
    //         {
    //             currentState = GameStates.FirstPlayerWin;
    //             EnterIdle();
    //             return;
    //         }
    //         if (roundWinsRed == 2)
    //         {
    //             currentState = GameStates.SecondPlayerWin;
    //             EnterIdle();
    //             return;
    //         }
    //         
    //         RestartGame();
    //
    //         currentState = GameStates.ThirdRound;
    //     }
    //         
    //     else if (currentState == GameStates.ThirdRound)
    //     {
    //         if (PlayerOne.GetScores() > PlayerTwo.GetScores())
    //             roundWinsBlue++;
    //         else if (PlayerOne.GetScores() < PlayerTwo.GetScores())
    //             roundWinsRed++;
    //         else
    //         {
    //             roundWinsBlue++;
    //             roundWinsRed++;
    //         }
    //
    //         if (roundWinsBlue == 2)
    //         {
    //             currentState = GameStates.FirstPlayerWin;
    //             EnterIdle();
    //             return;
    //         }
    //         if (roundWinsRed == 2)
    //         {
    //             currentState = GameStates.SecondPlayerWin;
    //             EnterIdle();
    //         }
    //     }
    //     
    //     else
    //     {
    //         print("Draw!!!");
    //         currentState = GameStates.Draw;
    //         roundStart = false;
    //         PlayerOne.ResetScores();
    //         PlayerTwo.ResetScores();
    //         EndGameSound.GetComponent<AudioSource>().Play();
    //         EnterIdle();
    //     }
    // }
    //
    // public void RoundWin(int ID)
    // {
    //     if (ID == 1)
    //     {
    //         roundWinsBlue++;
    //         if (roundWinsBlue >= 2)
    //         {
    //             currentState = GameStates.FirstPlayerWin;
    //             
    //         }
    //         else
    //         {
    //             StartCoroutine(nameof(RedBaseDestroy));
    //         }
    //     }
    //
    //     else
    //     {
    //         roundWinsRed++;
    //         if (roundWinsRed >= 2)
    //         {
    //             currentState = GameStates.SecondPlayerWin;
    //             
    //         }
    //         else
    //         {
    //             StartCoroutine(nameof(BlueBaseDestroy));
    //         }
    //     }
    // }
    //
    // private IEnumerator RedBaseDestroy()
    // {
    //     roundStart = false;
    //     DestroyBaseBlue.SetActive(true);
    //     foreach (var VARIABLE in balls)
    //     {
    //         VARIABLE.SetActive(false);
    //     }
    //     yield return new WaitForSeconds(3f);
    //     foreach (var VARIABLE in balls)
    //     {
    //         VARIABLE.SetActive(true);
    //     }
    //     Ball.SetActive(true);
    //     DestroyBaseBlue.SetActive(false);
    //     NextRound();
    //     roundStart = true;
    // }
    //
    // private IEnumerator BlueBaseDestroy()
    // {
    //     roundStart = false;
    //     DestroyBaseRed.SetActive(true);
    //     print("Ваша база уничтожена");
    //     foreach (var VARIABLE in balls)
    //     {
    //         VARIABLE.SetActive(false);
    //     }
    //     yield return new WaitForSeconds(3f);
    //     print("ui disable");
    //     foreach (var VARIABLE in balls)
    //     {
    //         VARIABLE.SetActive(true);
    //     }
    //     DestroyBaseRed.SetActive(false);
    //     NextRound();
    //     roundStart = true;
    // }
    //
    // private void EnterIdle()
    // {
    //     uiController.FirstActivateButtonPressed += FirstPlayerActivateGame;
    //     uiController.SecondActivateButtonPressed += SecondPlayerActivateGame;
    //     currentState = GameStates.Idle;
    //     DestroySpawners();
    //     DestroyBalls();
    //     uiController.ActivateButtons();
    //
    //     firstPlayerReady = false;
    //     secondPlayerReady = false;
    //     
    //     EndGameSound.GetComponent<AudioSource>().Play();
    //     
    //     PlayerOne.ResetScores();
    //     PlayerTwo.ResetScores();
    //     
    //     roundStart = false;
    //     timer = RoundTime;
    // }
    // public IEnumerator StartGame()
    // {
    //     currentState = GameStates.FirstRound;
    //     
    //     uiController.ButtonsDisable();
    //     yield return new WaitForSeconds(1f);
    //     
    //     roundStart = true;
    //     SpawnBlocks();
    //
    //     uiController.FirstActivateButtonPressed -= FirstPlayerActivateGame;
    //     uiController.SecondActivateButtonPressed -= SecondPlayerActivateGame;
    //     
    // }
    //
    // private void FirstPlayerActivateGame()
    // {
    //     if (!firstPlayerReady)
    //     {
    //         buttonPressedToStart++;
    //         firstPlayerReady = true;
    //         if (buttonPressedToStart >= 2)
    //         {
    //             currentState = GameStates.Start;
    //             buttonPressedToStart = 0;
    //         }
    //     }
    // }
    // private void SecondPlayerActivateGame()
    // {
    //     if (!secondPlayerReady)
    //     {
    //         buttonPressedToStart++;
    //         secondPlayerReady = true;
    //         if (buttonPressedToStart >= 2)
    //         {
    //             currentState = GameStates.Start;
    //             buttonPressedToStart = 0;
    //         }
    //     }
    //
    // }
    //
    // [ContextMenu("RestartGame")]
    // private void RestartGame()
    // {
    //     timer = RoundTime;
    //     DestroySpawners();
    //     DestroyBalls();
    //     SpawnBlocks();
    //     
    // }
    //
    // private void SpawnBlocks()
    // {
    //     //currentState = GameStates.FirstRound;
    //     
    //     if (Parent != null)
    //     {
    //         var firstSpawner = prefabFactory.Create(FirstPlayerBlocks, firstPlayerPosition, Quaternion.identity, Parent);
    //         var secondSpawner = prefabFactory.Create(SecondPlayerBlocks, secondPlayerPosition, Quaternion.identity, Parent);
    //     
    //         var ball = prefabFactory.Create(Ball, new Vector3(0f, 1.5f, 0f), Quaternion.identity, Parent);
    //         
    //         balls.Add(ball);
    //         spawners.Add(firstSpawner);
    //         spawners.Add(secondSpawner);
    //     }
    // }
    //
    // private void DestroySpawners()
    // {
    //     foreach (var go in spawners)
    //     {
    //         Destroy(go, 0.001f);
    //     }
    //     spawners.Clear();
    // }
    //
    // private void DestroyBalls()
    // {
    //     foreach (var go in balls)
    //     {
    //         Destroy(go, 0.001f);
    //     }
    //     balls.Clear();
    // }
}
