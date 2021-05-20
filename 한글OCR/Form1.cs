using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace 한글OCR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static List<String> DIC = new List<String>();
        public static bool BlockFillter;
        public static int TIME = 0;
        public static Bitmap img;

        private void Form1_Load(object sender, EventArgs e)
        {
            DIC.Add("페미");
            DIC.Add("꽤미");
            DIC.Add("한남");
            DIC.Add("자들자들");
            DIC.Add("여성혐오");
            DIC.Add("냄저");
            DIC.Add("냄져");
            DIC.Add("좆돌");
            DIC.Add("젠더");
            DIC.Add("젠더 감수성");
            DIC.Add("젠더감수성");
            DIC.Add("흉자");
            DIC.Add("자이루");
            DIC.Add("모르면 배우세요");
            DIC.Add("모르면배우세요");
            DIC.Add("모르면공부하세요");
            DIC.Add("모르면 공부하세요");
            DIC.Add("모르면 외우세요");
            DIC.Add("모르면외우세요");
            DIC.Add("재기해");
            DIC.Add("재기");
            DIC.Add("부랄발광");
            DIC.Add("좆팔");
            DIC.Add("조팔");
            DIC.Add("살남");
            DIC.Add("걸스캔두애니띵");
            DIC.Add("걸스캔두에니띵");
            DIC.Add("캔두에니띵");
            DIC.Add("캔두 에니띵");
            DIC.Add("워마드");
        }

        private void PathBnt_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JPG  (*.jpg / *.jpeg)|*jpg|PNG (*.png)|*.png|All File (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                PathText.Text = openFileDialog1.FileName.ToString();
            }

            pictureBox1.ImageLocation = PathText.Text;
        }

        private void START_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();


        }

        private void ResultBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control)
            {
                if(e.KeyCode == Keys.A)
                {
                    this.ResultBox.Focus();
                    this.ResultBox.SelectAll();
                }
            }
        }

        private void ResultBox_TextChanged(object sender, EventArgs e)
        {

        }


        [DllImport("user32.dll")]
        public static extern void keybd_event(uint vk, uint scan, uint flags, uint extraInfo);
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (TIME == 5)
            {
                if (!Directory.Exists("CAP"))
                {
                    Directory.CreateDirectory("CAP");
                }
                if(File.Exists(@"CAP\K-001.png"))
                {
                    File.Delete(@"CAP\K-001.png");
                }
                keybd_event((byte)Keys.ControlKey, 0, 0x00, 0);
                keybd_event((byte)Keys.P, 0, 0x00, 0);
                keybd_event((byte)Keys.P, 0, 0x02, 0);
                keybd_event((byte)Keys.ControlKey, 0, 0x02, 0);



                pictureBox1.ImageLocation = @"CAP\K-001.png";
                Thread.Sleep(2000);
                ResultBox.Text = "";
                //MessageBox.Show("1");
                try
                {
                    img = new Bitmap(pictureBox1.Image);
                    
                    var ocr = new TesseractEngine("./tessdata", "kor", EngineMode.Default);
                    //var ocr = new TesseractEngine("./tessdata", "eng", EngineMode.TesseractAndCube);
                    var texts = ocr.Process(img);
                    ResultBox.Text = texts.GetText().ToString();

                    
                }
                catch { }
                string HResult = ResultBox.Text;
                foreach (string Blockword in DIC)
                {
                    BlockFillter = HResult.Contains(Blockword);

                    if (BlockFillter.ToString() == "True")
                    {
                        if (!File.Exists("BlockList.txt"))
                        {
                            File.Create("BlockList.txt");
                        }
                        var ocr2 = new TesseractEngine("./tessdata", "eng", EngineMode.TesseractAndCube);
                        var texts2 = ocr2.Process(img);
                        string EResult = texts2.GetText().ToString();
                        using (StreamWriter BlockList = new StreamWriter("BlockList.txt", true))
                        {
                            BlockList.WriteLine(EResult + Environment.NewLine);
                        }


                        break;
                    }
                }
                TIME = 0;
            }
            TIME++;
        }
    }
}
