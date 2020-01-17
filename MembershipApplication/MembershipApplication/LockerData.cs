using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MembershipApplication
{
    class LockerData
    {
        private static Dictionary<string, LockerDataClass> dicLockerData = new Dictionary<string, LockerDataClass>();

        public static void SetMembershipData(string name, LockerDataClass value) //함수 호출 시 넘긴 값을 받아서 변수에 저장
        {
            if (dicLockerData.ContainsKey(name) == true) //입력한 성함이 Dictionary에 존재하는 경우 true를 반환
            {
                dicLockerData[name] = value; //Dictionary에 이미 할당된 성함이 있는 상태에서, 새로운 값을 추가(ADD)하면 오류가 뜨기 때문에, 새로 받은 정보를 기존의 정보에 덮어씌워줌  
            }
            else //입력한 성함이 Dictionary에 존재하지 않는 경우 즉, flase를 반환 받은 경우
            {
                dicLockerData.Add(name, value); //Dictionary에 정보를 추가 //ex) 홍길동(key)→1995년05월21일, 남, OneYear, 수영_오전A, 95847(value)
            }
        }
        public static Dictionary<string, LockerDataClass> GetLockerList() //SearchMembership폼에 정보를 전달하기 위한 함수
        {
            return dicLockerData; //Dictionary에 저장된 정보를 반환시킴
        }
    }


    public class LockerDataClass
    {
        public int number = 0;
        public int lockernumber = 0;
    }
}
