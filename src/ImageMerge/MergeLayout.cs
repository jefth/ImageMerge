﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Deepleo.ImageMerge
{
    /// <summary>
    /// 合并布局枚举
    /// </summary>
    public enum Merge2LayoutEnum
    {
        /// <summary>
        /// 2张图片，上下各1个长方形
        ///  ———————————————————
        /// |                  |
        /// |        R1        |
        /// |                  |
        ///  ———————————————————
        /// |                  |
        /// |        R2        |
        /// |                  |
        ///  ———————————————————
        /// </summary>
        Merge2R1 = 1,

        /// <summary>
        /// 2张图片，左右各1个长方形
        ///  ———————————————————
        /// |         |        |
        /// |         |        |
        /// |         |        |
        /// |    R1   |   R2   |
        /// |         |        |
        /// |         |        |
        /// |         |        |
        ///  ———————————————————
        /// </summary>
        Merge2R2 = 2
    }

    public enum Merge3LayoutEnum
    {

        /// <summary>
        /// 3张图片， 上面一个长方形，下面2个正方形并排
        ///  ———————————————————
        /// |                  |
        /// |         R1       |
        /// |                  |
        ///  ———————————————————
        /// |         |        |
        /// |    S1   |   S2   |
        /// |         |        |
        ///  ———————————————————
        /// </summary>
        Merge1R2S1 = 3,

        /// <summary>
        /// 3张图片，上面2个正方形并排，下面一个长方形
        ///  ———————————————————
        /// |         |        |
        /// |    S1   |   S2   |
        /// |         |        |
        ///  ———————————————————
        /// |                  |
        /// |         R1       |
        /// |                  |
        /// ———————————————————
        /// </summary>
        Merge1R2S2 = 4,


        /// <summary>
        /// 3张图片，上面2个正方形并排，下面一个长方形
        ///  ———————————————————
        /// |         |        |
        /// |         |    S1  |
        /// |         |        |
        /// |    R1   |—————————
        /// |         |        |
        /// |         |    S2  |
        /// |         |        |
        ///  ———————————————————
        /// </summary>
        Merge1R2S3 = 5,


        /// <summary>
        /// 3张图片，上面2个正方形并排，下面一个长方形
        ///  ———————————————————
        /// |         |        |
        /// |    S2   |        |
        /// |         |        |
        /// |—————————|    R1  |
        /// |         |        |
        /// |    S2   |        |
        /// |         |        |
        ///  ———————————————————
        /// </summary>
        Merge1R2S4 = 6
    }

    public enum Merge4LayoutEnum
    {
        /// <summary>
        /// 4张图片，上面一个长方形，下面2个正方形并排
        ///  ———————————————————
        /// |         |        |
        /// |    S1   |   S2   |
        /// |         |        |
        ///  ———————————————————
        /// |         |        |
        /// |    S3   |   S4   |
        /// |         |        |
        ///  ———————————————————
        /// </summary>
        Merge4S = 7

    }
}
