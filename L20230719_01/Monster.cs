using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230719_01
{
    class Monster
    {
        public Monster()
        {
            _hp = 0;
            _gold = 0;
            _name = "몬스터";
        }

        ~Monster()
        {
            Console.WriteLine(_name + "이/가 삭제되었습니다.");
        }

        public string name { get;set; }
        //{
        //    get
        //    {
        //        return _name;
        //    }
        //    set
        //    {
        //        _name = value;
        //    }
        //}

        private int _hp = 0;
        private int _gold = 0;
        private string _name = string.Empty;

        public void Move()
        {
            Console.WriteLine(_name + "이/가 움직인다.");
        }
        public void Attack()
        {
            Console.WriteLine(_name + "이/가 공격한다.");
        }
        public void Die()
        {
            Console.WriteLine(_name + "이/가 죽었다.");
        }
    }
}
