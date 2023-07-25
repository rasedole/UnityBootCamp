using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace L20230719_01
{
    class Hog : Monster
    {
        public Hog()
        {
            name = "멧돼지";
            Console.WriteLine(name + "이/가 생성 되었다.");
        }
        
        ~Hog()
        {
            Console.WriteLine(name + "이/가 삭제되었습니다.");
        }
    }
}
