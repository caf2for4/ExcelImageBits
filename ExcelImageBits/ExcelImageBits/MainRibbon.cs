using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace ExcelImageBits
{
    public partial class MainRibbon
    {
        private Actor.ImageActor _image;

        private void MainRibbon_Load(object sender, RibbonUIEventArgs e)
        {
            //TODO:透過部分の判定(元からの色とのマージ)
            //TODO:描画オフチェックボックスで判定
            //TODO:BGWorker対応

            setEvent();
        }

        private void setEvent()
        {
            this.btnImageSelect.Click += getImageFilePath;
        }

        private void getImageFilePath(object sender, RibbonControlEventArgs e)
        {
            this.openFileDialog.CheckFileExists = true;
            if (this.openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            this._image = new Actor.ImageActor(this.openFileDialog.FileName);
            if (!this._image.InRangeSize)
            {
                MessageBox.Show("画像が大きすぎます。");
                return;
            }

            Actor.ExcelActor.setExcelBits(this._image.Image.Size);
            createImageBits();

            MessageBox.Show("完了");
        }

        private void createImageBits()
        {
            for (int y = 0; y < this._image.Image.Size.Height; y++)
            {
                for (int x = 0; x < this._image.Image.Size.Width; x++)
                {
                    Color color = this._image.getBitColor(x, y);
                    if (color.A == 0)
                    {
                        continue;
                    }

                    Actor.ExcelActor.setExcelBitsColor(x, y, color);
                }
            }
        }


    }
}
