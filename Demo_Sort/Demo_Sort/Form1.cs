using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Demo_Sort
{
    public partial class DoAn : Form
    {
        const int soluong = 50;

        Button[] BTs = new Button[55];
        public DoAn()
        {
            InitializeComponent();
            
            
        }
        private void swap_button(int button_A,int button_B)
        {
            Point point_A = new Point(BTs[button_A].Location.X, BTs[button_B].Location.Y);
            Point point_B = new Point(BTs[button_B].Location.X, BTs[button_A].Location.Y);
            BTs[button_A].Location = point_A;
            BTs[button_B].Location = point_B;
            int temp = BTs[button_A].Height;
            BTs[button_A].Height = BTs[button_B].Height;
            BTs[button_B].Height = temp;
        }
        private void Add_Load_Column()
        {
            this.Container_bt.Controls.Clear();
            for (int i = 1; i <= soluong; i += 1)
            {
                this.Container_bt.Controls.Add(BTs[i]);
            }
        }
        private void Loadd(int denta)//Duoc dung de phan chia ra
        {
            Random rand = new Random();
            int width = this.Container_bt.Width;
            int height = this.Container_bt.Height;
            int so_bt = (int)width / denta;
            Point point = new Point(0, 0);
            for (int i = 1; i <= denta; i+=1)
            {
                BTs[i] = new Button();
                BTs[i].Height = rand.Next(50,height);
                BTs[i].Width = so_bt;
                BTs[i].BackColor = Color.Black;
                BTs[i].FlatAppearance.BorderColor = Color.Black;
                BTs[i].FlatAppearance.BorderSize = 1;
                point.X = (i - 1) * so_bt;
                point.Y = height-BTs[i].Height;//Thay doi tai day de de xep bang
                BTs[i].Location = point;
                this.Container_bt.Controls.Add(BTs[i]);
            }
            //Print_Height();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Loadd(soluong);
            //Add_Load_Column();
        }

        private void Print_Height()
        {
            string thongtin = "";
            for(int i = 1; i < soluong; i++)
            {
                thongtin+=$"{BTs[i].Height} ";
            }
            MessageBox.Show(thongtin);
        }
        private void Selection_Sort_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < soluong; i++)
            {
                int min_height = i;
                for (int j = i + 1; j <= soluong; j++)
                {
                    if (BTs[min_height].Height > BTs[j].Height)
                    {
                        min_height = j;
                    }
                }
                if (i != min_height)
                {
                    Thread.Sleep(150);
                    swap_button(i, min_height);
                    this.Container_bt.Update();
                }
            }
            
        }

        private void bt_init_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            Point point = new Point();
            int height = this.Container_bt.Height;
            for (int i = 1; i <= soluong; i++)
            {
                BTs[i].Height = rand.Next(50, height);
                point.X = BTs[i].Location.X;
                point.Y = height - BTs[i].Height;//Thay doi tai day de de xep bang
                BTs[i].Location = point;
            }
            this.Container_bt.Update();
        }

        private void bt_Insert_Sort_Click(object sender, EventArgs e)
        {
            int i, index;
            for (i = soluong; i >= 1; i--)
            {
                index = i - 1;
                while (index > 0 && BTs[index].Height < BTs[index + 1].Height )
                {
                    index--;
                }
                if (index > 0)
                {
                    int value = BTs[index].Height;
                    index++;
                    Thread.Sleep(150);
                    while (index <= soluong && value > BTs[index].Height)
                    {
                        swap_button(index - 1 ,index);
                        index++;
                        
                    }
                    this.Container_bt.Update();
                }
            }
        }

        private void bt_shakeSort_Click(object sender, EventArgs e)
        {
            int left = 1, right = soluong, j;
            while (left < right)
            {
                for (j = left; j < right; j++)
                {
                    if (BTs[j].Height > BTs[j + 1].Height)
                    {
                        Thread.Sleep(10);
                        swap_button(j, j + 1);
                        this.Container_bt.Update();
                    }
                }
                right--;
                for (j = right; j > left; j--)
                {
                    if (BTs[j].Height < BTs[j - 1].Height)
                    {
                        Thread.Sleep(10);
                        swap_button(j, j - 1);
                        this.Container_bt.Update();
                    }
                }
                left++;
            }
        }

        private void bt_music_Click(object sender, EventArgs e)
        {
            SoundPlayer ms = new SoundPlayer(@".\source\music\music.wav");
            ms.Play();
        }

        private void bt_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
