namespace ListDictionary
{
    public class Node
    {
        // 값을 생성자로만 입력한다.
        public Node(int data)
        {
            // 프로퍼티 Data에 값을 입력
            this.Data = data;
        }
        // Data 프로퍼티
        public int Data
        {
            // 입력은 생성자로만 받는다.
            get; private set;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            //List
            var list = new List<Node>();

            for (int i = 0; i < 10; i++)
            {
                list.Add(new Node(i));
            }

            list.Remove(list[5]);
            list.Insert(2, new Node(100));

            foreach (var node in list)
            {
                Console.WriteLine(node.Data);
            }

            Console.WriteLine();

            //Dictionary
            var dic = new Dictionary<string, Node>();

            for (int i = 0; i < 10; i++)
            {
                // 딕셔너리에 키는 "Key" + i의 값으로 데이터를 삽입
                dic.Add("Key" + i, new Node(i));
            }

            dic.Remove("Key2");
            dic.Add("key600", new Node(100));

            foreach (var key in dic.Keys)
            {
                var node = dic[key];
                Console.WriteLine("Key = " + key + ", value = " + node.Data);
            }

            Console.WriteLine("-----------------------------------------------");

            //list
            EvenList();
            EvenListLinq();
            EvenDescendingLinq();
            Lambda();

        }

        static void EvenList()
        {
            var list2 = new List<Node>();

            for (int i = 0; i < 10; i++)
            {
                list2.Add(new Node(i));
            }

            var evenList = new List<Node>();

            foreach (var node in list2)
            {
                if (node.Data % 2 == 0)
                {
                    evenList.Add(node);
                }
            }

            foreach (var node in evenList)
            {
                Console.WriteLine(node.Data);
            }
        }

        static void EvenListLinq()
        {
            var list = new List<Node>();

            for (int i = 0; i < 10; i++)
            {
                list.Add(new Node(i));
            }

            var evenList = from node in list
                           where node.Data % 2 == 0
                           select node;

            foreach (var node in evenList)
            {
                Console.WriteLine(node.Data);
            }
        }

        /// <summary>
        ///  orderby로 리스트를 내림차순(descending)으로 재정렬하고 
        ///  group by로 1과 0으로 재정렬하고
        ///  select로 딕셔너리 형태로 데이터를 만듬
        ///  
        /// 간단하게 Dictionary<int, List<Node>> 형태로 재구성되는 것
        /// </summary>
        static void EvenDescendingLinq()
        {
            Console.WriteLine();
            Console.WriteLine("Another way to display");
            var list = new List<Node>();

            for (int i = 0; i < 10; i++)
            {
                list.Add(new Node(i));
            }

            // 짝수, 홀수 별로 그룹을 나누고 그 키로 Node를 재정렬한다.
            var filerList = from node in list
                            orderby node.Data
                            descending
                            group node by node.Data % 2
                            into g
                            select (key: g.Key, value: g);

            // filerList의 키 순서대로 반복문
            foreach (var item in filerList)
            {
                // 각 키안에 리스트를 출력
                foreach (var value in item.value)
                {
                    Console.WriteLine("Key : " + item.key + " Value : " + value.Data);
                }
                Console.WriteLine();
            }
        }

        static void Lambda()
        {
            Console.WriteLine();
            Console.WriteLine("Another way to display");
            var list = new List<Node>();

            for (int i = 0; i < 10; i++)
            {
                list.Add(new Node(i));
            }

            var evenList = list.Where(x => x.Data % 2 == 0);

            foreach (var node in evenList)
            {
                Console.WriteLine(node.Data);
            }

            Console.WriteLine();

            // 짝수, 홀수 별로 그룹을 나누고 그 키로 Node를 재정렬한다.
            var filerList = list.OrderByDescending(x => x.Data).GroupBy(x => x.Data % 2).Select(x => (key: x.Key, value: x));
          
            // filerList의 키 순서대로 반복문
            foreach (var item in filerList)
            {
                // 각 키안에 리스트를 출력
                foreach (var value in item.value)
                {
                    Console.WriteLine("Key : " + item.key + " Value : " + value.Data);
                }
                Console.WriteLine();
            }
        }
    }
}