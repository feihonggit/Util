﻿using Util.Ui.Builders;
using Util.Ui.Configs;
using Util.Ui.Material.Panels.Builders;
using Util.Ui.Renders;

namespace Util.Ui.Material.Panels.Renders {
    /// <summary>
    /// 面板操作渲染器
    /// </summary>
    public class PanelActionRender : RenderBase {
        /// <summary>
        /// 配置
        /// </summary>
        private readonly IConfig _config;

        /// <summary>
        /// 初始化面板操作渲染器
        /// </summary>
        /// <param name="config">配置</param>
        public PanelActionRender( IConfig config ) : base( config ) {
            _config = config;
        }

        /// <summary>
        /// 获取标签生成器
        /// </summary>
        protected override TagBuilder GetTagBuilder() {
            var builder = new PanelActionBuilder();
            Config( builder );
            return builder;
        }

        /// <summary>
        /// 配置
        /// </summary>
        protected void Config( TagBuilder builder ) {
            ConfigId( builder );
            ConfigContent( builder );
        }

        /// <summary>
        /// 配置内容
        /// </summary>
        private void ConfigContent( TagBuilder builder ) {
            if( _config.Content == null )
                return;
            builder.SetContent( _config.Content );
        }
    }
}