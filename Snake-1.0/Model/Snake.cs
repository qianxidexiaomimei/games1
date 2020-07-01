using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Collections;
using Snake_1._0.Interface;

namespace Snake_1._0
{
    public class Snake : IShow
    {
        ArrayList blockList;
        private int headNumber;                                       //蛇头序数
        private Point headPoint;                                      //蛇头位置
        private int direction = 1;                                    //0,1,2,3分别代表上、右、下、左
        
        public void Display(Graphics g)
        {
            throw new NotImplementedException();
        }

        public void UnDisplay(Graphics g)
        {
            throw new NotImplementedException();
        }
       
    }
}
