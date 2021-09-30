using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yılanoyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<KareInfo> listKare = new List<KareInfo>();
        List<KareInfo> listUzuv = new List<KareInfo>();
        YılanInfo yılanInfo = null;
        int yon = 2;
        int toplamKareSayisi = 900;
        bool gameOver = false;
        bool yemVar = false;
        int scr = 0;
        bool hızlı = false;
        bool gamecon = false;
        

        private void Form1_Load(object sender, EventArgs e)
        {
            int kareKenarUzunluk = 12;
            int kareX = 1;
            int kareY = 1;
            int margin = 2;

            for (int i = 0; i < toplamKareSayisi; i++)
            {
                KareInfo kareInfo = new KareInfo(this.panel, new Point(kareX, kareY), new Size(kareKenarUzunluk, kareKenarUzunluk), i);
                listKare.Add(kareInfo);
                kareX += kareKenarUzunluk + margin;

                if ((i + 1) % 30 == 0)
                {
                    kareX = 1;
                    kareY += kareKenarUzunluk + margin;
                }
            }
            sınırEkle();
            

            yılanInfo = new YılanInfo(listKare,listUzuv);
        }
        
        void yemEkle()
        {
            if (yemVar)
            {
                return;
            }
            else
            {
                Random random = new Random();
                int indis = 0;
                bool durum = false;
                while (durum == false)
                {
                    indis = random.Next(0, toplamKareSayisi);
                    durum = true;
                    if (this.listKare[indis].sinir || this.listKare[indis].uzuv)
                    {
                        durum = false;
                    }

                }
                if (durum)
                {
                    this.listKare[indis].yemYap();
                    this.yemVar = true;
                }

            }

        }
        void sınırEkle()
        {
            for (int i = 0; i < 30; i++)
            {
                listKare[i].sinirYap();
            }
            for (int i = 0; i < 870; i +=30)
            {
                listKare[i].sinirYap();
            }
            for (int i = 29; i < 899; i +=30)
            {
                listKare[i].sinirYap();
            }
            for (int i = 870; i < 900; i++)
            {
                listKare[i].sinirYap();
            }
        }

        class KareInfo {

            public Point location { get; set; }
            public Size size { get; set; }
            public Color backColor { get; set; }
            public int indis { get; set; }
            public bool uzuv { get; set; }
            public bool yem { get; set; }
            public bool sinir { get; set; }
            public Panel panel { get; set; }
            public PictureBox pictureBox { get; set; }


            public KareInfo(Panel panel,Point location, Size size,int indis)
            {
                this.panel = panel;
                this.location = location;
                this.size = size;
                this.indis = indis;
                this.backColor = Color.Black;
                this.uzuv = false;
                this.yem = false;
                this.sinir = false;
                pictureBoxAdd();
                
            }

            void pictureBoxAdd()
            {
                pictureBox = new PictureBox();
                pictureBox.Location = this.location;
                pictureBox.Size = this.size;
                pictureBox.BackColor = this.backColor;
                this.panel.Controls.Add(pictureBox);
            }

            public void uzuvYap()
            {
                this.pictureBox.BackColor = Color.GreenYellow;
                this.uzuv = true;
            }

            public void uzuvYapma()
            {
                this.pictureBox.BackColor = this.backColor;
                this.uzuv = false;
            }

            public void yemYap()
            {
                this.pictureBox.BackColor = Color.Red;
                this.yem = true;
            }

            public void yemYapma()
            {
                this.pictureBox.BackColor = this.backColor;
                this.yem = false;
            }

            public void sinirYap()
            {
                this.pictureBox.BackColor = Color.Gray;
                this.sinir = true;
            }



        }

        class YılanInfo
        {
            public int starPosition = 33;
            public int yon { get; set; }
            public List<KareInfo> listKare { get; set; }
            public List<KareInfo> listUzuv { get; set; }  
            

            public YılanInfo(List<KareInfo> listKare, List<KareInfo> listUzuv)
            {
                this.listKare = listKare;
                this.listUzuv = listUzuv;

                this.listKare[31].uzuvYap();
                this.listKare[32].uzuvYap();
                this.listKare[33].uzuvYap();
                this.listUzuv.Add(this.listKare[31]);
                this.listUzuv.Add(this.listKare[32]);
                this.listUzuv.Add(this.listKare[33]);
            }

            public int yurut(int yon)
            {
                this.yon = yon;
                switch (yon)
                {
                    case 1:
                        starPosition = starPosition - 30;
                        break;
                    case 2:
                        starPosition = starPosition + 1;
                        break;
                    case 3:
                        starPosition = starPosition + 30;
                        break;
                    case 4:
                        starPosition = starPosition - 1;
                        break;
                    default:
                        break;
                }
                if(this.listKare[this.starPosition].uzuv || this.listKare[this.starPosition].sinir)
                {
                    return 0; //oyun bitiyor
                }
                else
                {
                    this.listKare[starPosition].uzuvYap();
                    this.listUzuv.Add(this.listKare[starPosition]);
                    if (this.listKare[starPosition].yem)
                    {
                        this.listKare[starPosition].yem = false;
                        
                        return 2;
                    }
                    else
                    {
                        this.listKare[this.listUzuv[0].indis].uzuvYapma();
                        this.listUzuv.RemoveAt(0);
                        return 1;
                    }
                }

                
            }
        }
        void newGame()
        {
            timer1.Stop();
            foreach (KareInfo item in listKare)
            {
                if (!item.sinir)
                {
                    item.uzuvYapma();
                    item.yemYapma();
                }
            }
            timer1.Interval = 100;
            gameOver = false;
            gamecon = false;
            hızlı = false;
            yon = 2;
            yemVar = false;
            scr = 0;
            score.Text = Convert.ToString(scr);
            listUzuv.Clear();
            yılanInfo = new YılanInfo(listKare, listUzuv);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            yemEkle();
            int sonuc = yılanInfo.yurut(yon);

            switch (sonuc)
            {
                case 0:
                    timer1.Stop();
                    gameOver = true;
                    MessageBox.Show("Oyun Bitti. Scorunuz = " + score.Text);
                    
                    break;
                case 1:
                    break;
                case 2:
                    yemVar = false;
                    gamecon = true;
                    scr += 1;
                    if (scr % 10 == 0 & hızlı == false)
                    {
                        timer1.Interval -= 10;
                    }
                    score.Text = Convert.ToString(scr);
                    break;
                default:
                    break;
            }
        }

        private void yukarı_Click(object sender, EventArgs e)
        {
            if(yılanInfo.yon != 3)
            {
                yon = 1;
            }
        }

        private void sag_Click(object sender, EventArgs e)
        {
            if (yılanInfo.yon != 4)
            {
                yon = 2;
            }
        }

        private void assa_Click(object sender, EventArgs e)
        {
            if (yılanInfo.yon != 1)
            {
                yon = 3;
            }
        }

        private void sol_Click(object sender, EventArgs e)
        {
            if (yılanInfo.yon != 2)
            {
                yon = 4;
            }
        }

        private void bbaslat_Click(object sender, EventArgs e)
        {
            if(gameOver == false)
            {
                timer1.Start();
            }       
        }

        private void bdur_Click(object sender, EventArgs e)
        {
            if (gameOver == false)
            {
                timer1.Stop();
            }
        }

        private void bnew_Click(object sender, EventArgs e)
        {
            if(gameOver == true)
            {
                newGame();
            }
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Up)
            {
                if (yılanInfo.yon != 3)
                {
                    yon = 1;
                }
            }
            if (keyData == Keys.Right)
            {
                if (yılanInfo.yon != 4)
                {
                    yon = 2;
                }
            }
            if (keyData == Keys.Left)
            {
                if (yılanInfo.yon != 2)
                {
                    yon = 4;
                }
            }
            if (keyData == Keys.Down)
            {
                if (yılanInfo.yon != 1)
                {
                    yon = 3;
                }
            }
            return base.ProcessDialogKey(keyData);
        }

        private void bultra_Click(object sender, EventArgs e)
        {
            if (gameOver == false & gamecon == false)
            {
                timer1.Interval = 10;
                hızlı = true;
            }
        }
    }
}
