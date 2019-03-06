using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_Tập_1
{
    public partial class Form1 : Form
    {
        //Các thuộc tính
        Graphics gp;
        Pen myPen;
        Color myColor;
        SolidBrush myBursh;

        //Cờ hiệu
        bool bLine = false;
        bool bKhungEllipse = false;
        bool bEllipse = false;
        bool bHCN = false;
        bool bKhungHCN = false;

        bool isStart;       //Xác định cờ đang vẽ

        //Điểm Ban đầu
        Point beginPoint;

        public Form1()
        {
            InitializeComponent();

            //Khởi tạo biến cờ hiệu
            isStart = true;

            gp = this.pnlMain.CreateGraphics();
            myColor = Color.Blue;
            myBursh = new SolidBrush(myColor);
            myPen = new Pen(myColor, 5);
        }

        private void btnDuongThang_Click(object sender, EventArgs e)
        {
            bLine = true;   //Khi người dùng click chuột sẽ biến cờ hiệu hoạt động
        }

        private void pnlMain_MouseDown(object sender, MouseEventArgs e)
        {

            if (isStart == true)
            {
                //Khởi tạo vẽ cập nhật điểm ban đầu
                beginPoint.X = e.X;
                beginPoint.Y = e.Y;
                isStart = false;
            }
            else
            {
                Point p1 = new Point();
                Point p2 = new Point();

                p1 = beginPoint;
                p2.X = e.X;
                p2.Y = e.Y;
                
                if (p1.X > p2.X && p1.Y > p2.Y)
                {
                    Point p = p1;
                    p1 = p2;
                    p2 = p;
                }

                if (bLine == true)
                {
                    //Vẽ Đường thẳng
                    gp.DrawLine(myPen, p1, p2);
                    bLine = false;
                }
                else
                {
                    if (bKhungEllipse == true)
                    {
                        gp.DrawEllipse(myPen, p1.X, p1.Y, Math.Abs(p2.Y - p1.Y), Math.Abs(p2.X - p1.X));
                        bKhungEllipse = false;
                    }
                    else
                    {
                        if (bKhungHCN == true)
                        {
                            gp.DrawRectangle(myPen, p1.X, p1.Y, Math.Abs(p2.Y - p1.Y), Math.Abs(p2.X - p1.X));
                            bKhungHCN = false;
                        }
                        else
                        {
                            if (bHCN == true)
                            {
                                gp.FillRectangle(myBursh, p1.X, p1.Y, Math.Abs(p2.Y - p1.Y), Math.Abs(p2.X - p1.X));
                                bHCN = false;
                            }
                            else
                            {
                                if (bEllipse == true)
                                {
                                    gp.FillEllipse(myBursh, p1.X, p1.Y, Math.Abs(p2.Y - p1.Y), Math.Abs(p2.X - p1.X));
                                    bEllipse = false;
                                }
                            }
                        }
                    }

                }

                isStart = true; //Vẽ lại từ đầu
            }
        }

        private void btnKhungEllipse_Click(object sender, EventArgs e)
        {
            bKhungEllipse = true;
        }

        private void btnHCN_Click(object sender, EventArgs e)
        {
            bHCN = true;
        }

        private void btnKhungHCN_Click(object sender, EventArgs e)
        {
            bKhungHCN = true;
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            bEllipse = true;
        }
    }
}
