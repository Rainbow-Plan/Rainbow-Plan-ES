using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RPlink;

namespace FunWinForm
{
    class WordList
    {
        int I = 0;//计数
        RPobject Word = new RPobject();
        public WordList()
        {

        }

        public RPobject[] Word_Queue = new RPobject[6];      //使用对象队列存储
        
        public void WordQueue(RPobject OB_Word)   //进队，出队调整
        {
            Word = OB_Word;
            if(I <= 5)
            {
                Word_Queue[I] = Word;
                I++;
            }
            else
            {
                Word_Queue[0] = Word_Queue[1];
                Word_Queue[1] = Word_Queue[2];
                Word_Queue[2] = Word_Queue[3];
                Word_Queue[3] = Word_Queue[4];
                Word_Queue[4] = Word_Queue[5];
                Word_Queue[5] = Word;
            }
        }
    }
}
