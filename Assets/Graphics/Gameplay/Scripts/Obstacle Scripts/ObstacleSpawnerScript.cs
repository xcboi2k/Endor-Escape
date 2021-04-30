using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawnerScript : MonoBehaviour
{
    public GameObject[] obstacles;

    private List<GameObject> obstaclesForSpawn = new List<GameObject>();
    void Awake() {
        InitializeObstacles();
    }

    void Start() {
        StartCoroutine(SpawnRandomObstacle());
    }
    
    void InitializeObstacles(){
        int index = 0;
        for(int i = 0; i < obstacles.Length * 3; i++){
            GameObject obj = Instantiate(obstacles[index],new Vector3(transform.position.x, transform.position.y,0), Quaternion.identity) as GameObject;
            obstaclesForSpawn.Add(obj);
            obstaclesForSpawn[i].SetActive(false);
            index++;

            if(index == obstacles.Length){
                index = 0;
            }
        }
    }

    void Shuffle(){
        for(int i = 0; i < obstaclesForSpawn.Count; i++){
            GameObject temp = obstaclesForSpawn[i];
            int random = Random.Range(i, obstaclesForSpawn.Count);
            obstaclesForSpawn[i] = obstaclesForSpawn[random];
            obstaclesForSpawn[random] = temp;
        }
    }

    IEnumerator SpawnRandomObstacle(){
        yield return new WaitForSeconds(Random.Range(5f, 8f));

        int index = Random.Range(0, obstaclesForSpawn.Count);

        while(true){
            if(!obstaclesForSpawn[index].activeInHierarchy){
                obstaclesForSpawn[index].SetActive(true);
                obstaclesForSpawn[index].transform.position = new Vector3(transform.position.x, transform.position.y,0);
                break;
            }

            else{
                index = Random.Range(0, obstaclesForSpawn.Count);
            }
        }

        StartCoroutine(SpawnRandomObstacle());
    }
}
