using System.Collections.Generic;
using UnityEngine;
//골드메탈 유튜브를 참고하여 수업에 사용. C#의 기초. 
public class Coding1 : MonoBehaviour
{//전역변수(가끔 맴버변수라고 하기도 함.)

    string[] monsters = { "슬라임", "사막뱀", "악마", };
    int level = 5;
    float strength = 15.5f;
    string playerName = "나검사";
    bool isFullLevel = false;
    List<string> items = new List<string>();
    int health = 30;
    int mana = 25;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello Unity");

        /*//1.변수

        //선언 변수 타입과 이름., 초기화 = 값을 넣어라., 호출 = 사용하라.. 
        //지역변수. start()안에서 쓸 수 있는 변수들이다. 다른 함수에선 불러오지 못한다.

        //int level = 5; //정수형. int level 선언, = 5 초기화 
        //float strength = 15.5f; //실수형 소수점이 있으면 f 넣어야 함. 없으면 f 생략 가능. 
        //string playerName = "나검사"; //문자열
        //bool isFullLevel = false; //참ture 거짓false

        //C - 카멜캐이스 대문자로 띄어쓰기 구분. 맨 앞에 메소드,스크립트는 대문자/ 변수는 소문자. 파이썬 - 스네이크 캐이스는 sanke_case 처럼 밑줄을 사용. 
        // 유지보수 어렵게 만드는 사람은 이니셜로 적을 때도 있음. 
        //int 에 값이 없으면 초기값은 0 
        //컴퓨터가 주석의 글씨는 보지 못한다. (컴퓨터 기준 공백이다.) 무엇을 써도 된다. 나중을 위해 남겨놓으나 지울 때 //를 이용.  

        
        //Debug.Log("용사의 이름은?");
        //Debug.Log(playerName);
        //호출 playerName
        //Debug.Log("용사의 레벨은?");
        //Debug.Log(level);
        //Debug.Log("용사의 힘은?");
        //Debug.Log(strength);
        //Debug.Log("용사는 만렙인가?");
        //Debug.Log(isFullLevel); 
        */

