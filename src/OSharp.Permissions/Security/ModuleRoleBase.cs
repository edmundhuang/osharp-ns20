﻿using System;
using System.Collections.Generic;
using System.Text;

using OSharp.Entity;


namespace OSharp.Security
{
    /// <summary>
    /// 模块角色信息基类
    /// </summary>
    /// <typeparam name="TModuleKey">模块编号</typeparam>
    /// <typeparam name="TRoleKey">角色编号</typeparam>
    public abstract class ModuleRoleBase<TModuleKey, TRoleKey> : EntityBase<Guid>
    {
        /// <summary>
        /// 获取或设置 模块编号
        /// </summary>
        public TModuleKey ModuleId { get; set; }

        /// <summary>
        /// 获取或设置 角色编号
        /// </summary>
        public TRoleKey RoleId { get; set; }
    }
}
