using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            //string code = "12345";////null合体演算子
            //var message = GetMessage(code) ?? DefaultMessage();//Console.WriteLine(message);
            //var ret = GetProductA();

            //int count = 0;
            //Console.WriteLine($"後置:{count++}");

            //Console.WriteLine($"前置:{++count}");

            var Session = new Dictionary<string, object>();
            Session["MyProduct"] = new Product();

            var product = Session["MyProduct"] as Product;
            if (product.Name == "") {
                //Productが取得できなかった時の処理
                Console.WriteLine("productが取得できなかった");           
            } else {
                //Productが取得できたとき
                Console.WriteLine("productが取得できた");
            }
            

        }

        private static Product GetProductA() {
            Sale sale = new Sale();
            sale.Product = new Product();
            sale = null;
            return sale?.Product;//null条件演算子
        }
        //スタブ
        //private static object DefaultMessage() {
        //    return "Default Message";
        //}
        //private static object GetMessage(object code) {
        //    return code;
        //}
    }
    class Sale {
        public string ShopName { get; set; } = "abcde";
        public int Amount { get; set; } = 12340;
        public Product Product { get; set; }
    }
}