        /*//2. 그룹형 변수 (배열) 
        string[] monsters = { "슬라임", "사막뱀", "악마", };//배열. 이렇게 하면 monster에 세 문자열이 담긴다.
        int id = 1;
        Debug.Log("맵에 있는 몬스터");
        Debug.Log(monsters[id - 1]);
        //Debug.Log(monsters[1]);
        //Debug.Log(monsters[2]);
       컴퓨터의 최초 값은 0이라서 0슬라임 1사막뱀 2악마 할당.

        
        int[] monsterLevel = new int[3]; //int3개 선언. 0 1 2 ... 마다 수를 넣을 수 있음. 
        monsterLevel[0] = 1;
        Debug.Log("맵에 존재하는 몬스터의 레벨");
        Debug.Log(monsterLevel[0]);
        Debug.Log(monsterLevel[1]);
        Debug.Log(monsterLevel[2]);
        monsterLevel[1] = 6;
        Debug.Log("맵에 존재하는 몬스터의 레벨");
        Debug.Log(monsterLevel[0]);
        Debug.Log(monsterLevel[1]);
        Debug.Log(monsterLevel[2]);
        monsterLevel[2] = 20;
        Debug.Log("맵에 존재하는 몬스터의 레벨");
        Debug.Log(monsterLevel[0]);
        Debug.Log(monsterLevel[1]);
        Debug.Log(monsterLevel[2]);
        //이렇게 하면 우리가 원하는 타이밍에 값을 넣을 수 있게된다.
        //포켓몬 보유 6마리 가능한데 2마리밖에 없을 때, new int = 6 에 012345 중  0,1에 값이 있는 것. 이런거 만들 때 사용. 
        //예시 string[] myPokemon = new string[6];
        //Debug.Log("현재 보유 중인 포켓몬");
        //Debug.Log("1번" + myPokemon[0]);
        //Debug.Log("2번" + myPokemon[1]);
        //Debug.Log("3번" + myPokemon[2]);
        //Debug.Log("4번" + myPokemon[3]);
        //Debug.Log("5번" + myPokemon[4]);
        //Debug.Log("6번" + myPokemon[5]);

        //Debug.Log("포켓몬을 받았다.");
        //myPokemon[0] = "피카츄";

        //Debug.Log("현재 보유 중인 포켓몬");
        //Debug.Log("1번" + myPokemon[0]);
        //Debug.Log("2번" + myPokemon[1]);
        //Debug.Log("3번" + myPokemon[2]);
        //Debug.Log("4번" + myPokemon[3]);
        //Debug.Log("5번" + myPokemon[4]);
        //Debug.Log("6번" + myPokemon[5]); 
        

        //리스트 
        List<string> items = new List<string>(); //유니티가 가진 것이 아니다. using System.Collections.Generic; 필요. C# 문법. 배열보다 많은 기능. 

        items.Add("생명물약30");
        items.Add("마나물약30");

        items.RemoveAt(0); //리스트의 번호에 해당하는 데이터를 지우고, 그 뒤에 있는 데이터를 당긴다. 

        Debug.Log("가지고 있는 아이템");
        Debug.Log(items[0]);
        //items1은 값이 없어진다. item0의 생명물약은 삭제되고 마나물약이 items0이 됨. 엑셀로 치면 열 삭제. (배열은 삭제가 없다. 리스트는 삭제가 있다.
        //인벤토리 같은건 리스트를 사용하기도 함. 랭킹같은 플레이어 리스트 같은 거에 사용. 빠지면 빈칸이 되는 건 배열에 사용.)

        //List의 기능들 
        //Count 합계를 셈. 
        //Last 리스트 마지막 값 반환. 
        //Add 리스트 끝 요소 추가. 
        //Append 리스트 끝에 요소 추가. 그때만 추가함. 
        //AddRange 한번에 다수의 요소 추가. 배열. 
        //Remove 매개변수로 받은 요소 삭제 1,2,3 에서 2 삭제하면 1,3 남음 (생명물약30이라고 하면, 생명물약30이 삭제됨. 운영자가 관리할 때, 씀.) 
        //RemoveAt 매개변수로 받은 인덱스에 담긴 요소 삭제. 삭제되면 뒤의 요소들이 한칸씩 앞으로 당겨진다. 1,2,3에서 2 제거하면 1,2 남음(2는 3의 데이터로 변경) 
        //RemoveRange 시작 인데스로부터 몇 개 삭제할 지 받음. 12345에서 1 3 지우면 1,5남음. 
        //GetRange 시작 인덱스부터 몇 개를 반환할 지. 
        //Contains 매개변수와 동일한 요소가 있는지 bool형으로 반환. "생명물약30" 치면 ture, "회복물약30"치면 fules 출력. 
        */

