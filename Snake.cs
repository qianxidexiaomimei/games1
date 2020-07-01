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
    
        private int direction = 1;                                    //0,1,2,3分别代表上、右、下、左
                                                                

        public int Direction                                         //蛇的运行方向属性
        {
            get { return direction; }
            set { direction = value; }
        }

        public void TurnDirection(int pDirection)                    //蛇的转向方法，参数为蛇要改变方向
        {
            switch (direction)
            {
                case 0:                                              //原来向上
                    if (pDirection == 3)                             //如果改变方向为左
                        direction = 3;
                    else if (pDirection == 1)                        //如果改变方向为右
                        direction = 1;
                    break;
                case 1:
                    if (pDirection == 2)
                        direction = 2;
                    else if (pDirection == 0)
                        direction = 0;
                    break;
                case 2:
                    if (pDirection == 3)
                        direction = 3;
                    else if (pDirection == 1)
                        direction = 1;
                    break;
                case 3:
                    if (pDirection == 2)
                        direction = 2;
                    else if (pDirection == 0)
                        direction = 0;
                    break;
            }
        }
    }
}
