using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RottoRandom : MonoBehaviour {


    public int m;
    public int[] a;
    public UILabel[] count;
	void Start ()
    {

    }
    public void RottoClick1()
    {
        for (int i = 0; i < 6; i++)
        {
            m = Random.Range(1, 46);
            a[i] = m;
            if (a[1] == a[0])
            {
                m = Random.Range(1, 46);
                a[i] = m;
            }
            if (a[2] == a[1] || a[2] == a[0])
            {
                m = Random.Range(1, 46);
                a[i] = m;
            }
            if (a[3] == a[0] || a[3] == a[1] || a[3] == a[2])
            {
                m = Random.Range(1, 46);
                a[i] = m;
            }
            if (a[4] == a[0] || a[4] == a[1] || a[4] == a[2] || a[4] == a[3])
            {
                m = Random.Range(1, 46);
                a[i] = m;
            }
            if (a[5] == a[0] || a[5] == a[1] || a[5] == a[2] || a[5] == a[3] || a[5] == a[4])
            {
                m = Random.Range(1, 46);
                a[i] = m;
            }
        }
        count[0].text = a[0].ToString() +" , "+ a[1].ToString() + " , " + a[2].ToString() + " , " + a[3].ToString() + " , " + a[4].ToString() + " , " + a[5].ToString();
    }
    public void RottoClick2()
    {
        for (int i = 0; i < 6; i++)
        {
            m = Random.Range(1, 46);
            a[i] = m;
            if (a[1] == a[0])
            {
                m = Random.Range(1, 46);
                a[i] = m;
            }
            if (a[2] == a[1] || a[2] == a[0])
            {
                m = Random.Range(1, 46);
                a[i] = m;
            }
            if (a[3] == a[0] || a[3] == a[1] || a[3] == a[2])
            {
                m = Random.Range(1, 46);
                a[i] = m;
            }
            if (a[4] == a[0] || a[4] == a[1] || a[4] == a[2] || a[4] == a[3])
            {
                m = Random.Range(1, 46);
                a[i] = m;
            }
            if (a[5] == a[0] || a[5] == a[1] || a[5] == a[2] || a[5] == a[3] || a[5] == a[4])
            {
                m = Random.Range(1, 46);
                a[i] = m;
            }
        }
        count[1].text = a[0].ToString() + " , " + a[1].ToString() + " , " + a[2].ToString() + " , " + a[3].ToString() + " , " + a[4].ToString() + " , " + a[5].ToString();
    }
    public void RottoClick3()
    {
        for (int i = 0; i < 6; i++)
        {
            m = Random.Range(1, 46);
            a[i] = m;
            if (a[1] == a[0])
            {
                m = Random.Range(1, 46);
                a[i] = m;
            }
            if (a[2] == a[1] || a[2] == a[0])
            {
                m = Random.Range(1, 46);
                a[i] = m;
            }
            if (a[3] == a[0] || a[3] == a[1] || a[3] == a[2])
            {
                m = Random.Range(1, 46);
                a[i] = m;
            }
            if (a[4] == a[0] || a[4] == a[1] || a[4] == a[2] || a[4] == a[3])
            {
                m = Random.Range(1, 46);
                a[i] = m;
            }
            if (a[5] == a[0] || a[5] == a[1] || a[5] == a[2] || a[5] == a[3] || a[5] == a[4])
            {
                m = Random.Range(1, 46);
                a[i] = m;
            }
        }
        count[2].text = a[0].ToString() + " , " + a[1].ToString() + " , " + a[2].ToString() + " , " + a[3].ToString() + " , " + a[4].ToString() + " , " + a[5].ToString();
    }
    public void RottoClick4()
    {
        for (int i = 0; i < 6; i++)
        {
            m = Random.Range(1, 46);
            a[i] = m;
            if (a[1] == a[0])
            {
                m = Random.Range(1, 46);
                a[i] = m;
            }
            if (a[2] == a[1] || a[2] == a[0])
            {
                m = Random.Range(1, 46);
                a[i] = m;
            }
            if (a[3] == a[0] || a[3] == a[1] || a[3] == a[2])
            {
                m = Random.Range(1, 46);
                a[i] = m;
            }
            if (a[4] == a[0] || a[4] == a[1] || a[4] == a[2] || a[4] == a[3])
            {
                m = Random.Range(1, 46);
                a[i] = m;
            }
            if (a[5] == a[0] || a[5] == a[1] || a[5] == a[2] || a[5] == a[3] || a[5] == a[4])
            {
                m = Random.Range(1, 46);
                a[i] = m;
            }
        }
        count[3].text = a[0].ToString() + " , " + a[1].ToString() + " , " + a[2].ToString() + " , " + a[3].ToString() + " , " + a[4].ToString() + " , " + a[5].ToString();
    }
    public void RottoClick5()
    {
        for (int i = 0; i < 6; i++)
        {
            m = Random.Range(1, 46);
            a[i] = m;
            if (a[1] == a[0])
            {
                m = Random.Range(1, 46);
                a[i] = m;
            }
            if (a[2] == a[1] || a[2] == a[0])
            {
                m = Random.Range(1, 46);
                a[i] = m;
            }
            if (a[3] == a[0] || a[3] == a[1] || a[3] == a[2])
            {
                m = Random.Range(1, 46);
                a[i] = m;
            }
            if (a[4] == a[0] || a[4] == a[1] || a[4] == a[2] || a[4] == a[3])
            {
                m = Random.Range(1, 46);
                a[i] = m;
            }
            if (a[5] == a[0] || a[5] == a[1] || a[5] == a[2] || a[5] == a[3] || a[5] == a[4])
            {
                m = Random.Range(1, 46);
                a[i] = m;
            }
        }
        count[4].text = a[0].ToString() + " , " + a[1].ToString() + " , " + a[2].ToString() + " , " + a[3].ToString() + " , " + a[4].ToString() + " , " + a[5].ToString();
    }
}
