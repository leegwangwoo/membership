using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MembershipApplication
{
    public enum enSex //열거형 정의
    {
        남, 여
    }
    public enum enPeriod
    {
        OneMonth, HalfYear, OneYear
    }
    public enum enSelect
    {
        강의명, 강사명
    }
    public enum enStudent
    {
        재학생, 일반인
    }
    public static class DataClass
    {
        //<key,value>로 Dictionary를 생성(key → key값을 이용하여 일치되는 정보를 찾는 역할, value → 저장할 정보를 담는 역할)
        private static Dictionary<string, MembershipDataClass> dicMembershipData = new Dictionary<string, MembershipDataClass>(); 

        public static void SetMembershipData(string name, MembershipDataClass value) //함수 호출 시 넘긴 값을 받아서 변수에 저장
        {
            if (dicMembershipData.ContainsKey(name) == true) //입력한 성함이 Dictionary에 존재하는 경우 true를 반환
            {
                dicMembershipData[name] = value; //Dictionary에 이미 할당된 성함이 있는 상태에서, 새로운 값을 추가(ADD)하면 오류가 뜨기 때문에, 새로 받은 정보를 기존의 정보에 덮어씌워줌  
            }
            else //입력한 성함이 Dictionary에 존재하지 않는 경우 즉, flase를 반환 받은 경우
            {
                dicMembershipData.Add(name, value); //Dictionary에 정보를 추가 //ex) 홍길동(key)→1995년05월21일, 남, OneYear, 수영_오전A, 95847(value)
            }
        }
        public static Dictionary<string, MembershipDataClass> GetMembershipDataList() //SearchMembership폼에 정보를 전달하기 위한 함수
        {
            return dicMembershipData; //Dictionary에 저장된 정보를 반환시킴
        }
    }


    public class MembershipDataClass 
    {
        public DateTime birthDay = new DateTime();
        public string sex = "";
        public string period = "";
        public string lecture = "";
        public string student = "";
        public int number = 0;
    }
}
