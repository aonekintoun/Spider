﻿using D.Spider.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D.Spider.Core.Interface.Plugin;
using D.Util.Interface;
using System.Collections.Concurrent;
using D.Spider.Core.Model;

namespace D.Spider.Core
{
    /// <summary>
    /// IPluginEventManager，IEventSender 的实现
    /// </summary>
    public class PluginEventManager : IPluginEventManager, IEventSender
    {
        ILogger _logger;

        /// <summary>
        /// 所以这在处理中的插件事件
        /// </summary>
        ConcurrentDictionary<Guid, PluginEventTask> _allEvents;

        /// <summary>
        /// 待分发的事件
        /// </summary>
        ConcurrentQueue<IPluginEvent> _waitingDistributeEvents;

        /// <summary>
        /// 每个插件正在等待执行的插件
        /// </summary>
        Dictionary<Guid, ConcurrentQueue<IPluginEvent>> _perPluginWaitingExecutingEvents;

        public PluginEventManager(
            ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<PluginEventManager>();

            _allEvents = new ConcurrentDictionary<Guid, PluginEventTask>();
            _waitingDistributeEvents = new ConcurrentQueue<IPluginEvent>();
            _perPluginWaitingExecutingEvents = new Dictionary<Guid, ConcurrentQueue<IPluginEvent>>();
        }

        #region IEventSender 实现
        public bool Cancel(IPluginEvent e)
        {
            throw new NotImplementedException();
        }

        public void Send(IPluginEvent e)
        {
            _logger.LogInformation($"{e.FromPlugin} 发送事件 {e}");

            var task = new PluginEventTask(e);
        }
        #endregion
    }
}