        /*//3.연산자 + 덧셈, -뻴셈,*곱셈,/나눗셈,%나머지
        int exp = 1500;
        exp = 1500 + 320;
        exp = exp - 10;
        level = exp / 300;
        strength = level * 3.1f;

        Debug.Log("용사의 총 경험치는?");
        Debug.Log(exp);
        Debug.Log("용사의 레벨은?");
        Debug.Log(level);
        Debug.Log("용사의 힘은?");
        Debug.Log(strength);
        int nextExp = 300 - (exp % 300); // 1810/300 =6 나머지 10
        Debug.Log("다음 레벨까지 남은 경험치는?");
        Debug.Log(nextExp);

        string title = "전설의";
        Debug.Log("용사의 이름은?");
        Debug.Log(title + " " + playerName); //(띄어쓰기 하려면 ""에 스페이스바를 추가. 문자열끼리 더할 수 있음.)

        int fullLevel = 99; //비교연산자 == ~와 같다. 
        isFullLevel = level == fullLevel; //level은 6 fullLevel은 99 달라서 fulse값이 출력. 같아야 ture가 됨. 
        Debug.Log("용사는 만렙입니까? " + isFullLevel); //+는 수식연산자의 +가 아닌, 두 디버그를 더했다는 뜻. 문자열과 논리연산은 가능. ,정수형과 논리연산은 불가능. 

        bool isEndTutorial = level > 10; // >  < 부등호. 초과.미만. >= <= 도 있음. 이상 이하  != 같지 않다. == 같다. (!는 부정을 의미함.)
        Debug.Log("튜토리얼이 끝난 용사입니까?" + isEndTutorial);

        //int health = 30; 
        //int mana = 25;
        //bool isBadCondition = health <= 50 && mana <= 20; // &&는 그리고 (연언) 두 조건 모두 참이어야 참이 출력.
        bool isBadCondition = health <= 50 || mana <= 20; // ||(\원화표시의 쉬프트) 또는 (선언) 두 조건 중 하나라도 있으면 참.
        //bool isBadCondition = health <= 50 || mana <= 20 && fullLevel; // 연언(논리곱)을 먼저 계산하고 이후 선언(논리합)을 계산.
        Debug.Log("용사의 상태가 나쁩니까?" + isBadCondition);

        string condition = isBadCondition ? "나쁨" : "좋음"; //() ? A : B == 삼항연산자 isBadCondition의 값에 따라 ture에 "나쁨" false에 "좋음" 출력. 
        Debug.Log("isBadCondition?" + isBadCondition);
        Debug.Log("용사의 상태가 나쁩니까? " + condition);
        //bool isBadCondition = health <= 50 && mana <= 20 ? "나쁨" : "좋음"; 이렇게 적을 수도 있음. 짧은게 좋으냐 보기 좋은게 좋으냐. 짧게 하려면 이렇게 해도 좋다. 

        */

        /*// 4.키워드 
        //int float = 1; 이거 안됨. 변수타입을 변수명으로 넣을 수 없다
        //string name = List; 이거 안됨. */

        /* // 5.조건문 if, else, else if
        if (condition == "나쁨") //if 안의 조건이 ture이면 다음 항이 진행됨. false이면(if가 실행되지 않으면) else의 다음 항이 실행됨.
        { Debug.Log("플레이어 상태가 나쁘니 아이템을 사용하세요."); }
        else
        { Debug.Log("플레이어 상태가 좋습니다."); }

        //--------이게 if 당 하나의 단위  if와 else가 하나의 단위.

        if (isBadCondition && items[0] == "생명물약30")
        {
            items.RemoveAt(0);
            health += 30;
            Debug.Log("생명포션30을 사용하였습니다.");
        }

        else if (isBadCondition && items[0] == "마나물약30")
        {
            items.RemoveAt(0);
            mana += 30;
            Debug.Log("마나포션30을 사용하였습니다.");
        }

        else if (!isBadCondition && items[0] == "생명물약")
        { Debug.Log("체력이 많아서 생명물약을 사용할 수 없습니다."); }
        //--- if와 else로 하나의 단위다. if, else if, else if 모두 아니면 else 실행.  if, else if, else if,else 가 하나의 단위. 
        //if 없으면 그 아래 것들은 모두 고장난다.
        else
        { Debug.Log("사망"); }


        int n = 0;
        Debug.Log(monsters[n]);
        switch (monsters[n]) // 많이 쓰지는 않으나, 상태머신을 만들 때 사용.
        // AI몬스터나 AI모드에서 초보 봇, 중급 봇을 만들 때, 피가 줄었을 때 도망. 이런 식의 사용.
        // 스위치 변수가 존재하면 case 변수 가 참이면 실행. break는 끊음(다른 케이스를 적을 수 있음) 
        //default는 case가 아니라면 (if 의 else같은 역할)
        {
            case "슬라임":
            case "사막뱀":
                Debug.Log("소형 몬스터가 출현!");
                break;
            case "악마":
                Debug.Log("중형 몬스터가 출현!");
                break;
            case "골렘":
                Debug.Log("대형 몬스터가 출현!");
                break;
            default: //케이스에 있는 게 아니라면, 
                Debug.Log("????");
                break;
        }

        */

