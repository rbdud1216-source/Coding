using UnityEngine;

public class Player : Actor //여기서 상속. Actor에 있는 내용이 Player에도 들어있는 모.자 관계가 됨.
{
    public string move() //ctrl 클릭하면 무엇을 상속하고 있는지 볼 수 있음. 
    {
        return "플레이어가 움직입니다.";
    }
    
}