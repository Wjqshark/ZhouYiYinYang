using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTraditional.Models.Basic
{
    /// <summary>
    /// 五行
    /// </summary>
    public class WuXing
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 生
        /// </summary>
        public string Generate { get; set; }
        /// <summary>
        /// 克
        /// </summary>
        public string Inhibite { get; set; }

        /// <summary>
        /// 从...生
        /// </summary>
        public string GenerateFrom { get; set; }
        /// <summary>
        /// 被...克
        /// </summary>
        public string InhibiteBy { get; set; }
        /// <summary>
        /// 构造
        /// </summary>
        /// <param name="name"></param>
        public WuXing(string name)
        {
            switch (name)
            {
                case "金":
                    Name = "金";
                    Generate = "水";
                    Inhibite = "木";
                    GenerateFrom = "土";
                    InhibiteBy = "火";
                    break;
                case "木":
                    Name = "木";
                    Generate = "火";
                    Inhibite = "土";
                    GenerateFrom = "水";
                    InhibiteBy = "金";
                    break;
                case "水":
                    Name = "水";
                    Generate = "木";
                    Inhibite = "火";
                    GenerateFrom = "金";
                    InhibiteBy = "土";
                    break;
                case "火":
                    Name = "火";
                    Generate = "土";
                    Inhibite = "金";
                    GenerateFrom = "木";
                    InhibiteBy = "水";
                    break;
                case "土":
                    Name = "土";
                    Generate = "金";
                    Inhibite = "水";
                    GenerateFrom = "火";
                    InhibiteBy = "木";
                    break;
            }

        }

        public override string ToString()
        {
            return Name.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            return this.ToString() == obj.ToString();

        }

        public override int GetHashCode()
        {
            var hashCode = -1457479457;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Generate);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Inhibite);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GenerateFrom);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(InhibiteBy);
            return hashCode;
        }
    }
}
