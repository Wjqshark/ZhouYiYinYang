using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTraditional.Models.Basic
{
    /// <summary>
    /// 八卦
    /// </summary>
    public class Gua8
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 爻（0-7）
        /// </summary>
        public byte Yao { get; set; }
        /// <summary>
        /// 爻排列（000-111）
        /// </summary>
        public string YaoStr { get; set; }

        /// <summary>
        /// 先天八卦数
        /// </summary>
        public int XianTianIndex { get; set; }

        /// <summary>
        /// 后天八卦数
        /// </summary>
        public int HouTianIndex { get; set; }

        /// <summary>
        /// 后天八卦方位
        /// </summary>
        public Postion HouTianPosition { get; set; }

        /// <summary>
        /// 五行
        /// </summary>
        public WuXing WuXing { get; set; }


        public Gua8(string name)
        {
            switch (name)
            {
                case "乾":
                    this.Yao = 7;
                    break;
                case "巽":
                    this.Yao = 6;
                    break;
                case "离":
                    this.Yao = 5;
                    break;
                case "艮":
                    this.Yao = 4;
                    break;
                case "兑":
                    this.Yao = 3;
                    break;
                case "坎":
                    this.Yao = 2;
                    break;
                case "震":
                    this.Yao = 1;
                    break;
                case "坤":
                    this.Yao = 0;
                    break;
            }
            this.Name = name;
            SetInfo();
        }

        public Gua8(int yao)
        {
            switch(yao)
            {
                case 0:
                    this.Name = "坤";
                    break;
                case 1:
                    this.Name = "震";
                    break;
                case 2:
                    this.Name = "坎";
                    break;
                case 3:
                    this.Name = "兑";
                    break;
                case 4:
                    this.Name = "艮";
                    break;
                case 5:
                    this.Name = "离";
                    break;
                case 6:
                    this.Name = "巽";
                    break;
                case 7:
                    this.Name = "乾";
                    break;
                default:
                    break;
            }
            this.Yao = (byte)yao;
            SetInfo();
        }

        private void SetInfo()
        {
            this.YaoStr = int.Parse(Convert.ToString(Yao, 2)).ToString("D3");
            switch (Name)
            {
                case "乾":
                    this.XianTianIndex = 1;
                    this.HouTianIndex = 6;
                    this.HouTianPosition = Postion.NorthWest;
                    this.WuXing = new WuXing("金");
                    break;
                case "巽":
                    this.XianTianIndex = 5;
                    this.HouTianIndex = 4;
                    this.HouTianPosition = Postion.SouthEast;
                    this.WuXing = new WuXing("木");
                    break;
                case "离":
                    this.XianTianIndex = 3;
                    this.HouTianIndex = 9;
                    this.HouTianPosition = Postion.South;
                    this.WuXing = new WuXing("火");
                    break;
                case "艮":
                    this.XianTianIndex = 7;
                    this.HouTianIndex = 8;
                    this.HouTianPosition = Postion.NorthEast;
                    this.WuXing = new WuXing("土");  
                    break;
                case "兑":
                    this.XianTianIndex = 2;
                    this.HouTianIndex = 7;
                    this.HouTianPosition = Postion.West;
                    this.WuXing = new WuXing("金");
                    break;
                case "坎":
                    this.XianTianIndex = 6;
                    this.HouTianIndex = 1;
                    this.HouTianPosition = Postion.North;
                    this.WuXing = new WuXing("水");
                    break;
                case "震":
                    this.XianTianIndex = 4;
                    this.HouTianIndex = 3;
                    this.HouTianPosition = Postion.East;
                    this.WuXing = new WuXing("木");
                    break;
                case "坤":
                    this.XianTianIndex = 8;
                    this.HouTianIndex = 2;
                    this.HouTianPosition = Postion.SouthWest;
                    this.WuXing = new WuXing("土");
                    break;
            }
        }
    }
}