        /*//6. 반복문 while 업데이트 문에 while을 적으면 유니티가 박살난다. 쓰지마라. 잘못하면 무한루프에 들어가게 되기 때문이다.
        while (health > 0)
        {
            health--; // ( -- 점점 줄어듦, ++ 점점 늘어남, 기본값은 1 )
            if (health > 0) Debug.Log("독 데미지를 입었습니다." + health);
            else Debug.Log("사망");

            if (health == 10)
            {
                Debug.Log("해독제를 사용합니다.");
                break;
            }
        }

        // for(연산될 변수; 조건; 연산) {로직} 게임에서 아주 자주쓰는 문. 어렵고 귀찮아도 익숙해져야 한다. 

        for (int count = 0; count < 10; count++) // 시작;언제까지 할 거냐;몇개씩 늘어나냐 

        {
            health++;
            Debug.Log("붕대로 치료 중..." + health);
        }


        for (int index = 0; index < monsters.Length; index++) //Length는 int다. 칸수(monsters는 3칸을 가지고 있다.)0,1,2
        {
            Debug.Log("이 지역에 있는 몬스터 : " + monsters[index]);
        }
        // for문을 쓰기 귀찮을 때, foreach는 배열에 담긴 개수만큼 해본다. 
        // 담긴 monsters에 담긴 개체 하나를 이번 foreach문에서만 monster로 칭한다. 
        foreach (string monster in monsters) //반복문을 편리하게 할 수 있다.
        { Debug.Log("이 지역에 있는 몬스터 : " + monster); }

        Heal();
        int[] monsterLevel = { 1, 2, 20 };
        for (int index = 0; index < monsters.Length; index++)
        {
            Debug.Log("용사는 " + monsters[index] + "에게" + Battle(monsterLevel[index]));
        }

        */


         //8. 클래스
        Player player = new Player(); //(클래스를 불러왔는데, 그것을 플레이어로 부르기로 함.
                                    //클래스를 새로운 데이터를 집어넣으면 인스턴스라고 함.
                                    //엑터 플레이어에 뉴 엑터를 인스턴스. (유니티에서 끌어넣는 것도 인스턴스라고 함.)
        player.id = 0;
        player.name = "나법사";
        player.level = 3;
        player.title = "현명한";
        player.strength = 2.4f;
        player.weapon = "나무 지팡이";
        Debug.Log(player.Talk());
        Debug.Log(player.HasWeapon());

        player.LevelUp();
        Debug.Log("레벨 업! " + player.name + "의 레벨은" + player.level + "입니다.");
        Debug.Log(player.move());
        
    }
        



    
    //7.함수(펑션,메소드) >> 코드 뭉치 >> 기능
    //int Heal(int currentHealth) //int면 reture은 반드시 정수,string이면 반드시 문자열. 변수를 따라야 한다.
    //int currentHealth는 매개변수다.이 함수에서만 쓴다 그냥 이름만 있는 것(x)같은거임..
    //start에서 사용된 변수의 변수명에 적용된다. 
    //그래서 health의 값이 들어가게 된다.
    //매개변수가 있는 함수면 반드시 return에 값이 있어야한다. vold함수는 return하는 값이 없어서 필요가 없다.

    //{  currentHealth += 10;
    //    Debug.Log("힐을 받았습니다. " + currentHealth); 
    //    return currentHealth;
    void Heal()
    {

        health += 10;
        Debug.Log("힐을 받았습니다. " + health);
        Debug.Log(health);

    }

    string Battle(int monsterLevel)
    {
        string result;
        if (level >= monsterLevel)
            result = "이겼습니다.";
        else
            result = "졌습니다.";
        return result;
    }


}

    










