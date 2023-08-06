using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace feff1
{
    public class Cheath
    {
        public int X, Y;

        public Bitmap imgs;
        public int dx = 1;
        public int iCurrFrame = 0;

    }
    public class Cfire
    {
        public Rectangle rcDst;
        public Rectangle rcSrc;
        public List<Bitmap> imgs = new List<Bitmap>();
        public int dx = 1;
        public int iCurrFrame = 0;

    }
    public class CActor
    {
        //public int X, Y;
        public Rectangle rcDst;
        public Rectangle rcSrc;
        // public Bitmap img;
        public List<Bitmap> imgs = new List<Bitmap>();
        public int iCurrFrame = 0;
        public int HEALTH=300;

    }
    
    /*public class CActor
    {
        public int X, Y;
        public List<Bitmap> imgs = new List<Bitmap>();
        public int iCurrFrame = 0;
    }*/
    public partial class Form1 : Form
    {
        int finn = 1;
        int g = 700;
        int cc = 0;
        int t = 0;
        int finishstart;
        Bitmap BK = new Bitmap("20.bmp");
        Bitmap off;
        Random RR = new Random();
        Random ee = new Random();

        //SoundPlayer soundPlayer = new SoundPlayer(soundLocation: @"C:\Users\Mostafa\source\repos\feff1\feff1\bin\Debug\net5.0-windowsfight.mp3");
        int ct = 0,ct11;
        int end = 0;
        int ww = 0;
        int ff = 4;
        int fin = 0;
      int ctcrouch = 0;
        int enmhit = 0;
        int comact = 0;
        int ctboxing = 0;
        int ctleg = 0;
        int fire=0;
        int com1 = 0, com2 = 0;
        int[] flagct = new int[100];
        int[] bullets = new int[100];
        int[] move = new int[100];
       
    //int ct = 1;
    int ctt = 0;
        Cheath pnn1 = new Cheath();
        int plaer2health=300;
       int plaer1health=300;
        Cfire pnn211 = new Cfire();
        Cfire pnn300 = new Cfire();

        List<Cfire> fini = new List<Cfire>();
        List<Cfire> lf = new List<Cfire>();

        public int H=1,p1=1;
        List<CActor> LActs = new List<CActor>();
        List<CActor> Lend = new List<CActor>();
        List<CActor> Lstart = new List<CActor>();

        List<CActor> player2lose = new List<CActor>();
        
        List<CActor> lplayer1win = new List<CActor>();
        List<CActor> LActs2 = new List<CActor>();
        List<Cheath> Lhealth = new List<Cheath>();
        Timer tt = new Timer();
        int ck = 0;
        int yes = 0;

        int start;
        public Form1()
        {
            this.WindowState = FormWindowState.Maximized;
            this.Paint += new PaintEventHandler(Form1_Paint);
            this.Load += new EventHandler(Form1_Load);
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            tt.Start();
            tt.Interval = 10;
            tt.Tick += Tt_Tick;
        }
        private void Tt_Tick(object sender, EventArgs e)
        {
            if (ck == 0)
            {
                 RR = new Random();
                 ct = RR.Next(1, 3);
            }
            if (ck % 2 == 0)
            {
                if (LActs2[0].rcDst.X <= LActs[0].rcDst.X + 200)
                {
                ee = new Random();
                ct11 = ee.Next(1, 4);
                    if (ct11 == 1)
                    {
                        hit();
                    }

                    if (ct11 == 2)
                    {
                        hit2();
                    }
                    if (ct11 == 3)
                    {
                        hit3();
                    }

                    }
                else
                {
                    moveenm();
                }
            }

            if(ck==50)
            {

                //if(ct==2)
                //{
                //    ct = 1;
                //}
                start++;

                //    ct++;
                 RR = new Random();
                 ct = RR.Next(1, 3);
                ck = 0;

            }
            for(int i=0;i<10;i++)
            {
                if (flagct[i] == 1)
                {
                    t++;
                     
                        fireon(i);
                    if (lf[0].rcDst.X >= LActs2[0].rcDst.X || bullets[i] >= 11)
                    {
                    coma();
                        ISHIT();

                        move[i] += 8110;

                        flagct[i] = 0;
                    }
                    else
                    {

                        bullets[i]++;
                        move[i] += 80;
                    }
                    if (bullets[i] > 10)
                    {
                        move[i] += 8110;
                        flagct[i] = 0;
                        lf.RemoveAt(0);

                    }
                    else
                    {
                        lf.RemoveAt(0);
                    }


                }
                //DrawDubb(this.CreateGraphics());

            }

            if (finishstart==1)
                {
                    movefin();
                    g -= 100;
                    finn++;
                fini.RemoveAt(0);
                }
            //if (LActs2[0].rcDst.X <= LActs[0].rcDst.X + 200)
            //{
            //    hit();
            //}
            //else
            //{
            //    moveenm();
            //}

        ck++;
            DrawDubb(this.CreateGraphics());
        }
       
        void hit()
        {
            //ctcrouch++;
            ctboxing = 0;
            //enmhit = 0;
           
                enmhit++;
                if (enmhit == 1)
                {
                    LActs2[0].iCurrFrame = 9;
                }
                else
                {


                    LActs2[0].iCurrFrame++;

                    if (16 < LActs2[0].iCurrFrame)
                    {
                        enmhit = 0;
                        LActs2[0].iCurrFrame = 0;
                    }
                }
                DrawDubb(this.CreateGraphics());

            ISHIT0();
        }


        void hit2()
        {
            //ctcrouch++;
            ctboxing = 0;
            //enmhit = 0;

            com1++;
            if (com1 == 1)
            {
                LActs2[0].iCurrFrame = 32;
            }
            else
            {


                LActs2[0].iCurrFrame++;

                if (39 < LActs2[0].iCurrFrame)
                {
                    com1 = 0;
                    LActs2[0].iCurrFrame = 0;
                }
            }
            DrawDubb(this.CreateGraphics());

            ISHIT0();
        }
        void hit3()
        {
            //ctcrouch++;
            ctboxing = 0;
            //enmhit = 0;

            com2++;
            if (com2 == 1)
            {
                LActs2[0].iCurrFrame = 39;
            }
            else
            {


                LActs2[0].iCurrFrame++;

                if (48 < LActs2[0].iCurrFrame)
                {
                    com2 = 0;
                    LActs2[0].iCurrFrame = 0;
                }
            }
            DrawDubb(this.CreateGraphics());

            ISHIT0();
        }





      


        void moveenm()
        {
            
            if(LActs[0].rcDst.X<LActs2[0].rcDst.X-500)
            {
                ct = 2;
            }

            if (ct==1&&LActs2[0].rcDst.X>=LActs[0].rcDst.X)
            {
                LActs2[0].rcDst.X += 6;
                LActs2[0].iCurrFrame++;
                if (LActs2[0].iCurrFrame >= 8)
                {
                    LActs2[0].iCurrFrame = 0;
                }

            }

            if (LActs2[0].rcDst.X <= LActs2[0].rcDst.X - 40)
                LActs2[0].rcDst.X -= 20;

            if (ct == 2 /*&& LActs2[0].rcDst.X >= LActs[0].rcDst.X*/)
            {
                LActs2[0].rcDst.X -= 6;
                LActs2[0].iCurrFrame++;
                if (LActs2[0].iCurrFrame >= 8)
                {
                    LActs2[0].iCurrFrame = 0;
                }

            }
            DrawDubb(this.CreateGraphics());

        }
        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int i;
            if (e.KeyCode == Keys.D)
            {
                ctcrouch = 0;
                ctboxing = 0;
                ctleg = 0;
                fin = 0;
                fire = 0;
                start++;

                // LActs[i].X += 5;
                if (LActs[0].rcDst.X <= 1800)
                    LActs[0].rcDst.X += 20;

                if (LActs[0].rcDst.X >= LActs2[0].rcDst.X-40)
                    LActs[0].rcDst.X -= 20;

                LActs[0].iCurrFrame++;
                if (LActs[0].iCurrFrame >= 8)
                {
                    LActs[0].iCurrFrame = 0;
                }



            }
            //if (e.KeyCode == Keys.D)
            //{
            //}
            if (e.KeyCode == Keys.S)
            {
                ctboxing = 0;
                ctleg = 0;
                ctcrouch = 0;
                fin = 0;
                fire = 0;
                start++;


                for (i = 1; i < 4; i++)
                {

                    ctcrouch++;
                    ctboxing = 0;


                    if (ctcrouch == 1)
                    {
                        LActs[0].iCurrFrame = 8;
                    }
                    else
                    {


                        LActs[0].iCurrFrame++;

                        if (10 < LActs[0].iCurrFrame)
                        {
                            ctcrouch = 0;
                            LActs[0].iCurrFrame = 0;
                        }
                    }

                    DrawDubb(this.CreateGraphics());

                }

            }


            if (e.KeyCode == Keys.E)
            {
                ctcrouch = 0;
                ctleg = 0;
                fin = 0;
                fire = 0;
                start++;

                //ctboxing = 0;

                //for (i = 1; i < 6; i++)
                ////{
                //{
                ctboxing++;

                    if (ctboxing == 1)
                    {
                        LActs[0].iCurrFrame = 11;
                    }
                    else
                    {


                        LActs[0].iCurrFrame++;

                        if (13 < LActs[0].iCurrFrame)
                        {
                            ctboxing = 0;
                            LActs[0].iCurrFrame = 0;
                        }
                    }
                    DrawDubb(this.CreateGraphics());

                //}
                if (LActs[0].rcDst.X > LActs2[0].rcDst.X - 150 && LActs[0].rcDst.X < LActs2[0].rcDst.X + 40)
                {
                    ISHIT();
                }

            }
            if (e.KeyCode == Keys.R)
            {
                ctcrouch = 0;
                ctboxing = 0;
                //ctleg = 1;
                //ctleg = 0;
                fin = 0;
                fire = 0;
                start++;

                //for (i = 1; i <6 ; i++)
                //{
                ctleg++;

                if (ctleg == 1)
                {
                    LActs[0].iCurrFrame = 14;
                }
                else
                {


                    LActs[0].iCurrFrame++;

                    if (18 <= LActs[0].iCurrFrame)
                    {
                        ctleg = 0;
                        LActs[0].iCurrFrame = 0;
                    }
                }
                DrawDubb(this.CreateGraphics());

                //}
                if (LActs[0].rcDst.X > LActs2[0].rcDst.X - 150 && LActs[0].rcDst.X < LActs2[0].rcDst.X + 40)
                {
                    ISHIT();
                }
            }
            if (e.KeyCode == Keys.F && LActs[0].rcDst.X <= 50)
            {
                ctboxing = 0;
                ctleg = 0;
                ctcrouch = 0;
                fin = 0;
                fire = 0;

                for (i = 1; i < 7; i++)
                {

                    fin++;


                    if (fin == 1)
                    {
                        LActs[0].iCurrFrame = 19;
                    }
                    else
                    {

                        LActs[0].iCurrFrame++;

                        if (25 < LActs[0].iCurrFrame)
                        {
                            fin = 0;
                            LActs[0].iCurrFrame = 0;
                        }
                    }
                    finishstart = 1;


                    DrawDubb(this.CreateGraphics());

                }


            }
            if (e.KeyCode == Keys.A)
            {
                ctcrouch = 0;
                ctboxing = 0;
                ctleg = 0;
                fin = 0;
                fire = 0;

                start++;


                for (i = 0; i < LActs.Count; i++)
                {
                    //LActs[i].X -= 5;
                    //if (LActs[i].rcDst.X! <= 0 )
                    if (LActs[i].rcDst.X >= 0)
                        LActs[i].rcDst.X -= 20;


                    LActs[i].iCurrFrame++;
                    if (LActs[i].iCurrFrame >= 8)
                    {
                        LActs[i].iCurrFrame = 0;
                    }
                }

            }




            if (e.KeyCode == Keys.Q)
            {
                ctboxing = 0;
                ctleg = 0;
                ctcrouch = 0;
                fin = 0;
                ff = 0;
                fire = 0;
                start++;


                for (i = 1; i < 4; i++)
                {

                    ff++;


                    if (ff == 1)
                    {
                        LActs[0].iCurrFrame = 25;
                    }
                    else
                    {

                        LActs[0].iCurrFrame++;

                        if (27 < LActs[0].iCurrFrame)
                        {
                            ff = 0;
                            LActs[0].iCurrFrame = 0;
                        }
                    }


                    DrawDubb(this.CreateGraphics());

                }
                flagct[ww] = 1;
                ww++;



                //DrawDubb(this.CreateGraphics());

            }
        }
       void coma()
        {
           
                //ctcrouch++;
                ctboxing = 0;
            comact = 0;
            //enmhit = 0;
            //for (int i = 1; i < 6; i++)
            //{
            comact++;
                    if (comact == 1)
                    {
                        LActs2[0].iCurrFrame = 25;
                    }
                    else
                    {


                        LActs2[0].iCurrFrame++;

                        if (29 < LActs2[0].iCurrFrame)
                        {
                            comact = 0;
                            LActs2[0].iCurrFrame = 0;
                        }
                    }
                    DrawDubb(this.CreateGraphics());
                //}
            
        }
      void burncar()
        {
            ctcrouch=0;
            ctboxing = 0;
            fire = 0;
            int q = LActs2[0].rcDst.Y;
            for (int i = 1; i < 9; i++)
            {

                fire++;
                if (fire == 1)
                {
                    LActs2[0].iCurrFrame = 17;
                }
                else
                {


                    LActs2[0].iCurrFrame++;

                    LActs2[0].rcDst.Y -= 20;

                    if (25 < LActs2[0].iCurrFrame)
                    {
                        LActs2[0].rcDst.Y +=180;
                        fire = 0;
                        //LActs2[0].iCurrFrame = 24;
                        


                    }
                }

                DrawDubb(this.CreateGraphics());

            }

            LActs2[0].rcDst.Y += 180;
            ctt = 2;
            end = 1;
            cc = 1;
            player2losee();
            player1win();
            endd();


        }
        void movefin()
        {

            //off = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            int X, Y;
             pnn211 = new Cfire();
                //pnn211.rcDst.X = LActs2[0].rcDst.X+100 ;
                //pnn211.rcDst.Y = LActs2[0].rcDst.Y;
                pnn211.rcSrc = new Rectangle(0, 0, 400/*pnn.imgs.Width*/, 400/*pnn.imgs.Height*/);
                X = LActs2[0].rcDst.X - g;
                Y = LActs2[0].rcDst.Y;
                pnn211.rcDst = new Rectangle(X, Y, 1500, 1500);

                Bitmap img = new Bitmap("firefinish"+finn+ ".bmp");
               Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnn211.imgs.Add(img);

                fini.Add(pnn211);
                if (finn == 8)
                {
                burncar();
                    finishstart = 0;
                }
                DrawDubb(this.CreateGraphics());
            
        }





        void fireon(int i)
        {

            //off = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            int X, Y;
           
                pnn300 = new Cfire();
                //pnn211.rcDst.X = LActs2[0].rcDst.X+100 ;
                //pnn211.rcDst.Y = LActs2[0].rcDst.Y;
                pnn300.rcSrc = new Rectangle(0, 0, 400/*pnn.imgs.Width*/, 400/*pnn.imgs.Height*/);
                X = LActs[0].rcDst.X +10+move[i];
                Y = LActs[0].rcDst.Y;
                pnn300.rcDst = new Rectangle(X, Y, 1500, 1500);

                Bitmap img = new Bitmap("fire" + bullets[i] + ".bmp");
                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnn300.imgs.Add(img);

                lf.Add(pnn300);
                if (ff == 10)
                {

                }
                DrawDubb(this.CreateGraphics());
            

        }
























        void ISHIT0()
        {
            if (LActs[0].rcDst.X <= LActs2[0].rcDst.X)
            {
                plaer1health -= 10;

                if (plaer1health == 270 || plaer1health == 220 || plaer1health == 170 || plaer1health == 120 || plaer1health == 70 || plaer1health == 40 || plaer1health == 20)
                {
                    p1++;

                    Lhealth[1].imgs = new Bitmap("health" + p1 + ".bmp");

                }
                if (plaer1health <= 0)
                {
                    end = 1;
                    player1lose();
                    player2win();
                    cc = 2;
                    endd();
                }
                //H ++;
                //MessageBox.Show(H+"");




            }
        }

        void ISHIT()
        {
           
            
            //if (LActs[0].rcDst.X <= LActs2[0].rcDst.X)
            //{
            plaer2health -= 5;

                if (plaer2health == 270 || plaer2health == 220 || plaer2health == 170 || plaer2health == 120 || plaer2health == 70 || plaer2health == 40 || plaer2health == 20)
                {
                    H++;

                    Lhealth[0].imgs = new Bitmap("health" + H + ".bmp");

                }
                if (plaer2health <= 0)
                {
                    end = 1;
                    ctt = 1;
                    player2losee();
                    player1win();
                    cc = 1;
                    endd();
                }
                //H ++;
                //MessageBox.Show(H+"");




            
        }
        void createhealthbar()
        {
            
            off = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            Random RR = new Random();
            int j = 0;
            for (int i = 0; i < 2; i++)
            {
                pnn1 = new Cheath();
                pnn1.X = 1500-j;
                pnn1.Y = 100;
                Lhealth.Add(pnn1);
                Lhealth[i].imgs = new Bitmap("health1.bmp");
                j += 1200;


            }


          
        }

        void Form1_Load(object sender, EventArgs e)
        {
            //soundPlayer.Play();
            //soundPlayer.Stop();
            CreateParamsfighttext();
            for (int i = 0; i < 100; i++)
            {


                bullets[i] = 3;
                move[i] = 0;


            }
            off = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            createhealthbar();

            Random RR = new Random();

            int X, Y;

            CActor pnn = new CActor();
            //    pnn.X = RR.Next(100, this.Width);
            pnn.rcSrc = new Rectangle(0, 0, 400/*pnn.imgs.Width*/, 400/*pnn.imgs.Height*/);
            X = 500;
            Y = 500;
            pnn.rcDst = new Rectangle(X, Y, 1500, 1500);

            // pnn.Y = RR.Next(100, this.Height);
            for (int k = 0; k < 8; k++)
            {
                Bitmap img = new Bitmap((k + 1) + ".bmp");
                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnn.imgs.Add(img);
            }
          
            for (int i = 1; i < 4; i++)
            {
                Bitmap img = new Bitmap(("crouch" + i + ".bmp"));

                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnn.imgs.Add(img);

            }
            for (int q = 1; q < 4; q++)
            {
                Bitmap img = new Bitmap(("boxing" + q + ".bmp"));
                //LActs[0].rcDst.Y += 50;

                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnn.imgs.Add(img);

            }
            for (int i = 1; i < 6; i++)
            {
                Bitmap img = new Bitmap(("leg" + i + ".bmp"));

                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnn.imgs.Add(img);

            }
            for (int i = 1; i < 7; i++)
            {
                Bitmap img = new Bitmap(("finish" + i + ".bmp"));

                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnn.imgs.Add(img);

            }
            for (int i = 1; i < 4; i++)
            {
                Bitmap img = new Bitmap(("fire" + i + ".bmp"));

                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnn.imgs.Add(img);

            }


            LActs.Add(pnn);
            createActor2();
            //createfire();

            //createhealthbar();


        }
        void createActor2()
        {
            off = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            Random RR = new Random();

            int X, Y;

            CActor pnn = new CActor();
            //    pnn.X = RR.Next(100, this.Width);
            pnn.rcSrc = new Rectangle(0, 0, 400/*pnn.imgs.Width*/, 400/*pnn.imgs.Height*/);
            X = 900;
            Y = 500;
            pnn.rcDst = new Rectangle(X, Y, 1500, 1500);

           
            for (int a = 0; a < 8; a++)
            {
                Bitmap img = new Bitmap("player2" +"."+ (a + 1) + ".bmp");
                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnn.imgs.Add(img);
            }
            for (int i = 1; i < 4; i++)
            {
                Bitmap img = new Bitmap(("box" + i + ".bmp"));

                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnn.imgs.Add(img);

            }
            for (int i = 1; i < 4; i++)
            {
                Bitmap img = new Bitmap(("player2leg" + i + ".bmp"));

                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnn.imgs.Add(img);

            }
            for (int i = 1; i < 4; i++)
            {
                Bitmap img = new Bitmap(("imdown" + i + ".bmp"));

                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnn.imgs.Add(img);

            }
            for (int i = 1; i < 9; i++)
            {
                Bitmap img = new Bitmap(("skullbody"+i + ".bmp"));

                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnn.imgs.Add(img);

            }
            for (int i = 1; i < 6; i++)
            {
                Bitmap img = new Bitmap(("coma" + i + ".bmp"));

                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnn.imgs.Add(img);

            }
            for (int i = 1; i < 11; i++)
            {
                Bitmap img = new Bitmap(("fightcom" + i + ".bmp"));

                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnn.imgs.Add(img);

            }
            for (int i = 1; i < 10; i++)
            {
                Bitmap img = new Bitmap(("fightp" + i + ".bmp"));

                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnn.imgs.Add(img);

            }


            LActs2.Add(pnn);
        }

        void CreateParamsfighttext()
        {
            off = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            Random RR = new Random();

            int X, Y;

            CActor pnnst = new CActor();
            //    pnn.X = RR.Next(100, this.Width);
            pnnst.rcSrc = new Rectangle(0, 0, 400/*pnn.imgs.Width*/, 400/*pnn.imgs.Height*/);
            X = 500;
            Y = 0;
            pnnst.rcDst = new Rectangle(X, Y, 1500, 1500);

          
                Bitmap img = new Bitmap("fighttext" + ".bmp");
                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnnst.imgs.Add(img);
            

            
            Lstart.Add(pnnst);
        }
        void endd()
        {
            off = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            Random RR = new Random();

            int X, Y;

            CActor pnn11 = new CActor();
            //    pnn.X = RR.Next(100, this.Width);
            pnn11.rcSrc = new Rectangle(0, 0, 400/*pnn.imgs.Width*/, 400/*pnn.imgs.Height*/);
            X = 500;
            Y = 0;
            pnn11.rcDst = new Rectangle(X, Y, 1500, 1500);

            if (cc == 1)
            {
                Bitmap img = new Bitmap("win" + ".bmp");
                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnn11.imgs.Add(img);
            }

            if (cc == 2)
            {
                Bitmap img = new Bitmap("lost" + ".bmp");
                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnn11.imgs.Add(img);
            }
            Lend.Add(pnn11);


            




        }
      void player1win()
        {

            off = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            Random RR = new Random();

            int X, Y;
            CActor pnn12 = new CActor();
            //    pnn.X = RR.Next(100, this.Width);
            pnn12.rcSrc = new Rectangle(0, 0, 400/*pnn.imgs.Width*/, 400/*pnn.imgs.Height*/);
            X = LActs[0].rcDst.X;
            Y = LActs[0].rcDst.Y;
            pnn12.rcDst = new Rectangle(X, Y, 1500, 1500);


            Bitmap img = new Bitmap("winplayer1" + ".bmp");
            Color clr = img.GetPixel(0, 0);
            img.MakeTransparent(clr);
            pnn12.imgs.Add(img);
            lplayer1win.Add(pnn12);
        }
        void player1lose()
        {

            off = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            Random RR = new Random();

            int X, Y;
            CActor pnn12 = new CActor();
            //    pnn.X = RR.Next(100, this.Width);
            pnn12.rcSrc = new Rectangle(0, 0, 400/*pnn.imgs.Width*/, 400/*pnn.imgs.Height*/);
            X = LActs[0].rcDst.X;
            Y = LActs[0].rcDst.Y;
            pnn12.rcDst = new Rectangle(X, Y, 1500, 1500);


            Bitmap img = new Bitmap("player1lose" + ".bmp");
            Color clr = img.GetPixel(0, 0);
            img.MakeTransparent(clr);
            pnn12.imgs.Add(img);
            lplayer1win.Add(pnn12);
        }
        void player2losee()
        {

            off = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            Random RR = new Random();

            int X, Y;
            CActor pnn13 = new CActor();
            //    pnn.X = RR.Next(100, this.Width);
            pnn13.rcSrc = new Rectangle(0, 0, 400/*pnn.imgs.Width*/, 400/*pnn.imgs.Height*/);
            X = LActs2[0].rcDst.X;
            Y = LActs2[0].rcDst.Y;
            if(ctt==2)
            {
                Y = LActs2[0].rcDst.Y-180;

            }
            pnn13.rcDst = new Rectangle(X, Y, 1500, 1500);

            if (ctt == 1)
            {
                Bitmap img = new Bitmap("player2dead" + ".bmp");
                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnn13.imgs.Add(img);
            }

            if (ctt == 2)
            {

                Bitmap img = new Bitmap("skullbody8" + ".bmp");

                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnn13.imgs.Add(img);
            }


            player2lose.Add(pnn13);
        }
        void player2win()
        {

            off = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            Random RR = new Random();

            int X, Y;
            CActor pnn13 = new CActor();
            //    pnn.X = RR.Next(100, this.Width);
            pnn13.rcSrc = new Rectangle(0, 0, 400/*pnn.imgs.Width*/, 400/*pnn.imgs.Height*/);
            X = LActs2[0].rcDst.X;
            Y = LActs2[0].rcDst.Y;
            pnn13.rcDst = new Rectangle(X, Y, 1500, 1500);

          
                Bitmap img = new Bitmap("player2win" + ".bmp");
                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnn13.imgs.Add(img);
           

            //if (ctt == 2)
            //{
            //    Bitmap img = new Bitmap("skullbody1" + ".bmp");

            //    Color clr = img.GetPixel(0, 0);
            //    img.MakeTransparent(clr);
            //    pnn13.imgs.Add(img);
            //}



            player2lose.Add(pnn13);
        }
        void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawDubb(e.Graphics);
        }

        void DrawDubb(Graphics g)
        {
            Graphics g2 = Graphics.FromImage(off);
            DrawScene(g2);
            g.DrawImage(off, 0, 0);
        }

        void DrawScene(Graphics g)
        {

            //g.Clear(Color.Gray);
            g.DrawImage(BK, 0, 0, this.Width, this.Height);
            Color clr;
            if (end != 1)
            {
                //for (int i = 0; i < LActs.Count; i++)
                //{

                int k = LActs[0].iCurrFrame;

                g.DrawImage(LActs[0].imgs[k], LActs[0].rcDst, LActs[0].rcSrc, GraphicsUnit.Pixel);


                //}
                //for (int i = 0; i < LActs2.Count; i++)
                //{

                int s = LActs2[0].iCurrFrame;

                g.DrawImage(LActs2[0].imgs[s], LActs2[0].rcDst, LActs2[0].rcSrc, GraphicsUnit.Pixel);
                //}
                for (int i = 0; i < Lhealth.Count; i++)
                {
                    //int k = Lhealth[i].iCurrFrame;
                    //int e = Lhealth[i].iCurrFrame;

                    clr = Lhealth[i].imgs.GetPixel(0, 0);
                    Lhealth[i].imgs.MakeTransparent(clr);

                    g.DrawImage(Lhealth[i].imgs, Lhealth[i].X, Lhealth[i].Y);

                }
                if(start==0)
                {
                    g.DrawImage(Lstart[0].imgs[0], Lstart[0].rcDst, Lstart[0].rcSrc, GraphicsUnit.Pixel);


                }
                for (int i = 0; i < fini.Count; i++)
                {
                    //int k = Lhealth[i].iCurrFrame;
                    //int e = Lhealth[i].iCurrFrame;

                    
                    g.DrawImage(fini[i].imgs[0], fini[i].rcDst, fini[i].rcSrc, GraphicsUnit.Pixel);

                }
                for (int i = 0; i < lf.Count; i++)
                {
                    //int k = Lhealth[i].iCurrFrame;
                    //int e = Lhealth[i].iCurrFrame;


                    g.DrawImage(lf[i].imgs[0], lf[i].rcDst, lf[i].rcSrc, GraphicsUnit.Pixel);

                }
            }
            else
            {

                

                g.DrawImage(lplayer1win[0].imgs[0], lplayer1win[0].rcDst, lplayer1win[0].rcSrc, GraphicsUnit.Pixel);
                g.DrawImage(player2lose[0].imgs[0], player2lose[0].rcDst, player2lose[0].rcSrc, GraphicsUnit.Pixel);
                g.DrawImage(Lend[0].imgs[0], Lend[0].rcDst.X, Lend[0].rcDst.Y);

            }
        }
    }
}
