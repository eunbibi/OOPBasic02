using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    public static class RefAndOut
    {
        /*
         * Main difference: 매개변수 초기화
         * ref: 사용전 초기화
         * out: 전달전 명시적 초기화 불필요, 이전의 값 모두 무시
        -ref keyword is used when a called method has to update 
        the passed parameter. 
        -ref keyword is used to pass data in bi-directional way
        
        -out keyword is used when a called method has to update 
        multiple parameter passed. 
        -out keyword is used to get data in uni-directional way.
         */

        //->overloading hehe
        //ref
        public static void Add(int i, ref int result)
        {
            result += i;
            return;
        }

        //out
        public static void Add(int i, int k, out int result)
        {
            result = i + k;
            return;
        }


        /*
        ref - 기존 변수를 메서드에서 수정하려고 할 때 사용
        out - 메서드 내에서 생성된 값을 반환할 때 사용
            - 여기서 out은 일반적으로 메서드에서 호출하는 코드에 대해 
              여러 개의 결과 값을 생성하는 경우 메서드의 반환 값과 함께 사용된다.
         */
    }
}
