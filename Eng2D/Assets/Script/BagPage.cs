using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagPage : MonoBehaviour {

    bool bagOpen = false;
    public GameObject Bag;

    // 拼好了没
    public static int gunPhare;
    public static int bowPhare;
    public static int panPhare;
    public static int ironPhare;
    public static int lovePhare;
    public static int laserPhare;

    // 还未拿到字母的画面
    public GameObject GunIn;
    public GameObject BowIn;
    public GameObject PanIn;
    public GameObject IronIn;
    public GameObject LoveIn;
    public GameObject LaserIn;

    // 武器拼字画面
    public GameObject GunWordSide;
    public GameObject BowWordSide;
    public GameObject PanWordSide;
    public GameObject IronWordSide;
    public GameObject LoveWordSide;
    public GameObject LaserWordSide;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            openBag();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            allClose();
        }

        //如果字有了，按按钮，会到拼字画面，拼好了，会到完好的画面
        // UI加入wordside，bool给我处理，星期五最晚！
        // 需要防止有人拼不出!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        // 武器需要的字完整自动跳转到拼字画面
        // 武器完成会忽然跳出来，要改
        if (GetWords.GunWords == 3)
        {
            GetWords.GunWords++;
            gunPhare= 1;
        }

        if (GetWords.BowWords == 3)
        {
            GetWords.BowWords++;
            bowPhare = 1;
        }

        if (GetWords.PanWords == 3)
        {
            GetWords.PanWords++;
            panPhare = 1;
        }

        if (GetWords.IronWords == 4)
        {
            GetWords.IronWords++;
            ironPhare = 1;
        }

        if (GetWords.LoveWords == 4)
        {
            GetWords.LoveWords++;
            lovePhare = 1;
        }

        if (GetWords.LaserWords == 5)
        {
            GetWords.LaserWords++;            
            laserPhare = 1;
        }
    }

    public void gunPage()
    {
        if (gunPhare == 0)
            changeType(GunIn, Bag);
        else
            changeType(GunWordSide, Bag);
    }

    public void bowPage()
    {
        if (bowPhare == 0)
            changeType(BowIn, Bag);
        else
            changeType(BowWordSide, Bag);

    }

    public void panPage()
    {
        if (panPhare == 0)
            changeType(PanIn, Bag);
        else
            changeType(PanWordSide, Bag);
    }

    public void ironPage()
    {
        if (ironPhare == 0)
            changeType(IronIn, Bag);
        else
            changeType(IronWordSide, Bag);
    }

    public void lovePage()
    {
        if (lovePhare == 0)
            changeType(LoveIn, Bag);
        else
            changeType(LoveWordSide, Bag);
    }
    public void laserPage()
    {
        if (laserPhare == 0)
            changeType(LaserIn, Bag);
        else
            changeType(LaserWordSide, Bag);
    }

    public void bagPage()
    {
        bagOpen = true;
        Bag.SetActive(true);

        // 全部unvisible,只有背包打开
        GunIn.SetActive(false);
        BowIn.SetActive(false);
        PanIn.SetActive(false);
        IronIn.SetActive(false);
        LoveIn.SetActive(false);
        LaserIn.SetActive(false);
        GunWordSide.SetActive(false);
        BowWordSide.SetActive(false);
        PanWordSide.SetActive(false);
        IronWordSide.SetActive(false);
        LoveWordSide.SetActive(false);
        LaserWordSide.SetActive(false);
    }

    public void allClose()
    {
        // 全部不见
        bagOpen = false;
        GunIn.SetActive(false);
        BowIn.SetActive(false);
        PanIn.SetActive(false);
        IronIn.SetActive(false);
        LoveIn.SetActive(false);
        LaserIn.SetActive(false);
        GunWordSide.SetActive(false);
        BowWordSide.SetActive(false);
        PanWordSide.SetActive(false);
        IronWordSide.SetActive(false);
        LoveWordSide.SetActive(false);
        LaserWordSide.SetActive(false);
        Bag.SetActive(false);
    }


    void changeType(GameObject show,GameObject dontShow)
    {
        show.SetActive(true);
        dontShow.SetActive(false);
    }

    void openBag()
    {
        // 打开背包
        bagOpen = !bagOpen;
        if (bagOpen == true)
        {
            Bag.SetActive(true);
        }
        else
        {
            Bag.SetActive(false);
        }
    }
}
