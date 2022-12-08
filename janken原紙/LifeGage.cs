using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace janken原紙
{
    internal class LifeGage
    {
        private ProgressBar progressBar;

        public LifeGage(ProgressBar progressBar, int maxLife)
        {
            this.progressBar = progressBar;
            this.progressBar.Maximum = maxLife;
            //プログレスバーが進める量を指定
            this.progressBar.Step = -1;
        }

        public bool Alive => this.progressBar.Value > 0;
        //=>はゴーズトゥー演算子でプロパティ定義を省略できる
        //Valueは現在の値

        public void ResetLife()
        {
            this.progressBar.Value = this.progressBar.Maximum;
        }

        public void Attack()
        {
            //stepで指定した分プログレスバーを進める
            this.progressBar.PerformStep();
        }
    }
}
