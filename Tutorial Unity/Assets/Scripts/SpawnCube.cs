using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//  ������Ʈ�� ���� ���� Ŭ���� (��ũ��Ʈ) �� �ְ� �ʹٸ� �� ���Ѿ� �� ����
//  1. Ŭ���� �̸��� ���� �̸��� ���ƾ� �Ѵ�. (class SpawnCube, �ַ�� Ž���� ������ SpawnCube.cs)
//  2. �ݵ�� MonoBehaviour �� ��� �޾ƾ� �Ѵ�. (class SpawnCube : MonoBehaviour)
public class SpawnCube : MonoBehaviour
{
    /*
    //  �ڵ带 �ۼ��� ��
    int A = 0;
    int B = 0;


    //  �ڿ� �Ұ�ȣ "(" ")" �� ���� �ֵ��� �Լ��̴�!
    //  Start() �Լ��� ����Ƽ�� ����Ǹ� �Լ� �ȿ� �ִ� �ڵ带 �����Ѵ�
    void Start()
    {
        //  Debug.Log ?
        //  ����Ƽ �ܼ� â�� �Ұ�ȣ �ȿ� �ִ� �༮�� ����Ѵ� (�����ش�)
        Debug.Log(A + B);
    }
    //  Ctrl + Shift + B ��ü ���� (���嵵��)
    //  �ڵ� �ۼ� �� ������ �ʷϻ��̸� ����� / ������� ���� �ȵ�
    */
    /*
    //  ����Ƽ �ν����� â ( Inspector) ���� �� Ŭ���� �ȿ� �ִ� ������ �����ϴ� ��!
    //  1.public ���λ縦 ���� �տ� �ٿ��ش�
    //  [SerializeField] ���λ縦 ���� �տ� �ٿ��ش�

    //  public �̶�� ���λ簡 ������ ������ �� Ŭ���� �ȿ� �ִ� 'A' ������ �������ų� �ٲ� �� �ִ�
    public int Count = 0;
    //  ó�� �ν����Ϳ��� ���Ǵ� ���� �̸� ������ �� �ִ�
    //  ���� ������Ʈ ���� ���� ������ �� �ִ�

    //  1.  ��ũ��Ʈ�� ������Ʈ �����
    private void Start()
    {
        //  ������Ʈ ����!
        //  ������ ���� new ��� ���λ縦 ���̰� ��� �ڷ���(); �Ұ�ȣ ���ش�
        //  ���ڿ��� ���� ���� �ݵ�� �ֵ���ǥ " ���� �����ؼ� �ֵ���ǥ�� ������ "
        //  �Ұ�ȣ�� �մ� �༮�� ��
        //  1. �޸� (,) �� ��� Ű���� �� �Ʒ� Arrow Ű�� ������ �߰� ����� �� �� �ִ�
        GameObject obj = new GameObject("���� ���� ù ������Ʈ");
        
        //  ���ڳ� ���ڸ� ���� ���� new �� ���� �ʰ� ���� �־��ش�
        
    }
    */
    /*
    void Start()
    {
        //  �ݺ��� ù ��°!
        //  for ��

        //  ���� ������Ʈ 3�� �����ϴ� ���
        for (int i = 0; i < 3; i++)
        {
            GameObject obj = new GameObject();
        }

        //  ���� ������Ʈ�� 5�� �����ϴ� ���
       for (int z = 0; z < 5; ++z)
        {
            GameObject o = new GameObject();
        }

       //   for ���ǻ���!
       //   1. for ( ù ���� ���� ������ �� int �Ӹ� �ƴ϶� �ٸ��͵� ���� �� �ִ�)
       //   2. for ( int ���� �� <- �� �ƹ��ų� �ص� ��� ����!)
       //   3. for ( int i = 0; i< ũ�� <- for ������ ũ����� ����Ǿ����� �ʴ´�!
       //   ex) for ( float dot = 0; ..), float (int num = 0; ...)
    }
    */
    /*
    void Start()
    {
        //  ���� ������Ʈ 5�� ����
        //  1.  ������Ʈ ���ٰ� ������� ��ȣ �̸��� �־�����
        //  2. "Node" ��� �̸����ٰ� ��ȣ�� �ο�����
        for (int i = 0; i< 5; i++)
        {
            //ToStrint() ? ���� ���� ���ڿ��� �������ִ� �Լ�
            new GameObject("Node_" + i.ToString());
        }

    }*/
    /*
    //  ť�긦 �����ϴ� ù ��° ���
    //  public �� ���̸� ����Ƽ���� ������ �����ϹǸ�
    //  �ν����� â ���� ���� ���� ������ ��ü�� ����Ƽ���� �־��ִ� ����� �̿�
    public GameObject CubePrefab;

    //  ť�긦 �����غ���!
    void Start()
    {
        //  �� ��� ���� �������� �̿��ؼ� ..
        //  GameObject.CreatePrimitive(PrimitiveType.Cube);


        // Instantiate ?  ��ü�� �����Ͽ� ���� �����ϴ� �Լ�
        for (int i = 0; i < 5; i++)
        {
            Instantiate(CubePrefab);
        }

    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            Instantiate(CubePrefab);
        }
        
    }
    */



}
