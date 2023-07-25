using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230719_01
{
    class Slime : Monster
    {
        public Slime()
        {
            name = "슬라임";
            Console.WriteLine(name + "이/가 생성 되었다.");
        }
        
        ~Slime()
        {
            Console.WriteLine(name + "이/가 삭제되었습니다.");
        }
    }
}
