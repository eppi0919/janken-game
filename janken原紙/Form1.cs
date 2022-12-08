using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace janken原紙
{
    public partial class Form1 : Form
    {
        private int roundCount;
        private int winCount;
        private int lossCount;

        //配列要素の型名+配列の変数名
        private PictureBox[] winlossResult;

        private LifeGage playerLifeGage;
        private LifeGage oniLifeGage;

        private bool InGame
        {
            //プロパティの定義文　セットで設定ゲットで取得
            set
            {
                guPB.Enabled = value;
                chokiPB.Enabled = value;
                paPB.Enabled = value;
            }
        }
        public Form1()
        {
            InitializeComponent();

            //配列の要素
            winlossResult = new[]
            {
                wl1,
                wl2,
                wl3,
                wl4,
                wl5,
            };
            //プログレスバーの初期化で5に設定
            playerLifeGage = new LifeGage(playerLife,5);
            oniLifeGage = new LifeGage(oniLife, 5);
        }

        private void guPB_Click(object sender, EventArgs e)
        {
            var playerHand = JankenHand.gu;
            Battle(playerHand);
        }

        private void chokiPB_Click(object sender, EventArgs e)
        {
            var playerHand = JankenHand.choki;
            Battle(playerHand);
        }

        private void paPB_Click(object sender, EventArgs e)
        {
            var playerHand = JankenHand.pa;
            Battle(playerHand);
        }

        private void NextRound()
        {
            //ライフリセット
            playerLifeGage.ResetLife();
            oniLifeGage.ResetLife();

            //手の画像クリア
            playerhandPB.Image = null;
            onihandPB.Image = null;

            roundCount += 1;

            MessageBox.Show($"{roundCount }回戦");
        }

        private void Battle(JankenHand playerHand)
        {
            var randum = new Random();
            var oniHandValue = randum.Next(0, 3);
            var oniHand = (JankenHand)oniHandValue;

            onihandPB.Image = GetHandImage(oniHand);
            playerhandPB.Image = GetHandImage(playerHand);

            JankenResult jankenResult;
            if (playerHand == oniHand)
            {
                jankenResult = JankenResult.Even;
            }
            else if ((playerHand == JankenHand.gu && oniHand == JankenHand.choki) ||
                    (playerHand == JankenHand.choki && oniHand == JankenHand.pa) ||
                    (playerHand == JankenHand.pa && oniHand == JankenHand.gu))
            {
                jankenResult = JankenResult.win;
            }
            else
            {
                jankenResult = JankenResult.loss;
            }

            switch (jankenResult)
            {
                case JankenResult.Even:
                    return;
                case JankenResult.win:
                    oniLifeGage.Attack();
                    break;
                case JankenResult.loss:
                    playerLifeGage.Attack();
                    break;
                default:
                    break;
            }

            //ラウンド継続
            if(playerLifeGage.Alive && oniLifeGage.Alive)
            {
                return;
            }

            //どちらかがライフなしでラウンド終了
            Image winlossResultImage;
            if(playerLifeGage.Alive)
            {
                MessageBox.Show($"{roundCount}回戦はあなたの勝ち");
                winCount += 1;
                winlossResultImage = Properties.Resources.maru;
            }
            else
            {
                MessageBox.Show($"{roundCount}回戦はあなたの負け");
                lossCount += 1;
                winlossResultImage = Properties.Resources.batu;
            }
            //ラウンドの勝敗結果を表示
            winlossResult[roundCount - 1].Image = winlossResultImage;
            

            //バトル終了判定
            if(winCount == 3 || lossCount == 3)
            {
                MessageBox.Show("試合終了");

                string gameResult;
                if (winCount > lossCount)
                {
                    gameResult = "ゲームクリア";
                }
                else
                {
                    gameResult = "ゲームオーバー";
                }
                MessageBox.Show($"{gameResult}"+ Environment.NewLine +$"{winCount}勝　{lossCount}敗");

                InGame = false;

                return;
            }

            NextRound();
        }

        private static Image GetHandImage(JankenHand hand)
        {
            Image handImage;
            if (hand == JankenHand.gu)
            {
                handImage = Properties.Resources.gu;
            }

            else if (hand == JankenHand.choki)
            {
                handImage = Properties.Resources.choki;
            }

            else
            {
                handImage = Properties.Resources.pa;
            }

            return handImage;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //手の選択不可　Enabled=falseはコントロール無効
            InGame = false;
        }

        private void start_Click(object sender, EventArgs e)
        {
            //手の選択可　Enabled=trueはコントロール有効
            InGame = true;

            //手の画像クリア
            playerhandPB.Image = null;
            onihandPB.Image = null;

            //(var 要素の変数名　in　配列変数{要素に対する処理})
            foreach(var pictureBox in winlossResult)
            {
                pictureBox.Image = null;
            }

            MessageBox.Show("ゲームスタート");

            roundCount = 0;

            winCount = 0;
            lossCount = 0;

            NextRound();
        }
    }
}
