using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Snake_1._0.Interface;

namespace Snake_1._0
{
    public class Block : IShow
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public Block()                                            
        {
        }

        private int number;                                       //定义蛇块序数
        private Point origin;                                     //定义二维点位置
        private bool ishead = false;                              //定义蛇头标志

        public int Number                                         
        {
            get { return number; }
            set { number = value; }
        }

        public bool Ishead                                         
        {
            get { return ishead; }
            set { ishead = value; }
        }

        public Point Origin
        {
            get { return origin; }
            set { origin = value; }
        }

        public void Display(Graphics g)                            //显示蛇块方法
        {
            if (Ishead)                                            
            {
                SolidBrush b = new SolidBrush(Color.Blue);         //定义蓝色画笔
                g.FillEllipse(b, origin.X, origin.Y, 15, 15);      //画实心圆形

            }
            else
            {
                SolidBrush b = new SolidBrush(Color.Yellow);       //定义黄色画笔
                g.FillRectangle(b, origin.X, origin.Y, 15, 15);    //画实心矩形
            }
        }

        public void UnDisplay(Graphics g)                          //消除蛇块方法
        {
            SolidBrush b = new SolidBrush(Color.AliceBlue);           //定义背景色画刷 
            g.FillRectangle(b, origin.X, origin.Y, 15, 15);        //用背景色重画原来矩形
           
        }
    }
}
