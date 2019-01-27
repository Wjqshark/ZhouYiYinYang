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
            this.YaoStr = int.Parse(Convert.ToString(Yao, 2)).ToString("D3");
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
            this.YaoStr = int.Parse(Convert.ToString(yao, 2)).ToString("D3");
        }

        private void SetInfo()
        {

        }
    }
}
