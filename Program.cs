using System.Collections;
using System.Net.WebSockets;
using System.Threading.Tasks.Dataflow;

namespace JJJ20
{
    internal class Program
    {
        public static void WR<T>(T a)
        {
            Console.WriteLine(a);
        }
        public static void PartArray(int[] array, int a, int b)
        {
            int[] result = new int[b];

            // 출력 범위를 초과하는지 체크
            if(a+b > array.Length +1)
            {
                Console.WriteLine("범위를 초과하는 값입니다.");
                return;
            }
            // 빈 배열에 함수 출력값 대입
            if (a == 0)
            {
                for (int i = 0; i < b; i++)
                {
                    result[i] = array[a + i];
                }
            }
            else
            {
                for (int i = 0; i < b; i++)
                {
                    result[i] = array[a + i - 1];
                }
            }
            // 배열에 값이 없다면 출력할 문구
            if (result.Length == 0)
            {
                Console.WriteLine("출력될 값이 없습니다.");
            }
            // 결과 값 배열 출력
            Console.WriteLine($"잘라낸 배열들은 {string.Join(",", result)} 입니다.");
        }
        public static int[] CopyArray(int[] array, int num1, int num2)
        {
            int[] result = new int[num2];

            Array.Copy(array, num1, result, 0, num2);

            return result;
        }
        public static void SortArray(int[] array, int stand)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            int[] result = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                dictionary.Add(array[i], array[i]);
            }

            for (int i = 0; i < dictionary.Count; i++)
            {
                dictionary[array[i]] = Math.Abs(stand - dictionary[array[i]]);
            }

            dictionary = dictionary.OrderBy(item => item.Value).ToDictionary(x => x.Key, x => x.Value);
            
            foreach (int i in dictionary.Keys)
            {
                Console.WriteLine($"키 값 : {i} 절대값 : {Math.Abs(stand-i)}");
            }


        }
        static void Main(string[] args)
        {
            // 1교시
            /*
            int[] array = { 10, 20, 30, 40, 50,60,70,80,90,100 };
            int[] array2 = { 1, 2, 3, 4, 5, 6,7,8,9,10};

            PartArray(array, 2, 3);

            // array의 4번째부터 5개의 인덱스를 array2의 2번째 인덱스부터 복사해넣어라.
            Array.Copy(array, 4, array2, 2, 5);
            array2.ToWriteLine();

            // IndexOf
            // 찾는 값과 일치하는 값이 배열의 몇번째 인덱스에 있는지 찾는 함수
            Console.WriteLine(Array.IndexOf(array, 90));

            // Array.Find(배열, bool반환 함수) : 배열에서 조건문을 만족하는 변수를 찾아낸다.
            // Array.FindLast(배열, bool 반환 함수) : 뒤에서부터 조건식에 맞는 요소를 찾아 반환한다.
            WR("90초과인 값은");
            WR(Array.Find(array, (num) => num > 90));

            // 문자열의 대문자 <-> 소문자 변경
            // 문자열은 상수 나열이기 때문에 toLower()로 참조하고 있는 값이 바뀌지 않는다.
            string str = "abCDEfg";
            Console.WriteLine($"기존 : {str}, 대문자 : {str.ToUpper()}, 소문자 : {str.ToLower()}");

            str.ToLower();

            Console.WriteLine("ToLower 이후의 str : "+str); // 출력된 값은 초기화 값과 다르지 않다.
            */
            // 2교시
            /*
            // 문자열 편집
            // (string).Substring(정수a(, 정수b)) : 문자열 인덱스 a부터 b개만큼 자른다. b가 없으면 a부터 문자열 끝까지 자른다. 
            string word = "Hello World!";

            WR(word.Substring(word.Length - 4));

            // string.Compare(string,string) : int
            // => 모든 compare는 공통적으로 좌측이 작으면 -1, 우측이 작으면 1, 같으면 0
            Console.WriteLine(string.Compare("AAAA", "AAAB"));

            // string.Concat(string,string +a) : string
            // => 두 문자열을 합쳐서 새로운 문자열을 반환한다.

            WR(string.Concat("가", "나", " ", "다라"));

            // Split => 문자열을 특정 문자(문자열)를 기준으로 자르는 것 
            string str4 = "My name. your name. we are";
            string[] splits = str4.Split(". ");

            foreach (string i in splits)
            { WR(i); }

            // .Replace(string, string) => (앞)특정 문자열을 (뒤) 문자열로 바꿔줌
            // 이 또한 참조형이라 변경 문구가 필요
            
            string str5 = "Do you have a hobby";
            str5 = str5.Replace("hobby", "job");
            WR(str5);
*/
            // 3교시

            int[] sortArray = { 4, 6, 80, 66, 25, 159, 1000, 2131 };


            SortArray(sortArray, 30);



        }

    }

    public static class Method
    {
        public static void ToWriteLine<T>(this T[] array)
        {
            foreach (T item in array)
            {
                Console.WriteLine(item);
            }
        }
    }

}

