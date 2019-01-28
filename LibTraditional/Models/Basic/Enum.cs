using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTraditional.Models.Basic
{
    /// <summary>
    /// 方位
    /// </summary>
    public enum Postion
    {
        /// <summary>
        /// 东
        /// </summary>
        [Description("东")]
        East,
        /// <summary>
        /// 东南
        /// </summary>
        [Description("东南")]
        SouthEast,
        /// <summary>
        /// 南
        /// </summary>
        [Description("南")]
        South,
        /// <summary>
        /// 西南
        /// </summary>
        [Description("西南")]
        SouthWest,
        /// <summary>
        /// 西
        /// </summary>
        [Description("西")]
        West,
        /// <summary>
        /// 西北
        /// </summary>
        [Description("西北")]
        NorthWest,
        /// <summary>
        /// 北
        /// </summary>
        [Description("北")]
        North,
        /// <summary>
        /// 东北
        /// </summary>
        [Description("东北")]
        NorthEast,

        /// <summary>
        /// 中央
        /// </summary>
        [Description("中央")]
        Middle
    }
}
