﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D.NovelCrawl.Core.Models.Domain.Novel
{
    public class Volume
    {
        /// <summary>
        /// 顺序号
        /// </summary>
        public int No { get; set; }

        /// <summary>
        /// 卷名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 已上传
        /// </summary>
        public bool Uploaded { get; set; }
    }
}
