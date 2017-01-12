﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D.NovelCrawl.Core.Models
{
    /// <summary>
    /// url 包含的数据
    /// </summary>
    internal class UrlData
    {
        public Novel NovelInfo { get; set; }

        public UrlTypes Type { get; set; }
    }
}
