using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_Tập_2
{
    public partial class Form1 : Form
    {
        Graphics gp;

        bool bLine = false;
        bool bKhungEllipse = false;
        bool bEllipse = false;
        bool bHCN = false;
        bool bKhungHCN = false;

        //Pen myPen;
        //Color myColor;

        bool isStart = false;   //Cờ xác định đi vẽ

        List<cLine> lLine = new List<cLine>();

        public Form1()
        {
            InitializeComponent();
            gp = this.pnlMain.CreateGraphics();

            DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pnlMain_MouseDown(object sender, MouseEventArgs e)
        {
            //Kiểm tra xem hiện tại người dùng chọn kiểu hình để vẽ
            if (bLine == true || bKhungEllipse == true || bKhungHCN == true || bHCN == true || bEllipse == true)
            {
                this.isStart = true;        //bắt đầu vẽ
                //Khi nhấn chuột cập nhật 1 hình vẽ
                cLine myLine = new cLine();
                myLine.p1 = e.Location;
                myLine.p2 = e.Location;
                ChonKieuHinh(myLine);
                this.lLine.Add(myLine);
            }
        }

        private void ChonKieuHinh(cLine myLine)
        {
            if (bLine == true)
            {
                myLine.kieuhinh = KieuHinh.Line;
            }
            else
            {
                if (bKhungHCN == true)
                {
                    myLine.kieuhinh = KieuHinh.KHCN;
                }
                else
                {
                    if (bHCN == true)
                    {
                        myLine.kieuhinh = KieuHinh.HCN;
                    }
                    else
                    {
                        if (bKhungEllipse == true)
                        {
                            myLine.kieuhinh = KieuHinh.Kellipse;
                        }
                        else
                        {
                            myLine.kieuhinh = KieuHinh.Ellipse;
                        }
                    }
                }
            }
        }

        private void pnlMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.isStart == true)
            {
                if (bLine == true || bKhungEllipse == true || bKhungHCN == true || bHCN == true || bEllipse == true)
                {
                    //Cập nhật lại vị trí con chuột hiện tại
                    this.lLine[lLine.Count - 1].p2 = e.Location;
                    this.pnlMain.Refresh(); //Làm tươi màn hình
                }
            }
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

            if (this.isStart == true)
            {
                for (int i = 0; i < this.lLine.Count; i++)
                {
                    Draw(lLine[i]);
                }
            }

        }

        public Rectangle TaoHCN(cLine myCline)
        {
            Point p = new Point();
            if (myCline.p1.X < myCline.p2.X && myCline.p1.Y < myCline.p2.Y)
            {
                p = myCline.p1;
            }
            else
            {
                if (myCline.p1.X > myCline.p2.X && myCline.p1.Y > myCline.p2.Y)
                {
                    p = myCline.p2;
                }
                else
                {
                    if (myCline.p1.X > myCline.p2.X && myCline.p1.Y < myCline.p2.Y)
                    {
                        p.X = myCline.p2.X;
                        p.Y = myCline.p1.Y;
                    }
                    else
                    {
                        p.X = myCline.p1.X;
                        p.Y = myCline.p2.Y;
                    }
                }
            }
            return new Rectangle(p, new Size(Math.Abs(myCline.p1.X - myCline.p2.X), Math.Abs(myCline.p1.Y - myCline.p2.Y)));
        }

        public void Draw(cLine myCline)
        {
            switch (myCline.kieuhinh)
            {
                case KieuHinh.Line:
                    gp.DrawLine(myCline.myPen, myCline.p1, myCline.p2);
                    break;
                case KieuHinh.HCN:
                    gp.DrawRectangle(myCline.myPen, TaoHCN(myCline));
                    break;
                case KieuHinh.KHCN:
                    gp.FillRectangle(myCline.sBrush, TaoHCN(myCline));
                    break;
                case KieuHinh.Ellipse:
                    gp.DrawEllipse(myCline.myPen, TaoHCN(myCline));
                    break;
                case KieuHinh.Kellipse:
                    gp.FillEllipse(myCline.sBrush, TaoHCN(myCline));
                    break;
                default:
                    break;
            }
        }

        private void pnlMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.bLine == true)
            {
                this.lLine[this.lLine.Count - 1].p2 = e.Location;
                this.pnlMain.Refresh();
            }
            this.isStart = false;
            //this.bLine = false;
        }

        #region Events for button

        private void btnDuongThang_Click(object sender, EventArgs e)
        {
            bLine = true;
            bKhungEllipse = false;
            bEllipse = false;
            bHCN = false;
            bKhungHCN = false;
        }

        private void btnKhungHCN_Click(object sender, EventArgs e)
        {
            bKhungHCN = true;
            bLine = false;
            bKhungEllipse = false;
            bEllipse = false;
            bHCN = false;
        }

        private void btnHCN_Click(object sender, EventArgs e)
        {
            bHCN = true;
            bLine = false;
            bKhungEllipse = false;
            bEllipse = false;
            bKhungHCN = false;
        }

        private void btnKhungEllipse_Click(object sender, EventArgs e)
        {
            bKhungEllipse = true;
            bLine = false;
            bEllipse = false;
            bHCN = false;
            bKhungHCN = false;
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            bEllipse = true;
            bLine = false;
            bKhungEllipse = false;
            bHCN = false;
            bKhungHCN = false;
        }

        #endregion
    }

    public class cLine
    {
        public Point p1;
        public Point p2;

        public Color mausac;
        public SolidBrush sBrush;
        public Pen myPen;

        public int doday;
        public KieuHinh kieuhinh;

        public cLine()
        {
            mausac = Color.Blue;
            doday = 4;
            myPen = new Pen(mausac, doday);
            sBrush = new SolidBrush(mausac);
        }
    }

    public enum KieuHinh
    {
        Line, HCN, KHCN, Ellipse, Kellipse
    }
}
