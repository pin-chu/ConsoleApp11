using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class A {
        public string Name;
        private string _Email;

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        public int Height { get; set; }//屬性的簡短寫法

        //方法要有大括號
        public int Add (int numl,int num2)
        {
            return numl + num2;
        }
    }
    interface IB{
        //介面裡,不能寫建構函數和field

        //只能寫這個語法,不能寫public,private

        string Email { get; set; }

        /// <summary>
        /// 只能這樣宣告,不能有大括號,必須接分號
        /// </summary>
        /// <param name="numl"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        int Add(int numl, int num2);
    }
    /// <summary>
    /// 顯示可能修正,實作
    /// </summary>
    class Member : IB
    {
        //1.介面有的類別都要有 2.都只用public
        public string Email {get; set ;}

        public int Add(int numl, int num2)
        {
            return numl + num2;
        }
    }

}
