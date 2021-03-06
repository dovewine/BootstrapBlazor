﻿using Microsoft.AspNetCore.Components;
using System;

namespace BootstrapBlazor.Components
{
    /// <summary>
    /// CalendarCell 组件
    /// </summary>
    sealed partial class CalendarCell
    {
        private string? TableCellClass => CssBuilder.Default()
            .AddClass("prev", Value.Month < CurrentValue.Month)
            .AddClass("next", Value.Month > CurrentValue.Month)
            .AddClass("current", Value.Month == CurrentValue.Month)
            .AddClass("is-selected", Value.Ticks == CurrentValue.Ticks)
            .AddClass("is-today", Value.Ticks == DateTime.Today.Ticks)
            .Build();

        /// <summary>
        /// 获取 日视图下日单元格显示文字
        /// </summary>
        /// <returns></returns>
        private string Text => $"{Value.Day}";

        /// <summary>
        /// 获得/设置 组件值
        /// </summary>
        [Parameter]
        public DateTime Value { get; set; }

        /// <summary>
        /// 获得/设置 组件值
        /// </summary>
        [Parameter]
        public DateTime CurrentValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Parameter]
        public Action<DateTime>? OnClick { get; set; }

        private void OnClickDay()
        {
            OnClick?.Invoke(Value);
        }
    }
}
