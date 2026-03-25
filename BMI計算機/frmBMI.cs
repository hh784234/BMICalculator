using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI計算機
{
    public partial class frmBMI : Form
    {
        public frmBMI()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            bool isHeightValid = Double.TryParse(txtHeight.Text, out double height);
            bool isWeightValid = Double.TryParse(txtWeight.Text, out double weight);

            // 驗證輸入的身高
            if (isHeightValid) {
                if (height <= 0) {
                    MessageBox.Show("身高必須大於零。", "身高值錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else {
                MessageBox.Show("請輸入有效身高數值。", "身高值錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 驗證輸入的體重
            if (isWeightValid)
            {
                if (weight <= 0)
                {
                    MessageBox.Show("體重必須大於零。", "體重值錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("請輸入有效體重數值。", "體重值錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 將身高從公分轉換為公尺
            height = height / 100.0;
            // BMI計算公式
            double bmi = weight / (height * height);

            // 定義BMI結果對應的文字和顏色
            string[] strResultList = { "體重過輕", "健康體位", "體位過重", "輕度肥胖", "中度肥胖", "重度肥胖" };
            Color[] colorList = { Color.SkyBlue, Color.LightGreen, Color.Yellow, Color.Orange, Color.OrangeRed, Color.FromArgb(180, 120, 200) };

            // 顯示BMI結果
            string strResult = "";
            Color colorResult = Color.Black;
            int iResultIndex = 0;

            // 根據BMI值判斷結果索引
            if (bmi < 18.5)
            {
                iResultIndex = 0;
            }
            else if (bmi >= 18.5 && bmi < 24)
            {
                iResultIndex = 1;
            }
            else if (bmi >= 24 && bmi < 27)
            {
                iResultIndex = 2;
            }
            else if (bmi >= 27 && bmi < 30)
            {
                iResultIndex = 3;
            }
            else if (bmi >= 30 && bmi < 35)
            {
                iResultIndex = 4;
            }
            else
            {
                iResultIndex = 5;
            }

            // 根據BMI結果索引獲取對應的文字和顏色
            strResult = strResultList[iResultIndex];
            colorResult = colorList[iResultIndex];

            // 顯示BMI結果
            this.lblResult.Text = $"{bmi:F2} ({strResult})";
            this.lblResult.BackColor = colorResult;

        }
    }
}
