﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D.Spider.Core.Interface.Plugin
{
    /// <summary>
    /// 插件类型
    /// </summary>
    public enum PluginType
    {
        /// <summary>
        /// 下载器，只要负责下载 html
        /// </summary>
        Downloader,

        /// <summary>
        /// url 管理器
        /// </summary>
        UrlManager,

        /// <summary>
        /// 页面处理
        /// </summary>
        PageProcess
    }

    /// <summary>
    /// 插件事件状态
    /// </summary>
    public enum PluginEventState
    {
        /// <summary>
        /// 创建
        /// </summary>
        Created,

        /// <summary>
        /// 等待处理
        /// </summary>
        Waiting,

        /// <summary>
        /// 处理中
        /// </summary>
        Handling,

        /// <summary>
        /// 处理完成
        /// </summary>
        Handled,

        /// <summary>
        /// 停止的
        /// </summary>
        Terminate
    }
}
