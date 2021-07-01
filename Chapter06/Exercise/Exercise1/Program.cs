using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            #region テスト用ドライバ
            Ecercise1_1(numbers);
            Console.WriteLine("-----");

            Ecercise1_2(numbers);
            Console.WriteLine("-----");

            Ecercise1_3(numbers);
            Console.WriteLine("-----");

            Ecercise1_4(numbers);
            Console.WriteLine("-----");

            Ecercise1_5(numbers);
            #endregion
        }

        private static void Ecercise1_1(int[] numbers) {
            //var max = numbers.Max();
            Console.WriteLine(numbers.Max());
        }

        private static void Ecercise1_2(int[] numbers) {
            var skip = numbers.Length - 2;
            foreach (var n in numbers.Skip(skip))
                Console.WriteLine(n);
        }

        private static void Ecercise1_3(int[] numbers) {
            var exe = numbers.Select(n => n.ToString());
            foreach (var s in exe)
                Console.WriteLine(s);
        }

        private static void Ecercise1_4(int[] numbers) {
            //var des = numbers.OrderBy(x=>x.);
        }

        private static void Ecercise1_5(int[] numbers) {

        }
    }
}
