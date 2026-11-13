
public class Actor //배우라는 놈의 정보만 있다. 유니티 기능은 전혀 없다. 
{
    public int id;
    public string name;
    public string title;
    public string weapon;
    public float strength;
    public int level;
    //private를 하면 외부 클래스에 공개 x (기본상태)

    public string Talk()
    {
        return "대화를 걸었습니다.";
    }

    public string HasWeapon()
    {
        return weapon;
    }

    public void LevelUp()
    {
        level = level + 1;
    }

}
    