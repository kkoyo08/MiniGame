using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetrisBlock : MonoBehaviour
{
    private float previousTime;
    public float fallTime = 1.0f;
    public static int height = 20;
    public static int width = 10;
    public Vector3 rotationPoint;
    public static Transform[,] grid = new Transform[width, height];

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    //블럭 좌우이동
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-1, 0, 0);
            if (!ValidMove())
            {
                transform.position -= new Vector3(-1, 0, 0);
            }

        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += new Vector3(1, 0, 0);
            if (!ValidMove())
            {
                transform.position -= new Vector3(1, 0, 0);
            }
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //회전하기
            transform.RotateAround(transform.TransformPoint(rotationPoint), new Vector3(0, 0, 1), 90);
            if (!ValidMove())
            {
                transform.RotateAround(transform.TransformPoint(rotationPoint), new Vector3(0, 0, 1), -90);
            }
        }

        // 블럭 떨어트리기
        if (Time.time - previousTime > (Input.GetKey(KeyCode.DownArrow) ? fallTime / 10 : fallTime))
        {
            transform.position += new Vector3(0, -1, 0);
            if (!ValidMove())
            {
                transform.position -= new Vector3(0, -1, 0);
                AddToGrid();
                this.enabled = false;
                FindObjectOfType<spawnertetris>().NewTetris();
            }
            previousTime = Time.time;
        }
    }

    void CheckForLines()
    {
        for (int i = height - 1; i >= 0; i--) // 테트리스 블록을 맨 윗줄부터 아래까지 검색한다.
        {
            if (HasLine(i))  // 줄이 블록으로 꽉차 있을경우
            {
                DeleteLine(i);  // 그 줄을 삭제하고
                RowDown(i);  // 줄을 한칸 내린다. 
            }
        }
    }

    bool HasLine(int i)  // 줄이 블록으로 꽉 차 있는지 확인하기
    {
        for (int j = 0; j < width; j++)  //줄을 0~9까직 검색한다.
        {
            if (grid[j, i] == null)  // 비어 있다면 
                return false;        //  false를 리턴한다. 
        }
        return true;  //줄이 꽉 차 있다면 true를 리턴한다. 
    }

    void DeleteLine(int i)  // 줄을 삭제한다. 
    {
        for (int j = 0; j < width; j++)
        {
            Destroy(grid[j, i].gameObject);
            grid[j, i] = null;
        }
    }

    void RowDown(int i)  // 줄을 아래로 내린다.
    {
        for (int y = i; y < height; y++)
        {
            for (int j = 0; j < width; j++)
            {
                if (grid[j, y] != null) // 윗줄을 아랫줄로 복사하는 과정이다.
                {
                    grid[j, y - 1] = grid[j, y];
                    grid[j, y] = null;
                    grid[j, y - 1].transform.position -= new Vector3(0, 1, 0);
                }
            }
        }
    }

    void AddToGrid()
    {
        foreach (Transform children in transform)
        {
            int roundX = Mathf.RoundToInt(children.transform.position.x);
            int roundY = Mathf.RoundToInt(children.transform.position.y);

            grid[roundX, roundY] = children;
        }
    }

    //백그라운드 설정
    bool ValidMove()
    {
        foreach (Transform children in transform)
        {
            int roundX = Mathf.RoundToInt(children.transform.position.x);
            int roundY = Mathf.RoundToInt(children.transform.position.y);

            if (roundX < 0 || roundX >= width || roundY < 0 || roundY >= height)
            {
                return false;
            }

            if (grid[roundX, roundY] != null)
                return false;
        }

        return true;

    }
}