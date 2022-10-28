using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Member[] items = {
                new Member{Name="A1",Height=195,DateOfBirth=new DateTime(1999,1,2) },
                new Member{Name="A2",Height=180,DateOfBirth=new DateTime (1992,2,5)},
                new Member{Name="A3",Height=185,DateOfBirth=new DateTime (1994,1,3)}
                
            };
            //Array.Sort(items);

            //IComparer<Member> comparer = new CompareByNameDESC();
            //IComparer<Member> comparer2 = new CompareByNameASC();

            //IComparer<Member> comparer3 = new CompareByHeightDESC();
            //IComparer<Member> comparer4 = new CompareByHeightASC();
            //comparer=new CompareByNameASC
            Array.Sort(items,Member.按姓名遞增排序);

            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
   
    internal class CompareByHeightASC : IComparer<Member>
    {
        public int Compare(Member x, Member y)
        {
            return x.Height.CompareTo(y.Height);
        }
    }

    public class CompareByNameASC:IComparer<Member>
    {
        public int Compare (Member x,Member y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
    public class CompareByNameDESC: IComparer<Member>
    {
        public int Compare(Member x, Member y)
        {
            return y.Name.CompareTo(x.Name);
        }
    }


    public class Member : IComparable<Member>
    {
        public static IComparer<Member> 按姓名遞減排序
        {
            get
            {
                return new CompareByNameDESC(); 
            }
        }
        public static IComparer<Member> 按姓名遞增排序
        {
            get 
            { 
                return new CompareByNameASC(); 
            }
        }

        
        public int Height { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        public int CompareTo(Member other)
        {
            Member x = this;
            Member y = other;

            //return y.Height.CompareTo(x.Height);
            return y.DateOfBirth.CompareTo(x.DateOfBirth);

            //if (x.Height > y.Height)
            //    return 1000;
            //else if (x.Height == y.Height)
            //    return 0;
            //else
            //    return -999;
        }

        public override string ToString()
        {
            return $"Name={Name},Height={Height},Birthday={DateOfBirth:yyyy/MM/dd}";
        }
    }
}
