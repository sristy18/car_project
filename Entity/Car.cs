using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Entity
{
    public class Car
    {
        public int speed;
        public void DrawRoad(Graphics g)
        {
              Pen p=new Pen(Color.Chocolate,3);
              Pen p0 = new Pen(Color.Gray, 7);
              Pen p01 = new Pen(Color.White, 5);
              Pen p02 = new Pen(Color.Black, 5);
              Pen p03 = new Pen(Color.Green, 8);
              Pen p04 = new Pen(Color.DarkGoldenrod, 11);
              Pen p05 = new Pen(Color.SkyBlue, 5);

              //Rode:-
              //loop:-
              //tree side curve1:-
              Point[] p1 = { new Point(300, 0), new Point(300, 70), new Point(0, 70) };
              g.DrawCurve(p, p1);
              Point[] p5 = { new Point(290, 0), new Point(290, 60), new Point(0, 60) };
              g.DrawCurve(p, p5);
              //tree side curve2:-
              Point[] p2 = { new Point(800, 0), new Point(800, 70), new Point(1200, 70) };
              g.DrawCurve(p, p2);
              Point[] p6 = { new Point(790, 0), new Point(790, 80), new Point(1200, 80) };
              g.DrawCurve(p, p6);
              // side curve3:-(change it)
              Point[] p3 = { new Point(350, 850), new Point(300, 450), new Point(0, 405) };
              g.DrawCurve(p, p3);
              Point[] p7 = { new Point(340, 850), new Point(290, 460), new Point(0, 415) };
              g.DrawCurve(p, p7);
              //side curve4:-
               Point[] p4 = { new Point(850, 800), new Point(750, 450), new Point(1200, 400) };
              g.DrawCurve(p, p4);
              Point[] p8 = { new Point(840, 800), new Point(740, 440), new Point(1200, 390) };
              g.DrawCurve(p, p8);
            //real
             // Point[] p4 = { new Point(600, 800), new Point(650, 350), new Point(900, 300) };
             // g.DrawCurve(p, p4);
              //Point[] p8 = { new Point(590, 800), new Point(640, 340), new Point(900, 290) };
             // g.DrawCurve(p, p8);
           
           
            //zebra:
              g.DrawLine(p01, new Point(0, 140), new Point(50, 140));
              g.DrawLine(p02, new Point(60, 140), new Point(110, 140));
              g.DrawLine(p01, new Point(120, 140), new Point(170, 140));
              g.DrawLine(p02, new Point(180, 140), new Point(230, 140));
              g.DrawLine(p01, new Point(240, 140), new Point(290, 140));
              g.DrawLine(p02, new Point(300, 140), new Point(350, 140));
              g.DrawLine(p01, new Point(360, 140), new Point(420, 140));
              g.DrawLine(p02, new Point(430, 140), new Point(480, 140));
              g.DrawLine(p01, new Point(490, 140), new Point(540, 140));
              g.DrawLine(p02, new Point(550, 140), new Point(600, 140));
              g.DrawLine(p01, new Point(610, 140), new Point(660, 140));
              g.DrawLine(p02, new Point(670, 140), new Point(720, 140));
              g.DrawLine(p01, new Point(730, 140), new Point(780, 140));
              g.DrawLine(p02, new Point(790, 140), new Point(840, 140));
              g.DrawLine(p01, new Point(850, 140), new Point(900, 140));
              g.DrawLine(p02, new Point(910, 140), new Point(960, 140));
              g.DrawLine(p01, new Point(970, 140), new Point(1010, 140));
              g.DrawLine(p02, new Point(1020, 140), new Point(1070, 140));
              g.DrawLine(p01, new Point(1080, 140), new Point(1130, 140));
              g.DrawLine(p02, new Point(1140, 140), new Point(1190, 140));

              g.DrawLine(p01, new Point(0, 320), new Point(50, 320));
              g.DrawLine(p02, new Point(60, 320), new Point(110, 320));
              g.DrawLine(p01, new Point(120, 320), new Point(170, 320));
              g.DrawLine(p02, new Point(180, 320), new Point(230, 320));
              g.DrawLine(p01, new Point(240, 320), new Point(290, 320));
              g.DrawLine(p02, new Point(300, 320), new Point(350, 320));
              g.DrawLine(p01, new Point(360, 320), new Point(420, 320));
              g.DrawLine(p02, new Point(430, 320), new Point(480, 320));
              g.DrawLine(p01, new Point(490, 320), new Point(540, 320));
              g.DrawLine(p02, new Point(550, 320), new Point(600, 320));
              g.DrawLine(p01, new Point(610, 320), new Point(660, 320));
              g.DrawLine(p02, new Point(670, 320), new Point(720, 320));
              g.DrawLine(p01, new Point(730, 320), new Point(780, 320));

              g.DrawLine(p02, new Point(790, 320), new Point(840, 320));
              g.DrawLine(p01, new Point(850, 320), new Point(900, 320));
              g.DrawLine(p02, new Point(910, 320), new Point(960, 320));
              g.DrawLine(p01, new Point(970, 320), new Point(1020, 320));
              g.DrawLine(p02, new Point(1030, 320), new Point(1070, 320));
              g.DrawLine(p01, new Point(1080, 320), new Point(1130, 320));
            //2nd:(Zebra):-
              g.DrawLine(p01, new Point(400,0), new Point(400, 20));
              g.DrawLine(p02, new Point(400, 30), new Point(400, 50));
              g.DrawLine(p01, new Point(400, 60), new Point(400, 80));
              g.DrawLine(p02, new Point(400, 90), new Point(400, 110));
              g.DrawLine(p01, new Point(400, 120), new Point(400, 140));
              g.DrawLine(p02, new Point(400, 150), new Point(400, 170));
              g.DrawLine(p01, new Point(400,180), new Point(400, 200));
              g.DrawLine(p02, new Point(400, 210), new Point(400, 230));
              g.DrawLine(p01, new Point(400, 240), new Point(400, 260));
              g.DrawLine(p02, new Point(400, 270), new Point(400, 290));
              g.DrawLine(p01, new Point(400, 300), new Point(400, 320));
              g.DrawLine(p02, new Point(400, 330), new Point(400, 350));
              g.DrawLine(p01, new Point(400, 360), new Point(400, 380));
              g.DrawLine(p02, new Point(400, 390), new Point(400, 410));
              g.DrawLine(p01, new Point(400, 420), new Point(400, 440));
              g.DrawLine(p02, new Point(400, 450), new Point(400, 470));
              g.DrawLine(p01, new Point(400, 480), new Point(400, 500));
              g.DrawLine(p02, new Point(400, 510), new Point(400, 530));
              g.DrawLine(p01, new Point(400, 540), new Point(400, 560));
              g.DrawLine(p02, new Point(400, 570), new Point(400, 590));
              g.DrawLine(p01, new Point(400, 600), new Point(400, 620));
              g.DrawLine(p02, new Point(400, 630), new Point(400, 650));

              g.DrawLine(p01, new Point(645, 0), new Point(645, 20));
              g.DrawLine(p02, new Point(645, 30), new Point(645, 50));
              g.DrawLine(p01, new Point(645, 60), new Point(645, 80));
              g.DrawLine(p02, new Point(645, 90), new Point(645, 110));
              g.DrawLine(p01, new Point(645, 120), new Point(645, 140));
              g.DrawLine(p02, new Point(645, 150), new Point(645, 170));
              g.DrawLine(p01, new Point(645, 180), new Point(645, 200));
              g.DrawLine(p02, new Point(645, 210), new Point(645, 230));
              g.DrawLine(p01, new Point(645, 240), new Point(645, 260));
              g.DrawLine(p02, new Point(645, 270), new Point(645, 290));
              g.DrawLine(p01, new Point(645, 300), new Point(645, 320));
              g.DrawLine(p02, new Point(645, 330), new Point(645, 350));
              g.DrawLine(p01, new Point(645, 360), new Point(645, 380));
              g.DrawLine(p02, new Point(645, 390), new Point(645, 410));
              g.DrawLine(p01, new Point(645, 420), new Point(645, 440));
              g.DrawLine(p02, new Point(645, 450), new Point(645, 470));
              g.DrawLine(p01, new Point(645, 480), new Point(645, 500));
              g.DrawLine(p02, new Point(645, 510), new Point(645, 530));
              g.DrawLine(p01, new Point(645, 540), new Point(645, 560));
              g.DrawLine(p02, new Point(645, 570), new Point(645, 590));
              g.DrawLine(p01, new Point(645, 600), new Point(645, 620));
              g.DrawLine(p02, new Point(645, 630), new Point(645, 650));
            //Rode lamp:
              g.DrawLine(p0, new Point(130, 0), new Point(130, 55));
              g.DrawLine(p0, new Point(55, 0), new Point(55,55));
              g.DrawLine(p0, new Point(90, 406), new Point(90, 1));
              g.DrawLine(p0, new Point(130, 50), new Point(55, 55));

            //real 1st treee:-

              g.DrawLine(p03, new Point(835, 0), new Point(835, 80));
              g.DrawLine(p04, new Point(835, 23), new Point(835, 80));//ex
              g.DrawLine(p03, new Point(873, 15), new Point(793, 38));
              g.DrawLine(p03, new Point(873, 38), new Point(793, 15));
              //real 2nd tree:
              g.DrawLine(p03, new Point(917, 0), new Point(917, 80));
              g.DrawLine(p04, new Point(917, 23), new Point(917, 80));//ex
              g.DrawLine(p03, new Point(959, 15), new Point(879, 38));
              g.DrawLine(p03, new Point(959, 38), new Point(879, 15));
             // real 5th tree:
              g.DrawLine(p03, new Point(1009, 0), new Point(1009, 80));
              g.DrawLine(p04, new Point(1009, 23), new Point(1009, 80));//ex
              g.DrawLine(p03, new Point(1051, 15), new Point(971, 38));
              g.DrawLine(p03, new Point(1051, 38), new Point(971, 15));
              // real 6th tree:
              g.DrawLine(p03, new Point(1101, 0), new Point(1101, 80));
              g.DrawLine(p04, new Point(1101, 23), new Point(1101, 80));//ex
              g.DrawLine(p03, new Point(1143, 15), new Point(1063, 38));
              g.DrawLine(p03, new Point(1143, 38), new Point(1063, 15));
              //Real 3rd tree:-
                g.DrawLine(p03, new Point(200, 1), new Point(200, 70));
                g.DrawLine(p04, new Point(200, 20), new Point(200, 70));//ex
                g.DrawLine(p03, new Point(238, 6), new Point(158, 42));
                g.DrawLine(p03, new Point(238,42 ), new Point(158, 6));

              //real 4th tree:-
              g.DrawLine(p03, new Point(250, 1), new Point(250, 70));
              g.DrawLine(p04, new Point(250, 20), new Point(250, 70));//ex
              g.DrawLine(p03, new Point(288, 3), new Point(208, 42));
              g.DrawLine(p03, new Point(288, 42), new Point(208, 3));
        }
        public void DrawCar(Graphics g, int objId)
        {
            Pen p = new Pen(Color.SaddleBrown, 5);
            Pen p01 = new Pen(Color.Green, 3);
            Pen p02 = new Pen(Color.SkyBlue, 3);
            

            if (objId == 0)
            {
                //Right view :-
                g.DrawLine(p01, new Point(10, 150), new Point(10, 100));//back
                g.DrawLine(p01, new Point(10, 100), new Point(250, 100)); //vitorer line 
                g.DrawLine(p01, new Point(250, 100), new Point(270, 150)); //samner 
                g.DrawLine(p01, new Point(270, 150), new Point(208, 150)); 
               
                g.DrawLine(p01, new Point(160, 150), new Point(110, 150)); //car er nicher line
               
                g.DrawLine(p01, new Point(60, 150), new Point(10, 150)); //front
                g.DrawLine(p01, new Point(10, 100), new Point(40, 90));
                g.DrawLine(p01, new Point(40, 90), new Point(60, 70));
                g.DrawLine(p01, new Point(60, 70), new Point(180, 70));
                g.DrawLine(p01, new Point(180, 70), new Point(190, 80));
                //flag:-
                g.DrawLine(p01, new Point(180, 30), new Point(180, 70));
                g.DrawLine(p01, new Point(180, 50), new Point(205,50));
                g.DrawLine(p01, new Point(180, 30), new Point(205, 50));

               // g.DrawEllipse(new Pen(Color.Red,2),183,40,10,10); // red circle
                g.FillEllipse(Brushes.Red, 183, 40, 10, 10); // red circle

 
                g.DrawLine(p01, new Point(150, 120), new Point(130,120));
                g.DrawLine(p01, new Point(140,100),new Point(140,150));
                //
                g.DrawLine(p01, new Point(190, 80), new Point(250, 100));
                g.FillRectangle(Brushes.PaleGreen, 80, 75, 18, 20); //window
                g.FillRectangle(Brushes.PaleGreen, 150, 75, 18, 20);
                //xtr:
               // g.DrawLine(p01, new Point(5, 10), new Point(6, 9));

                 g.DrawEllipse(new Pen(Color.White,5), 60, 125, 50, 50);//wheel
                 g.FillEllipse(Brushes.Bisque, 68, 132, 35, 35);
                 g.FillEllipse(Brushes.Black, 75, 140, 20, 20);

                 g.DrawEllipse(new Pen(Color.White, 5), 160, 125, 50, 50);
                 g.FillEllipse(Brushes.Bisque, 168, 132, 35, 35);
                 g.FillEllipse(Brushes.Black, 175, 140, 20, 20);

                 g.FillRectangle(Brushes.Gold, 230, 100, 18, 20); //headlight
                //mirror:
                 g.DrawLine(p02, new Point(200, 95), new Point(180,100));
                 g.FillEllipse(Brushes.SkyBlue, 194, 88, 10, 10); // mirror
                
               
          
            }
            if (objId == 1)
            {
                // Left View:-
                g.DrawLine(p01, new Point(0, 150), new Point(10, 100));
                g.DrawLine(p01, new Point(10, 100), new Point(250, 100));
                g.DrawLine(p01, new Point(250, 100), new Point(250, 150));
                g.DrawLine(p01, new Point(250, 150), new Point(210, 150));
                g.DrawLine(p01, new Point(160, 150), new Point(110, 150));
                g.DrawLine(p01, new Point(60, 150), new Point(0, 150));
                g.DrawLine(p01, new Point(10, 100), new Point(75, 80));
                g.DrawLine(p01, new Point(75, 80), new Point(80, 70));
                g.DrawLine(p01, new Point(80, 70), new Point(195, 70));
                g.DrawLine(p01, new Point(195, 70), new Point(220, 90));
                g.DrawLine(p01, new Point(220, 90), new Point(250, 100));
                g.FillRectangle(Brushes.PaleGreen, 90, 75, 18, 20);
                g.FillRectangle(Brushes.PaleGreen, 160, 75, 18, 20);
                //flag( must change hare) :-
                g.DrawLine(p01, new Point(70,82), new Point(70,30));
                g.DrawLine(p01, new Point(70, 50), new Point(40, 50));
                g.DrawLine(p01, new Point(70, 30), new Point(40, 50));
                //g.DrawEllipse(new Pen(Color.Red, 2), 56, 40, 10, 10);// red circle 
                g.FillEllipse(Brushes.Red, 56, 40, 10, 10);// red circle 
                //
                //Tanar ta:
                g.DrawLine(p01, new Point(150, 120), new Point(130, 120));
                g.DrawLine(p01, new Point(140, 100), new Point(140, 150));
                //mirror:
                g.DrawLine(p02, new Point(65, 100), new Point(50, 95));
                g.FillEllipse(Brushes.SkyBlue,49, 88, 10, 10); // Mirror
                //wheel:-
                g.DrawEllipse(new Pen(Color.White, 5), 60, 125, 50, 50);
                g.FillEllipse(Brushes.Bisque, 68, 132, 35, 35);
                g.FillEllipse(Brushes.Black, 75, 140, 20, 20);

                g.DrawEllipse(new Pen(Color.White, 5), 160, 125, 50, 50);
                g.FillEllipse(Brushes.Bisque, 168, 132, 35, 35);
                g.FillEllipse(Brushes.Black, 175, 140, 20, 20);

                g.FillRectangle(Brushes.Gold, 10, 100, 18, 20);
               

            }
            if (objId == 2)
            {
                //Up View:-
                g.DrawLine(p01, new Point(100,210), new Point(190, 210));
                g.DrawLine(p01, new Point(100, 210), new Point(100, 50));
                g.DrawLine(p01, new Point(100, 50), new Point(120, 20));
                g.DrawLine(p01, new Point(120, 20), new Point(170, 20));
                g.DrawLine(p01, new Point(170, 20), new Point(190, 50));
                g.DrawLine(p01, new Point(190, 210), new Point(190, 50));
                Point[] p1 = { new Point(100, 50), new Point(150, 40), new Point(190, 50) };
                g.DrawCurve(p01, p1);
                g.DrawLine(p01, new Point(100, 50), new Point(130, 70));
                g.DrawLine(p01, new Point(130, 70), new Point(130, 180));
                g.DrawLine(p01, new Point(130, 180), new Point(100, 210));
                g.DrawLine(p01, new Point(190, 50), new Point(160, 70));
                g.DrawLine(p01, new Point(160, 70), new Point(160, 180));
                g.DrawLine(p01, new Point(160, 180), new Point(190, 210));
                g.DrawLine(p01, new Point(130, 70), new Point(160, 70));
                g.DrawLine(p01, new Point(130, 180), new Point(160, 180));

                g.FillRectangle(Brushes.Gold, 120, 20, 10, 10);
                g.FillRectangle(Brushes.Gold, 160, 20, 10, 10);

             
            }
            if (objId == 3)
            { 
                //Down view:-
                g.DrawLine(p01, new Point(100, 50), new Point(190, 50));

                Point[] p1 = { new Point(100, 210), new Point(150, 218), new Point(190, 210) };
                g.DrawCurve(p01, p1);
                g.DrawLine(p01, new Point(100, 210), new Point(120, 240));
                g.DrawLine(p01, new Point(120, 240), new Point(170, 240));
                g.DrawLine(p01, new Point(170, 240), new Point(190, 210));


                g.DrawLine(p01, new Point(100, 210), new Point(100, 50));
                g.DrawLine(p01, new Point(190, 210), new Point(190, 50));
                g.DrawLine(p01, new Point(100, 50), new Point(130, 70));
                g.DrawLine(p01, new Point(130, 70), new Point(130, 180));
                g.DrawLine(p01, new Point(130, 180), new Point(100, 210));
                g.DrawLine(p01, new Point(190, 50), new Point(160, 70));
                g.DrawLine(p01, new Point(160, 70), new Point(160, 180));
                g.DrawLine(p01, new Point(160, 180), new Point(190, 210));
                g.DrawLine(p01, new Point(130, 70), new Point(160, 70));
                g.DrawLine(p01, new Point(130, 180), new Point(160, 180));
                g.FillRectangle(Brushes.Gold, 120, 230, 10, 10);
                g.FillRectangle(Brushes.Gold, 160, 230, 10, 10);


            }
            
        }
    }
}
